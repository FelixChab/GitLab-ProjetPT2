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
            getRecommendations();
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
            ALBUMS theAlbum = this.Database.GetAlbumWithID(1);

            // Ensure the album can be borrowed
            Assert.AreEqual(true, theAlbum.IsAvailable());

            Assert.IsNotNull(theAlbum);
            this._Subscriber.BorrowAlbum(theAlbum);

            // Ensure the album has been borrowed
            Assert.AreEqual(1, this._Subscriber.EMPRUNTER.Count);

            this._Subscriber.BorrowAlbum(theAlbum);
            // Ensure the album cannot be borrowed anymore
            Assert.IsFalse(theAlbum.IsAvailable());
            Assert.AreEqual(1, this._Subscriber.EMPRUNTER.Count);

            EMPRUNTER theLoan = this._Subscriber.EMPRUNTER.First();

            Assert.AreEqual(theAlbum, theLoan.ALBUMS);
            Assert.AreEqual(this._Subscriber, theLoan.ABONNÉS);
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
        private void getRecommendations()
        {

            Dictionary<ALBUMS, int> dict = this._Subscriber.GetRecommandations();

            // check if the list of recommendations is in the right order
            for (int i = 1; i < dict.Count; i++)
            {
                int lim = dict.ElementAt(i).Value;
                int after = dict.ElementAt(i - 1).Value;
                Assert.IsTrue(lim >= after);
            }

            // check if the genre of recommendations is the good one.
            for (int i = 1; i < dict.Count; i++)
            {
                ALBUMS genre = dict.ElementAt(i).Key;
                ALBUMS afterGenre = dict.ElementAt(i - 1).Key;
                Assert.AreEqual(genre.CODE_GENRE, afterGenre.CODE_GENRE);
            }
        }
    }


}
