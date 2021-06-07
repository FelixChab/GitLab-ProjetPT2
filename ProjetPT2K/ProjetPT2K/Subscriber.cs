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

            this.Connection.EMPRUNTER.Add(borrow);
            this.Connection.SaveChanges();
        }

        public List<ALBUMS> GetRecommandations()
        {
            var top = (from loan in this.EMPRUNTER
                       group loan.ALBUMS by loan.ALBUMS.GENRES into groups
                       select groups);

            Dictionary<GENRES, int> preferences = new Dictionary<GENRES, int>(); 
            foreach (var request in top)
            {
                if (preferences.ContainsKey(request.Key))
                {
                    preferences[request.Key]++;
                }
                else
                {
                    preferences[request.Key] = 1;
                }
            }


            return null;
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
