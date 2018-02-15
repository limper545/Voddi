using Bab_1.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class Registration
    {
        public static bool CreateNewUser(String vorname, String nachname, String email, String username, String passwordOne)
        {
            return DBHandler.CreateUser(vorname, nachname, email, username, passwordOne);
        }
    }
}
