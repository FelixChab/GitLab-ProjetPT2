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

        public List<ABONNÉS> getLateSubscribers()
        {
            MusiquePT2_KEntities connection = Database.GetInstance().GetConnection();
            List<ABONNÉS> lateSubscribers = (from a in connection.ALBUMS
                                  join e in connection.EMPRUNTER
                                  on a.CODE_ALBUM equals e.CODE_ALBUM
                                  where (e.DATE_EMPRUNT.AddDays(10).CompareTo(new DateTime()) <= 0)
                                  from s in connection.ABONNÉS where s.CODE_ABONNÉ==e.CODE_ABONNÉ select s).ToList();
            return lateSubscribers;
        }
    }
}
