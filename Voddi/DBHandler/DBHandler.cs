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

        public static bool ExistsUser(String username) => TransactionQueries.CheckIfUserRegistered(username);

        public static bool CreateUser(String vorname, String nachname, String email, String username, String password)
        => TransactionQueries.RegisterNewUser(vorname, nachname, email, username, password);

        public static bool HasUserCharacters(String username) => TransactionQueries.HasUserCharacters(username);

        public static List<String> GetAllClasses()
        {
            List<String> listClasses = new List<String>();
            List<String> classes = TransactionQueries.GetAllClasses();
            return classes;
        }

        public static void CreateCharacterForAUser(String characterName, String characterKlasse) => TransactionQueries.CreateCharacterForUser(characterName, characterKlasse);
    }
}
