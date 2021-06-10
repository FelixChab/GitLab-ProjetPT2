using System;
using ProjetPT2K;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjetPT2K
{
    /// <summary>
    /// Unit tests for the class Subscriber.
    /// </summary>
    [TestClass]
    public class SubscriberUnitTest : UnitTest
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
            ExtendLoan();
            GetRecommendations();
        }

        /// <summary>
        /// Attempt to create a new account in the database.
        /// </summary>
        private void CreateAccount()
        {
            this.Database.AttemptAccountCreation("Marc", "Antoine", 4, "marc", "antoine");
            Account Marc = this.Database.Login("marc", "antoine");
            this._Subscriber = (ABONNÉS)Marc;

            Assert.IsNotNull(this._Subscriber);
            Assert.IsFalse(this._Subscriber.IsAdministrator);

            Assert.AreEqual("Marc", this._Subscriber.PRÉNOM_ABONNÉ);
            Assert.AreEqual("Antoine", this._Subscriber.NOM_ABONNÉ);

            Assert.AreEqual("marc", this._Subscriber.LOGIN_ABONNÉ);
            Assert.AreEqual("antoine", this._Subscriber.PASSWORD_ABONNÉ);

            Assert.AreEqual(4, this._Subscriber.CODE_PAYS);

            CheckCredentials();
        }

        /// <summary>
        /// Ensure the credentials are valid.
        /// </summary>
        private void CheckCredentials()
        {
            Assert.ThrowsException<Exception>(
                () => this.Database.AttemptAccountCreation("Marc", "Antoine", 4, "marc antoine", "antoine"));

            Assert.ThrowsException<Exception>(
                () => this.Database.AttemptAccountCreation("Marc", "Antoine", 4, "marc", "\"antoine"));

            Assert.ThrowsException<Exception>(
                () => this.Database.AttemptAccountCreation("Marc", "Antoine", 4, "'marc'", "antoine"));

            Assert.ThrowsException<Exception>(
                () => this.Database.AttemptAccountCreation("Marc", "Antoine", 4, "marc", ""));
        }

        /// <summary>
        /// Attempt to borrow an album from the database.
        /// </summary>
        private void BorrowAlbum()
        {
            Assert.AreEqual(0, this._Subscriber.EMPRUNTER.Count);
            ALBUMS theAlbum = this.Database.GetAlbumWithID(1);

            // Ensure the album can be borrowed
            Assert.AreEqual(true, theAlbum.IsAvailable());

            Assert.IsNotNull(theAlbum);
            this._Subscriber.BorrowAlbum(theAlbum);

            // Ensure the album has been borrowed
            Assert.AreEqual(1, this._Subscriber.EMPRUNTER.Count);

            // Ensure the album cannot be borrowed anymore
            Assert.ThrowsException<Exception>(() => this._Subscriber.BorrowAlbum(theAlbum));

            Assert.IsFalse(theAlbum.IsAvailable());
            Assert.AreEqual(1, this._Subscriber.EMPRUNTER.Count);

            EMPRUNTER theLoan = this._Subscriber.EMPRUNTER.First();

            Assert.AreEqual(theAlbum, theLoan.ALBUMS);
            Assert.AreEqual(this._Subscriber, theLoan.ABONNÉS);

            // Ensure it is possible to borrow the album again once it has been returned
            theLoan.Return();
            this._Subscriber.BorrowAlbum(theAlbum);
        }

        /// <summary>
        /// Ensure the list of loans is correct
        /// </summary>
        private void ListAlbums()
        {
            ALBUMS theAlbum = this.Database.GetAlbumWithID(2);

            Assert.IsNotNull(theAlbum);
            this._Subscriber.BorrowAlbum(theAlbum);

            List<EMPRUNTER> theLoans = (from loan in this.Connection.EMPRUNTER
                                        where loan.CODE_ABONNÉ == this._Subscriber.CODE_ABONNÉ
                                        select loan).ToList();

            foreach (EMPRUNTER loan in this._Subscriber.EMPRUNTER)
                Assert.IsTrue(theLoans.Contains(loan));
        }

        /// <summary>
        /// Attempt to extend a loan.
        /// </summary>
        private void ExtendLoan()
        {
            EMPRUNTER theLoan = this._Subscriber.EMPRUNTER.FirstOrDefault();
            Assert.IsNotNull(theLoan);

            // Ensure the loan has not been extended yet
            Assert.IsFalse(theLoan.HasBeenExtended());
            theLoan.Extend();

            // Ensure the date is correct
            int theDelay = theLoan.ALBUMS.GENRES.DÉLAI;
            DateTime theDate = theLoan.DATE_EMPRUNT.AddDays(theDelay).AddMonths(1);
            Assert.AreEqual(theDate, theLoan.DATE_RETOUR_ATTENDUE);

            // Ensure the loan has been extended
            Assert.IsTrue(theLoan.HasBeenExtended());
        }


        /// <summary>
        /// Attempt to getRecommendations.
        /// </summary>
        private void GetRecommendations()
        {

            Dictionary<ALBUMS, int> theRecommandations = this._Subscriber.GetRecommandations();
            // check if the list of recommendations is in the right order
            for (int i = 1; i < theRecommandations.Count; i++)
            {
                int lim = theRecommandations.ElementAt(i).Value;
                int after = theRecommandations.ElementAt(i - 1).Value;
                Assert.IsTrue(lim >= after);
            }

            // check if the genre of recommendations is the good one.
            for (int i = 1; i < theRecommandations.Count; i++)
            {
                ALBUMS theFirstAlbum = theRecommandations.ElementAt(i).Key;
                ALBUMS theSecondAlbum = theRecommandations.ElementAt(i - 1).Key;
                Assert.AreEqual(theFirstAlbum.CODE_GENRE, theSecondAlbum.CODE_GENRE);
            }
        }
    }


}
