using System.Web.Helpers;

namespace BloodBankProject.Core.Utils
{
    public class Helpers
    {
        public static string ConnectionString
        {
            get
            {
                return @"Server=.\SqlExpress;Database=BloodBankDb;User Id=dbusername;Password=dbpass;";
            }
        }

        public static string HashPassword(string password)
        {
            return Crypto.HashPassword(password);
        }

        public static bool VerifyPassword(string hashedPassword, string cleanPassword)
        {
            return Crypto.VerifyHashedPassword(hashedPassword, cleanPassword);
        }
    }
}
