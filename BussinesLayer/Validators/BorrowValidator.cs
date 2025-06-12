using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinesLayer.Validators
{
    public class clsBorrowValidator : clsValidations
    {
        public static bool AddBook(string Book)
        {
            return (!clsBooksDataAccess.isBookExists(Book));
        }
    }
}
