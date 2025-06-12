using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DataLayer;
using System.Diagnostics.PerformanceData;

namespace BussinesLayer
{
    public static class clsGlobalVariables
    {
        private static clsEmployees _currentEmployee;

        public static clsEmployees CurrentEmployee
        {
            get => _currentEmployee;
            set
            {
                _currentEmployee = value;
                clsLogsDataAccess.AddSignupLoginLog(
                        $"Email: {value.Employee.person.Email}, Username: {value.Employee.person.Username}",
                        value.Employee.ID, -1,
                        "Login");
            }
        }
        private static clsStudents _currentStudent;
        public static clsStudents CurrentStudent 
        {
            get => _currentStudent;

            set
            {
                _currentStudent = value;
                clsLogsDataAccess.AddSignupLoginLog(
                        $"Email: {value.Student.person.Email}, Username: {value.Student.person.Username}",
                        -1, value.Student.ID,
                        "Login");
            }
        
        }

        public static int getID()
        {
            return CurrentEmployee.Employee.ID;
        }
        public static int getPermissions()
        {
            return CurrentEmployee.Employee.Permissions;
        }
        public static string getImagePath()
        {
            return CurrentEmployee.Employee.person.ImagePath;
        }
        public static string getFirstname()
        {
            return CurrentEmployee.Employee.person.Firstname;
        }
        public static string getLastname()
        {
            return CurrentEmployee.Employee.person.Lastname;
        }
        public static string getIDnumber()
        {
            return CurrentEmployee.Employee.person.IDnumber;
        }
        public static string getNationality()
        {
            return CurrentEmployee.Employee.person.Nationality;
        }
        public static DateTime? getDateOfBirth()
        {
            return CurrentEmployee.Employee.person.DateOfBirth;
        }
        public static string getGender()
        {
            return CurrentEmployee.Employee.person.Gender;
        }
        public static string getPhone()
        {
            return CurrentEmployee.Employee.person.Phone.Split(' ')[1];
        }
        public static string getCountryCode()
        {
            return CurrentEmployee.Employee.person.Phone.Split(' ')[0];
        }
        public static string getEmployeeCardNumber()
        {
            return CurrentEmployee.Employee.EmployeeCardNumber;
        }
        public static int getManagerID()
        {
            return CurrentEmployee.Employee.ManagersID;
        }
        public static string getManagerName()
        {
            return clsEmployees.Find(ID: CurrentEmployee.Employee.ManagersID).Employee.person.Firstname;
        }
        public static double getSalary()
        {
            return CurrentEmployee.Employee.Salary;
        }
        public static string getRole()
        {
            return clsEmployees.GetRoleByRoleID(CurrentEmployee.Employee.Role.ID);
        }
        public static Image getImage()
        {
        
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string ImagePath = CurrentEmployee.Employee.person.ImagePath;
            if (ImagePath == "")
                 return null;
         
            string FullPath = Path.Combine(basePath, $@"..\..\..{ImagePath}");
            if (FullPath != null)
                 return Image.FromFile(FullPath);
            else
                 return null;
                           
        }
        public static string getUsername()
        {
            return CurrentEmployee.Employee.person.Username;
        }
        public static string getEmail()
        {
            return CurrentEmployee.Employee.person.Email;
        }
        public static int getWorkingDays()
        {
            return CurrentEmployee.Employee.Department.OpenDays;
        }


        public static void setEmployee(

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
            double Salary = -1,
            int RoleID = -1,
            int DepartmentID = -1,
            int ShiftID = -1,
            string EmployeeCardNumber = "",
            int ManagersID = -1,
            int Permissions = -1
            )
        {
            
            if (Firstname != "") CurrentEmployee.Employee.person.Firstname = Firstname;
            if (Lastname != "") CurrentEmployee.Employee.person.Lastname = Lastname;
            if (Email != "") CurrentEmployee.Employee.person.Email = Email;
            if (Password != "") CurrentEmployee.Employee.person.Password = Password;
            if (Username != "") CurrentEmployee.Employee.person.Username = Username;
            if (Phone != "") CurrentEmployee.Employee.person.Phone = Phone;
            if (Gender != "") CurrentEmployee.Employee.person.Gender = Gender;
            if (Nationality != "") CurrentEmployee.Employee.person.Nationality = Nationality;
            if (IDnumber != "") CurrentEmployee.Employee.person.IDnumber = IDnumber;
            if (DateOfBirth != null) CurrentEmployee.Employee.person.DateOfBirth = DateOfBirth;
            if (ImagePath != "") CurrentEmployee.Employee.person.ImagePath = ImagePath;
            if (Salary != -1) CurrentEmployee.Employee.Salary = Salary;
            if (RoleID != -1) CurrentEmployee.Employee.Role.ID = RoleID;
            if (DepartmentID != -1) CurrentEmployee.Employee.Department.ID = DepartmentID;
            if (ShiftID != -1) CurrentEmployee.Employee.Shift.ID = ShiftID;
            if (EmployeeCardNumber != "") CurrentEmployee.Employee.EmployeeCardNumber = EmployeeCardNumber;
            if (ManagersID != -1) CurrentEmployee.Employee.ManagersID = ManagersID;
            if (Permissions != -1) CurrentEmployee.Employee.Permissions = Permissions;

        }

        public static void SetDepartment()
        {
            clsDepartments dep = clsDepartments.Find(CurrentEmployee.Employee.Department.ID);
            CurrentEmployee.Employee.Department = dep.Department;
        }
        public static void SetShift()
        {
            (TimeSpan From, TimeSpan To) Shift = clsEmployees.GetShiftByID(CurrentEmployee.Employee.Shift.ID);
            CurrentEmployee.Employee.Shift.ShiftFrom = Shift.From;
            CurrentEmployee.Employee.Shift.ShiftTo = Shift.To;
        }
        public static (TimeSpan From, TimeSpan To) GetShift()
        {
            return (CurrentEmployee.Employee.Shift.ShiftFrom, CurrentEmployee.Employee.Shift.ShiftTo);
        }

        public enum enOpenDays {
            eMon = 1, eTue = 2, eWed = 4,
            eThu = 8, eFri = 16, eSat = 32,
            eSun = 64
        }
        public enum enDepartment 
        {
            eID,
            eName, eImagePath,
            eDescription, eLocation,
            eOpenHoursFrom, eOpenHoursTo,
            eOpenDays, eMinimumAge
        }
        public static object getDepartment(enDepartment dep)
        {
            switch(dep)
            {
                case enDepartment.eID:
                     return CurrentEmployee.Employee.Department.ID;
                case enDepartment.eName:
                    return CurrentEmployee.Employee.Department.Name;
                case enDepartment.eImagePath:
                    return CurrentEmployee.Employee.Department.ImagePath;
                case enDepartment.eDescription:
                    return CurrentEmployee.Employee.Department.Description;
                case enDepartment.eLocation:
                    return CurrentEmployee.Employee.Department.Location;
                case enDepartment.eOpenHoursFrom:
                    return CurrentEmployee.Employee.Department.OpenHoursFrom;
                case enDepartment.eOpenHoursTo:
                    return CurrentEmployee.Employee.Department.OpenHoursTo;
                case enDepartment.eOpenDays:
                    return CurrentEmployee.Employee.Department.OpenDays;
                case enDepartment.eMinimumAge:
                    return CurrentEmployee.Employee.Department.MinimumAge.ToString();
                default:
                    return null;
            }
        }


    }
}
