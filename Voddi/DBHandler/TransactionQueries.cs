﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHandler
{
    class TransactionQueries
    {
        public static void InitProjectDatabase(SQLiteConnection connectionString)
        {
            List<String> queriesList = Queries.GetAllQuerysForInitProject();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                SQLiteTransaction transaction;

                transaction = connection.BeginTransaction();

                command.Connection = connection;
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
                        throw ex2;
                    }
                }
            }
        }

        public static bool CheckIfLoginDataAreCorrect(string username, string password, SQLiteConnection connectionString)
        {
            String query = Queries.LoginQuery(username, password);

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.Connection = connection;
                try
                {
                    command.CommandText = Queries.LoginQuery(username, password);
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
    }
}
