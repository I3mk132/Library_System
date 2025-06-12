    using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinesLayer
{
    public class clsBorrows
    {
        public clsBorrow Borrow { get; set; }
        private enum enMode { AddNew, Update }
        private enMode _Mode;

        public clsBorrows()
        {
            Borrow = new clsBorrow();
            _Mode = enMode.AddNew;
        }
        private clsBorrows(clsBorrow borrow)
        {
            Borrow = borrow;
            _Mode = enMode.Update;

        }
        public clsBorrows(string Title, string Firstname, DateTime ReturnDate)
        {
            _Mode = enMode.AddNew;
            Borrow = new clsBorrow();

            int id = clsStudents.Find(Firstname: Firstname).Student.ID;
            Borrow.Student.ID = id;
            id = clsCopys.Find(BookID: clsBooks.Find(Title: Title).Book.ID).Copy.ID;
            Borrow.Copy.ID = id;
            Borrow.ReturnDate = ReturnDate;
            Borrow.BorrowDate = DateTime.Now.Date;
        }


        public static DataTable GetAllBorrows()
        {
            return clsBorrowsDataAccess.GetAllBorrows();
        }
        public static clsBorrows Find(
            int ID = -1, int StudentID = -1, int CopyID = -1
        )
        {
            clsBorrow Borrow = new clsBorrow();
            Borrow.ID = ID;
            Borrow.Student.ID = StudentID;
            Borrow.Copy.ID= CopyID;

            if (clsBorrowsDataAccess.GetBorrow(ref Borrow))
            {
                return new clsBorrows(Borrow);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetBorrowsWith(
            int ID = -1, int StudentID = -1, int CopyID = -1, int BookID = -1
        )
        {
            clsBorrow borrow = new clsBorrow();
            borrow.ID = ID;
            borrow.Student.ID = StudentID;
            borrow.Copy.ID = CopyID;

            return clsBorrowsDataAccess.GetBorrows(borrow);
        }
        public static DataTable GetBorrowsWith(
            int ID = -1, string StudentName = "", string BookTitle = ""
        )
        {
            clsBorrow borrow = new clsBorrow();
            borrow.ID = ID;

            clsStudents student = clsStudents.Find(Firstname: StudentName);
            if (student == null)
            {
                student = new clsStudents();
            }
            int id = (StudentName != "") ? student.Student.ID : -1;
            borrow.Student.ID =  (id != -1) ? id : -1;

            clsBooks book = clsBooks.Find(Title: BookTitle);
            if (book == null)
            {
                book = new clsBooks();
            }
            id = (BookTitle != "") ? book.Book.ID : -1;
            borrow.Copy.Book.ID = id;

            return clsBorrowsDataAccess.GetBorrows(borrow);
        }
        public static bool isBorrowExists(int ID)
        {
            return clsBorrowsDataAccess.isBorrowExists(ID);
        }
        public static bool DeleteBorrow(int ID)
        {
            return (clsBorrowsDataAccess.DeleteBorrow(ID));
        }
        public static DataTable GetNearBorrows(int Days)
        {
            return clsBorrowsDataAccess.GetNeerBorrows(Days);
        }
        public static DataTable GetNearBorrowIn(int Days, int DepartmentID)
        {
            DataTable borrows = clsBorrowsDataAccess.GetNeerBorrows(Days);
            if (borrows == null || borrows.Rows.Count == 0 || !borrows.Columns.Contains("DepartmentID"))
            {
                return new DataTable(); // Return an empty table with the same structure
            }
            DataRow[] FilteredRows = borrows.Select($"DepartmentID={DepartmentID}");
            DataTable result = borrows.Clone();
            foreach (DataRow Row in FilteredRows)
            {
                result.ImportRow(Row);
            }
            return result;
        }
        public static int GetBorrowsCount()
        {
            return clsBorrowsDataAccess.GetAllBorrows().Rows.Count;
        }

        public static string StudentnameByStudentID(int StudentID)
        {
            clsStudents student = clsStudents.Find(ID: StudentID);
            if (student != null) { 
                return student.Student.person.Firstname;
            }
            else
            {
                return "";
            }

        }

        public void set(
            
            int CopyID = -1,
            int StudentID = -1,
            DateTime? BorrowDate = null,
            DateTime? ReturnDate = null
            
        )
        {
            if (CopyID != -1) Borrow.Copy.ID = CopyID;
            if (StudentID != -1) Borrow.Student.ID = StudentID;
            if (BorrowDate != null) Borrow.BorrowDate = BorrowDate.Value;
            if (ReturnDate != null) Borrow.ReturnDate = ReturnDate.Value;
        }

        public enum enBorrow { eID, eCopyID, eStudentID, eBorrowDate, eReturnDate}
        public object get(
            enBorrow borrow
            )
        {
            switch (borrow)
            {
                case enBorrow.eID: return Borrow.ID;
                case enBorrow.eCopyID: return Borrow.Copy.ID;
                case enBorrow.eStudentID: return Borrow.Student.ID;
                case enBorrow.eBorrowDate: return Borrow.BorrowDate.Date;
                case enBorrow.eReturnDate: return Borrow.ReturnDate.Date;
                default: return null;
            }
        }
        public string getBookname()
        {
            clsCopys copy = clsCopys.Find(ID: Borrow.Copy.ID);
            if (copy != null)
            {
                return clsBooks.Find(ID: copy.Copy.Book.ID).Book.Title;
            }
            else
            {
                return "";
            }
        }
        public string getStudantname()
        {
            clsStudents student = clsStudents.Find(ID: Borrow.Student.ID);
            if (student != null)
            {
                return student.Student.person.Firstname;
            }
            else
            {
                return "";
            }
        }
        private bool _AddNewBorrow()
        {
            this.Borrow.ID = clsBorrowsDataAccess.AddBorrow(this.Borrow);

            return (this.Borrow.ID != -1);
        }
        private bool _UpdateBorrow()
        {
            return clsBorrowsDataAccess.UpdateBorrow(this.Borrow);
        }
        public bool Save()
        {

            if (_Mode == enMode.AddNew)
            {
                if (_AddNewBorrow())
                {
                    clsLogsDataAccess.AddBorrowLog(
                        "Borrowed a Book", this.Borrow.ID, this.Borrow.Student.ID, this.Borrow.Copy.ID
                    );
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
                if (_UpdateBorrow())
                {
                    clsLogsDataAccess.AddBorrowLog(
                        "Borrows Updated Successfully. ", this.Borrow.ID, this.Borrow.Student.ID, this.Borrow.Copy.ID
                    );
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
