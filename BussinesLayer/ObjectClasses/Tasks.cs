using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinesLayer
{
    public class clsTasks
    {
        public clsTask Task { get; set; }
        private enum enMode { AddNew, Update }
        private enMode _Mode;

        public clsTasks()
        {
            Task = new clsTask();
            _Mode = enMode.AddNew;
        }
        private clsTasks(clsTask task)
        {
            Task = task;
            _Mode = enMode.Update;

        }
        

        public static DataTable GetAllTasks()
        {
            return clsTasksDataAccess.GetAllTasks();
        }
        public static clsTasks Find(
            int ID = -1, int EmployeeID = -1, string Task = ""
        )
        {
            clsTask task = new clsTask();
            task.ID = ID;
            task.Employee.ID = EmployeeID;
            task.Task = Task;

            if (clsTasksDataAccess.GetTask(ref task))
            {
                return new clsTasks(task);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetTasksWith(
            int ID = -1, int EmployeeID = -1, string Task = ""
        )
        {
            clsTask task = new clsTask();
            task.ID = ID;
            task.Employee.ID = EmployeeID;
            task.Task = Task;

            return clsTasksDataAccess.GetTasks(task);
        }
        public static DataTable GetTasksSimpledWith(
            int ID = -1, int EmployeeID = -1, string Task = ""
        )
        {
            clsTask task = new clsTask();
            task.ID = ID;
            task.Employee.ID = EmployeeID;
            task.Task = Task;

            return clsTasksDataAccess.GetTasksSimpled(task);
        }
        public static DataTable GetUsersNearTasks(int EmployeeID, int Days)
        {
            return clsTasksDataAccess.GetEmployeesNeerTasks(EmployeeID, Days);
        }
        public static bool isTaskExists(int ID)
        {
            return clsTasksDataAccess.isTaskExists(ID);
        }
        public static bool DeleteTask(int ID)
        {
            return (clsTasksDataAccess.DeleteTask(ID));
        }

        public void set(
                int ID = -1,
                int EmployeeID = -1,
                string Task = "",
                DateTime? FinishDate = null
            )
        {
            if (ID != -1) this.Task.ID = ID;
            if (EmployeeID != -1) this.Task.Employee.ID = EmployeeID;
            if (Task != "") this.Task.Task = "";
            if (FinishDate != null) this.Task.FinishDate = FinishDate.Value;
        }


        private bool _AddNewTask()
        {
            this.Task.ID = clsTasksDataAccess.AddTask(this.Task);

            return (this.Task.ID != -1);
        }
        private bool _UpdateTask()
        {
            return clsTasksDataAccess.UpdateTask(this.Task);
        }
        public bool Save()
        {

            if (_Mode == enMode.AddNew)
            {
                if (_AddNewTask())
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
                if (_UpdateTask())
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
