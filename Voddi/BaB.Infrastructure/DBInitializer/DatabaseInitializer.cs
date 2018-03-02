using BaB.Infrastructure.Transactions;
using System;
using System.Data.SQLite;

namespace BaB.Infrastructure.DatabaseInitializer
{
    public static class DatabaseInitializer
    {

        public static bool CheckIfDbExists() => System.IO.File.Exists(Properties.Settings.Default.connectionString);

        public static bool InitDatabase()
        {
            var dbName = Properties.Settings.Default.connectionString;
            try
            {
                if (!System.IO.File.Exists(dbName))
                {
                    SQLiteConnection.CreateFile(dbName);
                    return TransactionsSQL.InitDatabase(DbInitializerAttributes.GetDatabaseConfigQuery);
                }
                return true;
            }
            catch (InvalidOperationException ex)
            {
                //Logger.Error("DatabaseInitializer.CheckIfDbExists", ex.Message);
                return false;
            }

            //    return TransactionQueries.InitProjectDatabase();
            //Logger.Error("DBHandler.CreateDatabase", ex.Message);
        }
    }
}

            
   
