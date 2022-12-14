using Maqs.SpecFlow.TestSteps;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace $safeprojectname$.Steps
{
    /// <summary>
    /// Steps class for GeneralFeatureSteps
    /// To utilize MAQS features for the steps in this class, make sure at add a 'MAQS_General' tag to the feature file(s)
    /// </summary>
    [Binding]
    public class GeneralFeatureSteps : BaseTestSteps
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralFeatureSteps"/> class.
        /// </summary>
        /// <param name="context">The scenario context.</param>
        protected GeneralFeatureSteps(ScenarioContext context) : base(context)
        {
        }

        /// <summary>
        /// Sample given method
        /// </summary>
        [Given(@"condition")]
        public void GivenCondition()
        {
            // this.LocalScenarioContext.Pending();
            Assert.IsTrue(true, "True should be true");
        }

        /// <summary>
        /// Sample when method
        /// </summary>
        [When(@"action")]
        public void WhenAction()
        {
            // this.LocalScenarioContext.Pending();
            Assert.IsFalse(false, "False should be false");
        }

        /// <summary>
        /// Sample then method
        /// </summary>
        [Then(@"verification")]
        public void ThenVerification()
        {
            // this.LocalScenarioContext.Pending();
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
