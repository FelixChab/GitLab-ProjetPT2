﻿using System;
using ProjetPT2K;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
        private readonly Admin _Administrator = new Admin();
        private readonly ABONNÉS subscriber = new ABONNÉS();

        /// <summary>
        /// Call the unit tests in an ordered manner.
        /// </summary>
        [TestMethod]
        public void OrderedUnitTests()
        {
            RestoreCleanState();
            checkBestAlbums();
            CreateAccounts();
           // InsertExtendedLoans();
            GetExtendedLoans();
            getBestAlbums();
        }

        /// <summary>
        /// Attempt to create a new account in the database.
        /// </summary>
        private void CreateAccounts()
        {
            this.Database.CreateAccount("Jean", "Pierre", 1, "jean", "pierre");
            Account subscriber1 = this.Database.Login("jean", "pierre");
            this.Database.CreateAccount("Jean", "patrick", 1, "patrick", "patrick");
            Account subscriber2 = this.Database.Login("patrick", "patrick");
            // Ensure the account was added to the database
            Assert.IsNotNull(subscriber1);
            Assert.IsNotNull(subscriber2);
        }

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
        /// Attempt to remove from the database the subscribers who have not borrowed an album in a year.
        /// </summary>
        private void PurgeDatabase()
        {
            // Ensure there are currently no inactive subscriber in the database
            Assert.AreEqual(0, this.Database.GetInactiveSubscribers().Count);

            ABONNÉS theSubscriber = (ABONNÉS)this.Database.Login("jean", "marie");

            ALBUMS theAlbum = this.Database.GetAlbumWithID(3);
            Assert.IsNotNull(theAlbum);

            EMPRUNTER theLoan = new EMPRUNTER
            {
                CODE_ABONNÉ = theSubscriber.CODE_ABONNÉ,
                CODE_ALBUM = theAlbum.CODE_ALBUM,
                DATE_EMPRUNT = new DateTime(2012, 12, 12),
                DATE_RETOUR_ATTENDUE = new DateTime(2012, 12, 25),
                DATE_RETOUR = new DateTime(2012, 12, 25)
            };

            this.Connection.EMPRUNTER.Add(theLoan);
            this.Connection.SaveChanges();

            // Ensure there is now one inactive subscriber in the database
            List<ABONNÉS> inactiveSubscribers = this.Database.GetInactiveSubscribers();
            Assert.AreEqual(1, inactiveSubscribers.Count);

            // Ensure the late subscriber is Jean Marie
            Assert.AreEqual(theSubscriber, inactiveSubscribers[0]);
        }


        /// <summary>
        /// 
        /// </summary>
        private void checkBestAlbums()
        {
            Assert.AreEqual(0, this._Administrator.GetBestAlbums().Count);
        }

        /// <summary>
        /// Attempt list the 10 best albums.
        /// </summary>
        private void getBestAlbums()
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


            Assert.AreEqual(0, this._Administrator.GetBestAlbums().Count);
            Dictionary<ALBUMS, int> dict = this._Administrator.GetBestAlbums();



            for (int i = 1; i < dict.Count; i++)
            {
                int lim = dict.ElementAt(i).Value;
                int after = dict.ElementAt(i - 1).Value;
                Assert.IsTrue(lim >= after);
            }
        }

    }
}