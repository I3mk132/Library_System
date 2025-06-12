using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinesLayer
{
    public class clsCopys
    {
        public clsCopyInfo Copy { get; set; }
        private enum enMode { AddNew, Update }
        private enMode _Mode;

        public clsCopys()
        {
            Copy = new clsCopyInfo();
            _Mode = enMode.AddNew;
        }
        private clsCopys(clsCopyInfo copy)
        {
            Copy = copy;

        }
        public clsCopys(int BookID, string BookStatus, int DepartmentID)
        {
            
            Copy = new clsCopyInfo();
            Copy.Book.ID = BookID;
            Copy.BookStatus = BookStatus;
            Copy.Department.ID = DepartmentID;
            _Mode = enMode.AddNew;
        }


        public static DataTable GetAllCopys()
        {
            return clsCopyDataAccess.GetAllCopys();
        }
        public static DataTable GetAllCopysAllData()
        {
            return clsCopyDataAccess.GetAllCopysAllData();
        }
        public static DataTable GetAllCopysAllDataFilterd(
                int ID = -1, string Title = "", string Author = "",
                string ISBN = "", string Genre = "", string Details = "",
                string BookStatus = ""
            )
        {
            clsCopyInfo copy = new clsCopyInfo();
            copy.Book.ID = ID;
            copy.Book.Title = Title;
            copy.Book.Author = Author;
            copy.Book.ISBN = ISBN;
            copy.Book.Genre = Genre;
            copy.Book.Details = Details;
            copy.BookStatus = BookStatus;

            return clsCopyDataAccess.GetAllCopysAllData(copy);
        }
        public static clsCopys Find(
            int ID = -1, int BookID = -1, string BookStatus = "",
            int DepartmentID = -1
        )
        {
            clsCopyInfo Copy = new clsCopyInfo();
            Copy.ID = ID;
            Copy.Book.ID = BookID;
            Copy.BookStatus = BookStatus;
            Copy.Department.ID = DepartmentID;

            if (clsCopyDataAccess.GetCopy(ref Copy))
            {
                return new clsCopys(Copy);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetCopysWith(
            int ID = -1, int BookID = -1, string BookStatus = "",
            int DepartmentID = -1
        )
        {
            clsCopyInfo Copy = new clsCopyInfo();
            Copy.ID = ID;
            Copy.Book.ID = BookID;
            Copy.BookStatus = BookStatus;
            Copy.Department.ID = DepartmentID;

            return clsCopyDataAccess.GetCopys(Copy);
        }
        public static bool isCopyExists(int ID)
        {
            return clsCopyDataAccess.isCopyExists(ID);
        }
        public static bool DeleteCopy(int ID)
        {
            return (clsCopyDataAccess.DeleteCopy(ID));
        }
        public static int GetCopysCount()
        {
            return clsCopys.GetAllCopys().Rows.Count;
        }
        public static string getBookTitle(int CopyID)
        {
            clsBooks book = clsBooks.Find(ID: Find(ID: CopyID).Copy.Book.ID);
            if (book != null)
            {
                return book.Book.Title;
            }
            else
            {
                return "";
            }
        }

        private bool _AddNewCopy()
        {
            this.Copy.ID = clsCopyDataAccess.AddCopy(this.Copy);

            return (this.Copy.ID != -1);
        }
        private bool _UpdateCopy()
        {
            return clsCopyDataAccess.UpdateCopy(this.Copy);
        }
        public bool Save()
        {

            if (_Mode == enMode.AddNew)
            {
                if (_AddNewCopy())
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
                if (_UpdateCopy())
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
