using System;
using System.Drawing;
using System.Windows.Forms;


namespace GUI
{
    public partial class StartMenu : Form
    {
        DBGUIHandler handler = new DBGUIHandler();
        public StartMenu()
        {
            InitializeComponent();
            dbConnection.Text = handler.GetConnectionStatus();
            dbConnection.BackColor = Color.Transparent;

            gameTitleLabel.Text = "BaB";
            gameTitleLabel.BackColor = Color.Transparent;
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            handler.LoginDataCorrect("a", "b");
        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Btn_Click_1(object sender, EventArgs e)
        {
            loginDataForm loginForm = new loginDataForm();
            loginForm.StartPosition = FormStartPosition.CenterParent;
            loginForm.Show(this);
        }

        private void reg_Btn_Click(object sender, EventArgs e)
        {
            registrationForm regi = new registrationForm();
            regi.Show();
        }
    }
}
