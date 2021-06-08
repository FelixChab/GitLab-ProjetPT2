
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjetPT2K;

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

        public void CreateAccount()
        {
            MusiquePT2_KEntities connection = Database.GetInstance().GetConnection();
            Database.GetInstance().CreateAccount("prénom", "nom", 01, "testeur", "blabla");
            connection.Database.ExecuteSqlCommand("SELECT NOM_ABONNÉ FROM ABONNÉS WHERE ABONNÉS.NOM_ABONNÉ = 'nom'");

        }

        [TestMethod]
        public void BorrowAlbum()
        {

        }

    }
}
