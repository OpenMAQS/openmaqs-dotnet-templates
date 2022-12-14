using Maqs.BasePlaywrightTest;

namespace $rootnamespace$
{
    /// <summary>
    /// Page object for $safeitemname$
    /// </summary>
    public class $safeitemname$ : BasePlaywrightPageModel
    {
		/// <summary>
        /// Get page url
        /// </summary>
        public static string Url
        {
            get { return PlaywrightConfig.WebBase() + "PAGE.html"; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="$safeitemname$" /> class.
        /// </summary>
        /// <param name="testObject">The Playwright test object</param>
        public $safeitemname$(IPlaywrightTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Sample element
        /// </summary>
        private PlaywrightSyncElement Sample
        {
			get { return new PlaywrightSyncElement(this.PageDriver, "#CSS_ID"); }
        }

        /// <summary>
        /// Open the page
        /// </summary>
        public void OpenPage()
        {
            // sample open login page
            this.PageDriver.Goto(Url);
        }

        /// <summary>
        /// Check if the login page is loaded
        /// </summary>
        public override bool IsPageLoaded()
        {
            return this.Sample.IsEventualyVisible();
        }
    }
}
