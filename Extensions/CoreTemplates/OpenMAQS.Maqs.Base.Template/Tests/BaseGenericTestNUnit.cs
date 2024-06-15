using OpenMAQS.Maqs.BaseTest;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Tests
{
    /// <summary>
    /// BaseGenericTestNUnit test class with NUnit
    /// </summary>
    [TestFixture]
    public class BaseGenericTestNUnit : BaseTest
    {
        /// <summary>
        /// Sample test
        /// </summary>
        [Test]
        public void SampleTestNUnit()
        {
            this.TestObject.Log.LogMessage("Start Test");
            Assert.IsTrue(true, "True is Not True");
        }
    }
}