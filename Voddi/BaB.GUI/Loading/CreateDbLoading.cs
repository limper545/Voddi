using System.Windows.Forms;
using BaB.Infrastructure.DatabaseInitializer;
using System;
using BaB.GUI.Menu;

namespace BaB.GUI.Loading
{
    public partial class CreateDbLoading : Form
    {
        static Timer MyTimer = new Timer();
        public CreateDbLoading()
        {
            InitializeComponent();

            MyTimer.Interval = 3000;

            CheckDatabaseCredentials();
        }

        void CheckDatabaseCredentials()
        {
            MyTimer.Tick += ShowStartMenu;
            MyTimer.Start();
            if (DatabaseInitializer.CheckIfDbExists())
            {
                labelTest.Text = "Database Connection Success.";
            }
            else
            {
                labelTest.Text = "Einen Moment, Db wird erstellt.";
                if (DatabaseInitializer.InitDatabase())
                {
                    labelTest.Text = "Wurde erfolgreich erstellt.";
                }
                else
                {
                    labelTest.Text = "Fehler beim erstellen der DB";
                }
            }
        }

        void ShowStartMenu(object sender, EventArgs e)
        {
            Hide();
            new StartMenu().Show();
        }
    }
}
