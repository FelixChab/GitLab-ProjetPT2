using System;

namespace ProjetPT2K
{
    public partial class ALBUMS
    {
        /**
         * Return true if the album is available, i.e. can be borrowed.
         * 
         * @return a boolean
         */
        public bool IsAvailable()
        {
            foreach (EMPRUNTER loan in this.EMPRUNTER)
            {
                if (loan.DATE_RETOUR != null)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Return the string representation of the Album.
        /// </summary>
        /// <returns> a string </returns>
        public override String ToString()
        {
            string availability = this.IsAvailable() ? "" : " (indisponible)";
            return this.TITRE_ALBUM.Trim() + " - " + this.GENRES.LIBELLÉ_GENRE.Trim() + availability;
        }
    }
}
