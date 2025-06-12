using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace DataLayer
{
    public class clsEmployeesDataAccess
    {
        public static DataTable GetAllEmployees()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = (

                "SELECT                                                              " +
                "    E.EmployeeID,                                                   " +
                "    P.Firstname,                                                    " +
                "    P.Lastname,                                                     " +
                "    P.Email,                                                        " +
                "    P.Password,                                                     " +
                "    P.Username,                                                     " +
                "    P.Phone,                                                        " +
                "    P.Gender,                                                       " +
                "    P.Nationality,                                                  " +
                "    P.IDnumber,                                                     " +
                "    P.DateOfBirth,                                                  " +
                "    P.ImagePath,                                                    " +
                "    E.Salary,                                                       " +
                "    E.RoleID,                                                       " +
                "    E.DepartmentID,                                                 " +
                "    E.ShiftID,                                                      " +
                "    E.EmployeeCardNumber,                                           " +
                "    E.ManagerID,                                                    " +
                "    E.Permissions                                                  " +
                "FROM Employees E                                                    " +
                "INNER JOIN Person P ON E.InfoID = P.InfoID                          "
            );

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetAllEmployees");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool GetEmployee(
            ref clsEmployee Employee
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();

            string filterString = "";


            if (Employee.ID != -1)
            {
                filterString += " E.EmployeeID = @ID AND";
                command.Parameters.AddWithValue("@ID", Employee.ID);
            }
            if (Employee.person.Firstname != "")
            {
                filterString += " P.Firstname = @Firstname AND";
                command.Parameters.AddWithValue("@Firstname", Employee.person.Firstname);
            }
            if (Employee.person.Lastname != "")
            {
                filterString += " P.Lastname = @Lastname AND";
                command.Parameters.AddWithValue("@Lastname", Employee.person.Lastname);
            }
            if (Employee.person.Email != "")
            {
                filterString += " P.Email = @Email AND";
                command.Parameters.AddWithValue("@Email", Employee.person.Email);
            }
            if (Employee.person.Username != "")
            {
                filterString += " P.Username = @Username AND";
                command.Parameters.AddWithValue("@Username", Employee.person.Username);
            }
            if (Employee.person.Phone != "")
            {
                filterString += " P.Phone = @Phone AND";
                command.Parameters.AddWithValue("@Phone", Employee.person.Phone);
            }
            if (Employee.person.Gender != "")
            {
                filterString += " P.Gender = @Gender AND";
                command.Parameters.AddWithValue("@Gender", Employee.person.Gender);
            }
            if (Employee.person.Nationality != "")
            {
                filterString += " P.Nationality = @Nationality AND";
                command.Parameters.AddWithValue("@Nationality", Employee.person.Nationality);
            }
            if (Employee.person.IDnumber != "")
            {
                filterString += " P.IDnumber = @IDnumber AND";
                command.Parameters.AddWithValue("@IDnumber", Employee.person.IDnumber);
            }
            if (Employee.Salary != -1)
            {
                filterString += " E.Salary = @Salary AND";
                command.Parameters.AddWithValue("@Salary", Employee.Salary);
            }
            if (Employee.Role.ID != -1)
            {
                filterString += " E.RoleID = @RoleID AND";
                command.Parameters.AddWithValue("@RoleID", Employee.Role.ID);
            }
            if (Employee.Department.ID != -1)
            {
                filterString += " E.DepartmentID = @DepartmentID AND";
                command.Parameters.AddWithValue("@DepartmentID", Employee.Department.ID);
            }
            if (Employee.Shift.ID != -1)
            {
                filterString += " E.ShiftID = @ShiftID AND";
                command.Parameters.AddWithValue("@ShiftID", Employee.Shift.ID);
            }
            if (Employee.EmployeeCardNumber != "")
            {
                filterString += " E.EmployeeCardNumber = @EmployeeCardNumber AND";
                command.Parameters.AddWithValue("@EmployeeCardNumber", Employee.EmployeeCardNumber);
            }
            if (Employee.ManagersID != -1)
            {
                filterString += " E.ManagersID = @ManagersID AND";
                command.Parameters.AddWithValue("@ManagersID", Employee.ManagersID); ;
            }
            if (Employee.Permissions != -1)
            {
                filterString += " Permissions = @Permissions";
                command.Parameters.AddWithValue("@Permissions", Employee.Permissions);
            }

            string query = (

                "SELECT                                                              " +
                "    E.InfoID,                                                       " +
                "    E.EmployeeID,                                                   " +
                "    P.Firstname,                                                    " +
                "    P.Lastname,                                                     " +
                "    P.Email,                                                        " +
                "    P.Password,                                                     " +
                "    P.Username,                                                     " +
                "    P.Phone,                                                        " +
                "    P.Gender,                                                       " +
                "    P.Nationality,                                                  " +
                "    P.IDnumber,                                                     " +
                "    P.DateOfBirth,                                                  " +
                "    P.ImagePath,                                                    " +
                "    E.Salary,                                                       " +
                "    E.RoleID,                                                       " +
                "    E.DepartmentID,                                                 " +
                "    E.ShiftID,                                                      " +
                "    E.EmployeeCardNumber,                                           " +
                "    E.ManagerID,                                                    " +
                "    E.Permissions                                                   " +
                "FROM Employees E                                                    " +
                "INNER JOIN Person P ON E.InfoID = P.InfoID                          " +
                "WHERE" + filterString + " ' ' = ' ' "
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

                    Employee.person.ID = (int)reader["InfoID"];
                    Employee.ID = (int)reader["EmployeeID"];
                    Employee.person.Firstname = (string)reader["Firstname"];
                    Employee.person.Lastname = (string)reader["Lastname"];
                    Employee.person.Email = (string)reader["Email"];
                    Employee.person.Password = (string)reader["Password"];
                    Employee.person.Username = (string)reader["Username"];
                    Employee.person.Phone = (string)reader["Phone"];
                    Employee.person.Gender = (string)reader["Gender"];
                    Employee.person.Nationality = (string)reader["Nationality"];
                    Employee.person.IDnumber = (string)reader["IDnumber"];
                    Employee.person.DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Employee.person.ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : null;
                    Employee.Salary = (double)reader["Salary"];
                    Employee.Role.ID = (int)reader["RoleID"];
                    Employee.Department.ID = (int)reader["DepartmentID"];
                    Employee.Shift.ID = (int)reader["ShiftID"];
                    Employee.EmployeeCardNumber = (string)reader["EmployeeCardNumber"];
                    Employee.ManagersID = (int)reader["ManagerID"];
                    Employee.Permissions = (int)reader["Permissions"];

                }
            }
            catch (Exception ex)
            {
                isFound = false;
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetEmployee");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static DataTable GetEmployees(
            clsEmployee Employee
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();

            string filterString = "";


            if (Employee.ID != -1)
            {
                filterString += " E.EmployeeID = @ID AND";
                command.Parameters.AddWithValue("@ID", Employee.ID);
            }
            if (Employee.person.Firstname != "")
            {
                filterString += " P.Firstname = @Firstname AND";
                command.Parameters.AddWithValue("@Firstname", Employee.person.Firstname);
            }
            if (Employee.person.Lastname != "")
            {
                filterString += " P.Lastname = @Lastname AND";
                command.Parameters.AddWithValue("@Lastname", Employee.person.Lastname);
            }
            if (Employee.person.Email != "")
            {
                filterString += " P.Email = @Email AND";
                command.Parameters.AddWithValue("@Email", Employee.person.Email);
            }
            if (Employee.person.Username != "")
            {
                filterString += " P.Username = @Username AND";
                command.Parameters.AddWithValue("@Username", Employee.person.Username);
            }
            if (Employee.person.Phone != "")
            {
                filterString += " P.Phone = @Phone AND";
                command.Parameters.AddWithValue("@Phone", Employee.person.Phone);
            }
            if (Employee.person.Gender != "")
            {
                filterString += " P.Gender = @Gender AND";
                command.Parameters.AddWithValue("@Gender", Employee.person.Gender);
            }
            if (Employee.person.Nationality != "")
            {
                filterString += " P.Nationality = @Nationality AND";
                command.Parameters.AddWithValue("@Nationality", Employee.person.Nationality);
            }
            if (Employee.person.IDnumber != "")
            {
                filterString += " P.IDnumber = @IDnumber AND";
                command.Parameters.AddWithValue("@IDnumber", Employee.person.IDnumber);
            }
            if (Employee.Salary != -1)
            {
                filterString += " E.Salary = @Salary AND";
                command.Parameters.AddWithValue("@Salary", Employee.Salary);
            }
            if (Employee.Role.ID != -1)
            {
                filterString += " E.RoleID = @RoleID AND";
                command.Parameters.AddWithValue("@RoleID", Employee.Role.ID);
            }
            if (Employee.Department.ID != -1)
            {
                filterString += " E.DepartmentID = @DepartmentID AND";
                command.Parameters.AddWithValue("@DepartmentID", Employee.Department.ID);
            }
            if (Employee.Shift.ID != -1)
            {
                filterString += " E.ShiftID = @ShiftID AND";
                command.Parameters.AddWithValue("@ShiftID", Employee.Shift.ID);
            }
            if (Employee.EmployeeCardNumber != "")
            {
                filterString += " E.EmployeeCardNumber = @EmployeeCardNumber AND";
                command.Parameters.AddWithValue("@EmployeeCardNumber", Employee.EmployeeCardNumber);
            }
            if (Employee.ManagersID != -1)
            {
                filterString += " E.ManagersID = @ManagersID AND";
                command.Parameters.AddWithValue("@ManagersID", Employee.ManagersID); ;
            }
            if (Employee.Permissions != -1)
            {
                filterString += " Permissions = @Permissions";
                command.Parameters.AddWithValue("@Permissions", Employee.Permissions);
            }

            string query = (

                "SELECT                                                              " +
                "    E.EmployeeID,                                                   " +
                "    P.Firstname,                                                    " +
                "    P.Lastname,                                                     " +
                "    P.Email,                                                        " +
                "    P.Password,                                                     " +
                "    P.Username,                                                     " +
                "    P.Phone,                                                        " +
                "    P.Gender,                                                       " +
                "    P.Nationality,                                                  " +
                "    P.IDnumber,                                                     " +
                "    P.DateOfBirth,                                                  " +
                "    P.ImagePath,                                                    " +
                "    E.Salary,                                                       " +
                "    E.RoleID,                                                       " +
                "    E.DepartmentID,                                                 " +
                "    E.ShiftID,                                                      " +
                "    E.EmployeeCardNumber,                                           " +
                "    E.ManagerID,                                                    " +
                "    E.Permissions                                                   " +
                "FROM Employees E                                                    " +
                "INNER JOIN Person P ON E.InfoID = P.InfoID                          " +
                "WHERE" + filterString + " ' ' = ' ' "
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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetEmployees");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return dt;
            
        }
        public static bool isEmployeeExists(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = "SELECT total=1 FROM Employees WHERE EmployeeID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if ( result != null )
                {
                    isFound = true;
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "isEmployeeExists");
            }
            finally
            {
                connection.Close();
            }
            return isFound;
            
        }
        public static int AddEmployee(
            clsEmployee Employee
        )
        {
            
            SqlConnection connection = new SqlConnection( clsSettings.connectionString);

            string query = (

                "INSERT INTO Person (" +
                "Firstname, Lastname, Email, Password, Username, Phone, Gender, Nationality, IDnumber, DateOfBirth, ImagePath) VALUES (" +
                "@Firstname, @Lastname, @Email, @Password, @Username, @Phone, @Gender, @Nationality, @IDnumber, @DateOfBirth, @ImagePath); " +
                "INSERT INTO Employees (" +
                "InfoID, Salary, RoleID, DepartmentID, ShiftID, EmployeeCardNumber, ManagerID, Permissions) VALUES (" +
                "SCOPE_IDENTITY(), @Salary, @RoleID, @DepartmentID, @ShiftID, @EmployeeCardNumber, @ManagerID, @Permissions); " + 
                "SELECT SCOPE_IDENTITY(); "

            );


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Firstname", Employee.person.Firstname);
            command.Parameters.AddWithValue("@Lastname", Employee.person.Lastname);
            command.Parameters.AddWithValue("@Email", Employee.person.Email);
            command.Parameters.AddWithValue("@Password", Employee.person.Password);
            command.Parameters.AddWithValue("@Username", Employee.person.Username);
            command.Parameters.AddWithValue("@Phone", Employee.person.Phone);
            command.Parameters.AddWithValue("@Gender", Employee.person.Gender);
            command.Parameters.AddWithValue("@Nationality", Employee.person.Nationality);
            command.Parameters.AddWithValue("@IDnumber", Employee.person.IDnumber);
            command.Parameters.AddWithValue("@DateOfBirth", Employee.person.DateOfBirth);
            command.Parameters.AddWithValue("@ImagePath", Employee.person.ImagePath);
            command.Parameters.AddWithValue("@Salary", Employee.Salary);
            command.Parameters.AddWithValue("@RoleID", Employee.Role.ID);
            command.Parameters.AddWithValue("@DepartmentID", Employee.Department.ID);
            command.Parameters.AddWithValue("@ShiftID", Employee.Shift.ID);
            command.Parameters.AddWithValue("@EmployeeCardNumber", Employee.EmployeeCardNumber);
            command.Parameters.AddWithValue("@Permissions", Employee.Permissions);
            if (Employee.ManagersID != -1)
                command.Parameters.AddWithValue("@ManagerID", Employee.ManagersID);
            else
                command.Parameters.AddWithValue("@ManagerID", 7);

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "AddEmployee");
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static bool UpdateEmployee(
            clsEmployee Employee
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                UPDATE Person SET
                Firstname = @Firstname,
                Lastname = @Lastname,
                Email = @Email,
                Password = @Password,
                Username = @Username,
                Phone = @Phone,
                Gender = @Gender,
                Nationality = @Nationality,
                IDnumber = @IDnumber,
                DateOfBirth = @DateOfBirth,
                ImagePath = @ImagePath
                WHERE InfoID = @InfoID;
                                
                UPDATE Employees SET
                Salary = @Salary,
                RoleID = @RoleID,
                DepartmentID = @DepartmentID,
                ShiftID = @ShiftID,
                EmployeeCardNumber = @EmployeeCardNumber,
                ManagerID = @ManagerID,
                Permissions = @Permissions
                WHERE EmployeeID = @EmployeeID;

            ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@Firstname", Employee.person.Firstname);
            command.Parameters.AddWithValue("@Lastname", Employee.person.Lastname);
            command.Parameters.AddWithValue("@Email", Employee.person.Email);
            command.Parameters.AddWithValue("@Password", Employee.person.Password);
            command.Parameters.AddWithValue("@Username", Employee.person.Username);
            command.Parameters.AddWithValue("@Phone", Employee.person.Phone);
            command.Parameters.AddWithValue("@Gender", Employee.person.Gender);
            command.Parameters.AddWithValue("@Nationality", Employee.person.Nationality);
            command.Parameters.AddWithValue("@IDnumber", Employee.person.IDnumber);
            command.Parameters.AddWithValue("@DateOfBirth", Employee.person.DateOfBirth);
            command.Parameters.AddWithValue("@ImagePath", Employee.person.ImagePath);
            command.Parameters.AddWithValue("@InfoID", Employee.person.ID);
            command.Parameters.AddWithValue("@Salary", Employee.Salary);
            command.Parameters.AddWithValue("@RoleID", Employee.Role.ID);
            command.Parameters.AddWithValue("@DepartmentID", Employee.Department.ID);
            command.Parameters.AddWithValue("@ShiftID", Employee.Shift.ID);
            command.Parameters.AddWithValue("@EmployeeCardNumber", Employee.EmployeeCardNumber);
            command.Parameters.AddWithValue("@Permissions", Employee.Permissions);
            command.Parameters.AddWithValue("@ManagerID", Employee.ManagersID);
            command.Parameters.AddWithValue("@EmployeeID", Employee.ID);

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "UpdateEmployee");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return result;
        }   
        public static bool DeleteEmployee(int ID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query1 = @"

                DELETE Employees WHERE EmployeeID = @EmployeeID;
            
            ";
            string query2 = @"

                DELETE FROM person
                    WHERE NOT EXISTS (
                        SELECT 1 FROM Students s WHERE s.InfoID = person.InfoID
                    )
                    AND NOT EXISTS (
                        SELECT 1 FROM Employees e WHERE e.InfoID = person.InfoID
                    );

            ";

            SqlCommand command = null;

            int rowsAffected1 = 0, rowsAffected2 = 0;

            try
            {
                connection.Open();

                command = new SqlCommand(query1, connection);
                command.Parameters.AddWithValue("@EmployeeID", ID);
                rowsAffected1 = command.ExecuteNonQuery();

                command = new SqlCommand(query2, connection);
                rowsAffected2 = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                DateTime now = DateTime.Now;
                clsLogsDataAccess.AddErrorLog(now.Date, now.TimeOfDay, ex.Message, "DeleteEmployee");
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected1 > 0 && rowsAffected2 > 0;
        }
        public static DataTable GetAllEmployeesAllData()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = (

                @"
                SELECT 

                    E.EmployeeID, P.InfoID, P.Firstname, P.Lastname, P.Email, P.Username,
                    P.Phone, P.Gender, P.Nationality, P.IDnumber, P.DateOfBirth,
                    P.ImagePath, E.Salary, R.RoleID, R.Role, D.DepartmentID, D.Name AS DepartmentName,
                    D.ImagePath AS DepartmentImagePath, D.Description,
                    D.Location, D.OpenHoursFrom, D.OpenHoursTo, D.OpenDays, D.MinimumAge,
                    S.ShiftID, S.Shift, E.EmployeeCardNumber, E.ManagerID, E.Permissions 

                FROM Employees E
                    JOIN	Person P ON E.InfoID = P.InfoID
                    JOIN	Roles R ON E.RoleID = R.RoleID
                    JOIN	Departments D ON E.DepartmentID = D.DepartmentID
                    JOIN	Shifts S ON E.ShiftID = S.ShiftID

                "
            );

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetAllEmployeesAllData");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static (TimeSpan From, TimeSpan To) GetShiftByShiftID(int ShiftID)
        {
            SqlConnection connection = new SqlConnection (clsSettings.connectionString);

            string query = @"SELECT ShiftFrom, ShiftTo FROM Shifts WHERE ShiftID = @ShiftID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ShiftID", ShiftID);

            (TimeSpan From, TimeSpan To) Shift = (new TimeSpan(), new TimeSpan());
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Shift.From = (TimeSpan)reader["ShiftFrom"];
                    Shift.To = (TimeSpan)reader["ShiftTo"];
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                clsLogsDataAccess.AddErrorLog($"Error While Getting shift ({ex.Message})", "GetShiftByShiftID");
            }
            finally
            {
                connection.Close();
            }
            return Shift;
        }
        public static int GetShiftIDByShift((TimeSpan From, TimeSpan To) Shift)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"SELECT ShiftID FROM Shifts WHERE ShiftFrom = @ShiftFrom AND ShiftTo = @ShiftTo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ShiftFrom", Shift.From);
            command.Parameters.AddWithValue("@ShiftTo", Shift.To);


            int ID = -1;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int)reader["ShiftID"];
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                clsLogsDataAccess.AddErrorLog($"Error While Getting shiftID ({ex.Message})", "GetShiftIDByShift");
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }

        public static string GetRoleByRoleID(int RoleID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"SELECT Role FROM Roles WHERE RoleID = @RoleID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoleID", RoleID);

            string Role = "";
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Role = (string)reader["Role"];
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                clsLogsDataAccess.AddErrorLog($"Error While Getting Role ({ex.Message})", "GetRoleByRoleID");
            }
            finally
            {
                connection.Close();
            }
            return Role;
        }
        public static int GetRoleIDByRole(string Role)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"SELECT RoleID FROM Roles WHERE Role = @Role";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Role", Role);



            int ID = -1;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int)reader["RoleID"];
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                clsLogsDataAccess.AddErrorLog($"Error While Getting RoleID ({ex.Message})", "GetRoleIDByRole");
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static DataTable GetAllEmployeesInShift()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                SELECT                                                          
                     E.EmployeeID,                                               
                     P.Firstname,                                                
                     P.Lastname,                                                 
                     P.Email,                                                    
                     P.Password,                                                 
                     P.Username,                                                 
                     P.Phone,                                                    
                     P.Gender,                                                   
                     P.Nationality,                                              
                     P.IDnumber,                                                 
                     P.DateOfBirth,             
                     P.ImagePath,                                                
                     E.Salary,                                                   
                     E.RoleID,                                                   
                     E.DepartmentID,                                             
                     E.ShiftID,                                                  
                     E.EmployeeCardNumber,                                       
                     E.ManagerID,                                           
                     E.Permissions                                             
                 FROM Employees E                                                
                 INNER JOIN Person P ON E.InfoID = P.InfoID
                 INNER JOIN Shifts S ON E.ShiftID = S.ShiftID
                 WHERE CAST(GETDATE() AS TIME) BETWEEN S.ShiftFrom and S.ShiftTo
    
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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetAllEmployeesInShift");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

    }
}
