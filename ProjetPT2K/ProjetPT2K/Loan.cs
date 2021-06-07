using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPT2K
{
    public partial class EMPRUNTER
    {

        public bool HasBeenExtended()
        {
            return (this.DATE_RETOUR_ATTENDUE - this.DATE_EMPRUNT) > TimeSpan.FromDays(this.ALBUMS.GENRES.DÉLAI);
        }

        public void Extend()
        {
            this.DATE_RETOUR_ATTENDUE = this.DATE_RETOUR_ATTENDUE.AddDays(30);
            Database.GetInstance().GetConnection().SaveChanges();
        }

        /**
         * Return the string representation of the Loan.
         */
        public override String ToString()
        {
            string extended = this.HasBeenExtended() ? " (prolongé)" : "";
            return this.ALBUMS.TITRE_ALBUM.Trim() + " - du " + this.DATE_EMPRUNT.ToShortDateString()
                + " au " + this.DATE_RETOUR_ATTENDUE.ToShortDateString() + extended;
        }
    }
}