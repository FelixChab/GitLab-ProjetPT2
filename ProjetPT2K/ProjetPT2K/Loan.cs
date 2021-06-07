using System;

namespace ProjetPT2K
{
    public partial class EMPRUNTER
    {
        /**
         * Return true if the current loan has been extended.
         * 
         * @return a boolean
         */
        public bool HasBeenExtended()
        {
            return (this.DATE_RETOUR_ATTENDUE - this.DATE_EMPRUNT) > TimeSpan.FromDays(this.ALBUMS.GENRES.DÉLAI);
        }

        /**
         * Extend the current loan by a year.
         */
        public void Extend()
        {
            this.DATE_RETOUR_ATTENDUE = this.DATE_RETOUR_ATTENDUE.AddDays(30);
            Database.GetInstance().GetConnection().SaveChanges();
        }

        /**
         * Return the string representation of the Loan.
         * 
         * @return a string
         */
        public override String ToString()
        {
            string extended = this.HasBeenExtended() ? " (prolongé)" : "";
            return this.ALBUMS.TITRE_ALBUM.Trim() + " - du " + this.DATE_EMPRUNT.ToShortDateString()
                + " au " + this.DATE_RETOUR_ATTENDUE.ToShortDateString() + extended;
        }
    }
}