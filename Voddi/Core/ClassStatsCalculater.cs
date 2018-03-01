using DBHandler;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class ClassStatsCalculater
    {
        /// <summary>
        /// Calculiert die Exp, die benötigt wird, für das Level up
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public static int CalculateExp(String level)
        {
            if (string.IsNullOrEmpty(level))
            {
                Logger.Error("ClassStatsCalculater.CalculateExp", "Null Exception");
                throw new ArgumentNullException(nameof(level), nameof(level));
            }
            return (int)(10 * 10 * Convert.ToInt64(level) * (1 + Convert.ToDouble(level) / 10));
            //return newExp = (int)(10 * 10 * Convert.ToInt64(level));
        }

        /// <summary>
        /// Passt alle Daten des Characters nach dem Levelup an und speichert diese in die DB
        /// </summary>
        /// <param name="character"></param>
        public static void CharacterLevelUp(GameCharacter character)
        {
            if (character == null)
            {
                Logger.Error("ClassStatsCalculater.CharacterLevelUp", "Null Exception");
                throw new ArgumentNullException(nameof(character));
            }

            var newLevel = Convert.ToInt32(character.Level);
            var newLife = Convert.ToDouble(character.Leben) * 1.2;
            var newMana = Convert.ToDouble(character.Mana) * 1.2;
            var newAtk = Convert.ToDouble(character.Atk) * 1.2;
            var newDef = Convert.ToDouble(character.Def) * 1.2;
            var newSpd = Convert.ToDouble(character.Spd) * 1.2;

            character.Level = (newLevel + 1).ToString();
            character.Exp = "0";
            character.Leben = Math.Round(newLife, 2).ToString();
            character.Mana = Math.Round(newMana, 2).ToString();
            character.Atk = Math.Round(newAtk, 2).ToString();
            character.Def = Math.Round(newDef, 2).ToString();
            character.Spd = Math.Round(newSpd, 2).ToString();
            //Handler.SaveNewCharacterAttributes(character);
        }
    }
}
