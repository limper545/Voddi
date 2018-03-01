using Core;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace DBHandler
{
    public static class TransactionQueries
    {
        /// <summary>
        /// Erstellt die DB und alle benötigten Tabellen
        /// </summary>
        public static void InitProjectDatabase()
        {
            var queriesList = Queries.GetAllQuerysForInitProject();
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                var command = CreateCommandMeta(connection);
                SQLiteTransaction transaction;
                transaction = connection.BeginTransaction();
                command.Transaction = transaction;
                try
                {
                    queriesList.ForEach(query =>
                    {
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        Console.WriteLine();
                    });
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    try
                    {
                        Logger.Error("TransactionQueries.InitProjectDatabase", "Rollback");
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        throw new Exception(ex2.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Checkt, ob die Daten des Users Correct sind und so mit in der DB existieren
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static List<Tuple<String, String>> CheckIfLoginDataAreCorrect(string username, string password)
        {
            var query = Queries.LoginQuery(username, password);

            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                var command = CreateCommandMeta(connection);
                try
                {
                    var user = new List<Tuple<String, String>>();
                    command.CommandText = query;
                    var queryReader = command.ExecuteReader();
                    if (queryReader.HasRows)
                    {
                        while (true)
                        {
                            if (!queryReader.Read())
                                break;
                            user.Add(new Tuple<String, String>(queryReader.GetValue(0).ToString(), queryReader.GetValue(1).ToString()));
                        }

                        return user;
                    }
                    return null;

                }
                catch (Exception ex)
                {
                    Logger.Error("TransactionQueries.CheckIfLoginDataAreCorrect", ex.Message);
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// Checkt, ob ein User schon in der DB registriert ist
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static bool CheckIfUserRegistered(String username)
        {
            var query = Queries.ExistUser(username);

            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                var command = CreateCommandMeta(connection);
                try
                {
                    command.CommandText = query;
                    var queryReader = command.ExecuteScalar();
                    return queryReader != null;
                }
                catch (Exception ex)
                {
                    Logger.Error("TransactionQueries.CheckIfUserRegistered", ex.Message);
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// Registriert einen neuen User in der DB
        /// </summary>
        /// <param name="vorname"></param>
        /// <param name="nachname"></param>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool RegisterNewUser(String vorname, String nachname, String email, String username, String password)
        {
            var query = Queries.RegisterUser(vorname, nachname, email, username, password);

            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                var command = CreateCommandMeta(connection);
                SQLiteTransaction transaction;
                transaction = connection.BeginTransaction();
                command.Transaction = transaction;
                try
                {
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    try
                    {
                        Logger.Error("TransactionQueries.RegisterNewUser", "Rollback");
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        throw new Exception(ex2.Message);
                    }
                    return false;
                }
            }
        }

        /// <summary>
        /// Schaut, ob der User schon Characters erstellt hat
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static String HasUserCharacters(String username)
        {
            var query = Queries.UsersCharacters(username);

            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                var command = CreateCommandMeta(connection);
                try
                {
                    command.CommandText = query;
                    var queryReader = command.ExecuteScalar();
                    return !queryReader.Equals(0) ? queryReader.ToString() : String.Empty;
                }
                catch (Exception ex)
                {
                    Logger.Error("TransactionQueries.HasUserCharacters", ex.Message);
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// Holt sich die Informationen für einen Character
        /// </summary>
        /// <param name="charID"></param>
        /// <returns></returns>
        public static List<Tuple<String, String>> GetCharacterInformations(String charID)
        {
            var query = Queries.GetAllCharactersForAUserFromTheDB(charID);

            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                var command = CreateCommandMeta(connection);
                try
                {
                    var list = new List<Tuple<String, String>>();
                    command.CommandText = query;
                    var queryReader = command.ExecuteReader();
                    while (queryReader.Read())
                    {
                        list.Add(new Tuple<String, String>(queryReader.GetValue(0).ToString(), queryReader.GetValue(1).ToString()));
                    }
                    return list;
                }
                catch (Exception ex)
                {
                    Logger.Error("TransactionQueries.GetCharacterInformations", ex.Message);
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// Setzt den Timestamp beim Login für ein User in der DB
        /// </summary>
        /// <param name="username"></param>
        public static void CreateTimestampLogin(String username)
        {
            var query = Queries.SaveUserTimestamp(username);
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                var command = CreateCommandMeta(connection);
                try
                {
                    var listClasses = new List<Tuple<String, String>>();
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Logger.Error("TransactionQueries.CreateTimestampLogin", ex.Message);
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// Holt sich alle Klassen aus der DB
        /// </summary>
        /// <returns></returns>
        public static List<Tuple<String, String>> GetAllClasses()
        {
            var query = Queries.GetAllClassesFromDB;

            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                var command = CreateCommandMeta(connection);
                try
                {
                    var listClasses = new List<Tuple<String, String>>();
                    command.CommandText = query;
                    var queryReader = command.ExecuteReader();
                    while (queryReader.Read())
                    {
                        listClasses.Add(new Tuple<String, String>(queryReader.GetValue(0).ToString(), queryReader.GetValue(1).ToString()));
                    }
                    return listClasses;
                }
                catch (Exception ex)
                {
                    Logger.Error("TransactionQueries.GetAllClasses", ex.Message);
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// Erstellt ein neuen Character für einen User in der DB
        /// </summary>
        /// <param name="name"></param>
        /// <param name="classID"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static bool CreateCharacterForUser(String name, String classID, String userID)
        {
            var query = Queries.CreateUserCharacter(name, Convert.ToInt32(classID), Convert.ToInt32(userID));
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                var command = CreateCommandMeta(connection);
                SQLiteTransaction transaction;
                transaction = connection.BeginTransaction();
                command.Transaction = transaction;
                try
                {
                    command.CommandText = query;
                    if (command.ExecuteNonQuery() == 1)
                    {
                        GetCharID(Convert.ToInt32(userID));
                        transaction.Commit();
                        return true;
                    }
                    throw new Exception("Transaction failed");
                    //
                }
                catch (Exception)
                {
                    try
                    {
                        Logger.Error("TransactionQueries.CreateCharacterForUser", "Rollback");
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        throw new Exception(ex2.Message);
                    }
                    return false;
                }

            }
        }

        /// <summary>
        /// Holt sich die ID eines Characters aus der DB
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static String GetCharID(int userID)
        {
            var query = Queries.GetCharIDForUserManager(userID);
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                var command = CreateCommandMeta(connection);
                command.CommandText = query;
                var queryReader = command.ExecuteReader();
                var charID = String.Empty;
                while (queryReader.Read())
                {
                    charID = queryReader.GetValue(0).ToString();
                }
                return charID;
            }
        }

        /// <summary>
        /// Speichert die Character ID in die User Tabelle
        /// </summary>
        /// <param name="charID"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static bool SaveCharIDInUserManager(String charID, String userID)
        {
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {

                try
                {
                    var quer = Queries.SaveCharIDFOrUser(userID.ToString(), charID);
                    var command = CreateCommandMeta(connection);
                    command.CommandText = quer;
                    return command.ExecuteNonQuery() == 1;
                }
                catch (Exception ex)
                {
                    Logger.Error("TransactionQueries.SaveCharIDInUserManager", ex.Message);
                    throw new Exception(ex.Message);
                }

            }
        }

        /// <summary>
        /// Speichert die Standart einstellungen für einen Character bei der Eerstellung in der DB
        /// </summary>
        /// <param name="characterID"></param>
        /// <param name="classID"></param>
        /// <returns></returns>
        public static bool SaveCharacterDetailsAtCreate(String characterID, int classID)
        {
            ClassAttributes.GetClassAttributes(Convert.ToByte(classID), out int level, out int leben, out int exp, out int atk,
                out int mana, out int def, out int spd);

            var query = Queries.CreateCharacterDetail(Convert.ToInt32(characterID), level, leben, exp, atk, mana, def, spd);
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                var command = CreateCommandMeta(connection);
                SQLiteTransaction transaction;
                transaction = connection.BeginTransaction();
                command.Transaction = transaction;
                try
                {
                    command.CommandText = query;
                    transaction.Commit();
                    return command.ExecuteNonQuery() == 1;
                }
                catch (Exception)
                {
                    try
                    {
                        Logger.Error("TransactionQueries.SaveCharacterDetailsAtCreate", "Rollback");
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        throw new Exception(ex2.Message);
                    }
                    return false;
                }
            }
        }

        /// <summary>
        /// Hollt sich den Character eines User aus der DB
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<String> GetGameCharacter(String name)
        {
            var list = new List<String>();
            var query = Queries.GameCharacterInformations(name);
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {

                var command = CreateCommandMeta(connection);
                command.CommandText = query;
                var queryResponse = command.ExecuteReader();
                while (queryResponse.Read())
                {
                    for (int i = 0; i < queryResponse.FieldCount; i++)
                    {
                        list.Add(queryResponse.GetValue(i).ToString());
                    }
                }
                return list;
            }
        }

        /// <summary>
        /// Speichert die Character Daten in die DB
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool SaveCharacter(GameCharacter c)
        {
            var query = Queries.SaveCharacter(c);
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                var command = CreateCommandMeta(connection);
                SQLiteTransaction transaction;
                transaction = connection.BeginTransaction();
                command.Transaction = transaction;
                try
                {
                    command.CommandText = query;
                    transaction.Commit();
                    return command.ExecuteNonQuery() == 1;
                }
                catch (Exception)
                {
                    try
                    {
                        Logger.Error("TransactionQueries.SaveCharacter", "Rollback");
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        Logger.Error("TransactionQueries.SaveCharacter", ex2.Message);
                        throw new Exception(ex2.Message);
                    }
                    return false;
                }
            }
        }

        /// <summary>
        /// Verteilt den ConnectionString der DB an andere Methoden
        /// </summary>
        /// <returns></returns>
        public static SQLiteConnection GetConnectionString()
        {
            return Handler.GetDbConnection;
        }

        /// <summary>
        /// Erstellt Commandos für SQL für andere Methoden zum verteilen
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static SQLiteCommand CreateCommandMeta(SQLiteConnection connection)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.Connection = connection;
            return command;
        }
    }
}