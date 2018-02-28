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
        }

        public GameCharacter Character { get => character; set => character = value; }
        public new string Name { get => name; set => name = value; }

        /// <summary>
        /// Öffnet das Fenster für die Details eines Characters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CharacterDetails_Click(object sender, EventArgs e)
        {
            new DetailsCharacter(Character).Show();
        }

        void fightBtn_Click(object sender, EventArgs e)
        {
            var newExp = Convert.ToInt64(Character.Exp);
            int newLevel;
            newExp += 50;
            if (newExp ==  ExpLevelMapper.CalculateExp(Character.Level))
            {
                newLevel = Convert.ToInt32(Character.Level) + 1;
                Character.Level = newLevel.ToString();
            }
            Character.Exp = newExp.ToString();
        }
    }
}