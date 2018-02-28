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

        /// <summary>
        /// Startet den Login vorgang im Backend
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void loginDataBtn_Click(object sender, EventArgs e)
        {
            var username = loginUsernameField.Text;
            var password = loginPasswordField.Text;
            var user = Handler.CheckLogin(username, password);
            if (user != null)
            {
                MessageBox.Show("Erfolgreich", "Anmeldung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new checkForPatch(user).Show();
                Close();
            }
            else
            {
                MessageBox.Show("Fehler", "Anmeldung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Bricht den Login ab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cancelBtn_Click(object sender, EventArgs e) => this.Close();
    }
}
