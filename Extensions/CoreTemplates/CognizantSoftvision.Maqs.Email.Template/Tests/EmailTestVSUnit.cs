using CognizantSoftvision.Maqs.BaseEmailTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    /// <summary>
    /// Tests test class
    /// </summary>
    [TestClass]
    public class EmailTestVSUnit : BaseEmailTest
    {
        /// <summary>
        /// Sample test
        /// </summary>
        [TestMethod]
        public void SampleTest()
        {
            // TODO: Update email connection configuration and add test code
            // Assert.IsTrue(this.EmailDriver.CanAccessEmailAccount(), "Could not access account");

            this.Log.LogMessage("Dummy test");
        }
    }
}