using Core;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace DBHandler
{
    public static class TransactionQueries
    {
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
                    });
                    transaction.Commit();
                }
                catch (Exception)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        throw new Exception(ex2.Message);
                    }
                }
            }
        }

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
                    throw new Exception(ex.Message);
                }
            }
        }

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
                    throw new Exception(ex.Message);
                }
            }
        }

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
                    throw new Exception(ex.Message);
                }
            }
        }

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
                    throw new Exception(ex.Message);
                }
            }
        }

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
                    throw new Exception(ex.Message);
                }
            }
        }

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
                    throw new Exception(ex.Message);
                }

            }
        }

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

        public static SQLiteConnection GetConnectionString()
        {
           return Handler.GetDbConnection;
        }

        public static SQLiteCommand CreateCommandMeta(SQLiteConnection connection)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.Connection = connection;
            return command;
        }
    }
}