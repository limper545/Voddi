using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace BaB.Infrastructure.Transactions
{
    public static class TransactionsSQL
    {

        public static bool InitDatabase(List<String> query)
        {
            if (query != null)
            {
                using (SQLiteConnection connection = new SQLiteConnection(GetDbConnection()))
                {
                    var command = CreateCommand(connection);
                    SQLiteTransaction transaction;
                    transaction = connection.BeginTransaction();
                    command.Transaction = transaction;
                    try
                    {
  
                        query.ForEach(queryString =>
                        {
                            command.CommandText = queryString;
                            command.ExecuteNonQuery();
                        });
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        // logger
                        return false;
                    }
                }
            }
            // Logger
            return false;

        }

        static SQLiteCommand CreateCommand(SQLiteConnection c)
        {
            c.Open();
            var command = c.CreateCommand();
            command.Connection = c;
            return command;
        }

        static SQLiteConnection GetDbConnection() =>  new SQLiteConnection(Properties.Settings.Default.connectionString);
      
    }
}
