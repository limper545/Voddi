using DBHandler;
using System;
using System.Text.RegularExpressions;
using System.Diagnostics.Contracts;

namespace Core
{
    public static class Validations
    {
        /// <summary>
        /// Validiert die Eingaben des Users in der Registrierung, ob die Daten eingetragen worden sind
        /// </summary>
        /// <param name="vorname"></param>
        /// <param name="nachname"></param>
        /// <param name="email"></param>
        /// <param name="user"></param>
        /// <param name="passwordOne"></param>
        /// <param name="passwordTwo"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Checkt, ob das Format der Email dem Standart entspricht
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool CorrectEmailFormat(String email)
        {
            Contract.Requires(!String.IsNullOrEmpty(email));
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("message", nameof(email));
            }

            return new Regex("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$").Match(email).Success;
        }

        /// <summary>
        /// Checkt ob der User schon in der DB existiert
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
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
