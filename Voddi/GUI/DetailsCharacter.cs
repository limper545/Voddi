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
            InitProgressBarProperties();
            // TODO Glow Animation löschen irgendwie
        }

        private void SetTextForLabels()
        {
            HPLabelName.Text = "HP: ";
            LevelLabelName.Text = "Level: ";
            EXPLabelName.Text = "EXP: ";
            RExpLabelName.Text = "Rest EXP: ";

            ATKLabelName.Text = "ATK: ";
            ManaLabelName.Text = "Mana: ";
            DefLabelName.Text = "DEF: ";
            SPDLabelName.Text = "SPD: ";
        }

        private void InitProgressBarProperties()
        {
            LabelEXPName.Text = "EXP: ";
            ExpValues.Text = " 10 / 1230";
            ExpBar.Maximum = 100;
            ExpBar.Value = 70;
        }
    }
}
