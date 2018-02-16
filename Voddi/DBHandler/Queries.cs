using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHandler
{
    public class Queries
    {
        #region DB Abfragen

        public static string dbName = "SaschaDB.sqlite";
        public static String queryCreateCharacters = "CREATE TABLE IF NOT EXISTS classes (id INTEGER PRIMARY KEY, name VARCHAR(20), life DOUBLE, mana DOUBLE, exp DOUBLE)";
        public static String queryCreateUsers = "CREATE TABLE IF NOT EXISTS userManager (id INTEGER PRIMARY KEY AUTOINCREMENT, " +
            "vorname VARCHAR(30), nachname VARCHAR (30), email VARCHAR(50), username VARCHAR(20), created VARCHAR(30), lastlogin VARCHAR(30), charid INT, password VARCHAR(30))";
        public static String queryAddMage = "INSERT INTO classes(id, name, life, mana, exp) VALUES(1, 'Magier', 8, 9, 1) ";
        public static String queryAddWarrior = "INSERT INTO classes(id, name, life, mana, exp) VALUES(2, 'Krieger', 10, 7, 1)";
        public static String queryAddRanger = "INSERT INTO classes(id, name, life, mana, exp) VALUES(3, 'Ranger', 9, 8, 1)";
        public static String queryUserCharacter = "CREATE TABLE IF NOT EXISTS charactersFromUser (id INTEGER PRIMARY KEY AUTOINCREMENT, name VARCHAR(20), userid int, charid int)";

        public static String LoginQuery(String username, String password) => "SELECT username FROM userManager WHERE username = '" + username + "' AND password = '" + password + "'";

        public static String SaveUserTimestamp(String username) => "UPDATE userManager SET lastlogin = CURRENT_TIMESTAMP WHERE username = '" + username + "'";
        #endregion

        public static List<String> GetAllQuerysForInitProject()
        {
            List<String> list = new List<String>();
            list.Add(queryCreateCharacters);
            list.Add(queryCreateUsers);
            list.Add(queryAddMage);
            list.Add(queryAddWarrior);
            list.Add(queryAddRanger);
            list.Add(queryUserCharacter);
            return list;
        }
    }
}
