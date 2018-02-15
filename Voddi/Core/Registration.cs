using System;
using DBHandler;


namespace Core
{
    class Registration
    {
        public static bool CreateNewUser(String vorname, String nachname, String email, String username, String passwordOne) => DBHandler.DBHandler.CreateUser(vorname, nachname, email, username, passwordOne);
    }
}
