using Core;
using System.Windows.Forms;
using System;

namespace GUI
{
    public partial class DetailsCharacter : Form
    {
        public GameCharacter character;
        public DetailsCharacter(GameCharacter c)
        {
            this.character = c;
            InitializeComponent();
            InitProgressBarProperties();
            SetTextForLabels();
            SetAttributesForDetails(c);
            // TODO Glow Animation löschen irgendwie
        }

        private void SetAttributesForDetails(GameCharacter c)
        {
            HPLabelValue.Text = c.Leben;
            LevelLabelValue.Text = c.Level;
            EXPLabelValue.Text = c.Exp;
            ExpValues.Text = c.Exp;
            RExpLabelValue.Text = "0";
            ATKLabelValue.Text = c.Atk;
            ManaLabelValue.Text = c.Mana;
            DefLabelValue.Text = c.Def;
            SPDLabelValue.Text = c.Spd;
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

        private void CharacterStatus_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
