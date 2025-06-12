using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class clsSecurity
    {

        public enum enPermissions { MainMenu = 1, Students = 2, Books = 4, Statics = 8, Profile = 16}
        
        public static string HashPassword(string Password)
        {
            // Generate Salt
            byte[] salt = new byte[16];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(salt);

            // PBKDF2 hash with (sha1)
            var pdkdf2 = new Rfc2898DeriveBytes(Password, salt, 100_000);
            byte[] hash = pdkdf2.GetBytes(32);

            byte[] hashBytes = new byte[48];
            Buffer.BlockCopy(salt, 0, hashBytes, 0, 16);
            Buffer.BlockCopy(hash, 0, hashBytes, 16, 32);

            return Convert.ToBase64String(hashBytes);
        }

        public static bool VerifyPassword(string Password, string HashedPassword)
        {
            byte[] hashbytes = Convert.FromBase64String(HashedPassword);

            // Extract salt
            byte[] salt = new byte[16];
            Buffer.BlockCopy(hashbytes, 0, salt, 0, 16);

            // Hash Entered Password
            var pdkdf2 = new Rfc2898DeriveBytes(Password, salt, 100_000);
            byte[] hash = pdkdf2.GetBytes(32);

            // Compare two
            for (int i = 0; i < 32; i++)
            {
                if (hash[i] != hashbytes[i + 16])
                    return false;
            }
            return true;
        }


        private static readonly Random rnd = new Random();
        public static string RandomDigit()
        {
            return Convert.ToString(rnd.Next(0, 10));
        }
        public static string RandomCardNumber()
        {
            string number = "";
            for (int i = 0; i < 10; i++)
            {
                number += RandomDigit();
            }
            return number;
        }
    }
}
