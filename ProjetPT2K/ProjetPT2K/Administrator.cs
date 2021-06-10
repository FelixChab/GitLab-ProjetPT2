using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjetPT2K
{
    /// <summary>
    /// Class representing the administrator account.
    /// </summary>
    public class Administrator : Account
    {
        /// <summary>
        /// The login of the administrator.
        /// </summary>
        public static string LOGIN = "ADMIN";

        /// <summary>
        /// The paswword of the administrator.
        /// </summary>
        public static string PASSWORD = "admin";

        /// <summary>
        /// Non-parametotised constructor creating a new Admin object.
        /// </summary>
        public Administrator()
        {
            this.IsAdministrator = true;
        }

        /// <summary>
        /// Return the list of extended loans in the database.
        /// </summary>
        /// <returns> a list of Emprunter objects </returns>
        public List<EMPRUNTER> GetExtendedLoans()
        {
            List<EMPRUNTER> lateLoans = new List<EMPRUNTER>();
            List<EMPRUNTER> theLoans = this.Connection.EMPRUNTER.ToList();
            foreach (EMPRUNTER theLoan in theLoans)
            {
                if (theLoan.HasBeenExtended())
                    lateLoans.Add(theLoan);
            }
            return lateLoans;
        }

        /// <summary>
        /// Return the list of subscribers who have a 10-days late loan.
        /// </summary>
        /// <returns> a list of Abonné objects </returns>
        public List<ABONNÉS> GetLateSubscribers()
        {
            List<ABONNÉS> lateSubscribers = new List<ABONNÉS>();
            List<EMPRUNTER> theLoans = this.Connection.EMPRUNTER.ToList();
            foreach (EMPRUNTER theLoan in theLoans)
            {
                if (theLoan.IsLate())
                    lateSubscribers.Add(theLoan.ABONNÉS);
            }
            return lateSubscribers;
        }

        /// <summary>
        /// Attempt to remove from the database the subscribers who have not borrowed an album in a year.
        /// </summary>
        public void PurgeDatabase()
        {
            List<ABONNÉS> inactiveSubscribers = this.Database.GetInactiveSubscribers();
            inactiveSubscribers.ForEach(subscriber => this.Connection.ABONNÉS.Remove(subscriber));
            Connection.SaveChanges();
        }

        /// <summary>
        /// Return the list of albums that have not been borrowed in a year.
        /// </summary>
        /// <returns></returns>
        public List<ALBUMS> GetUnpopularAlbums()
        {
            List<ALBUMS> unpopularAlbums = new List<ALBUMS>();
            List<ALBUMS> theAlbums = this.Connection.ALBUMS.ToList();
            foreach (ALBUMS theAlbum in theAlbums)
            {
                if (!theAlbum.IsPopular())
                    unpopularAlbums.Add(theAlbum);
            }
            return unpopularAlbums;
        }
    }
}