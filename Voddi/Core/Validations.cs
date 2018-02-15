using Bab_1.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core
{
    public class Validations
    {
        public static string CheckRegistrationValidation(String vorname, String nachname, String email, String user, String passwordOne, String passwordTwo)
        {
            if (vorname.Length == 0)
            {
                return "Vorname";
            }
            else if (nachname.Length == 0)
            {
                return "Nachname";
            }
            else if (email.Length == 0)
            {
                return "E-Mail Adresse";
            }
            else if (user.Length == 0)
            {
                return "Username";
            }
            else if (passwordOne.Length == 0 || passwordTwo.Length == 0)
            {
                return "Passwort";
            }
            else
            {
                return "OK";
            }
        }

        public static bool CorrectEmailFormat(String email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            return match.Success;
        }

        public static bool UserNotExists(String username)
        {
            return DBHandler.ExistsUser(username);
        }
    }
}
