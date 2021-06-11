using System;
using Discotèque;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProjetPT2K
{
    /// <summary>
    /// Unit tests for the class Administrator.
    /// </summary>
    [TestClass]
    public class AdministratorUnitTest : UnitTest
    {
        /// <summary>
        /// The administrator used in this tests.
        /// </summary>
        private readonly Administrator _Administrator = new Administrator();

        /// <summary>
        /// Call the unit tests in an ordered manner.
        /// </summary>
        [TestMethod]
        public void OrderedUnitTests()
        {
            RestoreCleanState();
            CreateAccounts();
            GetExtendedLoans();
            GetLateSubscribers();
            //GetUnpopularAlbums();
            PurgeDatabase();
            GetMostBorrowedAlbums();
        }

        /// <summary>
        /// Create new accounts in the database.
        /// </summary>
        private void CreateAccounts()
        {
            // this.Database.AttemptAccountCreation("Jean", "Pierre", 1, "jean", "pierre");
            // this.Database.AttemptAccountCreation("Marc", "Antoine", 1, "marc", "antoine");

            // Retrieve the accounts
            Account subscriber1 = this.Database.Login("jean", "pierre");            
            Account subscriber2 = this.Database.Login("marc", "antoine");
            
            // Ensure the account was added to the database
            Assert.IsNotNull(subscriber1);
            Assert.IsNotNull(subscriber2);

            // Ensure an account with an existing login cannot be created
            Account subscriber3 = this.Database.Login("jean", "marie");
            Assert.IsNull(subscriber3);
        }

        /// <summary>
        /// Retrieve the extended loans from the database.
        /// </summary>
        private void GetExtendedLoans()
        {
            // Ensure there are top 10 yet
            Assert.AreEqual(0, this._Administrator.GetMostBorrowedAlbums().Count);

            // Ensure there are currently no extended loans in the database
            Assert.AreEqual(0, this._Administrator.GetExtendedLoans().Count);
            ABONNÉS theSubscriber = (ABONNÉS)this.Database.Login("jean", "pierre");

            ALBUMS theAlbum = this.Database.GetAlbumWithID(1);
            Assert.IsNotNull(theAlbum);

            EMPRUNTER theLoan = new EMPRUNTER
            {
                CODE_ABONNÉ = theSubscriber.CODE_ABONNÉ,
                CODE_ALBUM = theAlbum.CODE_ALBUM,
                DATE_EMPRUNT = new DateTime(2020, 12, 12),
                DATE_RETOUR_ATTENDUE = new DateTime(2021, 1, 25),
                DATE_RETOUR = new DateTime(2021, 1, 25)
            };

            this.Connection.EMPRUNTER.Add(theLoan);
            this.Connection.SaveChanges();

            // Ensure there is now one extended loan in the database
            List<EMPRUNTER> lateLoans = this._Administrator.GetExtendedLoans();
            Assert.AreEqual(1, lateLoans.Count);

            // Ensure the late loan is the one we inserted
            Assert.AreEqual(theLoan, lateLoans[0]);
        }

        /// <summary>
        /// Retrieve the subscribers with a late loan.
        /// </summary>
        private void GetLateSubscribers()
        {
            // Ensure there are currently no late subscribers in the database
            Assert.AreEqual(0, this._Administrator.GetLateSubscribers().Count);
            ABONNÉS theSubscriber = (ABONNÉS)this.Database.Login("jean", "pierre");

            ALBUMS theAlbum = this.Database.GetAlbumWithID(3);
            Assert.IsNotNull(theAlbum);

            EMPRUNTER theLoan = new EMPRUNTER
            {
                CODE_ABONNÉ = theSubscriber.CODE_ABONNÉ,
                CODE_ALBUM = theAlbum.CODE_ALBUM,
                DATE_EMPRUNT = new DateTime(2020, 12, 12),
                DATE_RETOUR_ATTENDUE = new DateTime(2020, 12, 29),
            };

            this.Connection.EMPRUNTER.Add(theLoan);
            this.Connection.SaveChanges();

            // Ensure there is now one late subscriber in the database
            List<ABONNÉS> lateSubscribers = this._Administrator.GetLateSubscribers();
            Assert.AreEqual(1, lateSubscribers.Count);

            // Ensure the late subscriber is Jean Pierre
            Assert.AreEqual(theSubscriber, lateSubscribers[0]);
        }

        /// <summary>
        /// Retrieve the list of unpopular albums (not borrowed in a year).
        /// </summary>
        private void GetUnpopularAlbums()
        {
            // Ensure there are no unpopular album in the database
            Assert.AreEqual(0, this._Administrator.GetUnpopularAlbums().Count);
            ABONNÉS theSubscriber = (ABONNÉS)this.Database.Login("marc", "antoine");

            ALBUMS theAlbum = this.Database.GetAlbumWithID(3);
            Assert.IsNotNull(theAlbum);

            EMPRUNTER theLoan = new EMPRUNTER
            {
                CODE_ABONNÉ = theSubscriber.CODE_ABONNÉ,
                CODE_ALBUM = theAlbum.CODE_ALBUM,
                DATE_EMPRUNT = new DateTime(2018, 12, 12),
                DATE_RETOUR_ATTENDUE = new DateTime(2019, 1, 25),
                DATE_RETOUR = new DateTime(2019, 1, 25)
            };

            this.Connection.EMPRUNTER.Add(theLoan);
            this.Connection.SaveChanges();

            // Ensure there is now one unpopular album in the database
            List<ALBUMS> unpopularAlbums = this._Administrator.GetUnpopularAlbums();
            Assert.AreEqual(1, unpopularAlbums.Count);

            // Ensure the unpopular album is the one we inserted in the database
            Assert.AreEqual(theAlbum, unpopularAlbums[0]);
        }

        /// <summary>
        /// Remove from the database the subscribers who have not borrowed an album in a year.
        /// </summary>
        private void PurgeDatabase()
        {
            // Ensure there is now one inactive subscriber in the database
            List<ABONNÉS> inactiveSubscribers = this.Database.GetInactiveSubscribers();
            Assert.AreEqual(1, inactiveSubscribers.Count);

            ABONNÉS theSubscriber = (ABONNÉS)this.Database.Login("marc", "antoine");

            // Ensure the late subscriber is Marc Antoine
            Assert.AreEqual(theSubscriber, inactiveSubscribers[0]);

            this._Administrator.PurgeDatabase();
            // Ensure the inactive user has been removed from the database
            Assert.AreEqual(0, this.Database.GetInactiveSubscribers().Count);
        }

        /// <summary>
        /// Attempt list the 10 most borrowed albums.
        /// </summary>
        private void GetMostBorrowedAlbums()
        {
            ALBUMS theAlbum = this.Database.GetAlbumWithID(7);
            ABONNÉS theSubscriber = (ABONNÉS)this.Database.Login("patrick", "patrick");
            EMPRUNTER theLoan = new EMPRUNTER
            {
                CODE_ABONNÉ = theSubscriber.CODE_ABONNÉ,
                CODE_ALBUM = theAlbum.CODE_ALBUM,
                DATE_EMPRUNT = new DateTime(2020, 12, 12),
                DATE_RETOUR_ATTENDUE = new DateTime(2021, 1, 15),
            };
            this.Connection.EMPRUNTER.Add(theLoan);
            this.Connection.SaveChanges();


            Assert.AreEqual(0, this._Administrator.GetMostBorrowedAlbums().Count);
            Dictionary<ALBUMS, int> dict = this._Administrator.GetMostBorrowedAlbums();

            for (int i = 1; i < dict.Count; i++)
            {
                int lim = dict.ElementAt(i).Value;
                int after = dict.ElementAt(i - 1).Value;
                Assert.IsTrue(lim >= after);
            }
        }

    }
}
