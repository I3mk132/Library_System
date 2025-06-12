using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Validators
{
    public class clsEmployeeValidator:clsValidations
    {
        public static bool AddFirstname(string Firstname)
        {
            return clsValidations.ValidateTextLength(Firstname, 1, 50);
        }
        public static bool AddLastname(string Lastname)
        {
            return clsValidations.ValidateTextLength(Lastname, 1, 50);
        }

        public static bool EnterEmail(string Email)
        {
            string regax = @"^(?!\.)(""[^""\r\\]*(\\.[^""\r\\]*)*""|[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*)@(?:(?!-)[a-zA-Z0-9-]{1,63}(?<!-)\.)+[a-zA-Z]{2,63}$";
            if (!clsValidations.ValidateText(Email, regax))
                return false;
            if (!clsValidations.ValidateTextLength(Email, 1, 255))
                return false;
            return true;
        }
        public static bool AddUsername(string Username)
        {

            if (!clsValidations.ValidateTextLength(Username, 1, 50))
                return false;   
            return true;
        }
        public static bool AddPhone(string Phone)
        {
            if (!clsValidations.ValidateTextLength(Phone, 1, 20))
                return false;
            return true;
        }
        public static bool AddNationality(string Nationality)
        {
            if (!clsValidations.ValidateTextLength(Nationality, 1, 50))
                return false;
            if (clsValidations.ValidateText(Nationality, @"^\+(\d{1,3})[\s\-]?(\d{1,4})[\s\-]?(\d{2,4})[\s\-]?(\d{2,4})[\s\-]?(\d{0,4})$"))
                return false;

            return true;
        }
        public static bool AddIDnumber(string IDnumber)
        {
            if (!clsValidations.ValidateTextLength(IDnumber, 1, 15))
                return false;

            return true;
        }
        public static bool AddImagePath(string ImagePath)
        {
            if (!clsValidations.ValidateText(ImagePath, @"^[a-zA-Z]:\\(?:[^\\/:*?""<>|\r\n]+\\)*[^\\/:*?""<>|\r\n]*$"))
                return false;
            if (!clsValidations.ValidateTextLength(ImagePath, 1, 255))
                return false;

            return true;
        }
        public static bool AddDateOfBirth(DateTime date)
        {
            if (date.Year > DateTime.Now.Year - 7)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool isPasswordMatch(string Password1, string Passwrod2)
        {
            return Password1 == Passwrod2;
        }
    }
}
