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

        private void CharacterDetails_Click(object sender, EventArgs e)
        {
            using (var detailsCharacter =
                        // TODO Character Object übergeben
                        new DetailsCharacter(Character))
            {
                detailsCharacter.Show();
            }
        }
    }
}
