using Maqs.BasePlaywrightTest;
using Maqs.BaseWebServiceTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.WebPage.Playwright;
using System;

namespace $safeprojectname$
{
    /// <summary>
    /// PlaywrightTest test class with VS unit
    /// </summary>
    [TestClass]
    public class PlaywrightTestsVSUnit : BasePlaywrightTest
    {
		/// <summary>
        /// Do post test run web service cleanup 
        /// </summary>
        // [ClassCleanup] - TODO: Remove or update per your testing needs
        public static void TestCleanup()
        {
            // Do web service post run cleanup
            WebServiceDriver client = new WebServiceDriver(new Uri(WebServiceConfig.GetWebServiceUri()));
            string result = client.Delete("/api/String/Delete/1", "text/plain", true);
            Assert.AreEqual(string.Empty, result);
        }
		
        /// <summary>
        /// Composite Playwright test class
        /// </summary>
        [TestMethod]
        public void OpenLoginPageTest()
        {
            LoginPageModel page = new LoginPageModel(this.TestObject);
            page.OpenLoginPage();
        }

        /// <summary>
        /// Enter credentials test
        /// </summary>
        [TestMethod]
        public void EnterValidCredentialsTest()
        {
            string username = "Ted";
            string password = "123";
            LoginPageModel page = new LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            HomePageModel homepage = page.LoginWithValidCredentials(username, password);
            Assert.IsTrue(homepage.IsPageLoaded());
        }

        /// <summary>
        /// Enter credentials test
        /// </summary>
        [TestMethod]
        public void EnterInvalidCredentials()
        {
            string username = "NOT";
            string password = "Valid";
            LoginPageModel page = new LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            Assert.IsTrue(page.LoginWithInvalidCredentials(username, password));
        }
    }
}

