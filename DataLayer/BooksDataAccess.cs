using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsBooksDataAccess
    {
        public static DataTable GetAllBooks()
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"SELECT * FROM BookInfo ";

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetAllBooks");
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool GetBook(
            ref clsBookInfo Book
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();

            string filterString = "";


            if (Book.ID != -1)
            {
                filterString += " BookID = @BookID AND";
                command.Parameters.AddWithValue("@BookID", Book.ID);
            }
            if (Book.Title != "")
            {
                filterString += " Title = @Title AND";
                command.Parameters.AddWithValue("@Title", Book.Title);
            }
            if (Book.Author != "")
            {
                filterString += " Author = @Author AND";
                command.Parameters.AddWithValue("@Author", Book.Author);
            }
            if (Book.ISBN != "")
            {
                filterString += " ISBN = @ISBN AND";
                command.Parameters.AddWithValue("@ISBN", Book.ISBN);
            }
            if (Book.Genre != "")
            {
                filterString += " Genre = @Genre AND";
                command.Parameters.AddWithValue("@Genre", Book.Genre);
            }
            if (Book.Details != "")
            {
                filterString += " Details = @Details AND";
                command.Parameters.AddWithValue("@Details", Book.Details);
            }

            string query = (
                @"SELECT * FROM BookInfo WHERE" + filterString + " ' ' = ' ' "
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

                    Book.ID = (int)reader["BookID"];
                    Book.Title = (string)reader["Title"];
                    Book.Author = (string)reader["Author"];
                    Book.ISBN = (string)reader["ISBN"];
                    Book.PublicationDate = (DateTime)reader["PublicationDate"];
                    Book.Genre = (string)reader["Genre"];
                    Book.Details = (string)reader["Details"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        Book.ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        Book.ImagePath = null; // or assign a default image path if needed
                    }


                }
            }
            catch (Exception ex)
            {
                isFound = false;
                DateTime CurrentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetBook");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static DataTable GetBooks(
            clsBookInfo Book
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand command = new SqlCommand();

            string filterString = "";

            if (Book.ID != -1)
            {
                filterString += " BookID = @BookID AND";
                command.Parameters.AddWithValue("@BookID", Book.ID);
            }
            if (Book.Title != "")
            {
                filterString += " Title = @Title AND";
                command.Parameters.AddWithValue("@Title", Book.Title);
            }
            if (Book.Author != "")
            {
                filterString += " Author = @Author AND";
                command.Parameters.AddWithValue("@Author", Book.Author);
            }
            if (Book.ISBN != "")
            {
                filterString += " ISBN = @ISBN AND";
                command.Parameters.AddWithValue("@ISBN", Book.ISBN);
            }
            if (Book.Genre != "")
            {
                filterString += " Genre = @Genre AND";
                command.Parameters.AddWithValue("@Genre", Book.Genre);
            }
            if (Book.Details != "")
            {
                filterString += " Details = @Details AND";
                command.Parameters.AddWithValue("@Details", Book.Details);
            }

            string query = (
                @"SELECT * FROM BookInfo WHERE" + filterString + " ' ' = ' ' "
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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "GetBooks");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool isBookExists(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = "SELECT total=1 FROM BookInfo WHERE BookID = @ID";

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "isBookExists");
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }
        public static bool isBookExists(string Title)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = "SELECT total=1 FROM BookInfo WHERE Title = @Title";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", Title);

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "isBookExists");
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool isBookExistsByISBN(string ISBN)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = "SELECT total=1 FROM BookInfo WHERE ISBN = @ISBN";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ISBN", ISBN);

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "isBookExistsByISBN");
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static int AddBook(
            clsBookInfo Book
        )
        {

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                INSERT INTO BookInfo
                ( Title, Author, ISBN, PublicationDate, Genre, Details, ImagePath ) VALUES 
                ( @Title, @Author, @ISBN, @PublicationDate, @Genre, @Details, @ImagePath );
                SELECT SCOPE_IDENTITY();
            
            ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Title", Book.Title);
            command.Parameters.AddWithValue("@Author", Book.Author);
            command.Parameters.AddWithValue("@ISBN", Book.ISBN);
            command.Parameters.AddWithValue("@PublicationDate", Book.PublicationDate);
            command.Parameters.AddWithValue("@Genre", Book.Genre);
            command.Parameters.AddWithValue("@Details", Book.Details);
            command.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(Book.ImagePath)
                                            ? (object)DBNull.Value
                                            : (object)Book.ImagePath);







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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "AddBook");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static bool UpdateBook(
            clsBookInfo Book
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                UPDATE BookInfo SET
                Author = @Author,
                ISBN = @ISBN,
                PublicationDate = @PublicationDate,
                Genre = @Genre,
                Details = @Details,
                ImagePath = @ImagePath
                WHERE BookID = @BookID

            ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@Author", Book.Author);
            command.Parameters.AddWithValue("@ISBN", Book.ISBN);
            command.Parameters.AddWithValue("@PublicationDate", Book.PublicationDate);
            command.Parameters.AddWithValue("@Genre", Book.Genre);
            command.Parameters.AddWithValue("@Details", Book.Details);
            command.Parameters.AddWithValue("@ImagePath", Book.ImagePath);
            command.Parameters.AddWithValue("@BookID", Book.ID);

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "UpdateBook");
                // Log
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public static bool DeleteBook(int ID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);

            string query = @"

                DELETE FROM BookInfo WHERE BookID = @BookID;

            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", ID);

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
                clsLogsDataAccess.AddErrorLog(CurrentDate, currentTime, ex.Message, "DeleteBook");
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;
        }

    }
}
