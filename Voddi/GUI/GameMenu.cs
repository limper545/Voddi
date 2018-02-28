using Core;
using System;
using System.Windows.Forms;
using DBHandler;
using System.Collections.Generic;

namespace GUI
{
    public partial class GameMenu : Form
    {
        User u;
        String noChar = "-- Leer --";
        String name1;

        public User U { get => u; set => u = value; }
        public string Name1 { get => name1; set => name1 = value; }
        public string NoChar { get => noChar; set => noChar = value; }

        public GameMenu(User username)
        {
            U = username;
            InitializeComponent();
            labelWelcome.Text = "Willkommen " + U.Name;
            GetUserCharacterInformations(U.Name);
        }

        public void GetUserCharacterInformations(String username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("message", nameof(username));
            }
            // TODO Später mit mehrer Character umbauen
            var characterList = Handler.HasUserCharacters(username);
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

        void charOneBtn_Click(object sender, EventArgs e)
        {
            if (charOneBtn.Text == NoChar)
            {
                using (var createCharacter = new CreateCharacter(U))
                {
                    createCharacter.Show();
                }
            }
            else
            {
                var gameChar = Handler.GetGameCharacterInformations(charOneBtn.Name);
                using (var gameWindow = new GameWindow(gameChar))
                {
                    gameWindow.Show();
                    this.Close();
                }
            }
        }

        void charTwoBtn_Click(object sender, EventArgs e)
        {
            if (charTwoBtn.Text == NoChar)
            {
                using (var createCharacter = new CreateCharacter(U))
                {
                    createCharacter.Show();
                }
            }
        }

        private void charThreeBtn_Click(object sender, EventArgs e)
        {
            if (charThreeBtn.Text == NoChar)
            {
                using (var createCharacter = new CreateCharacter(U))
                {
                    createCharacter.Show();
                }
            }
        }
    }
}
