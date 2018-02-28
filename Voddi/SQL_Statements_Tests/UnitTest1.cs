using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DBHandler;
using System.Collections.Generic;
using Core;

namespace SQL_Statements_Tests
{
    [TestClass]
    public class UnitTest1
    {
        String username;
        String password;
        String fakeUsername;
        String fakePassword;

        [TestInitialize]
        public void Initialize()
        {
            Handler.CreateDatabase();
            username = "a";
            password = "a";

            fakeUsername = "b";
            fakePassword = "b";
        }

        [TestMethod]
        public void Is_User_Registered_Or_Not()
        {
            var responseOne = Handler.ExistsUser(username);
            var responseTwo = Handler.ExistsUser(fakeUsername);
            Assert.AreEqual(true, responseOne);
            Assert.AreEqual(false, responseTwo);
        }

        [TestMethod]
        public void Can_A_RegisteredUserLogin_And_Not_Registered_User_Not()
        {
            var u1 = Handler.CheckLogin(username, password);
            var u2 = Handler.CheckLogin(fakeUsername, fakePassword);
            Assert.IsNotNull(u1);
            Assert.IsNull(u2);
        }

        [TestMethod]
        public void Has_A_User_Characters_Or_Not()
        {
            /*bool responseOne = Handler.HasUserCharacters(username);
            bool responseTwo = Handler.HasUserCharacters(fakeUsername);
            Assert.AreEqual(responseOne, true);
            Assert.AreEqual(responseTwo, false);*/
        }

        [TestMethod]
        public void Check_If_All_Classes_Are_Correct()
        {
            List<Classes> testClass;
            var classNames = new List<String>();
            testClass = Handler.GetAllClasses();
            Assert.AreEqual(3, testClass.Count);
            testClass.ForEach(item =>
            {
                classNames.Add(item.Name);
            });
            Assert.AreEqual(true, classNames.Contains("Magier"));
            Assert.AreEqual(true, classNames.Contains("Krieger"));
            Assert.AreEqual(true, classNames.Contains("Ranger"));
            Assert.AreEqual(false, classNames.Contains("Sascha"));
        }
    }
}