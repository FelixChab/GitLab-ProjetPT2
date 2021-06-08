using System;

namespace ProjetPT2K
{
    public partial class EMPRUNTER
    {
        /// <summary>
        /// Return true if the current loan has been extended.
        /// </summary>
        /// <returns> a boolean </returns>
        public bool HasBeenExtended()
        {
            return (this.DATE_RETOUR_ATTENDUE - this.DATE_EMPRUNT) > TimeSpan.FromDays(this.ALBUMS.GENRES.DÉLAI);
        }

        /// <summary>
        /// Extend the current loan by a month.
        /// </summary>
        /// <returns> a boolean </returns>
        public void Extend()
        {
            if (!HasBeenExtended())
            {
                this.DATE_RETOUR_ATTENDUE = this.DATE_RETOUR_ATTENDUE.AddDays(30);
                Database.GetInstance().GetConnection().SaveChanges();
            }
        }

        /// <summary>
        /// Return the string representation of the loan.
        /// </summary>
        /// <returns> a string </returns>
        public override String ToString()
        {
            string extended = this.HasBeenExtended() ? " (prolongé)" : "";
            return this.ALBUMS.TITRE_ALBUM.Trim() + " - du " + this.DATE_EMPRUNT.ToShortDateString()
                + " au " + this.DATE_RETOUR_ATTENDUE.ToShortDateString() + extended;
        }
    }
}