using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsTasksDataAccess
    {
        public static DataTable GetEmployeesNeerTasks(int ID, int Days)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = $@"

                SELECT Task, FinishDate FROM Tasks 
                WHERE (FinishDate Between CAST(GETDATE() - {Days} AS DATE) AND GETDATE()) AND EmployeeID = @ID
            ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

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
                clsLogsDataAccess.AddErrorLog($"Error While trying to Get Tasks : [{ex.Message}]", "GetEmployeesNeerTasks");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable GetAllTasks()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"SELECT * FROM Tasks";

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetAllTasks");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable GetTasks(
            clsTask task
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();

            string filterString = "";

            if (task.ID != -1)
            {
                filterString += " TaskID = @TaskID AND";
                command.Parameters.AddWithValue("@TaskID", task.ID);
            }
            if (task.Employee.ID != -1)
            {
                filterString += " EmployeeID = @EmployeeID AND";
                command.Parameters.AddWithValue("@EmployeeID", task.Employee.ID);
            }
            if (task.Task != "")
            {
                filterString += " Task = @Task AND";
                command.Parameters.AddWithValue("@Task", task.Task);
            }

            string query = (
                @"SELECT * FROM Tasks WHERE" + filterString + " ' ' = ' ' "
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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetTasks");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable GetTasksSimpled(
            clsTask task
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();

            string filterString = "";

            if (task.ID != -1)
            {
                filterString += " TaskID = @TaskID AND";
                command.Parameters.AddWithValue("@TaskID", task.ID);
            }
            if (task.Employee.ID != -1)
            {
                filterString += " EmployeeID = @EmployeeID AND";
                command.Parameters.AddWithValue("@EmployeeID", task.Employee.ID);
            }
            if (task.Task != "")
            {
                filterString += " Task = @Task AND";
                command.Parameters.AddWithValue("@Task", task.Task);
            }

            string query = (
                @"SELECT TaskID, Task, FinishDate FROM Tasks WHERE" + filterString + " ' ' = ' ' "
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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetTask");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool GetTask(
            ref clsTask task
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();

            string filterString = "";


            if (task.ID != -1)
            {
                filterString += " TaskID = @TaskID AND";
                command.Parameters.AddWithValue("@TaskID", task.ID);
            }
            if (task.Employee.ID != -1)
            {
                filterString += " EmployeeID = @EmployeeID AND";
                command.Parameters.AddWithValue("@EmployeeID", task.Employee.ID);
            }
            if (task.Task != "")
            {
                filterString += " Task = @Task AND";
                command.Parameters.AddWithValue("@Task", task.Task);
            }


            string query = (
                @"SELECT * FROM Tasks WHERE" + filterString + " ' ' = ' ' "
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

                    task.ID = (int)reader["TaskID"];
                    task.Employee.ID = (int)reader["EmployeeID"];
                    task.Task = (string)reader["Task"];
                    task.FinishDate = (DateTime)reader["FinishDate"];

                }
            }
            catch (Exception ex)
            {
                isFound = false;
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetTask");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static int AddTask( clsTask task )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                INSERT INTO Tasks 
                ( EmployeeID, Task, FinishDate) VALUES 
                ( @EmployeeID, @Task, @FinishDate);
                SELECT SCOPE_IDENTITY();
            
            ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", task.Employee.ID);
            command.Parameters.AddWithValue("@Task", task.Task);
            command.Parameters.AddWithValue("@FinishDate", task.FinishDate);
            

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "AddTask");
            }
            finally
            {
                connection.Close();
            }

            return ID;
        }
        public static bool isTaskExists(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = "SELECT total=1 FROM Tasks WHERE TaskID = @ID";

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "isTaskExists");
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }
        public static bool UpdateTask(
            clsTask task
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                UPDATE Tasks SET
                EmployeeID = @EmployeeID,
                Task = @Task,
                FinishDate = @FinishDate
                WHERE TaskID = @TaskID

            ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@EmployeeID", task.Employee.ID);
            command.Parameters.AddWithValue("@Task", task.Task);
            command.Parameters.AddWithValue("@FinishDate", task.FinishDate);
            command.Parameters.AddWithValue("@TaskID", task.ID);

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "UpdateTask");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public static bool DeleteTask(int ID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                DELETE Tasks WHERE TaskID = @TaskID;

            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TaskID", ID);

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "DeleteTask");
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;
        }
    }
}
