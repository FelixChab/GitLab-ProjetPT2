using System;
using ProjetPT2K;
using System.Linq;
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
         * Call the unit tests in an ordered manner.
         */
        [TestMethod]
        public void OrderedUnitTests()
        {
            RestoreCleanState();
            CreateAccount();
            BorrowAlbum();
        }

        /**
         * Restore the database to a clean state for unit tests.
         */
        private void RestoreCleanState()
        {
            this.Database.RestoreCleanState();
            // Ensures the database is empty
            Assert.IsFalse(this.Database.AccountExists("test"));
        }

        /**
         * Attempt to create a new account in the database.
         */
        private void CreateAccount()
        {
            this.Database.CreateAccount("Test", "Unitaire", 1, "test", "unitaire");
            Account subscriber = this.Database.Login("test", "unitaire");
            this._Subscriber = (ABONNÉS)subscriber;
            
            Assert.IsNotNull(this._Subscriber);
            Assert.IsFalse(this._Subscriber.IsAdministrator);

            Assert.AreEqual("Test", this._Subscriber.PRÉNOM_ABONNÉ);
            Assert.AreEqual("Unitaire", this._Subscriber.NOM_ABONNÉ);

            Assert.AreEqual("test", this._Subscriber.LOGIN_ABONNÉ);
            Assert.AreEqual("unitaire", this._Subscriber.PASSWORD_ABONNÉ);

            Assert.AreEqual(1, this._Subscriber.CODE_PAYS);
        }

        private void BorrowAlbum()
        {
            ALBUMS theAlbum = (from album in this.Connection.ALBUMS
                            select album).FirstOrDefault();
        }

    }

}
