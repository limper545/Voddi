using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBHandler;
using Core;
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
            String query = Queries.UsersCharacters(username);

            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                SQLiteCommand command = CreateCommandMeta(connection);
                try
                {
                    command.CommandText = query;
                    object queryReader = command.ExecuteScalar();
                    if (!queryReader.Equals(0))
                    {
                        return queryReader.ToString();
                    }
                    else
                    {
                        return String.Empty;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
        }

        public static List<Tuple<String, String>> GetCharacterInformations(String charID)
        {
            String query = Queries.GetAllCharactersForAUserFromTheDB(charID);

            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                SQLiteCommand command = CreateCommandMeta(connection);
                try
                {
                    var list = new List<Tuple<String, String>>();
                    command.CommandText = query;
                    SQLiteDataReader queryReader = command.ExecuteReader();
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
            String query = Queries.CreateUserCharacter(name, Convert.ToInt32(classID), Convert.ToInt32(userID));
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                SQLiteCommand command = CreateCommandMeta(connection);
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
                    else
                    {
                        throw new Exception("Transaction failed");
                    }
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
            String query = Queries.GetCharIDForUserManager(userID);
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                SQLiteCommand command = CreateCommandMeta(connection);
                command.CommandText = query;
                SQLiteDataReader queryReader = command.ExecuteReader();
                String charID = String.Empty;
                while (queryReader.Read())
                {
                    charID = queryReader.GetValue(0).ToString();
                }
                return charID;
            }
        }

        public static bool SaveCharIDInUserManager(String charID, String userID)
        {
            String query = Queries.SaveCharIDFOrUser(userID, charID);
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {

                try
                {
                    String quer = Queries.SaveCharIDFOrUser(userID.ToString(), charID);
                    SQLiteCommand command = CreateCommandMeta(connection);
                    command.CommandText = quer;
                    return command.ExecuteNonQuery() == 1;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
        }

        public static bool SaveCharacterDetailsAtCreate(String characterID, String userID, int classID)
        {
            ClassAttributes.GetClassAttributes(Convert.ToByte(classID), out int level, out int leben, out int exp, out int atk, 
                out int mana, out int def, out int spd);

            String query = Queries.CreateCharacterDetail(Convert.ToInt32(characterID), level, leben, exp, atk, mana, def, spd);
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                SQLiteCommand command = CreateCommandMeta(connection);
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
