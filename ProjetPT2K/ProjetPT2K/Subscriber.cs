using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetPT2K
{
    public partial class ABONNÉS : Account
    {

        /**
         * Function that allows to borrow an album.
         *
         * @param album the album the subscriber want to borrow
         */
        public void BorrowAlbum(ALBUMS album)
        {
            EMPRUNTER borrow = new EMPRUNTER
            {
                CODE_ABONNÉ = this.CODE_ABONNÉ,
                CODE_ALBUM = album.CODE_ALBUM,
                DATE_EMPRUNT = DateTime.Today,
                DATE_RETOUR_ATTENDUE = DateTime.Today.AddDays(album.GENRES.DÉLAI)
            };

            Connection.EMPRUNTER.Add(borrow);
            Connection.SaveChanges();
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



        /**
         * Return the string representation of the subscriber
         */
        public override String ToString()
        {
            return NOM_ABONNÉ + " " + PRÉNOM_ABONNÉ + " (" + CODE_ABONNÉ + ")";
        }

    }
}
