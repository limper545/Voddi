using Core;
using System.Windows.Forms;
using System;

namespace GUI
{
    public partial class DetailsCharacter : Form
    {
        GameCharacter character;
        static Timer myTimer = new Timer();
        public GameCharacter Character { get => character; set => character = value; }

        public DetailsCharacter(GameCharacter c)
        {
            myTimer.Interval = 100;
            myTimer.Tick += new EventHandler(InterValFunction);
            myTimer.Enabled = true;
            Character = c;
            InitializeComponent();
            InitProgressBarProperties();
            SetTextForLabels();
            SetAttributesForDetails();
            SetCharacterImage();
            //C
            // TODO Glow Animation löschen irgendwie
        }

        /// <summary>
        /// Setzt das Character Image anhand der Klasse des Users
        /// </summary>
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

        /// <summary>
        /// Setzt die Attribute in der Form für den Character
        /// </summary>
        void SetAttributesForDetails()
        {
            HPLabelValue.Text = Character.Leben;
            EXPLabelValue.Text = Character.Exp;
            ExpValues.Text = Character.Exp;
            RExpLabelValue.Text = "0";
            ATKLabelValue.Text = Character.Atk;
            ManaLabelValue.Text = Character.Mana;
            DefLabelValue.Text = Character.Def;
            SPDLabelValue.Text = Character.Spd;
        }

        /// <summary>
        /// Setzt den Text in der Form für die Attribute
        /// </summary>
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

        /// <summary>
        /// Zeigt die EXP in einer Bar an 
        /// </summary>
        void InitProgressBarProperties()
        {
            LabelEXPName.Text = "EXP: ";
        }

        static void CharacterStatus_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotSupportedException();
        }

        void InterValFunction(object sender, EventArgs e)
        {
            try
            {
                var valueExp = (int)Convert.ToInt64(Character.Exp);
                var fullExp = ExpLevelMapper.CalculateExp(Character.Level);
                ExpBar.Value = valueExp;
                EXPLabelValue.Text = Character.Exp;
                ExpValues.Text = Character.Exp;
                ExpValues.Text = $"{valueExp} / {fullExp}";
                ExpBar.Maximum = fullExp;
                LevelLabelValue.Text = Character.Level;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
