using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinesLayer.Validators
{
    public class clsBookValidator : clsValidations
    {
        public static bool AddTitle(string Title)
        {
            if (!clsValidations.ValidateTextLength(Title, 1, 50))
                return false;

            return true;
        }
        public static bool AddAuthor(string Author)
        {
            return clsValidations.ValidateTextLength(Author, 1, 50);
        }
        public static bool AddISBN(string ISBN)
        {
            if (ISBN.Length != 13)
                return false;
            if (ISBN.Length > 3)
                if (ISBN.Substring(0, 3) != "978" && ISBN.Substring(0, 3) != "979")
                    return false;

            return true;
        }
        public static bool AddGenre(string Genre)
        {
            return (clsValidations.ValidateTextLength(Genre, 1, 50));
        }
        public static bool AddDetails(string Details)
        {
            return (clsValidations.ValidateTextLength(Details, 1, 255));
        }
        public static bool AddImagePath(string ImagePath)
        {
            if (!clsValidations.ValidateText(ImagePath, @"^[a-zA-Z]:\\(?:[^\\/:*?""<>|\r\n]+\\)*[^\\/:*?""<>|\r\n]*$"))
                return false;
            if (!clsValidations.ValidateTextLength(ImagePath, 1, 255))
                return false;

            return true;
        }
    }
}
