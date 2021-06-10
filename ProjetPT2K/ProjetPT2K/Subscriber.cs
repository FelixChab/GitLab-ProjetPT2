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
                if (theLoan.DATE_RETOUR == null) continue;
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
                EMPRUNTER theLoan = this.GetLoanOfAlbum(theAlbum);
                if (theLoan != null)
                    UpdateLoan(theLoan);
                else
                    CreateLoan(theAlbum);
            }
            else
            {
                throw new Exception("L'album n'est pas disponible à l'emprunt");
            }
        }

        /// <summary>
        /// Return the loan of the current subscriber whose album is the same as the given one.
        /// </summary>
        /// <param name="theAlbum"> the considered album </param>
        /// <returns></returns>
        private EMPRUNTER GetLoanOfAlbum(ALBUMS theAlbum)
        {
            foreach (EMPRUNTER theLoan in this.EMPRUNTER)
            {
                if (theLoan.ALBUMS.Equals(theAlbum))
                    return theLoan;
            }
            return null;
        }

        /// <summary>
        /// Update the borrow date and the return date of the given loan.
        /// </summary>
        /// <param name="theLoan"> the considered loan </param>
        private void UpdateLoan(EMPRUNTER theLoan)
        {
            ALBUMS theAlbum = theLoan.ALBUMS;

            theLoan.DATE_RETOUR = null;
            theLoan.DATE_EMPRUNT = DateTime.Now;
            theLoan.DATE_RETOUR_ATTENDUE = DateTime.Now.AddDays(theAlbum.GENRES.DÉLAI);

            this.Connection.SaveChanges();
        }

        /// <summary>
        /// Create a new loan for the given album and insert it into the database.
        /// </summary>
        /// <param name="theAlbum"> the considered album </param>
        private void CreateLoan(ALBUMS theAlbum)
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

        /// <summary>
        /// Create a new loan for the given album and insert it into the database.
        /// </summary>
        /// <param name="theAlbum"> the considered album </param>
        private void CreateLoan(ALBUMS theAlbum)
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Dictionary<ALBUMS, int> GetRecommandations()
        {
            GENRES theGenre = this.GetMostBorrowedGenre();
            return Database.GetInstance().GetMostBorrowedAlbumsOfGenre(theGenre);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private GENRES GetMostBorrowedGenre()
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

                if (topGenres[loan.ALBUMS.GENRES] > loanNumber)
                {
                    loanNumber = topGenres[loan.ALBUMS.GENRES];
                    theGenre = loan.ALBUMS.GENRES;
                }

            }
            return theGenre;
        }

        /// <summary>
        /// Return the string representation of the subscriber.
        /// </summary>
        /// <returns> a string </returns>
        public override String ToString()
        {
            return NOM_ABONNÉ.Trim() + " " + PRÉNOM_ABONNÉ.Trim();
        }
    }
}
