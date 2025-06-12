using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinesLayer
{
    public class clsBooks
    {
        public clsBookInfo Book { get; set; }
        private enum enMode { AddNew, Update }
        private enMode _Mode;

        public clsBooks()
        {
            Book = new clsBookInfo();
            _Mode = enMode.AddNew;
        }
        private clsBooks(clsBookInfo book)
        {
            Book = book;
            _Mode = enMode.Update;

        }
        public clsBooks(
                 string Title = "", string Author = "",
                 string Genre = "", string ISBN = "",
                 string Details = "", string ImagePath = "",
                 DateTime PublicationDate = new DateTime()
            )
        {
            Book = new clsBookInfo();
            Book.Title = Title;
            Book.Author = Author;
            Book.Genre = Genre;
            Book.ISBN = ISBN;
            Book.Details = Details;
            Book.ImagePath = ImagePath;
            Book.PublicationDate = PublicationDate;
            _Mode = enMode.AddNew;
        }



        public static DataTable GetAllBooks()
        {
            return clsBooksDataAccess.GetAllBooks();
        }
        public static clsBooks Find(
            int ID = -1, string Title = "",
            string Author = "", string ISBN = "",
            string Genre = "", string Details = ""
        )
        {
            clsBookInfo Book = new clsBookInfo();
            Book.ID = ID;
            Book.Title = Title;
            Book.Author = Author;
            Book.ISBN = ISBN;
            Book.Genre = Genre;
            Book.Details = Details;

            if (clsBooksDataAccess.GetBook(ref Book))
            {
                return new clsBooks(Book);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetBooksWith(
            int ID = -1, string Title = "",
            string Author = "", string ISBN = "",
            string Genre = "", string Details = ""
        )
        {
            clsBookInfo Book = new clsBookInfo();
            Book.ID = ID;
            Book.Title= Title; 
            Book.Author = Author;
            Book.ISBN = ISBN;
            Book.Genre = Genre;
            Book.Details = Details;

            return clsBooksDataAccess.GetBooks(Book);
        }
        public static bool isBookExists(int ID)
        {
            return clsBooksDataAccess.isBookExists(ID);
        }
        public static bool isBookExists(string Title)
        {
            return clsBooksDataAccess.isBookExists(Title);
        }
        public static bool isBookExistsByISBN(string ISBN)
        {
            return clsBooksDataAccess.isBookExistsByISBN(ISBN);
        }
        public static bool DeleteBook(int ID)
        {
            return (clsBooksDataAccess.DeleteBook(ID));
        }
        public static clsBooks SearchBook(string ISBN)
        {
            clsBookInfo book = clsCodeReadWrite.GetBookDataByISBN(ISBN);

            if (book  == null)
            {
                return new clsBooks();
            }

            return new clsBooks(book);
        }


        public enum enBook {
            eID,
            eTitle, eAuthor, eGenre,
            eISBN, eDetails, eImagePath,
            ePublicationDate}

        public object getBookData(enBook book)
        {
            switch (book)
            {
                case enBook.eID: return Book.ID;
                case enBook.eTitle: return Book.Title;
                case enBook.eISBN: return Book.ISBN;
                case enBook.eGenre: return Book.Genre;
                case enBook.eImagePath: return Book.ImagePath;
                case enBook.ePublicationDate: return Book.PublicationDate;
                case enBook.eDetails: return Book.Details;
                case enBook.eAuthor: return Book.Author;
                default: return null;
            }
        }
        public void setBook(
                int ID = -1, string Title = "",
                string ISBN = "", string Genre = "",
                string ImagePath = "", string Details = "",
                DateTime? PublicationDate = null,
                string Author = ""
            )
        {
            if ( ID != -1 ) Book.ID = ID;
            if (Title != "") Book.Title = Title;
            if (ISBN != "") Book.ISBN = ISBN;
            if (Genre != "") Book.Genre = Genre;
            if (ImagePath != "") Book.ImagePath = ImagePath;
            if (PublicationDate != null) Book.PublicationDate = PublicationDate.Value;
            if (Author != "") Book.Author = Author;
            if (Details != "") Book.Details = Details;
        }

        private bool _AddNewBook()
        {
            this.Book.ID = clsBooksDataAccess.AddBook(this.Book);

            return (this.Book.ID != -1);
        }
        private bool _UpdateBook()
        {
            return clsBooksDataAccess.UpdateBook(this.Book);
        }
        public bool Save()
        {

            if (_Mode == enMode.AddNew)
            {
                if (_AddNewBook())
                {
                    _Mode = enMode.Update;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (_UpdateBook())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
