using Maqs.SpecFlow.TestSteps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace $safeprojectname$.Steps
{
    /// <summary>
    /// Steps class for EmailFeatureSteps
    /// To utilize MAQS features for the steps in this class, make sure at add a 'MAQS_Email' tag to the feature file(s)
    /// </summary>
    [Binding]
    public class EmailFeatureSteps : BaseEmailTestSteps
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailFeatureSteps"/> class.
        /// </summary>
        /// <param name="context">The scenario context.</param>
        protected EmailFeatureSteps(ScenarioContext context) : base(context)
        {
        }

        /// <summary>
        /// Sample given method
        /// </summary>
        [Given(@"condition")]
        public void GivenCondition()
        {
            // Mark as pending as there user will likely not have an email configured
            this.LocalScenarioContext.Pending();
        }

        /// <summary>
        /// Sample when method
        /// </summary>
        [When(@"action")]
        public void WhenAction()
        {
            // this.LocalScenarioContext.Pending();
        }

        /// <summary>
        /// Sample then method
        /// </summary>
        [Then(@"verification")]
        public void ThenVerification()
        {
            // this.LocalScenarioContext.Pending();
            Assert.IsTrue(this.EmailDriver.CanAccessEmailAccount(), "Email account was not accessible");
        }

        //// Store objects
        //[Given(@"initial")]
        //public void GivenInitial()
        //{
        //    OBJECTTYPE statefulObjectName = new OBJECTTYPE(); 
        //    this.LocalScenarioContext.Set(statefulObjectName);

        //    OBJECTTYPE statefulObjectName2 = new OBJECTTYPE();
        //    this.LocalScenarioContext.Add("SpecificName", statefulObjectName2);
        //}

        //// Get objects
        //[When(@"later")]
        //public void WhenLater()
        //{
        //    OBJECTTYPE statefulObjectName = this.LocalScenarioContext.Get<OBJECTTYPE>();
        //    OBJECTTYPE statefulObjectName2 = this.LocalScenarioContext.Get<OBJECTTYPE>("SpecificName");
        //}
    }
}
