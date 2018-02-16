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
    }
}
