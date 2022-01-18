using Magenic.Maqs.BaseDatabaseTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace $safeprojectname$
{
    /// <summary>
    /// Tests test class with VSUnit
    /// </summary>
    [TestClass]
    public class DatabaseTestVSUnit : BaseDatabaseTest
    {
        /// <summary>
        /// Get record using stored procedure
        /// </summary>
        [TestMethod]
        public void GetRecordTest()
        {
            // TODO: Update database connection configuration and add test code
            // var result = this.DatabaseDriver.Query("getStateAbbrevMatch", new { StateAbbreviation = "MN" }, commandType: CommandType.StoredProcedure);
            // Assert.AreEqual(1, result.Count(), "Expected 1 state abbreviation to be returned.");

            this.Log.LogMessage("Dummy test");
        }
    }
}
