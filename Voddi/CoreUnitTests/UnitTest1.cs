using Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            var result = Validations.CheckRegistrationValidation(vorname, nachname, email, user, passwordOne, passwordTwo);
            Assert.AreEqual("OK", result);
        }

        [TestMethod]
        public void Check_If_Password_Is_Empty()
        {
            String result;
            result = Validations.CheckRegistrationValidation(vorname, nachname, email, user, passwordOne, "");
            Assert.AreEqual("Passwort", result);

            result = Validations.CheckRegistrationValidation(vorname, nachname, email, user, "", "");
            Assert.AreEqual("Passwort", result);

            result = Validations.CheckRegistrationValidation(vorname, nachname, email, user, "", passwordTwo);
            Assert.AreEqual("Passwort", result);
        }

        [TestMethod]
        public void Check_If_Username_Is_Empty()
        {
            var result = Validations.CheckRegistrationValidation(vorname, nachname, email, "", passwordOne, passwordTwo);
            Assert.AreEqual("Username", result);
        }

        [TestMethod]
        public void Check_If_Email_Is_Empty()
        {
            var result = Validations.CheckRegistrationValidation(vorname, nachname, "", user, passwordOne, passwordTwo);
            Assert.AreEqual("E-Mail Adresse", result);
        }

        [TestMethod]
        public void Check_If_Nachname_Is_Empty()
        {
            var result = Validations.CheckRegistrationValidation(vorname, "", email, user, passwordOne, passwordTwo);
            Assert.AreEqual("Nachname", result);
        }

        [TestMethod]
        public void Check_If_Vorname_Is_Empty()
        {
            var result = Validations.CheckRegistrationValidation("", nachname, email, user, passwordOne, passwordTwo);
            Assert.AreEqual("Vorname", result);
        }

        [TestMethod]
        public void Check_If_Email_Is_Correct_Format()
        {
            bool response;
            response = Validations.CorrectEmailFormat(email);
            Assert.AreEqual(true, response);

            response = Validations.CorrectEmailFormat("test@test.t");
            Assert.AreEqual(false, response);

            response = Validations.CorrectEmailFormat("test@test.");
            Assert.AreEqual(false, response);

            response = Validations.CorrectEmailFormat("test@test");
            Assert.AreEqual(false, response);

            response = Validations.CorrectEmailFormat("test@");
            Assert.AreEqual(false, response);

            response = Validations.CorrectEmailFormat("tes");
            Assert.AreEqual(false, response);
        }
    }
}