using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sweepstakes;

namespace Sweepstakes_test
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void EmailValidation_UserSuppliesOnlyAtDot()
        {
            Uservalidation val = new Uservalidation();
            string email = ".@";
            bool expected = false;
            bool actual;


            actual = val.ValidateEmail(email);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EmailValidation_UserSuppliesEmptyEmail()
        {
            Uservalidation val = new Uservalidation();
            string email = "";
            bool expected = false;
            bool actual;


            actual = val.ValidateEmail(email);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EmailValidation_UserSuppliesValidEmail()
        {
            Uservalidation val = new Uservalidation();
            string email = "name.last@domain.com";
            bool expected = true;
            bool actual;


            actual = val.ValidateEmail(email);

            Assert.AreEqual(expected, actual);
        }
    }
}
