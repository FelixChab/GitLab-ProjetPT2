using System;
using System.Collections.Generic;

namespace ProjetPT2K
{
    /// <summary>
    /// Class representing a subscriber in the database.
    /// </summary>
    public partial class ABONNÉS : Account
    {
        /// <summary>
        /// Return true if the subscriber has borrowed an album in less than a year.
        /// </summary>
        /// <returns> a boolean </returns>
        public bool IsActive()
        {
            foreach (EMPRUNTER theLoan in this.EMPRUNTER)
            {
                TimeSpan theGap = DateTime.Now - theLoan.DATE_EMPRUNT;
                if (theGap.TotalDays >= 365)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Borrow the given album from the database for the current subscriber.
        /// </summary>
        /// <param name="theAlbum"> the considered album </param>
        public void BorrowAlbum(ALBUMS theAlbum)
        {
            if (theAlbum.IsAvailable())
            {
                EMPRUNTER theLoan = new EMPRUNTER
                {
                    CODE_ABONNÉ = this.CODE_ABONNÉ,
                    CODE_ALBUM = theAlbum.CODE_ALBUM,
                    DATE_EMPRUNT = DateTime.Today,
                    DATE_RETOUR_ATTENDUE = DateTime.Today.AddDays(theAlbum.GENRES.DÉLAI)
                };

                this.Connection.EMPRUNTER.Add(theLoan);
                this.Connection.SaveChanges();
            }
        }

        public Dictionary<ALBUMS, int> GetRecommandations()
        {
            int loanNumber = -1;
            GENRES theGenre = null;
            Dictionary<GENRES, int> topGenres = new Dictionary<GENRES, int>();
            foreach (EMPRUNTER loan in this.EMPRUNTER)
            {
                if (topGenres.ContainsKey(loan.ALBUMS.GENRES))
                {
                    topGenres[loan.ALBUMS.GENRES]++;
                }
                else
                {
                    topGenres[loan.ALBUMS.GENRES] = 1;
                }

                if (topGenres[loan.ALBUMS.GENRES] > loanNumber)
                {
                    loanNumber = topGenres[loan.ALBUMS.GENRES];
                    theGenre = loan.ALBUMS.GENRES;
                }

            }
            return Database.GetInstance().GetBestAlbumsOfGenre(theGenre);
        }

        /// <summary>
        /// Return the string representation of the subscriber.
        /// </summary>
        /// <returns> a string </returns>
        public override String ToString()
        {
            return NOM_ABONNÉ + " " + PRÉNOM_ABONNÉ + " (" + CODE_ABONNÉ + ")";
        }
    }
}
