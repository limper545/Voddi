using Core;
using System.Windows.Forms;
using System;

namespace GUI
{
    public partial class DetailsCharacter : Form
    {
        GameCharacter character;

        public GameCharacter Character { get => character; set => character = value; }

        public DetailsCharacter(GameCharacter c)
        {
            Character = c;
            InitializeComponent();
            InitProgressBarProperties();
            SetTextForLabels();
            SetAttributesForDetails();
            SetCharacterImage();
            //C
            // TODO Glow Animation löschen irgendwie
        }

        void SetCharacterImage()
        {
            switch (Character.Klasse)
            {
                case "Magier":
                    {
                        CharacterImagePanel.BackgroundImage = Properties.Resources.image_2018_02_23__1_;
                        break;
                    }
                case "Ranger":
                    {
                        CharacterImagePanel.BackgroundImage = Properties.Resources.image_2018_02_23__2_;
                        break;
                    }
                case "Krieger":
                    {
                        CharacterImagePanel.BackgroundImage = Properties.Resources.image_2018_02_23__3_;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        void SetAttributesForDetails()
        {
            HPLabelValue.Text = Character.Leben;
            LevelLabelValue.Text = Character.Level;
            EXPLabelValue.Text = Character.Exp;
            ExpValues.Text = Character.Exp;
            RExpLabelValue.Text = "0";
            ATKLabelValue.Text = Character.Atk;
            ManaLabelValue.Text = Character.Mana;
            DefLabelValue.Text = Character.Def;
            SPDLabelValue.Text = Character.Spd;
        }

        void SetTextForLabels()
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

        static void CharacterStatus_Paint(object sender, PaintEventArgs e)
        {
            throw new NotSupportedException();
        }
    }
}
