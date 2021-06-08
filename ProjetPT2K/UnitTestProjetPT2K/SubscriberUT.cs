using System;
using ProjetPT2K;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjetPT2K
{
    [TestClass]
    public class SubscriberUT : UnitTest
    {
        /**
         * The subscriber used in the test.
         */
        private ABONNÉS _Subscriber;

        /**
         * Restore the database to a clean state for Unit Testing.
         */
        [TestMethod]
        public void RestoreCleanState()
        {
            this.Database.RestoreCleanState();
        }

        [TestMethod]
        public void CreateAccount()
        {

        }

        [TestMethod]
        public void BorrowAlbum()
        {

        }

    }
}
