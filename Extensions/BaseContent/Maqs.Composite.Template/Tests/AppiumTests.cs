using CognizantSoftvision.Maqs.BaseAppiumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Mobile;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using System;

namespace Tests
{
    /// <summary>
    /// AppiumTests test class with VSUnit
    /// </summary>
    [TestClass]
    public class AppiumTests : BaseAppiumTest
    {
        /// <summary>
        /// The starting page
        /// </summary>
        private ALoginPageModel startingPage;

        /// <summary>
        /// Sets up the starting page to be iOS or Android
        /// </summary>
        [TestInitialize]
        public void SetupStartingPage()
        {
            // TODO: Update Appium connection configuration and reenable this code
            //Type driverType = this.TestObject.AppiumDriver.GetType();
            //if (driverType == typeof(IOSDriver))
            //{
            //    startingPage = new IOSLoginPageModel(this.TestObject);
            //}
            //else if (driverType == typeof(AndroidDriver))
            //{
            //    startingPage = new AndroidLoginPageModel(this.TestObject);
            //}
            //else
            //{
            //    throw new NotSupportedException($"This OS type: {driverType} is not supported.");
            //}
        }

        /// <summary>
        /// Verifies the error message is as expected when a user logs in with invalid creds
        /// </summary>
        [TestMethod]
        public void InvalidLoginTest()
        {
            // TODO: Update Appium connection configuration and add test code
            //string expectedError = "Use the following credentials: \r\n(User Name: Ted Password: 123)";
            //startingPage.LoginWithInvalidCredentials("Not", "Valid");
            //Assert.AreEqual(expectedError, startingPage.GetErrorMessage());

            this.Log.LogMessage("Dummy test");
        }

        /// <summary>
        /// Verifies a user can login with valid creds
        /// </summary>
        [TestMethod]
        public void ValidLoginTest()
        {
            // TODO: Update Appium connection configuration and add test code
            //string username = "Ted";
            //string password = "123";
            //string expectedGreeting = $"Welcome {username}!";
            //string expectedTimeDescription = "The current time is:";
            //AHomePageModel homePage = startingPage.LoginWithValidCredentials(username, password);
            //SoftAssert.Assert(() => Assert.AreEqual(expectedGreeting, homePage.GetGreetingMessage()));
            //SoftAssert.Assert(() => Assert.AreEqual(expectedTimeDescription, homePage.GetTimeDiscription()));
            //SoftAssert.Assert(() => Assert.IsTrue(DateTime.TryParse(homePage.GetTime(), out DateTime time), "Time Parsing"));
            //SoftAssert.FailTestIfAssertFailed();

            this.Log.LogMessage("Dummy test");
        }
    }
}
