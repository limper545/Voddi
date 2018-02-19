using System;
using System.Windows.Forms;
using System.Data.SQLite;
using DBHandler;

namespace GUI
{
    public partial class LoginDataForm : Form
    {
        public LoginDataForm() => InitializeComponent();
        private void loginDataBtn_Click(object sender, EventArgs e)
        {
            string username = loginUsernameField.Text;
            string password = loginPasswordField.Text;
           if (Handler.CheckLogin(username, password))
            {
                MessageBox.Show("Erfolgreich", "Anmeldung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new checkForPatch(username).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Fehler", "Anmeldung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e) => this.Close();
    }
}
