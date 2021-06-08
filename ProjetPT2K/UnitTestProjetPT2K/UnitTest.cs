using ProjetPT2K;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjetPT2K
{
    /// <summary>
    /// Super class providing utility methods and attribute to use the database.
    /// </summary>
    public class UnitTest
    {
        /// <summary>
        /// The Database object the tests will use.
        /// </summary>
        protected Database Database = Database.GetInstance();

        /// <summary>
        /// The connection to the dabase.
        /// </summary>
        protected MusiquePT2_KEntities Connection = Database.GetInstance().GetConnection();

        /// <summary>
        /// Restore the database to a clean state for unit tests.
        /// </summary>
        protected void RestoreCleanState()
        {
            this.Database.RestoreCleanState();
            // Ensures the database is empty
            Assert.IsFalse(this.Database.AccountExists("jean"));
        }

    }
}
