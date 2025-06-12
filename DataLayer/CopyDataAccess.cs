using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsCopyDataAccess
    {
        public static DataTable GetAllCopys()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"SELECT * FROM CopyInfo ";

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetAllCopys");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable GetAllCopysAllData()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"
                    SELECT 
	                    C.CopyID,
	                    B.Title,
	                    B.Author,
	                    B.ISBN,
	                    B.PublicationDate,
	                    B.Genre,
	                    B.Details,
	                    C.BookStatus,
	                    D.Name,
	                    B.ImagePath
                    FROM BookInfo B
                    JOIN CopyInfo C ON B.BookID = C.BookID 
                    JOIN Departments D ON C.DepartmentID = D.DepartmentID
";

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetAllCopys");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable GetAllCopysAllData(clsCopyInfo copy)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();
            string filterString = "";


            if (copy.Book.ID != -1)
            {
                filterString += " B.BookID = @BookID AND ";
                command.Parameters.AddWithValue("@BookID", copy.Book.ID);
            }
            if (copy.Book.Title != "")
            {
                filterString += " B.Title = @Title AND ";
                command.Parameters.AddWithValue("@Title", copy.Book.Title);
            }
            if (copy.Book.Author != "")
            {
                filterString += " B.Author = @Author AND ";
                command.Parameters.AddWithValue("@Author", copy.Book.Author);
            }
            if (copy.Book.ISBN != "")
            {
                filterString += " B.ISBN = @ISBN AND ";
                command.Parameters.AddWithValue("@ISBN", copy.Book.ISBN);
            }
            if (copy.Book.Genre != "")
            {
                filterString += " B.Genre = @Genre AND ";
                command.Parameters.AddWithValue("@Genre", copy.Book.Genre);
            }
            if (copy.Book.Details != "")
            {
                filterString += " B.Details = @Details AND ";
                command.Parameters.AddWithValue("@Details", copy.Book.Details);
            }
            if (copy.BookStatus != "")
            {
                filterString += " C.BookStatus = @BookStatus AND ";
                command.Parameters.AddWithValue("@BookStatus", copy.BookStatus);
            }


            string query = @"
                    SELECT 
	                    C.CopyID,
	                    B.Title,
	                    B.Author,
	                    B.ISBN,
	                    B.PublicationDate,
	                    B.Genre,
	                    B.Details,
	                    C.BookStatus,
	                    D.Name,
	                    B.ImagePath
                    FROM BookInfo B
                    JOIN CopyInfo C ON B.BookID = C.BookID 
                    JOIN Departments D ON C.DepartmentID = D.DepartmentID
                    WHERE " + filterString + " ' ' = ' ' ";


            command.Connection = connection;
            command.CommandText = query;

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetAllCopysAllData");

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool GetCopy(
            ref clsCopyInfo Copy
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();

            string filterString = "";


            if (Copy.ID != -1)
            {
                filterString += " CopyID = @CopyID AND";
                command.Parameters.AddWithValue("@CopyID", Copy.ID);
            }
            if (Copy.Book.ID != -1)
            {
                filterString += " BookID = @BookID AND";
                command.Parameters.AddWithValue("@BookID", Copy.Book.ID);
            }
            if (Copy.BookStatus != "")
            {
                filterString += " BookStatus = @BookStatus AND";
                command.Parameters.AddWithValue("@BookStatus", Copy.BookStatus);
            }
            if (Copy.Department.ID != -1)
            {
                filterString += " DepartmentID = @DepartmentID AND";
                command.Parameters.AddWithValue("@DepartmentID", Copy.Department.ID);
            }

            string query = (
                @"SELECT * FROM CopyInfo WHERE" + filterString + " ' ' = ' ' "
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

                    Copy.ID = (int)reader["CopyID"];
                    Copy.Book.ID = (int)reader["BookID"];
                    Copy.BookStatus = (string)reader["BookStatus"];
                    Copy.Department.ID = (int)reader["DepartmentID"];

                }
            }
            catch (Exception ex)
            {
                isFound = false;
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetCopy");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static DataTable GetCopys(
            clsCopyInfo Copy
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();

            string filterString = "";

            if (Copy.ID != -1)
            {
                filterString += " CopyID = @CopyID AND";
                command.Parameters.AddWithValue("@CopyID", Copy.ID);
            }
            if (Copy.Book.ID != -1)
            {
                filterString += " BookID = @BookID AND";
                command.Parameters.AddWithValue("@BookID", Copy.Book.ID);
            }
            if (Copy.BookStatus != "")
            {
                filterString += " BookStatus = @BookStatus AND";
                command.Parameters.AddWithValue("@BookStatus", Copy.BookStatus);
            }
            if (Copy.Department.ID != -1)
            {
                filterString += " DepartmentID = @DepartmentID AND";
                command.Parameters.AddWithValue("@DepartmentID", Copy.Department.ID);
            }

            string query = (
                @"SELECT * FROM CopyInfo WHERE" + filterString + " ' ' = ' ' "
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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetCopy");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool isCopyExists(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = "SELECT total=1 FROM CopyInfo WHERE CopyID = @ID";

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "isCopyExists");
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }
        public static int AddCopy(
            clsCopyInfo Copy
        )
        {

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                INSERT INTO CopyInfo 
                ( BookID, BookStatus, DepartmentID ) VALUES 
                ( @BookID, @BookStatus, @DepartmentID );
                SELECT SCOPE_IDENTITY();
            
            ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", Copy.Book.ID);
            command.Parameters.AddWithValue("@BookStatus", Copy.BookStatus);
            command.Parameters.AddWithValue("@DepartmentID", Copy.Department.ID);

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "AddCopy");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static bool UpdateCopy(
            clsCopyInfo Copy
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                UPDATE CopyInfo SET
                    BookID = @BookID,
                    BookStatus = @BookStatus,
                    DepartmentID = @DepartmentID
                    WHERE CopyID = @CopyID

            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", Copy.Book.ID);
            command.Parameters.AddWithValue("@BookStatus", Copy.BookStatus);
            command.Parameters.AddWithValue("@DepartmentID", Copy.Department.ID);
            command.Parameters.AddWithValue("@CopyID", Copy.ID);

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "UpdateCopy");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public static bool DeleteCopy(int ID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                DELETE CopyInfo WHERE CopyID = @CopyID;

            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CopyID", ID);

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "DeleteCopy");
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;
        }

    }
}
