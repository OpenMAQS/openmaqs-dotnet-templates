using OpenMAQS.Maqs.BasePlaywrightTest;
using NUnit.Framework;
using PageModel;
using Assert = NUnit.Framework.Assert;

namespace $safeprojectname$
{
    /// <summary>
    /// PlaywrightTest test class with NUnit
    /// </summary>
    [TestFixture]
    public class PlaywrightTestsNUnit : BasePlaywrightTest
    {
        /// <summary>
        /// Open page test
        /// </summary>
        [Test]
        public void OpenLoginPageTestNUnit()
        {
            LoginPageModel page = new LoginPageModel(this.TestObject);
            page.OpenLoginPage();
        }

        /// <summary>
        /// Enter credentials test
        /// </summary>
        [Test]
        public void EnterValidCredentialsTestNUnit()
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
        [Test]
        public void EnterInvalidCredentialsNUnit()
        {
            string username = "NOT";
            string password = "Valid";
            LoginPageModel page = new LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            Assert.IsTrue(page.LoginWithInvalidCredentials(username, password));
        }
    }
}
