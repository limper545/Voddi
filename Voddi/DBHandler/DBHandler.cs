using System.Configuration;
using System;
using System.Collections;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;

namespace DBHandler
{
   
    public class Handler
    {
        public static SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + Queries.dbName + "; Version=3;");
        public static void CreateDatabase()
        {
            if (!System.IO.File.Exists(Queries.dbName)) SQLiteConnection.CreateFile(Queries.dbName);
            try
            {
                TransactionQueries.InitProjectDatabase();
            }
            catch (Exception ex)
            {
                // TODO Fehler an das Frontend melden
                throw new Exception("Fehler beim erstellen der Datenbank. Fehler: " + ex.Message);
            }
        }
        public static bool CheckLogin(String username, String password) => TransactionQueries.CheckIfLoginDataAreCorrect(username, password);

        public static bool ExistsUser(String username)
        {
  
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