using System;
using UserRegistrationProblem;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class MatchingPatternsTest
    {
        /// <summary>
        /// Validating the inputs to test with First name regex patterns.
        /// </summary>
        /// <param name="firstNameInput"></param>
        [TestCategory("First Name")]
        [TestMethod]
        [DataRow("Vishal")]
        [DataRow("vishal")]
        [DataRow("vis")]
        [DataRow("Vis")]
        [DataRow("V")]
        [DataRow("")]
        [DataRow(null)]
        public void TestingFirstName(string firstNameInput)
        {
            //Arrange
            UserRegistration userRegistration = new UserRegistration();
            try
            {

                //Act
                bool expected = userRegistration.FirstAndLastName(firstNameInput);
                //Arrange
                Assert.IsTrue(expected, firstNameInput);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual(ex.Message, "invalid name");
            }
        }
        /// <summary>
        /// Validating the inputs to test with last name regex patterns.
        /// </summary>
        /// <param name="lastNameInput"></param>
        [TestCategory("Last Name")]
        [TestMethod]
        [DataRow("garg")]
        public void TestingLastName(string lastNameInput)
        {
            //Arrange
            UserRegistration userRegistration = new UserRegistration();
            try
            {
                //Act
                bool expected = userRegistration.FirstAndLastName(lastNameInput);
                //Arrange
                Assert.IsTrue(expected, lastNameInput);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual(ex.Message, "invalid name");
            }

        }
        /// <summary>
        /// Validating the inputs to test with email regex patterns.
        /// </summary>
        /// <param name="emailInput"></param>

        [TestMethod]
        [DataRow("")]
        [DataRow(null)]
        [DataRow("vishal.garg@capgemini.com")]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc111@yahoo.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc+100@gmail.com")]
        [DataRow("abc")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void TestingEmail(string emailInput)
        {
            try
            {
                //Arrange
                UserRegistration userRegistration = new UserRegistration();
                //Act
                bool expected = userRegistration.Email(emailInput);
                //Arrange
                Assert.IsTrue(expected, emailInput);
            }
            catch (UserRegistrationCustomException ue)
            {
                Assert.AreEqual(ue.Message, "invalid email");
            }
        }
        /// <summary>
        /// Validating the inputs to test with mobile number regex patterns.
        /// </summary>
        /// <param name="mobileNoInput"></param>
        [TestMethod]
        [DataRow("91 8570934858")]
        [DataRow("")]
        [DataRow(null)]
        public void TestingMobileNo(string mobileNoInput)
        {
            try
            {
                //Arrange
                UserRegistration userRegistration = new UserRegistration();
                //Act
                bool expected = userRegistration.MobileNo(mobileNoInput);
                //Arrange
                Assert.IsTrue(expected, mobileNoInput);
            }
            catch (UserRegistrationCustomException ue)
            {
                Assert.AreEqual(ue.Message, "invalid phone");
            }
        }
        /// <summary>
        /// Validating the inputs to test with password regex patterns.
        /// </summary>
        /// <param name="passwordInput"></param>
        [TestMethod]
        [DataRow("vishalgargVisGarg111")]
        [DataRow("")]
        [DataRow(null)]
        public void TestingPassword(string passwordInput)
        {
            try
            {
                //Arrange
                UserRegistration userRegistration = new UserRegistration();
                //Act
                bool expected = userRegistration.Password(passwordInput);
                //Arrange
                Assert.IsTrue(expected, passwordInput);
            }
            catch (UserRegistrationCustomException ue)
            {
                Assert.AreEqual(ue.Message, "invalid password");
            }
        }
    }

    internal class TestClassAttribute : Attribute
    {
    }
}