using Core;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace DBHandler
{
    public class TransactionQueries
    {
        public static void InitProjectDatabase()
        {
            List<String> queriesList = Queries.GetAllQuerysForInitProject();
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                SQLiteCommand command = CreateCommandMeta(connection);
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
                catch (Exception ex)
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
            String query = Queries.LoginQuery(username, password);

            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                SQLiteCommand command = CreateCommandMeta(connection);
                try
                {
                    var user = new List<Tuple<String, String>>();
                    command.CommandText = query;
                    SQLiteDataReader queryReader = command.ExecuteReader();
                    if (queryReader.HasRows)
                    {
                        while (queryReader.Read())
                        {
                            user.Add(new Tuple<String, String>(queryReader.GetValue(0).ToString(), queryReader.GetValue(1).ToString()));
                        }
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public static bool CheckIfUserRegistered(String username)
        {
            String query = Queries.ExistUser(username);

            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                SQLiteCommand command = CreateCommandMeta(connection);
                try
                {
                    command.CommandText = query;
                    object queryReader = command.ExecuteScalar();
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
            String query = Queries.RegisterUser(vorname, nachname, email, username, password);

            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                SQLiteCommand command = CreateCommandMeta(connection);
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
                catch (Exception ex)
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

        public static bool HasUserCharacters(String username)
        {
            String query = Queries.UsersCharacters(username);

            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                SQLiteCommand command = CreateCommandMeta(connection);
                try
                {
                    command.CommandText = query;
                    object queryReader = command.ExecuteScalar();
                    return queryReader != null;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public static List<Tuple<String, String>> GetAllClasses()
        {
            List<String> list = new List<String>();
            String query = Queries.GetAllClassesFromDB;

            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                SQLiteCommand command = CreateCommandMeta(connection);
                try
                {
                    var listClasses = new List<Tuple<String, String>>();
                    command.CommandText = query;
                    SQLiteDataReader queryReader = command.ExecuteReader();
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
            String query = Queries.CreateUserCharacter(name, Convert.ToInt32(classID), Convert.ToInt32(classID));
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                SQLiteCommand command = CreateCommandMeta(connection);
                SQLiteTransaction transaction;
                transaction = connection.BeginTransaction();
                command.Transaction = transaction;
                try
                {
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    // TODO Speichern der CHARID bei User
                    return true;
                }
                catch (Exception ex)
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

        public static SQLiteConnection GetConnectionString()
        {
            return Handler.dbConnection;
        }

        public static SQLiteCommand CreateCommandMeta(SQLiteConnection connection)
        {
            connection.Open();
            SQLiteCommand command = connection.CreateCommand();
            command.Connection = connection;
            return command;
        }
    }
}