using System.Configuration;
using System;
using System.Collections;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using Core;

namespace DBHandler
{

    public class Handler
    {
        public static SQLiteConnection dbConnection = new SQLiteConnection("Data Source=" + Queries.dbName + "; Version=3;");

        public static void CreateDatabase()
        {
            if (!System.IO.File.Exists(Queries.dbName)) SQLiteConnection.CreateFile(Queries.dbName);
            try
            {
                TransactionQueries.InitProjectDatabase();
            }
            catch (Exception ex)
            {
                // TODO Fehler an das Frontend melden
                throw new Exception("Fehler beim erstellen der Datenbank. Fehler: " + ex.Message);
            }
        }
        public static User CheckLogin(String username, String password)
        {
            User u = User.CreateUser(TransactionQueries.CheckIfLoginDataAreCorrect(username, password)); ;
            return u;
        }
        public static bool ExistsUser(String username) => TransactionQueries.CheckIfUserRegistered(username);

        public static bool CreateUser(String vorname, String nachname, String email, String username, String password)
        => TransactionQueries.RegisterNewUser(vorname, nachname, email, username, password);

        public static List<Tuple<String, String>> HasUserCharacters(String username)
        {
            String responseHasUserCharacter;
            responseHasUserCharacter = TransactionQueries.HasUserCharacters(username);
            if (responseHasUserCharacter.Length != 0)
            {
                return TransactionQueries.GetCharacterInformations(responseHasUserCharacter);
            }
            else
            {
                return null;
            }
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
                    if (TransactionQueries.SaveCharacterDetailsAtCreate(characterID, userID, Convert.ToInt32(classID)))
                    {
                        return TransactionQueries.SaveCharIDInUserManager(characterID, userID);

                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static GameCharacter GetGameCharacterInformations(String characterName)
        {
            String name;
            String klasse;
            String level;
            String leben;
            String exp;
            String atk;
            String mana;
            String def;
            String spd;

            List<String> gameCharacterList = TransactionQueries.GetGameCharacter(characterName);
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
