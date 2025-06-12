using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinesLayer
{
    public class clsDepartments
    {
        public clsDepartment Department { get; set; }
        private enum enMode { AddNew, Update }
        private enMode _Mode;

        public clsDepartments()
        {
            Department = new clsDepartment();
            _Mode = enMode.AddNew;
        }
        private clsDepartments(clsDepartment department)
        {
            Department = department;
            _Mode = enMode.Update;

        }



        public static DataTable GetAllDepartments()
        {
            return clsDepartmentsDataAccess.GetAllDepartments();
        }
        public static clsDepartments Find(
            int ID = -1, string Name = "", string ImagePath = "",
            string Description = "", string Location = "",
            int OpenDays = -1, int MinimumAge = -1
        )
        {
            clsDepartment department = new clsDepartment();
            
            department.ID = ID;
            department.Name = Name;
            department.ImagePath = ImagePath;
            department.Description = Description;
            department.Location = Location;
            department.MinimumAge = MinimumAge;

            if (clsDepartmentsDataAccess.GetDepartment(ref department))
            {
                return new clsDepartments(department);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetDepartmentsWith(
            int ID = -1, string Name = "", string ImagePath = "",
            string Description = "", string Location = "",
            int OpenDays = -1, int MinimumAge = -1
        )
        {
            clsDepartment department = new clsDepartment();
            department.ID = ID;
            department.Name = Name;
            department.ImagePath = ImagePath;
            department.Description = Description;
            department.Location = Location;
            department.MinimumAge = MinimumAge;

            return clsDepartmentsDataAccess.GetDepartments(department);
        }
        public static bool isDepartmentExists(int ID)
        {
            return clsDepartmentsDataAccess.isDepartmentExists(ID);
        }
        public static bool DeleteDepartment(int ID)
        {
            return (clsDepartmentsDataAccess.DeleteDepartment(ID));
        }
        public static int GetIDByName(string Name)
        {
            return Find(Name: Name).Department.ID;
        }
        public static string GetNameByID(int ID)
        {
            return Find(ID: ID).Department.Name;
        }
        public static int GetSeatCount(int ID)
        {
            return clsDepartmentsDataAccess.GetSeatCountInDep(ID);
        }

        public static string GetDepartmentImagePath(int ID)
        {
            clsDepartments dt = Find(ID: ID);
            if (dt != null)
                return dt.Department.ImagePath;
            else
                return "";
        }
        public static Image GetDepartmentImage(int ID)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string ImagePath = GetDepartmentImagePath(ID);
            if (ImagePath == "")
                return null;
            
            string FullPath = Path.Combine(basePath, $@"..\..\..{ImagePath}");
            if (FullPath != null)
                return Image.FromFile(FullPath);
            else
                return null;
        }


        public enum enDepartment
        {
            eID,
            eName, eImagePath,
            eDescription, eLocation,
            eOpenHoursFrom, eOpenHoursTo,
            eOpenDays, eMinimumAge, eSeatCount
        }
        public object get(enDepartment dep)
        {
            switch (dep)
            {
                case enDepartment.eID: return Department.ID;
                case enDepartment.eName: return Department.Name;
                case enDepartment.eImagePath: return Department.ImagePath;
                case enDepartment.eDescription: return Department.Description;
                case enDepartment.eLocation: return Department.Location;
                case enDepartment.eOpenHoursFrom: return Department.OpenHoursFrom;
                case enDepartment.eOpenHoursTo: return Department.OpenHoursTo;
                case enDepartment.eOpenDays: return Department.OpenDays;
                case enDepartment.eMinimumAge: return Department.MinimumAge.ToString();
                case enDepartment.eSeatCount: return Department.SeatCount.ToString();

                default: return null;
            }
        }
        public void set(
            int ID = -1,
            string Name = "",
            string ImagePath = "",
            string Description = "",
            string Location = "",
            TimeSpan? OpenHoursFrom = null,
            TimeSpan? OpenHoursTo = null,
            int OpenDays = -1,
            int MinimumAge = -1,
            int SeatCount = -1
        )
        {
            if (ID != -1) Department.ID = ID;
            if (Name != "") Department.Name = Name;
            if (ImagePath != "") Department.ImagePath = ImagePath;
            if (Description != "") Department.Description = Description;
            if (Location != "") Department.Location = Location;
            if (OpenHoursFrom != null) Department.OpenHoursFrom = OpenHoursFrom.Value;
            if (OpenHoursTo != null) Department.OpenHoursTo = OpenHoursTo.Value;
            if (OpenDays != -1) Department.OpenDays = OpenDays;
            if (MinimumAge != -1) Department.MinimumAge = MinimumAge;
            if (SeatCount != 1) Department.SeatCount = SeatCount;
        }

        private bool _AddNewDepartment()
        {
            this.Department.ID = clsDepartmentsDataAccess.AddDepartment(this.Department);

            return (this.Department.ID != -1);
        }
        private bool _UpdateDepartment()
        {
            return clsDepartmentsDataAccess.UpdateDepartment(this.Department);
        }
        public bool Save()
        {

            if (_Mode == enMode.AddNew)
            {
                if (_AddNewDepartment())
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
                if (_UpdateDepartment())
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
