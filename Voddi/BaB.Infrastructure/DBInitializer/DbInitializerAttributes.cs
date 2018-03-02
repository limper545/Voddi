using System;
using System.Collections.Generic;

namespace BaB.Infrastructure.DatabaseInitializer
{
    static class DbInitializerAttributes
    {

        public static String CreateClassesTbl() => "CREATE TABLE IF NOT EXISTS classes (id INTEGER PRIMARY KEY, name VARCHAR(20))";

        public static String CreateUserTbl() => "CREATE TABLE IF NOT EXISTS userManager (id INTEGER PRIMARY KEY AUTOINCREMENT, " +
            "vorname VARCHAR(30), nachname VARCHAR (30), email VARCHAR(50), username VARCHAR(20), created VARCHAR(30), lastlogin VARCHAR(30), charid INT, password VARCHAR(30))";

        public static String CreateUserCharactersTbl() => "CREATE TABLE IF NOT EXISTS charactersFromUser (id INTEGER PRIMARY KEY AUTOINCREMENT, name VARCHAR(20), userid int, charid int)";

        public static String queryCreateCharacterDetails() => "CREATE TABLE IF NOT EXISTS characterDetails " +
            "(id INTEGER PRIMARY KEY AUTOINCREMENT, charid int, atk int, leben int, def int, exp int, mana int, spd int, level int)";

        public static List<String> GetDatabaseConfigQuery => CreateDatabaseConfigInit();

        static List<String> CreateDatabaseConfigInit() => new List<String>
            {
                CreateClassesTbl(),
                CreateUserTbl(),
                CreateUserCharactersTbl(),
                queryCreateCharacterDetails()
            };
    }
}
