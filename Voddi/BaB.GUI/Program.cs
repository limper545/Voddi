using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaB.Infrastructure.DatabaseInitializer;

namespace BaB.GUI
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (DatabaseInitializer.CheckIfDbExists())
            {
                //LoadingScreen
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
