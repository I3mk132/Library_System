using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataLayer;
using System.Security.Cryptography;
using System.Security.Policy;

namespace BussinesLayer
{
    public class clsEmployees
    {
        public clsEmployee Employee { get; set; }
        private enum enMode { AddNew, Update }
        private enMode _Mode;

        public clsEmployees()
        {
            Employee = new clsEmployee();
            _Mode = enMode.AddNew;
        }
        public clsEmployees(

            string Firstname, string Lastname,
            string Email, string Username, string Phone,
            string Gender, string Nationality, string IDnumber,
            DateTime DateOfBirth, string ImagePath,
            double Salary, int RoleID, int DepartmentID,
            int ShiftID, string EmployeeCardNumber,
            int ManagersID, int Permissions, string Password

            )
        {
            Employee = new clsEmployee();
            Employee.person.Firstname = Firstname;
            Employee.person.Lastname = Lastname;
            Employee.person.Email = Email;
            Employee.person.Username = Username;
            Employee.person.Phone = Phone;
            Employee.person.Gender = Gender;
            Employee.person.Nationality = Nationality;
            Employee.person.IDnumber = IDnumber;
            Employee.person.DateOfBirth = DateOfBirth;
            Employee.person.ImagePath = ImagePath;
            Employee.Salary = Salary;
            Employee.Role.ID = RoleID;
            Employee.Department.ID = DepartmentID;
            Employee.Shift.ID = ShiftID;
            Employee.EmployeeCardNumber = EmployeeCardNumber;
            Employee.ManagersID = ManagersID;
            Employee.Permissions = Permissions;
            Employee.person.Password = Password;
            _Mode = enMode.AddNew;
        }
        private clsEmployees(clsEmployee employee)
        {
            Employee = employee;
            _Mode = enMode.Update;
            
        }



        public static DataTable GetAllEmployees()
        {
            return clsEmployeesDataAccess.GetAllEmployees();
        }
        public static clsEmployees Find (
            int ID = -1, string Firstname = "", string Lastname = "",
            string Email = "", string Username = "", string Phone = "",
            string Gender = "", string Nationality = "", string IDnumber = "",
            double Salary = -1, int RoleID = -1, int DepartmentID = -1,
            int ShiftID = -1, string EmployeeCardNumber = "",
            int ManagersID = -1, int Permissions = -1
        )
        {
            clsEmployee employee = new clsEmployee();
            employee.ID = ID;
            employee.person.Firstname = Firstname;
            employee.person.Lastname = Lastname;
            employee.person.Email = Email;
            employee.person.Username = Username;
            employee.person.Phone = Phone;
            employee.person.Gender = Gender;
            employee.person.Nationality = Nationality;
            employee.person.IDnumber = IDnumber;
            employee.Salary = Salary;
            employee.Role.ID = RoleID;
            employee.Department.ID = DepartmentID;
            employee.Shift.ID = ShiftID;
            employee.EmployeeCardNumber = EmployeeCardNumber;
            employee.ManagersID = ManagersID;
            employee.Permissions = Permissions;


            if (clsEmployeesDataAccess.GetEmployee(ref employee))
            {
                return new clsEmployees(employee);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetEmployeesWitih(
            int ID = -1, string Firstname = "", string Lastname = "",
            string Email = "", string Username = "", string Phone = "",
            string Gender = "", string Nationality = "", string IDnumber = "",
            double Salary = -1, int RoleID = -1, int DepartmentID = -1,
            int ShiftID = -1, string EmployeeCardNumber = "",
            int ManagersID = -1, int Permissions = -1
        )
        {
            clsEmployee employee = new clsEmployee();
            employee.ID = ID;
            employee.person.Firstname = Firstname;
            employee.person.Lastname = Lastname;
            employee.person.Email = Email;
            employee.person.Username = Username;
            employee.person.Phone = Phone;
            employee.person.Gender = Gender;
            employee.person.Nationality = Nationality;
            employee.person.IDnumber = IDnumber;
            employee.Salary = Salary;
            employee.Role.ID = RoleID;
            employee.Department.ID = DepartmentID;
            employee.Shift.ID = ShiftID;
            employee.EmployeeCardNumber = EmployeeCardNumber;
            employee.ManagersID = ManagersID;
            employee.Permissions = Permissions;

            return clsEmployeesDataAccess.GetEmployees( employee );
        }
        public static bool isEmployeeExists(int ID)
        {
            return clsEmployeesDataAccess.isEmployeeExists(ID);
        }
        public static bool DeleteEmployee(int ID)
        {
            return (clsEmployeesDataAccess.DeleteEmployee(ID));
        }
        public static DataTable GetAllEmployeesAllData()
        {
            return clsEmployeesDataAccess.GetAllEmployeesAllData();
        }
        public static DataTable GetAllEmployeesInShift()
        {
            return clsEmployeesDataAccess.GetAllEmployeesInShift();
        }

        public static string GetEmployeeFullName(int ID)
        {

            clsEmployee Data = Find(ID:ID).Employee;
            return Data.person.Firstname + " " + Data.person.Lastname;
            
        }
        public static clsEmployees GetEmployeeManagerData(int ID)
        {
            return Find(Find(ID).Employee.ManagersID);
        }
        public static (TimeSpan From, TimeSpan To) GetShiftByID(int ID)
        {
            return clsEmployeesDataAccess.GetShiftByShiftID(ID);
        }
        public static int GetShiftIDByShift((TimeSpan From,TimeSpan To) Shift)
        {
            return clsEmployeesDataAccess.GetShiftIDByShift(Shift);
        }
        public static string GetRoleByRoleID(int ID)
        {
            return clsEmployeesDataAccess.GetRoleByRoleID(ID);
        }
        public static int GetRoleIDByRole(string Role)
        {
            return clsEmployeesDataAccess.GetRoleIDByRole(Role);
        }

        public static bool CheckPassword(clsEmployees employee, string Password)
        {
            return (clsSecurity.VerifyPassword(Password, employee.Employee.person.Password));
            
        }

        public void setEmployee(

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

            if (Firstname != "") Employee.person.Firstname = Firstname;
            if (Lastname != "") Employee.person.Lastname = Lastname;
            if (Email != "") Employee.person.Email = Email;
            if (Password != "") Employee.person.Password = Password;
            if (Username != "") Employee.person.Username = Username;
            if (Phone != "") Employee.person.Phone = Phone;
            if (Gender != "") Employee.person.Gender = Gender;
            if (Nationality != "") Employee.person.Nationality = Nationality;
            if (IDnumber != "") Employee.person.IDnumber = IDnumber;
            if (DateOfBirth != null) Employee.person.DateOfBirth = DateOfBirth;
            if (ImagePath != "") Employee.person.ImagePath = ImagePath;
            if (Salary != -1) Employee.Salary = Salary;
            if (RoleID != -1) Employee.Role.ID = RoleID;
            if (DepartmentID != -1) Employee.Department.ID = DepartmentID;
            if (ShiftID != -1) Employee.Shift.ID = ShiftID;
            if (EmployeeCardNumber != "") Employee.EmployeeCardNumber = EmployeeCardNumber;
            if (ManagersID != -1) Employee.ManagersID = ManagersID;
            if (Permissions != -1) Employee.Permissions = Permissions;

        }
        public enum enEmployee
        {
            eID, eFirstname, eLastname,
            eEmail, ePassword, eUsername, 
            ePhone, eGender, eNationality,
            eIDnumber, eDateOfBirth, eImagePath,
            eSalary, eRoleID, eDepartmentID,
            eShiftID, eEmployeeCardNumber, eManagerID,
            ePermissions
        }
        public object get(enEmployee book)
        {
            switch (book)
            {
                case enEmployee.eID: return Employee.ID;
                case enEmployee.eFirstname: return Employee.person.Firstname;
                case enEmployee.eLastname: return Employee.person.Lastname;
                case enEmployee.eEmail: return Employee.person.Email;
                case enEmployee.ePassword: return Employee.person.Password;
                case enEmployee.eUsername: return Employee.person.Username;
                case enEmployee.ePhone: return Employee.person.Phone;
                case enEmployee.eGender: return Employee.person.Gender;
                case enEmployee.eNationality: return Employee.person.Nationality;
                case enEmployee.eIDnumber: return Employee.person.IDnumber;
                case enEmployee.eDateOfBirth: return Employee.person.DateOfBirth;
                case enEmployee.eImagePath: return Employee.person.ImagePath;
                case enEmployee.eSalary: return Employee.Salary;
                case enEmployee.eRoleID: return Employee.Role.ID;
                case enEmployee.eDepartmentID: return Employee.Department.ID;
                case enEmployee.eShiftID: return Employee.Shift.ID;
                case enEmployee.eEmployeeCardNumber: return Employee.EmployeeCardNumber;
                case enEmployee.eManagerID: return Employee.ManagersID;
                case enEmployee.ePermissions: return Employee.Permissions;

                default: return null;
            }
        }


        private bool _AddNewEmployee()
        {
            this.Employee.ID = clsEmployeesDataAccess.AddEmployee(this.Employee);

            return (this.Employee.ID != -1);
        }
        private bool _UpdateEmployee()
        {
            return clsEmployeesDataAccess.UpdateEmployee(this.Employee);
        }
        public bool Save()
        {
            
            if (_Mode == enMode.AddNew)
            {
                if (_AddNewEmployee())
                {
                    clsLogsDataAccess.AddSignupLoginLog(
                        $"Email: {this.Employee.person.Email}, Username: {this.Employee.person.Username}",
                        this.Employee.ID, -1,
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
                if (_UpdateEmployee())
                {

                    clsLogsDataAccess.AddChangeLog("Info Changed Successfully", this.Employee.ID, -1);
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
