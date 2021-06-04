using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPT2K
{
    public partial class ABONNÉS : Account
    {
        public List<ALBUMS> getLoans()
        {
            MusiquePT2_KEntities connection = Database.GetInstance().GetConnection();
            List<ALBUMS> loans = (from a in connection.ALBUMS
                                  join e in connection.EMPRUNTER
                                  on a.CODE_ALBUM equals e.CODE_ALBUM
                                  join ab in connection.ABONNÉS on e.CODE_ABONNÉ equals CODE_ABONNÉ
                                  select a).ToList();
            return loans;
        }

        public String toString()
        {
            return NOM_ABONNÉ + " " + PRÉNOM_ABONNÉ + " (" + CODE_ABONNÉ + ")";
        }
    }
}
