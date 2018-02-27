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
            SetAttributesForDetails();
            SetCharacterImage();
            //C
            // TODO Glow Animation löschen irgendwie
        }

        private void SetCharacterImage()
        {
            switch (character.Klasse)
            {
                case "Magier":
                    CharacterImagePanel.BackgroundImage = Properties.Resources.image_2018_02_23__1_;
                    break;
                case "Ranger":
                    CharacterImagePanel.BackgroundImage = Properties.Resources.image_2018_02_23__2_;
                    break;
                case "Krieger":
                    CharacterImagePanel.BackgroundImage = Properties.Resources.image_2018_02_23__3_;
                    break;
            }
        }

        private void SetAttributesForDetails()
        {
            HPLabelValue.Text = character.Leben;
            LevelLabelValue.Text = character.Level;
            EXPLabelValue.Text = character.Exp;
            ExpValues.Text = character.Exp;
            RExpLabelValue.Text = "0";
            ATKLabelValue.Text = character.Atk;
            ManaLabelValue.Text = character.Mana;
            DefLabelValue.Text = character.Def;
            SPDLabelValue.Text = character.Spd;
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
