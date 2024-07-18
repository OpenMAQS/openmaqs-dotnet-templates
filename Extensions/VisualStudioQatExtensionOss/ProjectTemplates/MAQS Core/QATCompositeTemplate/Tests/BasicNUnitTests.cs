using OpenMAQS.Maqs.BaseTest;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace $safeprojectname$
{
    /// <summary>
    /// BasicNUnitTest test class with NUnit
    /// </summary>
    [TestFixture]
    public class BasicNUnitTests : BaseTest
    {
        /// <summary>
        /// Sample test
        /// </summary>
        [Test]
        public void SampleTest()
        {
            this.TestObject.Log.LogMessage("Start Test");
            Assert.IsTrue(true, "True is Not True");
        }
    }
}
