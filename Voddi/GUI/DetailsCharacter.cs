using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DetailsCharacter : Form
    {
        public DetailsCharacter()
        {
            InitializeComponent();
            ExpValues.Text = " 10 / 1230";
            ExpBar.Maximum = 100;
            ExpBar.Value = 70;
            // TODO Glow Animation löschen irgendwie
        }
    }
}
