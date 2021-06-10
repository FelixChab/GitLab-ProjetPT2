using System;

namespace ProjetPT2K
{
    /// <summary>
    /// Class representing a loan in the database.
    /// </summary>
    public partial class EMPRUNTER
    {
        /// <summary>
        /// Return true if the current loan has been extended.
        /// </summary>
        /// <returns> a boolean </returns>
        public bool HasBeenExtended()
        {
            TimeSpan theGap = this.DATE_RETOUR_ATTENDUE - this.DATE_EMPRUNT;
            return theGap.TotalDays > this.ALBUMS.GENRES.DÉLAI;
        }

        /// <summary>
        /// Return true if the current loan is late by 10 days.
        /// </summary>
        /// <returns> a boolean </returns>
        public bool IsLate()
        {
            TimeSpan theGap = DateTime.Now - this.DATE_RETOUR_ATTENDUE;
            return this.DATE_RETOUR == null && theGap.TotalDays >= 10;
        }

        /// <summary>
        /// Extend the current loan by a month.
        /// </summary>
        /// <returns> a boolean </returns>
        public void Extend()
        {
            if (!this.HasBeenExtended())
            {
                this.DATE_RETOUR_ATTENDUE = this.DATE_RETOUR_ATTENDUE.AddDays(30);
                Database.GetInstance().GetConnection().SaveChanges();
            }
        }

        /// <summary>
        /// Set the return date of the current loan and update the database.
        /// </summary>
        public void Return()
        {
            this.DATE_RETOUR = DateTime.Now;
            Database.GetInstance().GetConnection().SaveChanges();
        }

        /// <summary>
        /// Return the string representation of the loan.
        /// </summary>
        /// <returns> a string </returns>
        public override String ToString()
        {
            return this.ALBUMS.TITRE_ALBUM.Trim() + " - du " + this.DATE_EMPRUNT.ToShortDateString()
                + " au " + this.DATE_RETOUR_ATTENDUE.ToShortDateString();
        }
    }
}