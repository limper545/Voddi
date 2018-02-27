using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;

namespace CoreUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        public String vorname, nachname, email, user, passwordOne, passwordTwo;
        [TestInitialize]
        public void Initialize()
        {
            vorname = "Sascha";
            nachname = "Test";
            email = "test@test.de";
            user = "a";
            passwordOne = "a";
            passwordTwo = "a";
        }
        [TestMethod]
        public void Check_If_String_Is_Empty_Or_Not()
        {
            String result = Validations.CheckRegistrationValidation(vorname, nachname, email, user, passwordOne, passwordTwo);
            Assert.AreEqual(result, "OK");
        }

        [TestMethod]
        public void Check_If_Password_Is_Empty()
        {
            String result;
            result = Validations.CheckRegistrationValidation(vorname, nachname, email, user, passwordOne, "");
            Assert.AreEqual(result, "Passwort");

            result = Validations.CheckRegistrationValidation(vorname, nachname, email, user, "", "");
            Assert.AreEqual(result, "Passwort");

            result = Validations.CheckRegistrationValidation(vorname, nachname, email, user, "", passwordTwo);
            Assert.AreEqual(result, "Passwort");
        }

        [TestMethod]
        public void Check_If_Username_Is_Empty()
        {
            String result = Validations.CheckRegistrationValidation(vorname, nachname, email, "", passwordOne, passwordTwo);
            Assert.AreEqual(result, "Username");
        }

        [TestMethod]
        public void Check_If_Email_Is_Empty()
        {
            String result = Validations.CheckRegistrationValidation(vorname, nachname, "", user, passwordOne, passwordTwo);
            Assert.AreEqual(result, "E-Mail Adresse");
        }

        [TestMethod]
        public void Check_If_Nachname_Is_Empty()
        {
            String result = Validations.CheckRegistrationValidation(vorname, "", email, user, passwordOne, passwordTwo);
            Assert.AreEqual(result, "Nachname");
        }

        [TestMethod]
        public void Check_If_Vorname_Is_Empty()
        {
            String result = Validations.CheckRegistrationValidation("", nachname, email, user, passwordOne, passwordTwo);
            Assert.AreEqual(result, "Vorname");
        }

        [TestMethod]
        public void Check_If_Email_Is_Correct_Format()
        {
            bool response;
            response = Validations.CorrectEmailFormat(email);
            Assert.AreEqual(response, true);

            response = Validations.CorrectEmailFormat("test@test.t");
            Assert.AreEqual(response, false);

            response = Validations.CorrectEmailFormat("test@test.");
            Assert.AreEqual(response, false);

            response = Validations.CorrectEmailFormat("test@test");
            Assert.AreEqual(response, false);

            response = Validations.CorrectEmailFormat("test@");
            Assert.AreEqual(response, false);

            response = Validations.CorrectEmailFormat("tes");
            Assert.AreEqual(response, false);
        }
    }
}
