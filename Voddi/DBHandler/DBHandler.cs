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
            SQLiteConnection.CreateFile(Queries.dbName);
            TransactionQueries.InitProjectDatabase(dbConnection);
            //try
            //{
            //    TransactionQueries.InitProjectDatabase(dbConnection);
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("Fehler beim erstellen der Datenbank. Fehler: " + ex.Message);
            //}
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