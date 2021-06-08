using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetPT2K
{

    public class Database
    {
        /**
         * The (unique) instance of the database
         */
        private static Database _Database;

        /**
         * Attributes allowing the connection
         */
        private readonly MusiquePT2_KEntities Connection;

        /**
         * The non-parameterised constructor creating a new instance of Database
         */
        private Database()
        {
            this.Connection = new MusiquePT2_KEntities();
        }

        /**
         * Function that allows the instanciation of the database
         */
        public static Database GetInstance()
        {
            if (_Database == null)
            {
                _Database = new Database();
            }
            return _Database;
        }

        /**
         * Function responsible for the connection with the database
         */
        public MusiquePT2_KEntities GetConnection()
        {
            return this.Connection;
        }

        /**
         * Restore the database to a state where no subscribers and no loans are registered.
         */
        public void RestoreCleanState()
        {
<<<<<<< HEAD
            this.Connection.Database.ExecuteSqlCommand("TRUNCATE TABLE EMPRUNTER");
            this.Connection.Database.ExecuteSqlCommand("DELETE FROM ABONNÉS");
=======
            this.Connection.Database.ExecuteSqlCommand("DELETE FROM ABONNÉS");
            this.Connection.Database.ExecuteSqlCommand("TRUNCATE TABLE EMPRUNTER");
>>>>>>> bf6cf64 (Created UT based class)
        }

        /**
         * Function that allows a subscriber to log itself the application
         * 
         * @param login, the login of the subscriber
         * @param password, the passeword of the subscriber
         * */
        public Account Login(string login, string password)
        {
            Account account;
            if (login == Admin.LOGIN && password == Admin.PASSWORD)
                account = new Admin();
            else
                account = FetchSubscriberAccount(login, password);
            return account;
        }

        /**
         * Retrieve the subscriber account corresponding to the given login and password
         */
        private Account FetchSubscriberAccount(string login, string password)
        {
            var request = from subscriber in this.Connection.ABONNÉS
                          where (subscriber.LOGIN_ABONNÉ == login)
                          && (subscriber.PASSWORD_ABONNÉ == password)
                          select subscriber;
            return (ABONNÉS)request.FirstOrDefault();
        }

        /**
         * Return true if an account with the given login already exists in the database
         */
        public bool AccountExists(string login)
        {
            ABONNÉS account = (from subscriber in this.Connection.ABONNÉS
                               where (subscriber.LOGIN_ABONNÉ == login)
                               select subscriber).FirstOrDefault();

            return account != null;
        }

        /**
         * Create a new subscriber account in the database
         */
        public void CreateAccount(string firstname, string lastname, int countryCode,
                string login, string password)
        {
            ABONNÉS subscriber = new ABONNÉS
            {
                CODE_PAYS = countryCode,
                NOM_ABONNÉ = lastname,
                PRÉNOM_ABONNÉ = firstname,
                LOGIN_ABONNÉ = login,
                PASSWORD_ABONNÉ = password
            };

            this.Connection.ABONNÉS.Add(subscriber);
            this.Connection.SaveChanges();
        }

        public List<ALBUMS> GetAllAlbums()
        {
            var albums = from album in this.Connection.ALBUMS
                         select album;

            return albums.ToList();
        }

        public List<ALBUMS> GetAlbumsContaining(string pattern)
        {
            var albums = from album in this.Connection.ALBUMS
                         where album.TITRE_ALBUM.Contains(pattern)
                         select album;

            return albums.ToList();
        }

        public Dictionary<ALBUMS, int> GetBestAlbumsOfGenre(GENRES genre)
        {
            Dictionary<ALBUMS, int> topAlbums = new Dictionary<ALBUMS, int>();
            List<ALBUMS> list = (from a in Connection.ALBUMS
                                 join e in Connection.EMPRUNTER on a.CODE_ALBUM equals e.CODE_ALBUM
                                 where a.GENRES.LIBELLÉ_GENRE == genre.LIBELLÉ_GENRE
                                 orderby a.EMPRUNTER.Count descending
                                 select a).ToList();
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
            Dictionary<ALBUMS, int> sorted = (from entry in topAlbums orderby entry.Value descending select entry).ToDictionary(entry => entry.Key, entry => entry.Value);
            return sorted;
        }

    }
}
