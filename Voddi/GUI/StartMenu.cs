using DBHandler;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
            //dbConnection.Text = DBHandler.DBHandler.GetConnectionStatus();
            dbConnection.BackColor = Color.Transparent;

            gameTitleLabel.Text = "BaB";
            gameTitleLabel.BackColor = Color.Transparent;
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            //Handler.LoginDataCorrect("a", "b");
        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Btn_Click_1(object sender, EventArgs e)
        {
            LoginDataForm loginForm = new LoginDataForm();
            loginForm.StartPosition = FormStartPosition.CenterParent;
            loginForm.Show(this);
        }

        private void reg_Btn_Click(object sender, EventArgs e)
        {
            RegistrationForm regi = new RegistrationForm();
            regi.Show();
        }
    }
}
