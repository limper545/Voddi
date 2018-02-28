using Core;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics.Contracts;

namespace DBHandler
{
    public static class Handler
    {
        static SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + Queries.GetDbName + "; Version=3;");

        public static SQLiteConnection GetDbConnection { get => dbConnection; set => dbConnection = value; }

        public static void CreateDatabase()
        {
            if (!System.IO.File.Exists(Queries.GetDbName)) SQLiteConnection.CreateFile(Queries.GetDbName);
            try
            {
                TransactionQueries.InitProjectDatabase();
            }
            catch (Exception ex)
            {
                // TODO Fehler an das Frontend melden
                throw ex;
            }
        }

        public static User CheckLogin(String username, String password)
        {
            var u = User.CreateUser(TransactionQueries.CheckIfLoginDataAreCorrect(username, password)); ;
            return u;
        }

        public static bool ExistsUser(String username) => TransactionQueries.CheckIfUserRegistered(username);

        public static bool CreateUser(String vorname, String nachname, String email, String username, String password)
        => TransactionQueries.RegisterNewUser(vorname, nachname, email, username, password);

        public static List<Tuple<String, String>> HasUserCharacters(String username)
        {
            String responseHasUserCharacter;
            responseHasUserCharacter = TransactionQueries.HasUserCharacters(username);
            return responseHasUserCharacter.Length != 0 ? TransactionQueries.GetCharacterInformations(responseHasUserCharacter) : null;
        }

        public static List<Classes> GetAllClasses() => Classes.FillListWithClasses(TransactionQueries.GetAllClasses());

        public static bool CreateCharacterForAUser(String characterName, String classID, String userID)
        {
            bool responseSaveCharacter;
            String characterID;
            responseSaveCharacter = TransactionQueries.CreateCharacterForUser(characterName, classID, userID);
            if (responseSaveCharacter)
            {
                characterID = TransactionQueries.GetCharID(Convert.ToInt32(userID));
                if (characterID.Length != 0)
                {
                    if (TransactionQueries.SaveCharacterDetailsAtCreate(characterID, Convert.ToInt32(classID)))
                    {
                        return TransactionQueries.SaveCharIDInUserManager(characterID, userID);
                    }
                    return false;
                }
                return false;
            }
            return false;
        }

        public static GameCharacter GetGameCharacterInformations(String characterName)
        {
            Contract.Ensures(Contract.Result<GameCharacter>() != null);
            if (string.IsNullOrEmpty(characterName))
            {
                throw new ArgumentException("message", nameof(characterName));
            }
            String name;
            String klasse;
            String level;
            String leben;
            String exp;
            String atk;
            String mana;
            String def;
            String spd;

            var gameCharacterList = TransactionQueries.GetGameCharacter(characterName);
            name = gameCharacterList[0];
            klasse = gameCharacterList[1];
            level = gameCharacterList[2];
            leben = gameCharacterList[3];
            exp = gameCharacterList[4];
            atk = gameCharacterList[5];
            mana = gameCharacterList[6];
            def = gameCharacterList[7];
            spd = gameCharacterList[8];

            return new GameCharacter(name, klasse, level, leben, exp, atk, mana, def, spd);
        }
    }
}