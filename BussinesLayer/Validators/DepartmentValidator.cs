using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinesLayer.Validators
{
    public class clsDepartmentValidator : clsValidations
    {
        public static bool AddName(string Name)
        {
            if (!clsValidations.ValidateTextLength(Name, 1, 150))
                return false;

            return true;
        }
        public static bool AddDescription(string Description)
        {
            return clsValidations.ValidateTextLength(Description, 1, 100);
        }
        public static bool AddLocation(string Location)
        {
            return clsValidations.ValidateTextLength(Location, 1, 100);
        }
        public static bool AddOpenDays(int Num)
        {
            return Num != 0;
        }
    }
}
