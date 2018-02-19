using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DBHandler;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;

// TODO Tests Anpassen
namespace SQL_Statements_Tests
{
    [TestClass]
    public class UnitTest1
    {
        public String username;
        public String password;
        public String fakeUsername;
        public String fakePassword;
        public List<String> testListForUnitTests;
        [TestInitialize]
        public void Initialize()
        {
            username = "a";
            password = "a";

            fakeUsername = "b";
            fakePassword = "b";
            List<String> testListForUnitTests = new List<String> { "Magier", "Krieger", "Ranger" };
            //Handler.CreateUser("a", "a", "a", username, password);
        }

        [TestMethod]
        public void Is_User_Registered_Or_Not()
        {
            bool responseOne = Handler.ExistsUser(username);
            bool responseTwo = Handler.ExistsUser(fakeUsername);
            Assert.AreEqual(responseOne, true);
            Assert.AreEqual(responseTwo, false);
        }

        [TestMethod]
        public void Can_A_RegisteredUserLogin_And_Not_Registered_User_Not()
        {
            bool responseOne = Handler.CheckLogin(username, password);
            bool responseTwo = Handler.CheckLogin(fakeUsername, fakePassword);
            Assert.AreEqual(responseOne, true);
            Assert.AreEqual(responseTwo, false);
        }

        [TestMethod]
        public void Has_A_User_Characters_Or_Not()
        {
            bool responseOne = Handler.HasUserCharacters(username);
            bool responseTwo = Handler.HasUserCharacters(fakeUsername);
            Assert.AreEqual(responseOne, true);
            Assert.AreEqual(responseTwo, false);
        }

        [TestMethod]
        public void Check_If_All_Classes_Are_Correct()
        {
            List<String> testClass = new List<string>();
            testClass = Handler.GetAllClasses();
            Assert.AreEqual(testClass.Count, 3);
            Assert.AreEqual(testClass.Contains("Magier"), true);
            Assert.AreEqual(testClass.Contains("Krieger"), true);
            Assert.AreEqual(testClass.Contains("Ranger"), true);
            Assert.AreEqual(testClass.Contains("Sascha"), false);
        }
    }
}
