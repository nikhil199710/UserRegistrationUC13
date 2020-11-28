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
        [TestMethod]
        [DataRow("Nikhil")]
        [DataRow("nikhil")]
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
        [DataRow("yadav")]
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
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
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
        [DataRow("nikhilyadavindigo1997")]
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
}
