
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaB_1._0.GUI
{
    public partial class GameMenu : Form
    {
        public String username;
        public string NoChar = "-- Leer --";
        public GameMenu(String username)
        {
            this.username = username;
            InitializeComponent();
            labelWelcome.Text = "Willkommen " + username;
            GetUserCharacterInformations(username);
        }

        void GetUserCharacterInformations(String username)
        {
            if (DBHandler.HasUserCharacters(username))
            {

            }
            else
            {
                charOneBtn.Text = NoChar;
                charTwoBtn.Text = NoChar;
                charThreeBtn.Text = NoChar;
            }
        }

        private void charOneBtn_Click(object sender, EventArgs e)
        {
            if (charOneBtn.Text == NoChar)
            {
                CreateCharacter charC = new CreateCharacter(username);
                charC.Show();
            }
        }

        private void charTwoBtn_Click(object sender, EventArgs e)
        {
            if (charTwoBtn.Text == NoChar)
            {
                CreateCharacter charC = new CreateCharacter(username);
                charC.Show();
            }
        }

        private void charThreeBtn_Click(object sender, EventArgs e)
        {
            if (charThreeBtn.Text == NoChar)
            {
                CreateCharacter charC = new CreateCharacter(username);
                charC.Show();
            }
        }
    }
}
