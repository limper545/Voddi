using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class GameWindow : Form
    {
        public String name = String.Empty;
        public GameWindow(String characterName)
        {
            this.name = characterName;
            InitializeComponent();
            // TODO Character Object erstellen
        }

        private void CharacterDetails_Click(object sender, EventArgs e)
        {
            // TODO Character Object übergeben
            new DetailsCharacter().Show();
        }
    }
}
