using System;
using DBHandler;
namespace Core
{
    public static class Registration
    {
        /// <summary>
        /// Erstellt ein neuen User in der DB
        /// </summary>
        /// <param name="vorname"></param>
        /// <param name="nachname"></param>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="passwordOne"></param>
        /// <returns></returns>
        public static bool CreateNewUser(String vorname, String nachname, String email, String username, String passwordOne) => Handler.CreateUser(vorname, nachname, email, username, passwordOne);
    }
}
