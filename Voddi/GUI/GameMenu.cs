using Core;
using GUI;
using System;
using System.Windows.Forms;
using DBHandler;

namespace GUI
{
    public partial class GameMenu : Form
    {
        public User u;
        public string NoChar = "-- Leer --";
        public string name;
        public GameMenu(User username)
        {
            this.u = username;
            InitializeComponent();
            labelWelcome.Text = "Willkommen " + u.Name;
            GetUserCharacterInformations(u.Name);
        }

        public void GetUserCharacterInformations(String username)
        {
            if (Handler.HasUserCharacters(username))
            {
                Console.WriteLine();
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
                new CreateCharacter(u).Show();
        }

        private void charTwoBtn_Click(object sender, EventArgs e)
        {
            if (charTwoBtn.Text == NoChar)
                new CreateCharacter(u).Show();
        }

        private void charThreeBtn_Click(object sender, EventArgs e)
        {
            if (charThreeBtn.Text == NoChar)
                new CreateCharacter(u).Show();
        }
    }
}
