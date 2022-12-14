using Maqs.BasePlaywrightTest;

namespace PageModel
{
    /// <summary>
    /// Playwright page model class for testing
    /// </summary>
    public class HomePageModel : BasePlaywrightPageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HomePageModel"/> class
        /// </summary>
        /// <param name="testObject">The base Playwright test object</param>
        public HomePageModel(IPlaywrightTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets welcome message
        /// </summary>
        private PlaywrightSyncElement WelcomeMessage
        {
            get { return new PlaywrightSyncElement(this.PageDriver, "#WelcomeMessage"); }
        }

        /// <summary>
        /// Check if the home page has been loaded
        /// </summary>
        /// <returns>True if the page was loaded</returns>
        public override bool IsPageLoaded()
        {
            return this.WelcomeMessage.IsEventualyVisible();
        }
    }
}
