using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BussinesLayer
{
    public class clsValidations
    {
        protected static bool ValidateText(string Text, string regax)
        {
            return Regex.IsMatch(Text, regax);
        }
        protected static bool ValidateNumberBetween(int Num, int From, int To)
        {
            return Num >= From && Num <= To;
        }
        protected static bool ValidateTextLength(string Text, int From, int To)
        {
            return Text.Length >= From && Text.Length <= To;
        }

    }
}
