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
            int newExp;
            Contract.Ensures(Contract.Result<string>() != null);
            if (string.IsNullOrEmpty(level))
            {
                throw new ArgumentException("message", nameof(level));
            }
            return newExp = (int)(10 * 10 * Convert.ToInt64(level));
        }

        /// <summary>
        /// Passt alle Daten des Characters nach dem Levelup an und speichert diese in die DB
        /// </summary>
        /// <param name="character"></param>
        public static void CharacterLevelUp(GameCharacter character)
        {
            var newLevel = Convert.ToInt32(character.Level);
            var newExp = Convert.ToInt32(character.Exp);
            var newLife = Convert.ToInt32(character.Leben);
            var newMana = Convert.ToInt32(character.Mana);
            var newAtk = Convert.ToInt32(character.Atk);
            var newDef = Convert.ToInt32(character.Def);
            var newSpd = Convert.ToInt32(character.Spd);

            character.Level = (newLevel + 1).ToString();

        }
    }
}
