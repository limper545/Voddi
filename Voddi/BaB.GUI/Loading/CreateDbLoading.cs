using System.Windows.Forms;
using BaB.Infrastructure.DatabaseInitializer;
namespace BaB.GUI.Loading
{
    public partial class CreateDbLoading : Form
    {
        public CreateDbLoading()
        {
            InitializeComponent();
            CheckDatabaseCredentials();
        }

        void CheckDatabaseCredentials()
        {
            if (DatabaseInitializer.CheckIfDbExists())
            {
                labelTest.Text = "Database Connection Success.";
            }
            else
            {
                labelTest.Text = "EInen Moment, Db wird erstellt.";
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
    }
}
