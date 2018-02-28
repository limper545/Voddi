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
            var username = loginUsernameField.Text;
            var password = loginPasswordField.Text;
            var user = Handler.CheckLogin(username, password);
           if (user != null)
            {
                MessageBox.Show("Erfolgreich", "Anmeldung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (var checkForPatch1 = new checkForPatch(user))
                {
                    checkForPatch1.Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Fehler", "Anmeldung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void cancelBtn_Click(object sender, EventArgs e) => this.Close();
    }
}
