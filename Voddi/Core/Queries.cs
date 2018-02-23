﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Queries
    {
        #region DB Queries

        public static string dbName = "SaschaDB.sqlite";

        public static String queryCreateCharacters = "CREATE TABLE IF NOT EXISTS classes (id INTEGER PRIMARY KEY, name VARCHAR(20))";

        public static String queryCreateUsers = "CREATE TABLE IF NOT EXISTS userManager (id INTEGER PRIMARY KEY AUTOINCREMENT, " +
            "vorname VARCHAR(30), nachname VARCHAR (30), email VARCHAR(50), username VARCHAR(20), created VARCHAR(30), lastlogin VARCHAR(30), charid INT, password VARCHAR(30))";

        public static String queryCreateCharacterDetails = "CREATE TABLE IF NOT EXISTS characterDetails " +
            "(id INTEGER PRIMARY KEY AUTOINCREMENT, userid int, atk int, leben int, def int, exp int, mana int, spd int, level int)";

        public static String queryAddMage = "INSERT INTO classes(id, name, life, mana, exp) VALUES(1, 'Magier') ";

        public static String queryAddWarrior = "INSERT INTO classes(id, name, life, mana, exp) VALUES(2, 'Krieger')";

        public static String queryAddRanger = "INSERT INTO classes(id, name, life, mana, exp) VALUES(3, 'Ranger')";

        public static String queryUserCharacter = "CREATE TABLE IF NOT EXISTS charactersFromUser (id INTEGER PRIMARY KEY AUTOINCREMENT, name VARCHAR(20), userid int, charid int)";

        public static String LoginQuery(String username, String password)
            => "SELECT username, id FROM userManager WHERE username = '" + username + "' AND password = '" + password + "'";

        // TODO Einbauen der Funktion 
        public static String SaveUserTimestamp(String username)
            => "UPDATE userManager SET lastlogin = CURRENT_TIMESTAMP WHERE username = '" + username + "'";

        public static String ExistUser(String username) => "SELECT username FROM userManager WHERE username = '" + username + "'";

        public static String RegisterUser(String vorname, String nachname, String email, String username, String password)
       => "INSERT INTO userManager(vorname, nachname, email, username, password, created) VALUES" +
              "('" + vorname + "', '" + nachname + "', '" + email + "', '" + username + "', '" + password + "', CURRENT_TIMESTAMP)";

        public static String UsersCharacters(String username)
            => "SELECT charid FROM userManager WHERE username  = '" + username + "'";

        public static String GetAllClassesFromDB = "SELECT name, id FROM classes";
        #endregion

        public static List<String> GetAllQuerysForInitProject()
        {
            List<String> list = new List<String>
            {
                queryCreateCharacters,
                queryCreateUsers,
                queryCreateCharacterDetails,
                queryAddMage,
                queryAddWarrior,
                queryAddRanger,
                queryUserCharacter
            };
            return list;
        }

        public static String GetCharacterID(String name) => "SELECT id FROM classes WHERE name = '" + name + "' ";

        public static String GetUserID(String name) => "SELECT id FROM userManager WHERE username = '" + name + "' ";

        public static String CreateUserCharacter(String name, int classID, int userID) => "INSERT INTO charactersFromUser(name, charid, userid) VALUES" +
                         "('" + name + "', " + classID + " ," + userID + ")";

        public static String GetCharIDForUserManager(int userID) => "SELECT id FROM charactersFromUser WHERE userid = " + userID + "";

        public static String SaveCharIDFOrUser(String userID, String charID) => "UPDATE userManager SET charid = '" + charID + "' WHERE id = " + userID + "";

        public static String GetAllCharactersForAUserFromTheDB(String charID)
            => "SELECT charactersFromUser.name, classes.name FROM charactersFromUser LEFT JOIN classes ON classes.id = charactersFromUser.charid WHERE charactersFromUser.id = " + charID;

        public static String CreateCharacterDetail(int userid, int level, int leben, int exp, int atk, int mana, int def, int spd)
            => "INSERT INTO characterDetails (userid, level, leben, exp, atk, mana, def, spd) VALUES (" + userid + ", " + level + ", " + leben + ", " + exp + ", " +
            "" + atk + ", " + mana + ", " + def + ", " + spd + ")";

        public static String GameCharacterInformations(String name)
            => "SELECT charactersFromUser.name, classes.name, characterDetails.level, characterDetails.leben, characterDetails.exp, characterDetails.atk, characterDetails.mana, characterDetails.def, characterDetails.spd FROM charactersFromUser LEFT JOIN characterDetails ON charactersFromUser.id = characterDetails.userid LEFT JOIN classes ON classes.id = charactersFromUser.charid WHERE charactersFromUser.name = '" + name + "'";
    }
}
