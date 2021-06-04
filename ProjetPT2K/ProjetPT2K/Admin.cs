using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPT2K
{
    public class Admin : Account
    {
        public Admin()
        {

        }

        public List<ALBUMS> GetLateLoans()
        {
            List<ALBUMS> lateLoans = (from a in this.Connection.ALBUMS
                                      join e in this.Connection.EMPRUNTER
                                      on a.CODE_ALBUM equals e.CODE_ALBUM
                                      where e.DATE_RETOUR_ATTENDUE < e.DATE_RETOUR
                                      select a).ToList();
            return lateLoans;
        }

        public List<ALBUMS> getLateSubscribers()
        {
            var lateLoans = (from a in this.Connection.ALBUMS
                             join e in this.Connection.EMPRUNTER
                             on a.CODE_ALBUM equals e.CODE_ALBUM
                             join g in this.Connection.GENRES
                             on a.CODE_GENRE equals g.CODE_GENRE
                             where e.DATE_RETOUR_ATTENDUE.CompareTo(e.DATE_EMPRUNT) <= a.GENRES.DÉLAI
                             select a).ToList();
            return lateLoans;
        }
    }
}
