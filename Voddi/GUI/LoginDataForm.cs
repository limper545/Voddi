using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginDataForm : Form
    {
        public LoginDataForm()
        {

            InitializeComponent();
        }

        private void loginDataBtn_Click(object sender, EventArgs e)
        {
            string username = loginUsernameField.Text;
            string password = loginPasswordField.Text;

           /* if (DBHandler.CheckLogin(username, password))
            {
                MessageBox.Show("Erfolgreich", "Anmeldung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkForPatch modalPatch = new checkForPatch(username);
                modalPatch.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Fehler", "Anmeldung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
