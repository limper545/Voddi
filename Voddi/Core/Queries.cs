using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Core
{
    public static class Queries
    {
        #region DB Queries

        static readonly string dbName = "SaschaDB.sqlite";

        static readonly String queryCreateCharacters = "CREATE TABLE IF NOT EXISTS classes (id INTEGER PRIMARY KEY, name VARCHAR(20))";

        static readonly String queryCreateUsers = "CREATE TABLE IF NOT EXISTS userManager (id INTEGER PRIMARY KEY AUTOINCREMENT, " +
            "vorname VARCHAR(30), nachname VARCHAR (30), email VARCHAR(50), username VARCHAR(20), created VARCHAR(30), lastlogin VARCHAR(30), charid INT, password VARCHAR(30))";

        static readonly String queryCreateCharacterDetails = "CREATE TABLE IF NOT EXISTS characterDetails " +
            "(id INTEGER PRIMARY KEY AUTOINCREMENT, userid int, atk int, leben int, def int, exp int, mana int, spd int, level int)";

        static readonly String queryUserCharacter = @"CREATE TABLE IF NOT EXISTS charactersFromUser (id INTEGER PRIMARY KEY AUTOINCREMENT, name VARCHAR(20), userid int, charid int)";

        static readonly String queryAddMage = @"INSERT INTO classes(id, name) VALUES(1, 'Magier') ";

        static readonly String queryAddWarrior = @"INSERT INTO classes(id, name) VALUES(2, 'Krieger') ";

        static readonly String queryAddRanger = @"INSERT INTO classes(id, name) VALUES(3, 'Ranger')";

        public static String LoginQuery(String username, String password)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                throw new ArgumentException("message", nameof(username));
            }
            return $"SELECT username, id FROM userManager WHERE username = '{username}' AND password = '{password}'";
        }

        public static String SaveUserTimestamp(String username)
        {
            if (username == null)
            {
                throw new ArgumentNullException(nameof(username));
            }

            return $"UPDATE userManager SET lastlogin = CURRENT_TIMESTAMP WHERE username = '{username}'";
        }

        public static String ExistUser(String username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("message", nameof(username));
            }

            return $"SELECT username FROM userManager WHERE username = '{username}'";
        }

        public static String RegisterUser(String vorname, String nachname, String email, String username, String password)
        {
            if (String.IsNullOrEmpty(vorname))
            {
                throw new ArgumentException("message", nameof(vorname));
            }

            return $"INSERT INTO userManager(vorname, nachname, email, username, password, created) VALUES('{vorname}', '{nachname}', '{email}', '{username}', '{password}', CURRENT_TIMESTAMP)";
        }

        public static String UsersCharacters(String username)
        {
            if (String.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException(nameof(username));
            }

            return $"SELECT charid FROM userManager WHERE username  = '{username}'";
        }

        private static readonly String allClassesFromDB = "SELECT name, id FROM classes";

        #endregion DB Queries

        #region Getter für Queries

        public static String GetDbName => dbName;
        public static String GetQueryCreateCharacters => queryCreateCharacters;
        public static String GetQueryCreateUsers => queryCreateUsers;
        public static String GetQueryCreateCharacterDetails => queryCreateCharacterDetails;
        public static String GetQueryAddMage => queryAddMage;
        public static String GetQueryAddWarrior => queryAddWarrior;
        public static String GetQueryAddRanger => queryAddRanger;
        public static String GetQueryUserCharacter => queryUserCharacter;
        public static String GetAllClassesFromDB => allClassesFromDB;

        #endregion Getter für Queries

        public static List<String> GetAllQuerysForInitProject()
        {
            var list = new List<String>
            {
                GetQueryCreateCharacters,
                GetQueryCreateUsers,
                GetQueryCreateCharacterDetails,
                GetQueryUserCharacter,
                GetQueryAddMage,
                GetQueryAddWarrior,
                GetQueryAddRanger
            };
            return list;
        }

        public static String GetCharacterID(String name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("message", nameof(name));
            }
            return $"SELECT id FROM classes WHERE name = '{name}' ";
        }



        public static String GetUserID(String name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("message", nameof(name));
            }
            return $"SELECT id FROM userManager WHERE username = '{name}' ";

        }
        public static String CreateUserCharacter(String name, int classID, int userID)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("message", nameof(name));
            }

            return $"INSERT INTO charactersFromUser(name, charid, userid) VALUES('{name}', {classID} ,{userID})";
        }

        public static String GetCharIDForUserManager(int userID)
        {
            return $"SELECT id FROM charactersFromUser WHERE userid = {userID}";
        }

        public static String SaveCharIDFOrUser(String userID, String charID)
        {
            if (string.IsNullOrEmpty(userID) || String.IsNullOrEmpty(charID))
            {
                throw new ArgumentException("message", nameof(userID));
            }

            return $"UPDATE userManager SET charid = '{charID}' WHERE id = {userID}";
        }

        public static String GetAllCharactersForAUserFromTheDB(String charID)
        {
            if (string.IsNullOrEmpty(charID))
            {
                throw new ArgumentException("message", nameof(charID));
            }

            return $"SELECT charactersFromUser.name, classes.name FROM charactersFromUser LEFT JOIN classes ON classes.id = charactersFromUser.charid WHERE charactersFromUser.id = {charID}";
        }

        public static String CreateCharacterDetail(int userid, int level, int leben, int exp, int atk, int mana, int def, int spd) => $"INSERT INTO characterDetails (userid, level, leben, exp, atk, mana, def, spd) VALUES ({userid}, {level}, {leben}, {exp}, {atk}, {mana}, {def}, {spd})";

        public static String GameCharacterInformations(String name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("message", nameof(name));
            }

            return $"SELECT charactersFromUser.name, classes.name, characterDetails.level, characterDetails.leben, characterDetails.exp, characterDetails.atk, characterDetails.mana, characterDetails.def, characterDetails.spd FROM charactersFromUser LEFT JOIN characterDetails ON charactersFromUser.id = characterDetails.userid LEFT JOIN classes ON classes.id = charactersFromUser.charid WHERE charactersFromUser.name = '{name}'";
        }
    }
}