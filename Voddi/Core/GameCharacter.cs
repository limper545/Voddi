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

        public GameCharacter()
        {

        }

        public GameCharacter(String name, String klasse, String level, String leben, String exp, String atk, String mana, String def, String spd)
        {
            this.Name = name;
            this.Klasse = klasse;
            this.Leben = leben;
            this.Level = level;
            this.Exp = exp;
            this.Atk = atk;
            this.Mana = mana;
            this.Def = def;
            this.Spd = spd;
        }
    }
}
