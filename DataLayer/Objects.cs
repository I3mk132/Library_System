using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsPerson
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string IDnumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string ImagePath { get; set; }

        public clsPerson()
        {
            ID = -1;
            Firstname = "";
            Lastname = "";
            Email = "";
            Password = "";
            Username = "";
            Phone = "";
            Gender = "";
            Nationality = "";
            IDnumber = "";
            DateOfBirth = new DateTime().Date;
            ImagePath = "";
        }
    }
    public class clsEmployee
    {
        public int ID { get; set; }
        public clsPerson person { get; set; }
        public double Salary { get; set; }
        public clsRoles Role { get; set; }
        public clsDepartment Department { get; set; }
        public clsShifts Shift { get; set; }
        public string EmployeeCardNumber { get; set; }
        public int Permissions { get; set; }
        public int ManagersID { get; set; }

        public clsEmployee()
        {
            ID = -1;
            person = new clsPerson();
            Salary = -1;
            Role = new clsRoles();
            Department = new clsDepartment();
            Shift = new clsShifts();
            EmployeeCardNumber = "";
            Permissions = -1;
            ManagersID = -1;
        }

    }
    public class clsStudent
    {
        public int ID { get; set; }
        public clsPerson person { get; set; }
        public clsStatus Status { get; set; }
        public string StudentCardNumber { get; set; }
        public clsDepartment Department { get; set; }
        public int CurrentSeat { get; set; }

        public clsStudent()
        {
            ID = -1;
            person = new clsPerson();
            Status = new clsStatus();
            StudentCardNumber = "";
            Department = new clsDepartment();
            CurrentSeat = -1;
        }
    }
    public class clsBorrow
    {
        public int ID { get; set; }
        public clsStudent Student { get; set; }
        public clsCopyInfo Copy{ get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime BorrowDate{ get; set; }

        public clsBorrow()
        {
            ID = -1;
            Student = new clsStudent();
            Copy = new clsCopyInfo();
            ReturnDate = new DateTime().Date;
            BorrowDate = new DateTime().Date;
        }
    }
    public class clsRoles
    {
        public int ID { get; set; }
        public string Role { get; set; }

        public clsRoles()
        {
            ID = -1;
            Role = "";
        }
    }
    public class clsShifts
    {
        public int ID { get; set; }
        public TimeSpan ShiftFrom { get; set; }
        public TimeSpan ShiftTo { get; set; }

        public clsShifts()
        {
            ID = -1;
            ShiftFrom = new TimeSpan();
            ShiftTo = new TimeSpan();
        }
    }
    public class clsStatus
    {
        public int ID { get; set; }
        public string Status { get; set; }

        public clsStatus()
        {
            ID = -1; ;
            Status = "";
        }
    }
    public class clsDepartment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public TimeSpan OpenHoursFrom { get; set; }
        public TimeSpan OpenHoursTo { get; set; }
        public int OpenDays { get; set; }
        public int MinimumAge { get; set; }
        public int SeatCount { get; set; }

        public clsDepartment()
        {
            ID = -1;
            Name = "";
            ImagePath = "";
            Description = "";
            Location = "";
            OpenHoursFrom = new TimeSpan();
            OpenHoursTo = new TimeSpan();
            OpenDays = -1;
            MinimumAge = -1;
            SeatCount = -1;
        }
    }
    public class clsCopyInfo
    {
        public int ID { get; set; }
        public clsBookInfo Book { get; set; }
        public string BookStatus { get; set; }
        public clsDepartment Department { get; set; }

        public clsCopyInfo()
        {
            ID = -1;
            Book = new clsBookInfo();
            BookStatus = "";
            Department = new clsDepartment();
        }
    }
    public class clsBookInfo
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Genre { get; set; }
        public string Details { get; set; }
        public string ImagePath { get; set; }

        public clsBookInfo()
        {
            ID = -1;
            Title = "";
            Author = "";
            ISBN = "";
            PublicationDate = new DateTime().Date;
            Genre = "";
            Details = "";
            ImagePath = "";
        }
    }
    public class clsTask
    {
        public int ID { get; set; }
        public clsEmployee Employee { get; set; }
        public string Task { get; set; }
        public DateTime FinishDate { get; set; }

        public clsTask()
        {
            ID = -1;
            Employee = new clsEmployee();
            Task = "";
            FinishDate = new DateTime().Date;

        }

    }
}
