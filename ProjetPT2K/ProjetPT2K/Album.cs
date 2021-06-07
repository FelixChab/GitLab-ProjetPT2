using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPT2K
{
    public partial class ALBUMS
    {

        public bool IsAvailable()
        {
            foreach (EMPRUNTER loan in this.EMPRUNTER)
            {
                if (loan.DATE_RETOUR != null)
                    return false;
            }
            return true;
        }

        /**
         * Return the string representation of the Album.
         */
        public override String ToString()
        {
            string availability = this.IsAvailable() ? "" : " (indisponible)";
            return this.TITRE_ALBUM.Trim() + " - " + this.GENRES.LIBELLÉ_GENRE.Trim() + availability;
        }
    }
}
