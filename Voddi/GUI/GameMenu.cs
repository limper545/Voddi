
using DBHandler;
using GUI;
using System;
using System.Windows.Forms;

namespace GUI
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
            if (Handler.HasUserCharacters(username))
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
                new CreateCharacter(username: username).Show();
        }

        private void charTwoBtn_Click(object sender, EventArgs e)
        {
            if (charTwoBtn.Text == NoChar)
                new CreateCharacter(username: username).Show();
        }

        private void charThreeBtn_Click(object sender, EventArgs e)
        {
            if (charThreeBtn.Text == NoChar)
                new CreateCharacter(username: username).Show();
        }
    }
}
