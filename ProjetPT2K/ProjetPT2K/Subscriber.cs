using System;
using System.Collections.Generic;

namespace ProjetPT2K
{
    public partial class ABONNÉS : Account
    {

        /// <summary>
        /// Borrow the given album from the database for the current subscriber.
        /// </summary>
        /// <param name="album"> the considered album </param>
        public void BorrowAlbum(ALBUMS album)
        {
            EMPRUNTER borrow = new EMPRUNTER
            {
                CODE_ABONNÉ = this.CODE_ABONNÉ,
                CODE_ALBUM = album.CODE_ALBUM,
                DATE_EMPRUNT = DateTime.Today,
                DATE_RETOUR_ATTENDUE = DateTime.Today.AddDays(album.GENRES.DÉLAI)
            };

            this.Connection.EMPRUNTER.Add(borrow);
            this.Connection.SaveChanges();
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
        /// Return the string representation of the subscriber.
        /// </summary>
        /// <returns> a string </returns>
        public override String ToString()
        {
            return NOM_ABONNÉ + " " + PRÉNOM_ABONNÉ + " (" + CODE_ABONNÉ + ")";
        }

    }
}
