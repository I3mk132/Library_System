using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace DataLayer
{
    public class clsDepartmentsDataAccess
    {
        public static DataTable GetAllDepartments()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"SELECT * FROM Departments";

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetAllDepartments");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool GetDepartment(
            ref clsDepartment Department
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();

            string filterString = "";


            if (Department.ID != -1)
            {
                filterString += " DepartmentID = @DepartmentID AND";
                command.Parameters.AddWithValue("@DepartmentID", Department.ID);
            }
            if (Department.Name != "")
            {
                filterString += " Name = @Name AND";
                command.Parameters.AddWithValue("@Name", Department.Name);
            }
            if (Department.Description != "")
            {
                filterString += " Description = @Description AND";
                command.Parameters.AddWithValue("@Description", Department.Description);
            }
            if (Department.ImagePath != "")
            {
                filterString += " ImagePath = @ImagePath AND";
                command.Parameters.AddWithValue("@ImagePath", Department.ImagePath);
            }
            if (Department.Location != "")
            {
                filterString += " Location = @Location AND";
                command.Parameters.AddWithValue("@Location", Department.Location);
            }
            if (Department.OpenDays != -1)
            {
                filterString += " OpenDays = @OpenDays AND";
                command.Parameters.AddWithValue("@OpenDays", Department.OpenDays);
            }
            if (Department.MinimumAge != -1)
            {
                filterString += " MinimumAge = @MinimumAge AND";
                command.Parameters.AddWithValue("@MinimumAge", Department.MinimumAge);
            }
            if (Department.SeatCount != -1)
            {
                filterString += " SeatCount = @SeatCount And";
                command.Parameters.AddWithValue("@SeatCount", Department.SeatCount);
            }

            string query = (
                @"SELECT * FROM Departments WHERE" + filterString + " ' ' = ' ' "
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

                    Department.ID = (int)reader["DepartmentID"];
                    Department.Name = (string)reader["Name"];
                    Department.ImagePath = (string)reader["ImagePath"];
                    Department.Description = (string)reader["Description"];
                    Department.Location = (string)reader["Location"];
                    Department.OpenHoursFrom = (TimeSpan)reader["OpenHoursFrom"];
                    Department.OpenHoursTo = (TimeSpan)reader["OpenHoursTo"];
                    Department.OpenDays = (int)reader["OpenDays"];
                    Department.MinimumAge = (int)reader["MinimumAge"];
                    Department.SeatCount = (int)reader["SeatCount"];

                }
            }
            catch (Exception ex)
            {
                isFound = false;
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetDepartment");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static DataTable GetDepartments(
            clsDepartment Department
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();

            string filterString = "";



            if (Department.ID != -1)
            {
                filterString += " DepartmentID = @DepartmentID AND";
                command.Parameters.AddWithValue("@DepartmentID", Department.ID);
            }
            if (Department.Name != "")
            {
                filterString += " Name = @Name AND";
                command.Parameters.AddWithValue("@Name", Department.Name);
            }
            if (Department.Description != "")
            {
                filterString += " Description = @Description AND";
                command.Parameters.AddWithValue("@Description", Department.Description);
            }
            if (Department.ImagePath != "")
            {
                filterString += " ImagePath = @ImagePath AND";
                command.Parameters.AddWithValue("@ImagePath", Department.ImagePath);
            }
            if (Department.Location != "")
            {
                filterString += " Location = @Location AND";
                command.Parameters.AddWithValue("@Location", Department.Location);
            }
            if (Department.OpenDays != -1)
            {
                filterString += " OpenDays = @OpenDays AND";
                command.Parameters.AddWithValue("@OpenDays", Department.OpenDays);
            }
            if (Department.MinimumAge != -1)
            {
                filterString += " MinimumAge = @MinimumAge AND";
                command.Parameters.AddWithValue("@MinimumAge", Department.MinimumAge);
            }
            if (Department.SeatCount != -1)
            {
                filterString += " SeatCount = @SeatCount And";
                command.Parameters.AddWithValue("@SeatCount", Department.SeatCount);
            }



            string query = (
                @"SELECT * FROM Departments WHERE" + filterString + " ' ' = ' ' "
            );

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
            
            
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetDepartments");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool isDepartmentExists(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = "SELECT total=1 FROM Departments WHERE DepartmentID = @ID";

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "isDepartmentExists");
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }
        public static bool isDepartmentExists(string Name)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = "SELECT total=1 FROM Departments WHERE Name = @DepartmentName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DepartmentName", Name);

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "isDepartmentExists");
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static int AddDepartment(
            clsDepartment Department
        )
        {

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                INSERT INTO Departments 
                ( Name, ImagePath, Description, Location, OpenHoursFrom, OpenHoursTo, OpenDays, MinimumAge, SeatCount) VALUES 
                ( @Name, @ImagePath, @Description, @Location, @OpenHoursFrom, @OpenHoursTo, @OpenDays, @MinimumAge, @SeatCount);
                SELECT SCOPE_IDENTITY();
            
            ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Department.Name);
            command.Parameters.AddWithValue("@ImagePath", Department.ImagePath);
            command.Parameters.AddWithValue("@Description", Department.Description);
            command.Parameters.AddWithValue("@Location", Department.Location);
            command.Parameters.AddWithValue("@OpenHoursFrom", Department.OpenHoursFrom);
            command.Parameters.AddWithValue("@OpenHoursTo", Department.OpenHoursTo);
            command.Parameters.AddWithValue("@OpenDays", Department.OpenDays);
            command.Parameters.AddWithValue("@MinimumAge", Department.MinimumAge);
            command.Parameters.AddWithValue("@SeatCount", Department.SeatCount);


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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "AddDepartment");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static bool UpdateDepartment(
            clsDepartment Department
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                UPDATE Departments SET
                Name = @Name,
                ImagePath = @ImagePath,
                Description = @Description,
                Location = @Location,
                OpenHoursFrom = @OpenHoursFrom,
                OpenHoursTo = @OpenHoursTo,
                OpenDays = @OpenDays,
                MinimumAge = @MinimumAge,
                SeatCount = @SeatCount
                WHERE DepartmentID = @DepartmentID

            ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@Name", Department.Name);
            command.Parameters.AddWithValue("@ImagePath", Department.ImagePath);
            command.Parameters.AddWithValue("@Description", Department.Description);
            command.Parameters.AddWithValue("@Location", Department.Location);
            command.Parameters.AddWithValue("@OpenHoursFrom", Department.OpenHoursFrom);
            command.Parameters.AddWithValue("@OpenHoursTo", Department.OpenHoursTo);
            command.Parameters.AddWithValue("@OpenDays", Department.OpenDays);
            command.Parameters.AddWithValue("@MinimumAge", Department.MinimumAge);
            command.Parameters.AddWithValue("@DepartmentID", Department.ID);
            command.Parameters.AddWithValue("@SeatCount", Department.SeatCount);

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "UpdateDepartment");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public static bool DeleteDepartment(int ID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                DELETE Departments WHERE DepartmentID = @DepartmentID;

            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DepartmentID", ID);

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "DeleteDepartment");
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;
        }

        public static int GetSeatCountInDep(int ID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                Select SeatCount From Departments WHERE DepartmentID = @ID

            ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            int count = 0;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result == null)
                {
                    count = 0;
                }
                else
                {
                    count = (int)result;
                }
            }
            catch (Exception ex)
            {
                clsLogsDataAccess.AddErrorLog(ex.Message, "GetSeatCountInDep");
            }
            finally
            {
                connection.Close();
            }
            return count;
        }
    }
}
