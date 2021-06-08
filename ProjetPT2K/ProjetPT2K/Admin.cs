using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjetPT2K
{
    /// <summary>
    /// Class representing the administrator account.
    /// </summary>
    public class Admin : Account
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
        public Admin()
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
            foreach (EMPRUNTER theLoan in this.Connection.EMPRUNTER)
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
            foreach (EMPRUNTER theLoan in this.Connection.EMPRUNTER)
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
        /// Method that returns a list of albums not borrowed in a year.
        /// </summary>
        /// <returns></returns>
        public List<ALBUMS> GetAlbumsNoLoan()
        {
            List<ALBUMS> noLoans = new List<ALBUMS>();
            foreach (EMPRUNTER e in Connection.EMPRUNTER)
            {
                if ((DateTime.Now - e.DATE_RETOUR) >= TimeSpan.FromDays(365))
                {
                    noLoans.Add(e.ALBUMS);
                }
            }
            return noLoans;
        }
    }
}