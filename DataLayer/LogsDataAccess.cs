using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsLogsDataAccess
    {
        public static int AddErrorLog(
            DateTime Date, TimeSpan Time, string Description, string ErrorWhere
        )
        {

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = (

                "INSERT INTO Log (" +
                "Date, Time, Description) VALUES (" +
                "@Date, @Time, @Description); " +
                "INSERT INTO ErrorLogs (" +
                "LogID, ErrorWhere) VALUES (" +
                "SCOPE_IDENTITY(), @ErrorWhere); " +
                "SELECT SCOPE_IDENTITY(); "

            );


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@Time", Time);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@ErrorWhere", ErrorWhere);

            
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
                // Log
                Console.WriteLine(ex.Message); // Just for hiding annoing error ( ex never used )
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static int AddErrorLog(
            string Description, string ErrorWhere
        )
        {

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = (

                "INSERT INTO Log (" +
                "Date, Time, Description) VALUES (" +
                "@Date, @Time, @Description); " +
                "INSERT INTO ErrorLogs (" +
                "LogID, ErrorWhere) VALUES (" +
                "SCOPE_IDENTITY(), @ErrorWhere); " +
                "SELECT SCOPE_IDENTITY(); "

            );


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Date", DateTime.Now.Date);
            command.Parameters.AddWithValue("@Time", DateTime.Now.TimeOfDay);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@ErrorWhere", ErrorWhere);


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
                Console.WriteLine(ex.Message); // Just for hiding annoing error ( ex never used )
                // Log
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static DataTable GetAllErrorLogs()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"
                SELECT        EL.ErrorLogID, L.Date, L.Time, L.Description, EL.ErrorWhere
                FROM            ErrorLogs EL INNER JOIN
                                    Log L ON EL.LogID = L.LogID";

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
                AddErrorLog(ex.Message, "GetAllErrorLogs");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public static int AddChangeLog(
            DateTime Date, TimeSpan Time, string Description, int EmployeeID, int StudentID
        )
        {

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"
                INSERT INTO Log (
                Date, Time, Description) VALUES (
                @Date, @Time, @Description); 
                INSERT INTO ChangeLogs (
                LogID, EmployeeID, StudentID) VALUES (
                SCOPE_IDENTITY(), @EmployeeID, @StudentID); 
                SELECT SCOPE_IDENTITY(); ";

            


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Date", DateTime.Now.Date);
            command.Parameters.AddWithValue("@Time", DateTime.Now.TimeOfDay);
            command.Parameters.AddWithValue("@Description", Description);
            if (EmployeeID != -1)
                command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            else
                command.Parameters.AddWithValue("@EmployeeID", DBNull.Value);

            if (StudentID != -1)
                command.Parameters.AddWithValue("@StudentID", StudentID);
            else
                command.Parameters.AddWithValue("@StudentID", DBNull.Value);


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
                // Log
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "AddChangeLog");
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static int AddChangeLog(
            string Description, int EmployeeID, int StudentID
        )
        {

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"
                INSERT INTO Log (
                Date, Time, Description) VALUES (
                @Date, @Time, @Description); 
                INSERT INTO ChangeLogs (
                LogID, EmployeeID, StudentID) VALUES (
                SCOPE_IDENTITY(), @EmployeeID, @StudentID); 
                SELECT SCOPE_IDENTITY(); ";

            


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Date", DateTime.Now.Date);
            command.Parameters.AddWithValue("@Time", DateTime.Now.TimeOfDay);
            command.Parameters.AddWithValue("@Description", Description);
            if (EmployeeID != -1) 
                command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            else
                command.Parameters.AddWithValue("@EmployeeID", DBNull.Value);

            if (StudentID != -1) 
                command.Parameters.AddWithValue("@StudentID", StudentID);
            else
                command.Parameters.AddWithValue("@StudentID", DBNull.Value);


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
                // Log
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "AddChangeLog");
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static DataTable GetAllChangeLogs()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"
                    SELECT        CL.ChangesLogID, L.Date, L.Time, L.Description, CL.EmployeeID, CL.StudentID
                    FROM            ChangeLogs CL INNER JOIN
                                         Log L ON CL.LogID = L.LogID";

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
                AddErrorLog(ex.Message, "GetAllChangeLogs");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public static int AddSignupLoginLog(
            DateTime Date, TimeSpan Time, string Description, int EmployeeID, int StudentID, string Type
        )
        {

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"
                 INSERT INTO Log (
                 Date, Time, Description) VALUES (
                 @Date, @Time, @Description); 
                 INSERT INTO SignupLoginLogs (
                 LogID, EmployeeID, StudentID, Type) VALUES (
                 SCOPE_IDENTITY(), @EmployeeID, @StudentID, @Type);
                 SELECT SCOPE_IDENTITY(); ";

            


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@Time", Time);
            command.Parameters.AddWithValue("@Description", Description);
            if (EmployeeID != -1)
                command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            else
                command.Parameters.AddWithValue("@EmployeeID", DBNull.Value);

            if (StudentID != -1)
                command.Parameters.AddWithValue("@StudentID", StudentID);
            else
                command.Parameters.AddWithValue("@StudentID", DBNull.Value);
            command.Parameters.AddWithValue("@Type", Type);



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
                // Log
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "AddSignupLoginLog");
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static int AddSignupLoginLog(
            string Description, int EmployeeID, int StudentID, string Type
        )
        {

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                INSERT INTO Log (
                Date, Time, Description) VALUES (
                @Date, @Time, @Description); 
                INSERT INTO SignupLoginLogs (
                LogID, EmployeeID, StudentID, Type) VALUES (
                SCOPE_IDENTITY(), @EmployeeID, @StudentID, @Type); 
                SELECT SCOPE_IDENTITY(); ";
            


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Date", DateTime.Now.Date);
            command.Parameters.AddWithValue("@Time", DateTime.Now.TimeOfDay);
            command.Parameters.AddWithValue("@Description", Description);
            if (EmployeeID != -1)
                command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            else
                command.Parameters.AddWithValue("@EmployeeID", DBNull.Value);

            if (StudentID != -1)
                command.Parameters.AddWithValue("@StudentID", StudentID);
            else
                command.Parameters.AddWithValue("@StudentID", DBNull.Value);
            command.Parameters.AddWithValue("@Type", Type);



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
                // Log
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "AddSignupLoginLog");
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static DataTable GetAllSignupLoginLogs()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"
                    SELECT        SLL.SignupLoginLogID, L.Date, L.Time, L.Description, SLL.EmployeeID, SLL.StudentID, SLL.Type
                    FROM            SignupLoginLogs SLL INNER JOIN
                                         Log L ON SLL.LogID = L.LogID";

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
                AddErrorLog(ex.Message, "GetAllSignupLoginLogs");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable GetAllSignupLogs()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"
                    SELECT        SLL.SignupLoginLogID, L.Date, L.Time, L.Description, SLL.EmployeeID, SLL.StudentID
                    FROM            SignupLoginLogs SLL INNER JOIN
                    Log L ON SLL.LogID = L.LogID
                    WHERE			SLL.Type = 'Signup'";

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
                AddErrorLog(ex.Message, "GetAllSignupLogs");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable GetAllLoginLogs()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"
                    SELECT        SLL.SignupLoginLogID, L.Date, L.Time, L.Description, SLL.EmployeeID, SLL.StudentID
                    FROM            SignupLoginLogs SLL INNER JOIN
                    Log L ON SLL.LogID = L.LogID
                    WHERE			SLL.Type = 'Login'";

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
                AddErrorLog(ex.Message, "GetAllLoginLogs");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static int AddBorrowLog(
            DateTime Date, TimeSpan Time, string Description, int BorrowID, int StudentID, int CopyID
        )
        {

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                 INSERT INTO Log (
                 Date, Time, Description) VALUES (
                 @Date, @Time, @Description); 
                 INSERT INTO BorrowLogs (
                 LogID, BorrowID, StudentID, CopyID) VALUES (
                 SCOPE_IDENTITY(), @BorrowID, @StudentID, @CopyID); 
                 SELECT SCOPE_IDENTITY(); ";

            


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@Time", Time);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@BorrowID", BorrowID);
            command.Parameters.AddWithValue("@StudentID", StudentID);
            command.Parameters.AddWithValue("@CopyID", CopyID);


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
                // Log
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "AddBorrowLog");
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static int AddBorrowLog(
            string Description, int BorrowID, int StudentID, int CopyID
        )
        {

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"
                INSERT INTO Log (
                Date, Time, Description) VALUES (
                @Date, @Time, @Description); 
                INSERT INTO BorrowLogs (
                LogID, BorrowID, StudentID, CopyID) VALUES (
                SCOPE_IDENTITY(), @BorrowID, @StudentID, @CopyID); 
                SELECT SCOPE_IDENTITY(); ";

            


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Date", DateTime.Now.Date);
            command.Parameters.AddWithValue("@Time", DateTime.Now.TimeOfDay);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@BorrowID", BorrowID);
            command.Parameters.AddWithValue("@StudentID", StudentID);
            command.Parameters.AddWithValue("@CopyID", CopyID);


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
                // Log
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "AddBorrowLog");
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static DataTable GetAllBorrowLogs()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"
                    SELECT        BL.BorrowID, L.Date, L.Time, L.Description, BL.BorrowID, BL.StudentID, BL.CopyID
                    FROM            BorrowLogs BL INNER JOIN
                                             Log L ON BL.LogID = L.LogID";

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
                AddErrorLog(ex.Message, "GetAllBorrowLogs");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

    }
}
