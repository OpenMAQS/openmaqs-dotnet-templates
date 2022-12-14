using Maqs.BasePlaywrightTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Models.WebPage.Playwright
{
    /// <summary>
    /// Page object for the Automation page
    /// </summary>
    public class LoginPageModel : BasePlaywrightPageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginPageModel"/> class
        /// </summary>
        /// <param name="testObject">The base Playwright test object</param>
        public LoginPageModel(IPlaywrightTestObject testObject)
            : base(testObject)
        {
        }

        /// <summary>
        /// Get page url
        /// </summary>
        public static string Url
        {
            get { return PlaywrightConfig.WebBase() + "Static/Training3/LoginPage.html"; }
        }

        /// <summary>
        /// Gets user name box
        /// </summary>
        private PlaywrightSyncElement UserNameInput
        {
            get { return new PlaywrightSyncElement(this.PageDriver, "#name"); }
        }

        /// <summary>
        /// Gets password box
        /// </summary>
        private PlaywrightSyncElement PasswordInput
        {
            get { return new PlaywrightSyncElement(this.PageDriver, "#pw"); }
        }

        /// <summary>
        /// Gets login button
        /// </summary>
        private PlaywrightSyncElement LoginButton
        {
            get { return new PlaywrightSyncElement(this.PageDriver, "#Login"); }
        }

        /// <summary>
        /// Gets error message
        /// </summary>
        private PlaywrightSyncElement ErrorMessage
        {
            get { return new PlaywrightSyncElement(this.PageDriver, "#LoginError"); }
        }

        /// <summary>
        /// Open the login page
        /// </summary>
        public void OpenLoginPage()
        {
            this.PageDriver.Goto(Url);
            this.AssertPageLoaded();
        }

        /// <summary>
        /// Enter the use credentials
        /// </summary>
        /// <param name="userName">The user name</param>
        /// <param name="password">The user password</param>
        public void EnterCredentials(string userName, string password)
        {
            this.UserNameInput.Type(userName);
            this.PasswordInput.Type(password);
        }

        /// <summary>
        /// Enter the use credentials and log in - Navigation sample
        /// </summary>
        /// <param name="userName">The user name</param>
        /// <param name="password">The user password</param>
        /// <returns>The home page</returns>
        public HomePageModel LoginWithValidCredentials(string userName, string password)
        {
            this.EnterCredentials(userName, password);
            this.LoginButton.Click();

            return new HomePageModel(this.TestObject);
        }

        /// <summary>
        /// Enter the use credentials and try to log in - Verify login failed
        /// </summary>
        /// <param name="userName">The user name</param>
        /// <param name="password">The user password</param>
        /// <returns>True if the error message is displayed</returns>
        public bool LoginWithInvalidCredentials(string userName, string password)
        {
            this.EnterCredentials(userName, password);
            this.LoginButton.Click();
            return this.ErrorMessage.IsEventualyVisible();
        }

        /// <summary>
        /// Open the page
        /// </summary>
        public void OpenPage()
        {
            this.PageDriver.Goto(Url);
        }

        /// <summary>
        /// Assert the login page loaded
        /// </summary>
        public void AssertPageLoaded()
        {
            Assert.IsTrue(this.IsPageLoaded(), $"The web page '{Url}' is not loaded");
        }

        /// <summary>
        /// Check if the home page has been loaded
        /// </summary>
        /// <returns>True if the page was loaded</returns>
        public override bool IsPageLoaded()
        {
            return this.UserNameInput.IsEventualyVisible() && this.PasswordInput.IsEventualyVisible() && this.LoginButton.IsEventualyVisible();
        }
    }
}
