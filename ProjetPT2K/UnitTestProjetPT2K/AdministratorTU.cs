using System;
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
        private readonly Admin _Administrator = new Admin();

        /// <summary>
        /// Call the unit tests in an ordered manner.
        /// </summary>
        [TestMethod]
        public void OrderedUnitTests()
        {
            RestoreCleanState();
            CreateAccount();
            InsertExtendedLoans();
            GetExtendedLoans();
        }

        /// <summary>
        /// Attempt to create a new account in the database.
        /// </summary>
        private void CreateAccount()
        {
            this.Database.CreateAccount("Jean", "Pierre", 1, "jean", "pierre");
            Account subscriber = this.Database.Login("jean", "pierre");
            // Ensure the account was added to the database
            Assert.IsNotNull(subscriber);
        }

        /// <summary>
        /// Insert a late loan in the database.
        /// </summary>
        private void InsertExtendedLoans()
        {
            // Ensure there are currently no late loans in the database
            Assert.AreEqual(0, this._Administrator.GetLateLoans().Count);
            ABONNÉS theSubscriber = (ABONNÉS)this.Database.Login("jean", "pierre");
            
            ALBUMS theAlbum = this.Database.GetAlbumWithID(3);
            Assert.IsNotNull(theAlbum);

            EMPRUNTER theLoan = new EMPRUNTER
            {
                CODE_ABONNÉ = theSubscriber.CODE_ABONNÉ,
                CODE_ALBUM = theAlbum.CODE_ALBUM,
                DATE_EMPRUNT = new DateTime(2020, 12, 12),
                DATE_RETOUR_ATTENDUE = new DateTime(2021, 1, 15),
            };

            this.Connection.EMPRUNTER.Add(theLoan);
            this.Connection.SaveChanges();
        }

        /// <summary>
        /// Attempt to retrieve the loans that were extended.
        /// </summary>
        private void GetExtendedLoans()
        {
            List<EMPRUNTER> lateLoans = this._Administrator.GetLateLoans();
            Assert.AreEqual(1, lateLoans.Count);
        }
    }
}