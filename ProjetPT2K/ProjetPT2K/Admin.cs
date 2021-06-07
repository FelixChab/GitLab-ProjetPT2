using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPT2K
{
    public class Admin : Account
    {
        /* Administrator login & credentials */
        public static string LOGIN = "ADMIN";
        public static string PASSWORD = "admin";

        public Admin()
        {
            this.IsAdministrator = true;
        }

        /**
         * Method to get albums loans that are late
         */
        public List<ALBUMS> GetLateLoans()
        {
            List<ALBUMS> lateLoans = (from a in Connection.ALBUMS
                                      join e in Connection.EMPRUNTER
                                      on a.CODE_ALBUM equals e.CODE_ALBUM
                                      where (e.DATE_RETOUR == null && e.DATE_RETOUR_ATTENDUE > DateTime.Now)
                                      select a).ToList();
            return lateLoans;
        }

        /**
         * Method to get subscriber who are 10-days late on a loan
         */
        public List<ABONNÉS> GetLateSubscribers()
        {
            List<ABONNÉS> lateSubscribers= new List<ABONNÉS>();
            foreach (EMPRUNTER e in Connection.EMPRUNTER)
            {
                if (e.DATE_RETOUR == null && e.DATE_EMPRUNT.AddDays(10).CompareTo(DateTime.Now) <= 0)
                {
                    lateSubscribers.Add(e.ABONNÉS);
                }
            }
            return lateSubscribers;
        }

        /**
         * Method to purge database : remove subscriber who have not borrowed for a year (and his loans)
         */
        public void PurgeDatabase()
        {
            foreach (ABONNÉS sub in Connection.ABONNÉS){
                EMPRUNTER music = sub.EMPRUNTER.FirstOrDefault();
                if (music != null && music.DATE_RETOUR != null && music.DATE_RETOUR.Value.AddYears(1) < DateTime.Now){
                    List < EMPRUNTER >loans = new List<EMPRUNTER>();
                    loans.AddRange(sub.EMPRUNTER);
                    foreach(EMPRUNTER e in loans)
                    {
                        sub.EMPRUNTER.Remove(e);
                    }
                    Connection.ABONNÉS.Remove(sub);
                }
            }
            Connection.SaveChanges();
        }

        /**
         * Method that returns a list of albums not loan in a year
         */
        public List<ALBUMS> GetAlbumsNoLoan()
        {
            List<ALBUMS> noLoans = new List<ALBUMS>();
            foreach (EMPRUNTER e in Connection.EMPRUNTER)
            {
                    if ((DateTime.Now-e.DATE_RETOUR)>=TimeSpan.FromDays(365))
                {
                    noLoans.Add(e.ALBUMS);
                }
            }
            return noLoans;
        }

        /**
        * Method to get top 10 albums of the year
        */
        public Dictionary<ALBUMS, int> GetBestAlbums()
        {
            Dictionary<ALBUMS, int> topAlbums = new Dictionary<ALBUMS, int>();
            List<ALBUMS> list = (from a in Connection.ALBUMS join e in Connection.EMPRUNTER on a.CODE_ALBUM equals e.CODE_ALBUM orderby a.EMPRUNTER.Count descending select a).ToList();
            for (int start = 0; start < list.Count; start++)
            {
                ALBUMS target = list[start];
                int empruntCount = target.EMPRUNTER.Count;
                foreach (EMPRUNTER e in target.EMPRUNTER)
                {
                    if (e.DATE_EMPRUNT.Year != DateTime.Now.Year)
                    {
                        empruntCount--;
                    }

                }
                if (empruntCount != 0 && !topAlbums.ContainsKey(target))
                {
                    topAlbums.Add(target, empruntCount);
                }
            }
            Dictionary<ALBUMS, int> sorted = (from entry in topAlbums orderby entry.Value ascending select entry).ToDictionary(entry => entry.Key, entry => entry.Value);
            return sorted;
        }
    }
}