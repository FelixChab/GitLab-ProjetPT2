using System;

namespace Discotèque
{
    /// <summary>
    /// Class representing an album in the database
    /// </summary>
    public partial class ALBUMS
    {
        /// <summary>
        /// Return true if the album is available (it can be borrowed).
        /// </summary>
        /// <returns></returns>
        public bool IsAvailable()
        {
            foreach (EMPRUNTER theLoan in this.EMPRUNTER)
            {
                if (theLoan.DATE_RETOUR == null)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Return true if the album has been borrowed less than a year ago.
        /// </summary>
        /// <returns> a boolean </returns>
        public bool IsPopular()
        {
            foreach (EMPRUNTER theLoan in this.EMPRUNTER)
            {
                TimeSpan theGap = DateTime.Now - theLoan.DATE_EMPRUNT;
                if (theGap.TotalDays <= 365)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Return the string representation of the Album.
        /// </summary>
        /// <returns> a string </returns>
        public override String ToString()
        {
            return this.TITRE_ALBUM.Trim() + " - " + this.GENRES.LIBELLÉ_GENRE.Trim();
        }
    }
}