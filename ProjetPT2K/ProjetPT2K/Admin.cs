using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPT2K
{
    public class Admin : Account
    {
        /**
         * The administrator login.
         */
        public static string LOGIN = "ADMIN";

        /**
         * The administrator password.
         */
        public static string PASSWORD = "admin";

        public Admin()
        {
            this.isAdministrator = true;
        }

        /**
         * Method to get albums albums that are late
         */
        public List<ALBUMS> GetLateLoans()
        {
            List<ALBUMS> lateLoans = (from a in Connection.ALBUMS
                                  join e in Connection.EMPRUNTER
                                  on a.CODE_ALBUM equals e.CODE_ALBUM
                                  where (e.DATE_RETOUR == null && e.DATE_RETOUR_ATTENDUE > DateTime.Now) select a).ToList();
            return lateLoans;
        }

        /**
         * Method to get subscriber who have 10 more days late
         */
        public List<ABONNÉS> GetLateSubscribers()
        {
            List<ABONNÉS> lateSubscribers = (from a in Connection.ALBUMS
                                  join e in Connection.EMPRUNTER
                                  on a.CODE_ALBUM equals e.CODE_ALBUM
                                  where (e.DATE_RETOUR == null && e.DATE_EMPRUNT.AddDays(10).CompareTo(DateTime.Now) <= 0)
                                  from s in Connection.ABONNÉS where s.CODE_ABONNÉ==e.CODE_ABONNÉ select s).ToList();
            return lateSubscribers;
        }

        /**
         * Method to purge database : remove subscriber who have not borrowed for a year (and its loans)
         */
        public int PurgeDatabase()
        {
            for (int index = 0; index < Connection.ABONNÉS.Count(); index++){
                ABONNÉS sub = Connection.ABONNÉS.ElementAt(index);
                EMPRUNTER music = sub.EMPRUNTER.LastOrDefault();
                if (music != null && music.DATE_RETOUR != null && music.DATE_RETOUR.Value.AddYears(1) < DateTime.Now ){
                    foreach(EMPRUNTER e in sub.EMPRUNTER)
                    {
                        Connection.EMPRUNTER.Remove(e);
                    }
                    Connection.ABONNÉS.Remove(sub);
                }
            }
            Connection.SaveChanges();
            return 0;
        }
        /**
        * Method to get top 10 albums of the year
        */
        public List<ALBUMS> getBestAlbums()
        {
            var allQuery = (from a in Connection.ALBUMS
                            join e in Connection.EMPRUNTER
                            on a.CODE_ALBUM equals e.CODE_ALBUM
                            where (e.DATE_EMPRUNT.Year == DateTime.Now.Year)
                            orderby a.EMPRUNTER.Count descending
                            select a);
            return allQuery.Take(10).ToList();
        }
    }
}
