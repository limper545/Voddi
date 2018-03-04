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
                    SQLiteTransaction tran = connection.BeginTransaction();
                    var comm = CreateCommand(connection, tran, null);
                    try
                    {
                        query.ForEach(queryString =>
                        {
                            comm.CommandText = queryString;
                            comm.ExecuteNonQuery();
                        });
                        tran.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        // logger
                        return false;
                    }
                }
            }
            // Logger
            return false;

        }

        static SQLiteCommand CreateCommand(SQLiteConnection c, SQLiteTransaction t, String q)
        {
            SQLiteCommand comm;
            c.Open();
            comm = c.CreateCommand();
            comm.Connection = c;
            comm.Transaction = t;
            comm.CommandText = q;
            return comm;
        }

        static String GetDbConnection() => Properties.Settings.Default.connectionString;
    }
}
