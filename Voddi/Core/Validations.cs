using DBHandler;
using System;
using System.Text.RegularExpressions;
using System.Diagnostics.Contracts;

namespace Core
{
    public static class Validations
    {
        public static String CheckRegistrationValidation(String vorname, String nachname, String email, String user, String passwordOne, String passwordTwo)
        {
            Contract.Ensures(Contract.Result<string>() != null);
            if (vorname.Length == 0)
                return "Vorname";
            else if (nachname.Length == 0)
                return "Nachname";
            else if (email.Length == 0)
                return "E-Mail Adresse";
            else if (user.Length == 0)
                return "Username";
            else if (passwordOne.Length == 0 || passwordTwo.Length == 0)
                return "Passwort";
            else
                return "OK";
        }

        public static bool CorrectEmailFormat(String email)
        {
            Contract.Requires(!String.IsNullOrEmpty(email));
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("message", nameof(email));
            }

            return new Regex("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$").Match(email).Success;
        }

        public static bool UserNotExists(String username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("message", nameof(username));
            }

            return Handler.ExistsUser(username);
        }
    }
}
