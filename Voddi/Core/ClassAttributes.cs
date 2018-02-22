using System;
using System.Collections.Generic;

namespace Core
{
    class ClassAttributes
    {
        //out int level, out int leben, out int exp, out int atk, out int mana, out int def, out int spd
        public static void GetClassAttributes(byte classID, out int level, out int leben, out int exp, out int atk, out int mana, out int def, out int spd)
        {
            switch (classID)
            {
                case 1:
                    level = 1;
                    leben = 9;
                    exp = 0;
                    atk = 9;
                    mana = 8;
                    def = 7;
                    spd = 10;
                    break;
                case 2:
                    level = 1;
                    leben = 10;
                    exp = 0;
                    atk = 10;
                    mana = 10;
                    def = 6;
                    spd = 10;
                    break;
                case 3:
                    level = 1;
                    leben = 10;
                    exp = 0;
                    atk = 8;
                    mana = 5;
                    def = 10;
                    spd = 10;
                    break;
                default:
                    level = 0;
                    leben = 0;
                    exp = 0;
                    atk = 0;
                    mana = 0;
                    def = 0;
                    spd = 0;
                    break;
            }
        }
    }
}
