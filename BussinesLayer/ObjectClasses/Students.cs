using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinesLayer
{
    public class clsStudents
    {
        public clsStudent Student { get; set; }
        private enum enMode { AddNew, Update }
        private enMode _Mode;

        public clsStudents()
        {
            Student = new clsStudent();
            _Mode = enMode.AddNew;
        }
        public clsStudents(

            string Firstname, string Lastname,
            string Email, string Username, string Phone,
            string Gender, string Nationality, string IDnumber,
            DateTime DateOfBirth, string ImagePath,
            int StatusID, string StudentCardNumber,
            string Password

            )
        {
            Student = new clsStudent();
            Student.person.Firstname = Firstname;
            Student.person.Lastname = Lastname;
            Student.person.Email = Email;
            Student.person.Username = Username;
            Student.person.Phone = Phone;
            Student.person.Gender = Gender;
            Student.person.Nationality = Nationality;
            Student.person.IDnumber = IDnumber;
            Student.person.DateOfBirth = DateOfBirth;
            Student.person.ImagePath = ImagePath;
            Student.Status.ID = StatusID;
            Student.StudentCardNumber = StudentCardNumber;
            Student.person.Password =   Password;

            _Mode = enMode.AddNew;
        }
        private clsStudents(clsStudent student)
        {
            Student = student;
            _Mode = enMode.Update;

        }



        public static DataTable GetAllStudents()
        {
            return clsStudentsDataAccess.GetAllStudents();
        }
        public static clsStudents Find(
            int ID = -1, string Firstname = "", string Lastname = "",
            string Email = "", string Username = "", string Phone = "",
            string Gender = "", string Nationality = "", string IDnumber = "",
            int StatusID = -1, string StudentCardNumber = ""
        )
        {
            clsStudent Student = new clsStudent();
            Student.ID = ID;
            Student.person.Firstname = Firstname;
            Student.person.Lastname = Lastname;
            Student.person.Email = Email;
            Student.person.Username = Username;
            Student.person.Phone = Phone;
            Student.person.Gender = Gender;
            Student.person.Nationality = Nationality;
            Student.person.IDnumber = IDnumber;
            Student.Status.ID = StatusID;
            Student.StudentCardNumber = StudentCardNumber;
            


            if (clsStudentsDataAccess.GetStudent(ref Student))
            {
                return new clsStudents(Student);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetStudentsWitih(
            int ID = -1, string Firstname = "", string Lastname = "",
            string Email = "", string Username = "", string Phone = "",
            string Gender = "", string Nationality = "", string IDnumber = "",
            int StatusID = -1, string StudentCardNumber = ""

        )
        {
            clsStudent student = new clsStudent();
            student.ID = ID;
            student.person.Firstname = Firstname;
            student.person.Lastname = Lastname;
            student.person.Email = Email;
            student.person.Username = Username;
            student.person.Phone = Phone;
            student.person.Gender = Gender;
            student.person.Nationality = Nationality;
            student.person.IDnumber = IDnumber;
            student.Status.ID = StatusID;
            student.StudentCardNumber = StudentCardNumber;

            return clsStudentsDataAccess.GetStudents(student);
        }
        public static DataTable GetStudentsWitihSimple(
            int ID = -1, string Firstname = "", string Lastname = "",
            string Email = "", string Username = "", string Phone = "",
            string Gender = "", string Nationality = "", string IDnumber = "",
            int StatusID = -1, string StudentCardNumber = ""

        )
        {
            clsStudent student = new clsStudent();
            student.ID = ID;
            student.person.Firstname = Firstname;
            student.person.Lastname = Lastname;
            student.person.Email = Email;
            student.person.Username = Username;
            student.person.Phone = Phone;
            student.person.Gender = Gender;
            student.person.Nationality = Nationality;
            student.person.IDnumber = IDnumber;
            student.Status.ID = StatusID;
            student.StudentCardNumber = StudentCardNumber;

            return clsStudentsDataAccess.GetStudentsSimple(student);
        }
        public static DataTable GetStudentsInDepartment(int DepartmentID )
        {
            clsStudent st = new clsStudent();

            st.Department.ID = DepartmentID;
            
            return clsStudentsDataAccess.GetStudents(st); 
        }
        public static DataTable GetStudentsInDepartment(string DepartmentName)
        {
            clsStudent st = new clsStudent();

            st.Department.Name = DepartmentName;

            return clsStudentsDataAccess.GetStudents(st);
        }
        public static bool isStudentExists(int ID)
        {
            return clsStudentsDataAccess.isStudentExists(ID);
        }
        public static bool DeleteStudent(int ID)
        {
            return (clsStudentsDataAccess.DeleteStudent(ID));
        }
        public static DataTable GetAllStudentsAllData()
        {
            return clsStudentsDataAccess.GetAllStudentsAllData();
        }
        public static DataTable GetAllStudentsAllDataFilterd(
            int ID = -1, string Firstname = "", string Lastname = "",
            string Email = "", string Username = "", string Phone = "",
            string Gender = "", string Nationality = "", string IDnumber = "",
            int StatusID = -1, string StudentCardNumber = ""
            )
        {
            clsStudent student = new clsStudent();
            student.ID = ID;
            student.person.Firstname = Firstname;
            student.person.Lastname = Lastname;
            student.person.Email = Email;
            student.person.Username = Username;
            student.person.Phone = Phone;
            student.person.Gender = Gender;
            student.person.Nationality = Nationality;
            student.person.IDnumber = IDnumber;
            student.Status.ID = StatusID;
            student.StudentCardNumber = StudentCardNumber;

            return clsStudentsDataAccess.GetAllStudentsAllDataFilterd(student);
        }

        public static string GetStudentFullName(int ID)
        {

            clsStudent Data = Find(ID: ID).Student;
            return Data.person.Firstname + " " + Data.person.Lastname;

        }
        public static string GetEmail(int ID)
        {
            clsStudent data = Find(ID: ID).Student;
            return data.person.Email;
        }
        public static string GetUsername(int ID)
        {
            clsStudent data = Find(ID: ID).Student;
            return data.person.Username;
        }
        public static string GetIDnumber(int ID)
        {
            clsStudent data = Find(ID: ID).Student;
            return data.person.IDnumber;
        }
        public static DataTable GetBlockedStudents()
        {
            return clsStudentsDataAccess.GetBlockedStudents();
        }
        public static int GetStudentCount()
        {
            return clsStudentsDataAccess.GetAllStudents().Rows.Count;
        }
        public static int GetStudentWithBorrowsCount()
        {
            return clsStudentsDataAccess.GetStudentsWithBorrowsCount();
        }
        public static int GetUnblockedStudentCount()
        {
            return clsStudentsDataAccess.GetUnblockedStudentCount();
        }
        public static string GetStudentImagePath(int ID)
        {
            clsStudents st = Find(ID: ID);
            if (st != null)
                return st.Student.person.ImagePath;
            else
                return "";
        }
        public static Image GetStudenttImage(int ID)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string ImagePath = GetStudentImagePath(ID);
            if (ImagePath == "")
                return null;

            string FullPath = Path.Combine(basePath, $@"..\..\..{ImagePath}");
            if (FullPath != null)
                return Image.FromFile(FullPath);
            else
                return null;
        }
        public static int GetStatusIDByStatus(string Status)
        {
            return clsStudentsDataAccess.GetStatusIDByStatus(Status);
        }
        public static string GetStatusByStatusID(int ID)
        {
            return clsStudentsDataAccess.GetStatusByStatusID(ID);
        }

        public void setStudent(

           string Firstname = "",
           string Lastname = "",
           string Email = "",
           string Password = "",
           string Username = "",
           string Phone = "",
           string Gender = "",
           string Nationality = "",
           string IDnumber = "",
           DateTime? DateOfBirth = null,
           string ImagePath = "",
           int StatusID = -1,
           string StudentCardNumber = "",
           int DepartmentID = -1,
           int CurrentSeat = -1

           )
        {

            if (Firstname != "") Student.person.Firstname = Firstname;
            if (Lastname != "") Student.person.Lastname = Lastname;
            if (Email != "") Student.person.Email = Email;
            if (Password != "") Student.person.Password = Password;
            if (Username != "") Student.person.Username = Username;
            if (Phone != "") Student.person.Phone = Phone;
            if (Gender != "") Student.person.Gender = Gender;
            if (Nationality != "") Student.person.Nationality = Nationality;
            if (IDnumber != "") Student.person.IDnumber = IDnumber;
            if (DateOfBirth != null) Student.person.DateOfBirth = DateOfBirth;
            if (ImagePath != "") Student.person.ImagePath = ImagePath;
            if (StatusID != -1) Student.Status.ID = StatusID;
            if (StatusID != 1)
            {
                Student.Department.ID = -1;
                Student.CurrentSeat = -1;
            }
            if (StudentCardNumber != "") Student.StudentCardNumber = StudentCardNumber;
            if (DepartmentID != -1) Student.Department.ID = DepartmentID;
            if (CurrentSeat != -1) Student.CurrentSeat = CurrentSeat;

        }
        public enum enStudent
        {
            eID, eFirstname, eLastname,
            eEmail, ePassword, eUsername,
            ePhone, eGender, eNationality,
            eIDnumber, eDateOfBirth, eImagePath,
            eStatus, eDepartmentID,
            eStudentCardNumber, eCurrentSeat
        }
        public object get(enStudent book)
        {
            switch (book)
            {
                case enStudent.eID: return Student.ID;
                case enStudent.eFirstname: return Student.person.Firstname;
                case enStudent.eLastname: return Student.person.Lastname;
                case enStudent.eEmail: return Student.person.Email;
                case enStudent.ePassword: return Student.person.Password;
                case enStudent.eUsername: return Student.person.Username;
                case enStudent.ePhone: return Student.person.Phone;
                case enStudent.eGender: return Student.person.Gender;
                case enStudent.eNationality: return Student.person.Nationality;
                case enStudent.eIDnumber: return Student.person.IDnumber;
                case enStudent.eDateOfBirth: return Student.person.DateOfBirth;
                case enStudent.eImagePath: return Student.person.ImagePath;
                case enStudent.eStatus: return Student.Status.ID;
                case enStudent.eDepartmentID: return Student.Department.ID;
                case enStudent.eStudentCardNumber: return Student.StudentCardNumber;
                case enStudent.eCurrentSeat: return Student.CurrentSeat;
                default: return null;
            }
        }

        private bool _AddNewStudent()
        {
            this.Student.ID = clsStudentsDataAccess.AddStudent(this.Student);

            return (this.Student.ID != -1);
        }
        private bool _UpdateStudent()
        {
            return clsStudentsDataAccess.UpdateStudent(this.Student);
        }
        public bool Save()
        {

            if (_Mode == enMode.AddNew)
            {
                if (_AddNewStudent())
                {
                    clsLogsDataAccess.AddSignupLoginLog(
                        $"Email: {this.Student.person.Email}, Username: {this.Student.person.Username}",
                        -1, this.Student.ID,
                        "Signup");
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
                if (_UpdateStudent())
                {

                    clsLogsDataAccess.AddChangeLog("Info Changed Successfully", -1, this.Student.ID);
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
