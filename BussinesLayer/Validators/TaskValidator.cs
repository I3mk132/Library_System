using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Validators
{
    public class clsTaskValidator : clsValidations
    {
        public static bool AddTask(string task)
        {
            return ValidateTextLength(task, 1, 50);
        }
    }
}
