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
            MusiquePT2_KEntities connection = Database.GetInstance().GetConnection();
            List<ALBUMS> lateLoans = (from a in connection.ALBUMS
                                  join e in connection.EMPRUNTER
                                  on a.CODE_ALBUM equals e.CODE_ALBUM
                                  where e.DATE_RETOUR_ATTENDU < e.DATE_RETOUR select a).ToList();
            return lateLoans;
        }

    }
}
