﻿using System;
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
                                  where (e.DATE_RETOUR == null && e.DATE_RETOUR_ATTENDUE > DateTime.Now) select a).ToList();
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
        public int PurgeDatabase()
        {
            foreach (ABONNÉS sub in Connection.ABONNÉS){
                EMPRUNTER music = sub.EMPRUNTER.LastOrDefault();
                if (music != null && music.DATE_RETOUR != null && music.DATE_RETOUR.Value.AddYears(1) < DateTime.Now){
                    
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
        public List<ALBUMS> GetBestAlbums()
        {
            var allQuery = (from a in Connection.ALBUMS
                            join e in Connection.EMPRUNTER
                            on a.CODE_ALBUM equals e.CODE_ALBUM
                            where (e.DATE_EMPRUNT.AddYears(1).CompareTo(DateTime.Now) > 0)
                            orderby a.EMPRUNTER.Count descending
                            select a);
            return allQuery.Take(10).ToList();
        }
    }
}
