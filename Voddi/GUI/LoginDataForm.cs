using System;
using System.Windows.Forms;
using System.Data.SQLite;
using DBHandler;
using Core;

namespace GUI
{
    public partial class LoginDataForm : Form
    {
        public LoginDataForm() => InitializeComponent();
        private void loginDataBtn_Click(object sender, EventArgs e)
        {
            string username = loginUsernameField.Text;
             string password = loginPasswordField.Text;
            User user = Handler.CheckLogin(username, password);
            Console.WriteLine();
           if (user != null)
            {
                MessageBox.Show("Erfolgreich", "Anmeldung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new checkForPatch(user).Show();
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
