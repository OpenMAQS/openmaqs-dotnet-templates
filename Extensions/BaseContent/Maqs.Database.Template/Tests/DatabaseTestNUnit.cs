using CognizantSoftvision.Maqs.BaseDatabaseTest;
using NUnit.Framework;

namespace Tests
{
    /// <summary>
    /// Tests test class with NUnit
    /// </summary>
    [TestFixture]
    public class DatabaseTestNUnit : BaseDatabaseTest
    {
        /// <summary>
        /// Get record using stored procedure
        /// </summary>
        [Test]
        public void GetRecordTestNUnit()
        {
            // TODO: Update database connection configuration and add test code
            //var result = this.DatabaseDriver.Query("getStateAbbrevMatch", new { StateAbbreviation = "MN" }, commandType: CommandType.StoredProcedure);
            //Assert.AreEqual(1, result.Count(), "Expected 1 state abbreviation to be returned.");

            this.Log.LogMessage("Dummy test");
        }
    }
}