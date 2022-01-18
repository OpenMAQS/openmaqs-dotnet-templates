using Magenic.Maqs.BaseAppiumTest;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace $rootnamespace$
{
    /// <summary>
    /// Page object for $safeitemname$
    /// </summary>
    public class $safeitemname$ : BaseAppiumPageModel
    {
        /// <summary>
        /// The user name input element 'By' finder
        /// </summary>
        protected override LazyMobileElement UserNameInput
        {
            get { return new LazyMobileElement(this.TestObject, By.Id("UserName"), "User Name Field"); }
        }

        /// <summary>
        /// The password input element 'By' finder
        /// </summary>
        protected override LazyMobileElement PasswordInput
        {
            get { return new LazyMobileElement(this.TestObject, By.Id("Password"), "Password Field"); }
        }

        /// <summary>
        /// The login button element 'By' finder
        /// </summary>
        protected override LazyMobileElement LoginButton
        {
            get { return new LazyMobileElement(this.TestObject, By.Id("Login"), "Login Button"); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="$safeitemname$" /> class.
        /// </summary>
        /// <param name="testObject">The Appium test object</param>
        public $safeitemname$(IAppiumTestObject testObject)
            : base(testObject)
        {
        }

        /// <summary>
        /// Check that the page is loaded
        /// </summary>
        /// <returns>True if the time is displayed</returns>
        public override bool IsPageLoaded()
        {
            return LoginButton.Exists;
        }
    }
}
