﻿using System;
using ProjetPT2K;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjetPT2K
{
    /// <summary>
    /// Unit tests for the class Administrator.
    /// </summary>
    [TestClass]
    public class AdministratorTU : UnitTest
    {
        /// <summary>
        /// the administrator used in this tests.
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
            GetUnpopularAlbums();
            PurgeDatabase();
        }

        /// <summary>
        /// Attempt to create a new account in the database.
        /// </summary>
        private void CreateAccounts()
        {
            this.Database.CreateAccount("Jean", "Pierre",  1, "jean", "pierre");
            this.Database.CreateAccount("Marc", "Antoine", 2, "marc", "antoine");
            this.Database.CreateAccount("Jean", "Marie",   3, "jean", "marie");

            // Retrieve the newly created accounts
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
        /// Attempt to retrieve the extended loans from the database.
        /// </summary>
        private void GetExtendedLoans()
        {
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
        /// Attempt to retrieve the late subscribers.
        /// </summary>
        private void GetLateSubscribers()
        {
            // Ensure there are currently no late subscribers in the database
            Assert.AreEqual(0, this._Administrator.GetLateSubscribers().Count);
            ABONNÉS theSubscriber = (ABONNÉS)this.Database.Login("jean", "pierre");

            ALBUMS theAlbum = this.Database.GetAlbumWithID(2);
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
                DATE_EMPRUNT = new DateTime(2019, 12, 12),
                DATE_RETOUR_ATTENDUE = new DateTime(2020, 1, 25)
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
        /// Attempt to remove from the database the subscribers who have not borrowed an album in a year.
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
    }
}