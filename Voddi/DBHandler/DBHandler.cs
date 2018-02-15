using System;
using System.Collections;
using System.Data;
using System.Data.SQLite;

namespace DBHandler
{
    public class DBHandler
    {
        #region DB Abfragen
        private static string dbName = "MyDatabase.sqlite";
        public static String queryCreateCharacters = "CREATE TABLE IF NOT EXISTS classes (id INTEGER PRIMARY KEY, name VARCHAR(20), life DOUBLE, mana DOUBLE, exp DOUBLE)";
        public static String queryCreateUsers = "CREATE TABLE IF NOT EXISTS userManager (id INTEGER PRIMARY KEY AUTOINCREMENT, " +
            "vorname VARCHAR(30), nachname VARCHAR (30), email VARCHAR(50), username VARCHAR(20), created VARCHAR(30), lastlogin VARCHAR(30), charid INT, password VARCHAR(30))";
        public static String queryAddMage = "INSERT OR REPLACE INTO classes(id, name, life, mana, exp) VALUES(1, 'Magier', 8, 9, 1) ";
        public static String queryAddWarrior = "INSERT OR REPLACE INTO classes(id, name, life, mana, exp) VALUES(2, 'Krieger', 10, 7, 1)";
        public static String queryAddRanger = "INSERT OR REPLACE INTO classes(id, name, life, mana, exp) VALUES(3, 'Ranger', 9, 8, 1)";
        public static String queryUserCharacter = "CREATE TABLE IF NOT EXISTS charactersFromUser (id INTEGER PRIMARY KEY AUTOINCREMENT, name VARCHAR(20), userid int, charid int)";
        #endregion
        public static SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + dbName + "; Version=3;");
        public void CreateAndConfigureDatabase() => SQLiteConnection.CreateFile(dbName);

        public static bool CreateDatabaseConnection()
        {

            //dbConnection = new SQLiteConnection("Data Source=" + dbName + "; Version=3;");
            dbConnection.Open();
            CreateTableCommand(queryCreateCharacters);
            return dbConnection.State == ConnectionState.Open;

        }

        public static void CreateTableCommand(String sqlQuery)
        {
            SQLiteCommand command = new SQLiteCommand(sqlQuery, dbConnection);
            SQLiteCommand commandMage = new SQLiteCommand(queryAddMage, dbConnection);
            SQLiteCommand commandWarrior = new SQLiteCommand(queryAddWarrior, dbConnection);
            SQLiteCommand commandRanger = new SQLiteCommand(queryAddRanger, dbConnection);
            SQLiteCommand commandUser = new SQLiteCommand(queryCreateUsers, dbConnection);
            SQLiteCommand commandUserChar = new SQLiteCommand(queryUserCharacter, dbConnection);
            command.ExecuteScalar();
            commandMage.ExecuteScalar();
            commandWarrior.ExecuteScalar();
            commandRanger.ExecuteScalar();
            commandUser.ExecuteScalar();
            commandUserChar.ExecuteScalar();
        }


        public static bool CheckLogin(String username, String password)
        {

            String query = "SELECT username FROM userManager WHERE username = '" + username + "' AND password = '" + password + "'";
            SQLiteCommand command = new SQLiteCommand(query, dbConnection);
            object response = command.ExecuteScalar();
            if (response == null)
            {
                return false;
            }
            else
            {
                String querySave = "UPDATE userManager SET lastlogin = CURRENT_TIMESTAMP WHERE username = '" + response + "'";
                SQLiteCommand commandSave = new SQLiteCommand(querySave, dbConnection);
                commandSave.ExecuteScalar();
                return true;
            }

        }

        public static bool ExistsUser(String username)
        {
            String query = "SELECT username FROM userManager WHERE username = '" + username + "'";
            SQLiteCommand command = new SQLiteCommand(query, dbConnection);
            object response = command.ExecuteScalar();
            if (response == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CreateUser(String vornameNew, String nachnameNew, String emailNew, String usernameNew, String passwordOne)
        {
            String query = "INSERT INTO userManager(vorname, nachname, email, username, password, created) VALUES" +
                "('" + vornameNew + "', '" + nachnameNew + "', '" + emailNew + "', '" + usernameNew + "', '" + passwordOne + "', CURRENT_TIMESTAMP)";
            SQLiteCommand command = new SQLiteCommand(query, dbConnection);
            object response = command.ExecuteNonQuery();
            if (response == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool HasUserCharacters(String username)
        {
            String query = "SELECT charid FROM userManager WHERE username  = '" + username + "'";
            SQLiteCommand command = new SQLiteCommand(query, dbConnection);
            object response = command.ExecuteNonQuery();
            if (response.ToString() == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static ArrayList GetAllClasses()
        {
            ArrayList classes = new ArrayList();
            String query = "SELECT name FROM classes";
            SQLiteCommand command = new SQLiteCommand(query, dbConnection);
            SQLiteDataReader response = command.ExecuteReader();
            while (response.Read())
            {
                classes.Add(response.GetValue(0).ToString());
            }
            return classes;
        }
    }
}