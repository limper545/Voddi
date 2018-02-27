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
            
            User u1 = Handler.CheckLogin(username, password);
            User u2= Handler.CheckLogin(fakeUsername, fakePassword);
            Assert.IsNotNull(u1);
            Assert.IsNull(u2);
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
            List<Classes> testClass = new List<Classes>();
            List<String> classNames = new List<String>();
            testClass = Handler.GetAllClasses();
            Assert.AreEqual(testClass.Count, 3);
            testClass.ForEach(item =>
            {
                classNames.Add(item.Name);
            });
            Assert.AreEqual(classNames.Contains("Magier"), true);
            Assert.AreEqual(classNames.Contains("Krieger"), true);
            Assert.AreEqual(classNames.Contains("Ranger"), true);
            Assert.AreEqual(classNames.Contains("Sascha"), false);
        }
    }
}
