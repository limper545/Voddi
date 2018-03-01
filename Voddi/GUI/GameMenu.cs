using Core;
using DBHandler;
using System;
using System.Windows.Forms;

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

        /// <summary>
        /// Schaut ob der User schon erstellte Characters hat
        /// </summary>
        /// <param name="username"></param>
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
                    charOneBtn.Text = $"{item.Item1.ToUpper()} - {item.Item2}";
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

        /// <summary>
        /// Öffnet das CreateCharacter Fenster oder leitet weiter, wenn der User schon ein Char hat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void charOneBtn_Click(object sender, EventArgs e)
        {
            if (charOneBtn.Text == NoChar)
            {
                new CreateCharacter(u).Show();
            }
            else
            {
                var gameChar = Handler.GetGameCharacterInformations(charOneBtn.Name);
                new GameWindow(gameChar).Show();
                this.Close();
            }
        }

        /// <summary>
        /// Öffnet das CreateCharacter Fenster oder leitet weiter, wenn der User schon ein Char hat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void charTwoBtn_Click(object sender, EventArgs e)
        {
            if (charTwoBtn.Text == NoChar)
            {
                new CreateCharacter(u).Show();
            }
        }

        /// <summary>
        /// Öffnet das CreateCharacter Fenster oder leitet weiter, wenn der User schon ein Char hat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void charThreeBtn_Click(object sender, EventArgs e)
        {
            if (charThreeBtn.Text == NoChar)
            {
                new CreateCharacter(u).Show();
            }
        }
    }
}