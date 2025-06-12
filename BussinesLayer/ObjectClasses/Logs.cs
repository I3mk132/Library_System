using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinesLayer.ObjectClasses
{
    public class clsLogs
    {
        public static DataTable getAllErrorLogs()
        {
            return clsLogsDataAccess.GetAllErrorLogs();
        }
        public static DataTable getAllChangeLogs()
        {
            return clsLogsDataAccess.GetAllChangeLogs();
        }
        public static DataTable getAllBorrowLogs()
        {
            return clsLogsDataAccess.GetAllBorrowLogs();
        }
        public static DataTable getAllSignupLoginLogs()
        {
            return clsLogsDataAccess.GetAllSignupLoginLogs();
        }
        public static DataTable getAllSignupLogs()
        {
            return clsLogsDataAccess.GetAllSignupLogs();
        }
        public static DataTable GetAllLoginLogs()
        {
            return clsLogsDataAccess.GetAllLoginLogs();
        }
    }
}
