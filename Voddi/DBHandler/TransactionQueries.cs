using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHandler
{
    class TransactionQueries
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

        public static bool CheckIfLoginDataAreCorrect(string username, string password)
        {
            String query = Queries.LoginQuery(username, password);

            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                SQLiteCommand command = CreateCommandMeta(connection);
                try
                {
                    command.CommandText = query;
                    object queryReader = command.ExecuteScalar();
                    if (queryReader == null)
                    {
                        return false;
                    }
                    else
                    {
                        command.CommandText = Queries.SaveUserTimestamp(username);
                        command.ExecuteNonQuery();
                        return true;
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
                    return queryReader == null;
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
                    return queryReader == null;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
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
