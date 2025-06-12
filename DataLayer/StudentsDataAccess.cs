using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsStudentsDataAccess
    {
        public static DataTable GetAllStudents()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = (

                "SELECT                                                              " +
                "    S.StudentID,                                                    " +
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
                "    S.StatusID,                                                     " +
                "    S.StudentCardNumber                                             " +
                "FROM Students S                                                     " +
                "INNER JOIN Person P ON S.InfoID = P.InfoID                          "

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetAllStudents");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool GetStudent(
            ref clsStudent Student
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();

            string filterString = "";


            if (Student.ID != -1)
            {
                filterString += " S.StudentID = @ID AND";
                command.Parameters.AddWithValue("@ID", Student.ID);
            }
            if (Student.person.Firstname != "")
            {
                filterString += " P.Firstname = @Firstname AND";
                command.Parameters.AddWithValue("@Firstname", Student.person.Firstname);
            }
            if (Student.person.Lastname != "")
            {
                filterString += " P.Lastname = @Lastname AND";
                command.Parameters.AddWithValue("@Lastname", Student.person.Lastname);
            }
            if (Student.person.Email != "")
            {
                filterString += " P.Email = @Email AND";
                command.Parameters.AddWithValue("@Email", Student.person.Email);
            }
            if (Student.person.Username != "")
            {
                filterString += " P.Username = @Username AND";
                command.Parameters.AddWithValue("@Username", Student.person.Username);
            }
            if (Student.person.Phone != "")
            {
                filterString += " P.Phone = @Phone AND";
                command.Parameters.AddWithValue("@Phone", Student.person.Phone);
            }
            if (Student.person.Gender != "")
            {
                filterString += " P.Gender = @Gender AND";
                command.Parameters.AddWithValue("@Gender", Student.person.Gender);
            }
            if (Student.person.Nationality != "")
            {
                filterString += " P.Nationality = @Nationality AND";
                command.Parameters.AddWithValue("@Nationality", Student.person.Nationality);
            }
            if (Student.person.IDnumber != "")
            {
                filterString += " P.IDnumber = @IDnumber AND";
                command.Parameters.AddWithValue("@IDnumber", Student.person.IDnumber);
            }
            if (Student.Status.ID != -1)
            {
                filterString += " S.StatusID = @StatusID AND";
                command.Parameters.AddWithValue("@StatusID", Student.Status.ID);
            }
            if (Student.StudentCardNumber != "")
            {
                filterString += " S.StudentCardNumber = @StudentCardNumber AND";
                command.Parameters.AddWithValue("@StudentCardNumber", Student.StudentCardNumber);
            }
           

            string query = (

                "SELECT                                                              " +
                "    S.InfoID,                                                       " +
                "    S.StudentID,                                                    " +
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
                "    S.StatusID,                                                     " +
                "    S.StudentCardNumber                                             " +
                "FROM Students S                                                     " +
                "INNER JOIN Person P ON S.InfoID = P.InfoID                          " +
                "WHERE " + filterString + " ' ' = ' ' "
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

                    Student.person.ID = (int)reader["InfoID"];
                    Student.ID = (int)reader["StudentID"];
                    Student.person.Firstname = (string)reader["Firstname"];
                    Student.person.Lastname = (string)reader["Lastname"];
                    Student.person.Email = (string)reader["Email"];
                    Student.person.Password = (string)reader["Password"];
                    Student.person.Username = (string)reader["Username"];
                    Student.person.Phone = (string)reader["Phone"];
                    Student.person.Gender = (string)reader["Gender"];
                    Student.person.Nationality = (string)reader["Nationality"];
                    Student.person.IDnumber = (string)reader["IDnumber"];
                    Student.person.DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Student.person.ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : null;
                    Student.Status.ID = (int)reader["StatusID"];
                    Student.StudentCardNumber = (string)reader["StudentCardNumber"];

                }
            }
            catch (Exception ex)
            {
                isFound = false;
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetStudent");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static DataTable GetStudents(
            clsStudent Student
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();

            string filterString = "";

            if (Student.ID != -1)
            {
                filterString += " S.StudentID = @ID AND";
                command.Parameters.AddWithValue("@ID", Student.ID);
            }
            if (Student.person.Firstname != "")
            {
                filterString += " P.Firstname = @Firstname AND";
                command.Parameters.AddWithValue("@Firstname", Student.person.Firstname);
            }
            if (Student.person.Lastname != "")
            {
                filterString += " P.Lastname = @Lastname AND";
                command.Parameters.AddWithValue("@Lastname", Student.person.Lastname);
            }
            if (Student.person.Email != "")
            {
                filterString += " P.Email = @Email AND";
                command.Parameters.AddWithValue("@Email", Student.person.Email);
            }
            if (Student.person.Username != "")
            {
                filterString += " P.Username = @Username AND";
                command.Parameters.AddWithValue("@Username", Student.person.Username);
            }
            if (Student.person.Phone != "")
            {
                filterString += " P.Phone = @Phone AND";
                command.Parameters.AddWithValue("@Phone", Student.person.Phone);
            }
            if (Student.person.Gender != "")
            {
                filterString += " P.Gender = @Gender AND";
                command.Parameters.AddWithValue("@Gender", Student.person.Gender);
            }
            if (Student.person.Nationality != "")
            {
                filterString += " P.Nationality = @Nationality AND ";
                command.Parameters.AddWithValue("@Nationality", Student.person.Nationality);
            }
            if (Student.person.IDnumber != "")
            {
                filterString += " P.IDnumber = @IDnumber AND ";
                command.Parameters.AddWithValue("@IDnumber", Student.person.IDnumber);
            }
            if (Student.Status.ID != -1)
            {
                filterString += " S.StatusID = @StatusID AND ";
                command.Parameters.AddWithValue("@StatusID", Student.Status.ID);
            }
            if (Student.StudentCardNumber != "")
            {
                filterString += " S.StudentCardNumber = @StudentCardNumber AND ";
                command.Parameters.AddWithValue("@StudentCardNumber", Student.StudentCardNumber);
            }
            if (Student.Department.ID != -1)
            {
                filterString += " S.DepartmentID = @DepartmentID AND ";
                command.Parameters.AddWithValue("@DepartmentID", Student.Department.ID);
            }
            if (Student.Department.Name != "") 
            {
                filterString += " D.Name = @DepartmentName AND ";
                command.Parameters.AddWithValue("@DepartmentName", Student.Department.Name);
            }



            string query = (

                "SELECT                                                              " +
                "    S.StudentID,                                                    " +
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
                "    S.StatusID,                                                     " +
                "    S.StudentCardNumber                                             " +
                "FROM Students S                                                     " +
                "INNER JOIN Person P ON S.InfoID = P.InfoID                          " +
                "INNER JOIN Departments D ON S.DepartmentID = D.DepartmentID         " +
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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetStudents");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable GetStudentsSimple(
            clsStudent Student
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();

            string filterString = "";

            if (Student.ID != -1)
            {
                filterString += " S.StudentID = @ID AND";
                command.Parameters.AddWithValue("@ID", Student.ID);
            }
            if (Student.person.Firstname != "")
            {
                filterString += " P.Firstname = @Firstname AND";
                command.Parameters.AddWithValue("@Firstname", Student.person.Firstname);
            }
            if (Student.person.Lastname != "")
            {
                filterString += " P.Lastname = @Lastname AND";
                command.Parameters.AddWithValue("@Lastname", Student.person.Lastname);
            }
            if (Student.person.Email != "")
            {
                filterString += " P.Email = @Email AND";
                command.Parameters.AddWithValue("@Email", Student.person.Email);
            }
            if (Student.person.Username != "")
            {
                filterString += " P.Username = @Username AND";
                command.Parameters.AddWithValue("@Username", Student.person.Username);
            }
            if (Student.person.Phone != "")
            {
                filterString += " P.Phone = @Phone AND";
                command.Parameters.AddWithValue("@Phone", Student.person.Phone);
            }
            if (Student.person.Gender != "")
            {
                filterString += " P.Gender = @Gender AND";
                command.Parameters.AddWithValue("@Gender", Student.person.Gender);
            }
            if (Student.person.Nationality != "")
            {
                filterString += " P.Nationality = @Nationality AND";
                command.Parameters.AddWithValue("@Nationality", Student.person.Nationality);
            }
            if (Student.person.IDnumber != "")
            {
                filterString += " P.IDnumber = @IDnumber AND";
                command.Parameters.AddWithValue("@IDnumber", Student.person.IDnumber);
            }
            if (Student.Status.ID != -1)
            {
                filterString += " S.StatusID = @StatusID AND";
                command.Parameters.AddWithValue("@StatusID", Student.Status.ID);
            }
            if (Student.StudentCardNumber != "")
            {
                filterString += " S.StudentCardNumber = @StudentCardNumber AND";
                command.Parameters.AddWithValue("@StudentCardNumber", Student.StudentCardNumber);
            }



            string query = (

                "SELECT                                                              " +
                "    P.Firstname,                                                    " +
                "    P.Lastname,                                                     " +
                "    P.Phone,                                                        " +
                "    P.Gender,                                                       " +
                "    S.StudentCardNumber                                             " +
                "FROM Students S                                                     " +
                "INNER JOIN Person P ON S.InfoID = P.InfoID                          " +
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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetStudents");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool isStudentExists(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = "SELECT total=1 FROM Students WHERE StudentID = @ID";

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
                isFound = false;
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "isStudentExists");
            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }
        public static bool isStudentExists(string Firstname)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = "SELECT total=1 FROM Students WHERE Firstname = @Firstname";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Firstname", Firstname);

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
                isFound = false;
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "isStudentExists");
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static int AddStudent(
            clsStudent Student
        )
        {

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = (

                "INSERT INTO Person (" +
                "Firstname, Lastname, Email, Password, Username, Phone, Gender, Nationality, IDnumber, DateOfBirth, ImagePath) VALUES (" +
                "@Firstname, @Lastname, @Email, @Password, @Username, @Phone, @Gender, @Nationality, @IDnumber, @DateOfBirth, @ImagePath); " +
                "INSERT INTO Students (" +
                "InfoID, StatusID, StudentCardNumber) VALUES (" +
                "SCOPE_IDENTITY(), @StatusID, @StudentCardNumber); " +
                "SELECT SCOPE_IDENTITY(); "

            );


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Firstname", Student.person.Firstname);
            command.Parameters.AddWithValue("@Lastname", Student.person.Lastname);
            command.Parameters.AddWithValue("@Email", Student.person.Email);
            command.Parameters.AddWithValue("@Password", Student.person.Password);
            command.Parameters.AddWithValue("@Username", Student.person.Username);
            command.Parameters.AddWithValue("@Phone", Student.person.Phone);
            command.Parameters.AddWithValue("@Gender", Student.person.Gender);
            command.Parameters.AddWithValue("@Nationality", Student.person.Nationality);
            command.Parameters.AddWithValue("@IDnumber", Student.person.IDnumber);
            command.Parameters.AddWithValue("@DateOfBirth", Student.person.DateOfBirth);
            command.Parameters.AddWithValue("@ImagePath", Student.person.ImagePath);
            command.Parameters.AddWithValue("@StatusID", Student.Status.ID);
            command.Parameters.AddWithValue("@StudentCardNumber", Student.StudentCardNumber);

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "AddStudent");
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static bool UpdateStudent(
            clsStudent Student
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
                                
                UPDATE Students SET
                StatusID = @StatusID,
                StudentCardNumber = @StudentCardNumber
                WHERE StudentID = @StudentID;

            ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@InfoID", Student.person.ID);
            command.Parameters.AddWithValue("@Firstname", Student.person.Firstname);
            command.Parameters.AddWithValue("@Lastname", Student.person.Lastname);
            command.Parameters.AddWithValue("@Email", Student.person.Email);
            command.Parameters.AddWithValue("@Password", Student.person.Password);
            command.Parameters.AddWithValue("@Username", Student.person.Username);
            command.Parameters.AddWithValue("@Phone", Student.person.Phone);
            command.Parameters.AddWithValue("@Gender", Student.person.Gender);
            command.Parameters.AddWithValue("@Nationality", Student.person.Nationality);
            command.Parameters.AddWithValue("@IDnumber", Student.person.IDnumber);
            command.Parameters.AddWithValue("@DateOfBirth", Student.person.DateOfBirth);
            command.Parameters.AddWithValue("@ImagePath", Student.person.ImagePath);
            command.Parameters.AddWithValue("@StatusID", Student.Status.ID);
            command.Parameters.AddWithValue("@StudentCardNumber", Student.StudentCardNumber);
            command.Parameters.AddWithValue("@StudentID", Student.ID);

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "UpdateStudent");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public static bool DeleteStudent(int ID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query1 = @"

                DELETE Students WHERE StudentID = @StudentID;
            
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
                command.Parameters.AddWithValue("@StudentID", ID);
                rowsAffected1 = command.ExecuteNonQuery();

                command = new SqlCommand(query2, connection);
                rowsAffected2 = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Log
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "DeleteStudent");
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected1 > 0 && rowsAffected2 > 0;
        }
        public static DataTable GetAllStudentsAllData()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = (

                @"
                SELECT 

                    S.StudentID, P.InfoID, P.Firstname, P.Lastname, P.Email, P.Username,
                    P.Phone, P.Gender, P.Nationality, P.IDnumber, P.DateOfBirth,
                    P.ImagePath, St.StatusID, St.Status, S.StudentCardNumber

                FROM Students S
                    JOIN	Person P ON S.InfoID = P.InfoID
                    JOIN	Status St ON S.StatusID = St.StatusID

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetAllStudentsAllData");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable GetAllStudentsAllDataFilterd(clsStudent Student)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();

            string filterString = "";

            if (Student.ID != -1)
            {
                filterString += " S.StudentID = @ID AND";
                command.Parameters.AddWithValue("@ID", Student.ID);
            }
            if (Student.person.Firstname != "")
            {
                filterString += " P.Firstname = @Firstname AND";
                command.Parameters.AddWithValue("@Firstname", Student.person.Firstname);
            }
            if (Student.person.Lastname != "")
            {
                filterString += " P.Lastname = @Lastname AND";
                command.Parameters.AddWithValue("@Lastname", Student.person.Lastname);
            }
            if (Student.person.Email != "")
            {
                filterString += " P.Email = @Email AND";
                command.Parameters.AddWithValue("@Email", Student.person.Email);
            }
            if (Student.person.Username != "")
            {
                filterString += " P.Username = @Username AND";
                command.Parameters.AddWithValue("@Username", Student.person.Username);
            }
            if (Student.person.Phone != "")
            {
                filterString += " P.Phone = @Phone AND";
                command.Parameters.AddWithValue("@Phone", Student.person.Phone);
            }
            if (Student.person.Gender != "")
            {
                filterString += " P.Gender = @Gender AND";
                command.Parameters.AddWithValue("@Gender", Student.person.Gender);
            }
            if (Student.person.Nationality != "")
            {
                filterString += " P.Nationality = @Nationality AND";
                command.Parameters.AddWithValue("@Nationality", Student.person.Nationality);
            }
            if (Student.person.IDnumber != "")
            {
                filterString += " P.IDnumber = @IDnumber AND";
                command.Parameters.AddWithValue("@IDnumber", Student.person.IDnumber);
            }
            if (Student.Status.ID != -1)
            {
                filterString += " S.StatusID = @StatusID AND";
                command.Parameters.AddWithValue("@StatusID", Student.Status.ID);
            }
            if (Student.StudentCardNumber != "")
            {
                filterString += " S.StudentCardNumber = @StudentCardNumber AND";
                command.Parameters.AddWithValue("@StudentCardNumber", Student.StudentCardNumber);
            }

            string query = (

                @"
                SELECT 

                    S.StudentID, P.InfoID, P.Firstname, P.Lastname, P.Email, P.Username,
                    P.Phone, P.Gender, P.Nationality, P.IDnumber, P.DateOfBirth,
                    P.ImagePath, St.StatusID, St.Status, S.StudentCardNumber

                FROM Students S
                    JOIN	Person P ON S.InfoID = P.InfoID
                    JOIN	Status St ON S.StatusID = St.StatusID

                WHERE " + filterString + " ' ' = ' ' "
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
                // Logger
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetAllStudentsAllData");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable GetBlockedStudents()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"
                SELECT S.StudentID,
                P.Firstname + ' ' + P.Lastname AS Fullname,
                S.StudentCardNumber
                FROM Students S JOIN Person P ON S.InfoID = P.InfoID
                WHERE S.StatusID = 3";


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
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetStudents");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static int GetStudentsWithBorrowsCount()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"
                
                    SELECT count(*)
                    FROM (SELECT DISTINCT StudentID FROM Borrows) ra;

            ";

            SqlCommand command = new SqlCommand(query, connection);

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
                clsLogsDataAccess.AddErrorLog(ex.Message, "GetStudentsWithBorrowCount");
            }
            finally
            {
                connection.Close();
            }
            return count;
        }

        public static int GetUnblockedStudentCount()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"
                SELECT count(*)
                FROM Students
                WHERE StatusID <> 3
                ";


            SqlCommand command = new SqlCommand(query, connection);

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
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetUnblockedStudentCount");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return count;
        }
        public static string GetStatusByStatusID(int ID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                SELECT Status FROM Status WHERE StatusID = @StatusID
            
            ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("StatusID", ID);
            string status = "";
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    status = (string)result;
                }

            }
            catch (Exception ex)
            {
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetStatusByStatusID");
            }
            finally { connection.Close(); }

            return status;
        }
        public static int GetStatusIDByStatus(string Status)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                SELECT StatusID FROM Status WHERE Status = @Status
            
            ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Status", Status);
            int StatusID = -1;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    StatusID = (int)result;
                }

            }
            catch (Exception ex)
            {
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetStatusIDByStatus");
            }
            finally { connection.Close(); }

            return StatusID;
        }
    }
}
