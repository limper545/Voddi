using Core;
using GUI;
using System;
using System.Windows.Forms;
using DBHandler;
using System.Collections.Generic;

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
            // TODO Später mit mehrer Character umbauen
            List<Tuple<String, String>> characterList = Handler.HasUserCharacters(username);
            if (characterList != null)
            {
                foreach (var item in characterList)
                {
                    charOneBtn.Text = String.Format("{0} - {1}", item.Item1.ToUpper(), item.Item2);
                    charOneBtn.Name = item.Item1;
                }
                charTwoBtn.Text = NoChar;
                charThreeBtn.Text = NoChar;
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
                new CreateCharacter(u).Show();
            }
            else
            {
                new GameWindow(charOneBtn.Name).Show();
                this.Close();
            }
        }

        private void charTwoBtn_Click(object sender, EventArgs e)
        {
            if (charTwoBtn.Text == NoChar)
            {
                new CreateCharacter(u).Show();
            }
            else
            {
                new GameWindow(charTwoBtn.Name).Show();
                this.Close();
            }
        }

        private void charThreeBtn_Click(object sender, EventArgs e)
        {
            if (charThreeBtn.Text == NoChar)
            {
                new CreateCharacter(u).Show();
            }
            else
            {
                new GameWindow(charThreeBtn.Name).Show();
                this.Close();
            }
        }
    }
}
