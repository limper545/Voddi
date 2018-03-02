using BaB.GUI.Loading;
using BaB.Infrastructure.DatabaseInitializer;
using System;

namespace BaB.Application
{
    public class Class1
    {
        [STAThread]
        static void Main(string[] args)
        {
            Test();
        }
        public static void Test()
        {
            new CreateDbLoading().Show();
            if (DatabaseInitializer.CheckIfDbExists())
            {
                
            }
            else
            {
                // Wait for Init Form
                if (DatabaseInitializer.InitDatabase())
                {
                    // Weiterleiten
                }
                else
                {
                    // Fehlermeldung und Application schließen
                }
            }
        }

    }
}
