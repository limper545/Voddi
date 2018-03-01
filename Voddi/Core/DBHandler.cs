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

        /// <summary>
        /// Leitet die DBConnection an andere Methoden weiter
        /// </summary>
        public static SQLiteConnection GetDbConnection { get => dbConnection; set => dbConnection = value; }

        /// <summary>
        /// Erstellt die DB und alle Felder/Tabellen, wenn diese noch nicht exestieren
        /// </summary>
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

        /// <summary>
        /// Logt den User in das Spiel ein und erstellt ein Timestamp 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static User CheckLogin(String username, String password)
        {
            if (String.IsNullOrEmpty(username ?? password)) throw new ArgumentNullException();

            var u = User.CreateUser(TransactionQueries.CheckIfLoginDataAreCorrect(username, password));
            TransactionQueries.CreateTimestampLogin(username);
            return u;
        }

        /// <summary>
        /// Checkt, ob es den User schon in der DB gibt 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static bool ExistsUser(String username)
        {
            Logger.Info(nameof(ExistsUser), username);
            if (String.IsNullOrEmpty(username)) throw new ArgumentNullException("username", nameof(username));

            return TransactionQueries.CheckIfUserRegistered(username);
        }

        /// <summary>
        /// Erstellt einen neuen User in der DB 
        /// </summary>
        /// <param name="vorname"></param>
        /// <param name="nachname"></param>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool CreateUser(String vorname, String nachname, String email, String username, String password)
        {
            if ((vorname ?? nachname ?? email ?? username ?? password) == null) throw new ArgumentNullException();

            return TransactionQueries.RegisterNewUser(vorname, nachname, email, username, password);
        }

        /// <summary>
        /// Schaut, ob der User schon Characters erstellt hat
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static List<Tuple<String, String>> HasUserCharacters(String username)
        {
            if (String.IsNullOrEmpty(username)) throw new ArgumentNullException("message", nameof(username));

            String responseHasUserCharacter;
            responseHasUserCharacter = TransactionQueries.HasUserCharacters(username);
            return responseHasUserCharacter.Length != 0 ? TransactionQueries.GetCharacterInformations(responseHasUserCharacter) : null;
        }

        /// <summary>
        /// Holt sich alle Klassen aus der DB
        /// </summary>
        /// <returns></returns>
        public static List<Classes> GetAllClasses() => Classes.FillListWithClasses(TransactionQueries.GetAllClasses());

        /// <summary>
        /// Erstellt einen neuen Character für einen User
        /// </summary>
        /// <param name="characterName"></param>
        /// <param name="classID"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static bool CreateCharacterForAUser(String characterName, String classID, String userID)
        {
            if (String.IsNullOrEmpty(characterName ?? classID ?? userID)) throw new ArgumentNullException();

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

        /// <summary>
        /// Holt sich die CharacterDetails für einen Character von einem User
        /// </summary>
        /// <param name="characterName"></param>
        /// <returns></returns>
        public static GameCharacter GetGameCharacterInformations(String characterName)
        {
            if (String.IsNullOrEmpty(characterName)) throw new ArgumentNullException("message", nameof(characterName));

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

        /// <summary>
        /// Speichert den Character in die DB
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool SaveNewCharacterAttributes(GameCharacter c)
        {
            if (c == null) throw new ArgumentNullException("message", nameof(c));
            return TransactionQueries.SaveCharacter(c);
        }
    }
}