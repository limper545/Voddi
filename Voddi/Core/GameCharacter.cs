using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class GameCharacter
    {
        #region Variablen für Character
        public String Name { get; set; }
        public string Klasse { get; set; }
        public String Leben { get; set; }
        public String Level { get; set; }
        public String Exp { get; set; }
        public String Atk { get; set; }
        public String Mana { get; set; }
        public String Def { get; set; }
        public String Spd { get; set; }
        #endregion

        GameCharacter()
        {

        }

        /// <summary>
        /// Constructor für einen Character
        /// </summary>
        /// <param name="name"></param>
        /// <param name="klasse"></param>
        /// <param name="level"></param>
        /// <param name="leben"></param>
        /// <param name="exp"></param>
        /// <param name="atk"></param>
        /// <param name="mana"></param>
        /// <param name="def"></param>
        /// <param name="spd"></param>
        public GameCharacter(String name, String klasse, String level, String leben, String exp, String atk, String mana, String def, String spd)
        {
            Name = name;
            Klasse = klasse;
            Leben = leben;
            Level = level;
            Exp = exp;
            Atk = atk;
            Mana = mana;
            Def = def;
            Spd = spd;
        }
    }
}
