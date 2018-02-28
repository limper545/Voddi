using Core;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class GameWindow : Form
    {
        String name = "";
        GameCharacter character;
        public GameWindow(GameCharacter cha)
        {
            Character = cha;
            InitializeComponent();
            // TODO Character Object erstellen
        }

        public GameCharacter Character { get => character; set => character = value; }
        public new string Name { get => name; set => name = value; }

        /// <summary>
        /// Öffnet das Fenster für die Details eines Characters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CharacterDetails_Click(object sender, EventArgs e) => new DetailsCharacter(Character).Show();
    }
}
