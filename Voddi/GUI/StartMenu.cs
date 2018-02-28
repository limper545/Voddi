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
            DBHandler.Handler.CreateDatabase();
          
            gameTitleLabel.Text = "BaB";
            gameTitleLabel.BackColor = Color.Transparent;
        }

        void close_Btn_Click(object sender, EventArgs e) => this.Close();

        void Login_Btn_Click_1(object sender, EventArgs e)
        {
            using (var loginForm = new LoginDataForm())
            {
                loginForm.StartPosition = FormStartPosition.CenterParent;
                loginForm.Show(this);
            }
        }

        static void reg_Btn_Click(object sender, EventArgs e) => new RegistrationForm().Show();
    }
}
