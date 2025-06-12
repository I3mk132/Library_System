using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsBorrowsDataAccess
    {
        public static DataTable GetAllBorrows()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"SELECT * FROM Borrows";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Logger
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetAllBorrows");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable GetNeerBorrows(int Days)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = $@"
                SELECT P.Firstname + ' ' + P.Lastname AS Fullname,
                        B.CopyID, B.ReturnDate FROM Borrows B 
                JOIN Students S ON B.StudentID = S.StudentID
                JOIN Person P ON S.InfoID = P.InfoID
                
                WHERE B.ReturnDate <= CAST(DATEADD(DAY, {Days}, GETDATE()) AS DATE)
            ";



            SqlCommand command = new SqlCommand(query, connection);

            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);
                reader.Close();

            }
            catch (Exception ex)
            {
                clsLogsDataAccess.AddErrorLog(DateTime.Now, DateTime.Now.TimeOfDay, ex.Message, "GetNeerBorrow");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool GetBorrow(
            ref clsBorrow Borrow
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();

            string filterString = "";


            if (Borrow.ID != -1)
            {
                filterString += " BorrowID = @BorrowID AND";
                command.Parameters.AddWithValue("@BorrowID", Borrow.ID);
            }
            if (Borrow.Student.ID != -1)
            {
                filterString += " StudentID = @StudentID AND";
                command.Parameters.AddWithValue("@StudentID", Borrow.Student.ID);
            }
            if (Borrow.Copy.ID != -1)
            {
                filterString += " CopyID = @CopyID AND";
                command.Parameters.AddWithValue("@CopyID", Borrow.Copy.ID);
            }

            string query = (
                @"SELECT * FROM Borrows WHERE" + filterString + " ' ' = ' ' "
            );

            command.Connection = connection;
            command.CommandText = query;

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Borrow.ID = (int)reader["BorrowID"];
                    Borrow.Student.ID = (int)reader["StudentID"];
                    Borrow.Copy.ID = (int)reader["CopyID"];
                    Borrow.ReturnDate = (DateTime)reader["ReturnDate"];
                    Borrow.BorrowDate = (DateTime)reader["BorrowDate"];


                }
            }
            catch (Exception ex)
            {
                isFound = false;
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetBorrow");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static DataTable GetBorrows(
            clsBorrow Borrow
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();

            string filterString = "";

            if (Borrow.ID != -1)
            {
                filterString += " BorrowID = @BorrowID AND";
                command.Parameters.AddWithValue("@BorrowID", Borrow.ID);
            }
            if (Borrow.Student.ID != -1)
            {
                filterString += " StudentID = @StudentID AND";
                command.Parameters.AddWithValue("@StudentID", Borrow.Student.ID);
            }
            if (Borrow.Copy.ID != -1)
            {
                filterString += " CopyID = @CopyID AND";
                command.Parameters.AddWithValue("@CopyID", Borrow.Copy.ID);
            }
            if (Borrow.Copy.Book.ID != -1)
            {
                filterString += " BookID = @BookID AND ";
                command.Parameters.AddWithValue("@BookID", Borrow.Copy.Book.ID);
            }
            if (filterString == "")
            {
                return new DataTable();
            }

            string query = (
                @"SELECT BorrowID, StudentID, Borrows.CopyID, ReturnDate, BorrowDate 
                FROM Borrows 
                	JOIN CopyInfo ON CopyInfo.CopyID = Borrows.CopyID 
                Where " + filterString + " ' ' = ' ' "
            );

            command.Connection = connection;
            command.CommandText = query;

            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);
            }
            catch (Exception ex)
            {
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetBorrow");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool isBorrowExists(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = "SELECT total=1 FROM Borrows WHERE BorrowID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    isFound = true;
                }
            }
            catch (Exception ex)
            {
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "isBorrowExists");
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }
        public static int AddBorrow(
            clsBorrow Borrow
        )
        {

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                INSERT INTO Borrows 
                ( StudentID, CopyID, ReturnDate, BorrowDate ) VALUES 
                ( @StudentID, @CopyID, @ReturnDate, @BorrowDate );
                UPDATE CopyInfo SET
                    BookStatus = 'Borrowed'
                WHERE CopyID = @CopyID;
                SELECT SCOPE_IDENTITY();
            
            ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentID", Borrow.Student.ID);
            command.Parameters.AddWithValue("@CopyID", Borrow.Copy.ID);
            command.Parameters.AddWithValue("@ReturnDate", Borrow.ReturnDate);
            command.Parameters.AddWithValue("@BorrowDate", Borrow.BorrowDate);

            int ID = -1;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                    ID = id;

            }
            catch (Exception ex)
            {
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "AddBorrow");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static bool UpdateBorrow(
            clsBorrow Borrow
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                UPDATE Borrows SET
                StudentID = @StudentID,
                CopyID = @CopyID,
                ReturnDate = @ReturnDate,
                BorrowDate = @BorrowDate
                WHERE BorrowID = @BorrowID

            ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@StudentID", Borrow.Student.ID);
            command.Parameters.AddWithValue("@CopyID", Borrow.Copy.ID);
            command.Parameters.AddWithValue("@ReturnDate", Borrow.ReturnDate);
            command.Parameters.AddWithValue("@BorrowDate", Borrow.BorrowDate);
            command.Parameters.AddWithValue("@BorrowID", Borrow.ID);

            int rowsAffected = 0;
            bool result = false;
            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
                result = (rowsAffected > 0);
            }
            catch (Exception ex)
            {
                result = false;
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "UpdateBorrow");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public static bool DeleteBorrow(int ID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"
                UPDATE CopyInfo
                SET BookStatus = 'Available'
                WHERE CopyID = (SELECT CopyID FROM Borrows WHERE BorrowID = @BorrowID);

                DELETE FROM Borrows WHERE BorrowID = @BorrowID;
            ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowID", ID);

            int rowsAffected = 0;
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Log
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "DeleteBorrow");
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;
        }


    }
}
