using OpenMAQS.Maqs.BaseDatabaseTest;
using OpenMAQS.Maqs.BaseSeleniumTest;
using OpenMAQS.Maqs.BaseWebServiceTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.WebPage.Selenium;
using System;
using System.Data;
using System.Linq;

namespace $safeprojectname$
{
    /// <summary>
    /// Composite Selenium test class
    /// </summary>
    [TestClass]
    public class SeleniumTests : BaseSeleniumTest
    {
        /// <summary>
        /// Do database setup for test run
        /// </summary>
        // [ClassInitialize] - Disabled because this step will fail as the template does not include access to a test database
        public static void TestSetup(TestContext context)
        {
            // Do database setup
            using (DatabaseDriver wrapper = new DatabaseDriver(DatabaseConfig.GetProviderTypeString(), DatabaseConfig.GetConnectionString()))
            {
                var result = wrapper.Query("getStateAbbrevMatch", new { StateAbbreviation = "MN" }, commandType: CommandType.StoredProcedure);
                Assert.AreEqual(1, result.Count(), "Expected 1 state abbreviation to be returned.");
            }
        }

        /// <summary>
        /// Do post test run web service cleanup
        /// </summary>
        // [ClassCleanup] - Disabled because this step will fail against the current base service
        public static void TestCleanup()
        {
            // Do web service post run cleanup
            WebServiceDriver client = new WebServiceDriver(new Uri(WebServiceConfig.GetWebServiceUri()));
            string result = client.Delete("/api/String/Delete/1", "text/plain", true);
            Assert.AreEqual(string.Empty, result);
        }

        /// <summary>
        /// Open page test
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
