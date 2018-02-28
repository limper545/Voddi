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

        static void Login_Btn_Click_1(object sender, EventArgs e) => new LoginDataForm().Show();

        static void reg_Btn_Click(object sender, EventArgs e) => new RegistrationForm().Show();
    }
}
