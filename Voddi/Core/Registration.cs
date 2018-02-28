using System;
using DBHandler;
namespace Core
{
    public static class Registration
    {
        public static bool CreateNewUser(String vorname, String nachname, String email, String username, String passwordOne) => Handler.CreateUser(vorname, nachname, email, username, passwordOne);
    }
}
