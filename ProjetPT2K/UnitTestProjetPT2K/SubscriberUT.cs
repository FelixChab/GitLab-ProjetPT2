using ProjetPT2K;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjetPT2K
{
    /// <summary>
    /// Unit tests for the class Subscriber.
    /// </summary>
    [TestClass]
    public class SubscriberUT : UnitTest
    {
        /// <summary>
        /// The subscriber used in the test.
        /// </summary>
        private ABONNÉS _Subscriber;

        /// <summary>
        /// Call the unit tests in an ordered manner.
        /// </summary>
        [TestMethod]
        public void OrderedUnitTests()
        {
            RestoreCleanState();
            CreateAccount();
            BorrowAlbum();
            ListAlbums();
            Extends();
        }

        /// <summary>
        /// Restore the database to a clean state for unit tests.
        /// </summary>
        private void RestoreCleanState()
        {
            this.Database.RestoreCleanState();
            // Ensures the database is empty
            Assert.IsFalse(this.Database.AccountExists("jean"));
        }

        /// <summary>
        /// Attempt to create a new account in the database.
        /// </summary>
        private void CreateAccount()
        {
            this.Database.CreateAccount("Jean", "Pierre", 1, "jean", "pierre");
            Account subscriber = this.Database.Login("jean", "pierre");
            this._Subscriber = (ABONNÉS)subscriber;

            Assert.IsNotNull(this._Subscriber);
            Assert.IsFalse(this._Subscriber.IsAdministrator);

            Assert.AreEqual("Jean", this._Subscriber.PRÉNOM_ABONNÉ);
            Assert.AreEqual("Pierre", this._Subscriber.NOM_ABONNÉ);

            Assert.AreEqual("jean", this._Subscriber.LOGIN_ABONNÉ);
            Assert.AreEqual("pierre", this._Subscriber.PASSWORD_ABONNÉ);

            Assert.AreEqual(1, this._Subscriber.CODE_PAYS);
        }

        /// <summary>
        /// Attempt to borrow an album from the database.
        /// </summary>
        private void BorrowAlbum()
        {
            Assert.AreEqual(0, this._Subscriber.EMPRUNTER.Count);
            ALBUMS theAlbum = (from album in this.Connection.ALBUMS
                               where album.CODE_ALBUM == 1
                               select album).FirstOrDefault();

            Assert.IsNotNull(theAlbum);
            this._Subscriber.BorrowAlbum(theAlbum);

            Assert.AreEqual(1, this._Subscriber.EMPRUNTER.Count);
            EMPRUNTER loan = this._Subscriber.EMPRUNTER.First();

            Assert.AreEqual(1, loan.CODE_ALBUM);
            Assert.AreEqual(this._Subscriber.CODE_ABONNÉ, loan.CODE_ABONNÉ);
        }

        /// <summary>
        /// Attempt to display the lists of loans from a subscriber
        /// </summary>
        private void ListAlbums()
        {
            ALBUMS theAlbum = (from album in this.Connection.ALBUMS
                               where album.CODE_ALBUM == 1
                               select album).FirstOrDefault();
        }

        /// <summary>
        /// Attempt to borrow an album.
        /// </summary>
        private void Extends()
        {
            EMPRUNTER loan = this._Subscriber.EMPRUNTER.FirstOrDefault();
            Assert.IsNotNull(loan);
            Assert.IsFalse(loan.HasBeenExtended());

            loan.Extend();
            Assert.AreNotEqual(loan.DATE_RETOUR, loan.DATE_RETOUR_ATTENDUE);
            Assert.AreNotEqual(loan.DATE_RETOUR, (loan.DATE_RETOUR_ATTENDUE));
            Assert.IsTrue(loan.HasBeenExtended());
        }
    }
}


