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
        }


    }
}
