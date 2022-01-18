using Magenic.Maqs.BaseDatabaseTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace $safeprojectname$
{
    /// <summary>
    /// Sample test class
    /// </summary>
    [TestClass]
    public class DatabaseTests : BaseDatabaseTest
    {
        /// <summary>
        /// Sample test
        /// </summary>
        [TestMethod]
        public void SampleTest()
        {
            // TODO: Update database connection configuration and add test code
            //var table = this.DatabaseDriver.Query("SELECT * FROM information_schema.tables");
            //Assert.AreEqual(10, table.Count(), "Expected 10 tables");

            this.Log.LogMessage("Dummy test");
        }
    }
}
