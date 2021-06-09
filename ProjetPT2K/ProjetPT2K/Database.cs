﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace ProjetPT2K
{
    /// <summary>
    /// Class representing the database and its connection.
    /// </summary>
    public class Database
    {
        /// <summary>
        /// The (unique) instance of the database
        /// </summary>
        private static Database _Database;

        /// <summary>
        /// Attributes allowing the connection
        /// </summary>
        private readonly MusiquePT2_KEntities Connection;

        /// <summary>
        /// The non-parameterised constructor creating a new instance of Database
        /// </summary>
        private Database()
        {
            this.Connection = new MusiquePT2_KEntities();
        }

        /// <summary>
        /// Function that allows the instanciation of the database
        /// </summary>
        /// <returns> a Database object </returns>
        public static Database GetInstance()
        {
            if (_Database == null)
            {
                _Database = new Database();
            }
            return _Database;
        }

        /// <summary>
        /// Return the connection to the database.
        /// </summary>
        /// <returns> a MusiquePT2_KEntities object </returns>
        public MusiquePT2_KEntities GetConnection()
        {
            return this.Connection;
        }

        /// <summary>
        /// Restore the database to a state where no subscribers and no loans are registered.
        /// </summary>
        public void RestoreCleanState()
        {
            this.Connection.Database.ExecuteSqlCommand("TRUNCATE TABLE EMPRUNTER");
            this.Connection.Database.ExecuteSqlCommand("DELETE FROM ABONNÉS");
        }

        /// <summary>
        /// Return the account retrieved from the database corresponding to the given credentials.
        /// </summary>
        /// <param name="login"> the login of the account </param>
        /// <param name="password"> the password of the account </param>
        /// <returns></returns>
        public Account Login(string login, string password)
        {
            Account account;
            if (login == Admin.LOGIN && password == Admin.PASSWORD)
                account = new Admin();
            else
                account = FetchSubscriberAccount(login, password);
            return account;
        }

        /// <summary>
        /// Retrieve the subscriber account corresponding to the given login and password.
        /// </summary>
        /// <param name="login"> the login of the subscriber </param>
        /// <param name="password"> the password of the subscriber </param>
        /// <returns> an Account object </returns>
        private Account FetchSubscriberAccount(string login, string password)
        {
            var request = from subscriber in this.Connection.ABONNÉS
                          where (subscriber.LOGIN_ABONNÉ == login)
                          && (subscriber.PASSWORD_ABONNÉ == password)
                          select subscriber;

            return (ABONNÉS)request.FirstOrDefault();
        }

        /// <summary>
        /// Return true if an account with the given login already exists in the database
        /// </summary>
        /// <param name="login"> the login we are looking for </param>
        /// <returns> a boolean </returns>
        public bool AccountExists(string login)
        {
            ABONNÉS account = (from subscriber in this.Connection.ABONNÉS
                               where (subscriber.LOGIN_ABONNÉ == login)
                               select subscriber).FirstOrDefault();

            return account != null;
        }

        /// <summary>
        /// Create a new subscriber account in the database
        /// </summary>
        /// <param name="firstname"> the firstname of the user </param>
        /// <param name="lastname"> the lastname of the user </param>
        /// <param name="countryCode"> the code of the user's country</param>
        /// <param name="login"> the login of the user </param>
        /// <param name="password"> the password of the user </param>
        public void CreateAccount(string firstname, string lastname, int countryCode, string login, string password)
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

        /// <summary>
        /// Return the list of all the inactive subscribers of the database (those who have not borrowed an album in a year).
        /// </summary>
        /// <returns> a list of Abonné objects </returns>
        public List<ABONNÉS> GetInactiveSubscribers()
        {
            List<ABONNÉS> inactiveSubscribers = new List<ABONNÉS>();
            foreach (ABONNÉS subscriber in this.Connection.ABONNÉS)
            {
                if (!subscriber.IsActive())
                    inactiveSubscribers.Add(subscriber);
                /*
                EMPRUNTER loan = subscriber.EMPRUNTER.FirstOrDefault();
                if (loan != null && loan.DATE_RETOUR != null && loan.DATE_RETOUR.Value.AddYears(1) < DateTime.Now)
                {
                    List<EMPRUNTER> loans = new List<EMPRUNTER>();
                    loans.AddRange(subscriber.EMPRUNTER);
                    foreach (EMPRUNTER e in loans)
                    {
                        subscriber.EMPRUNTER.Remove(e);
                    }
                    Connection.ABONNÉS.Remove(subscriber);
                }
                */
            }

            return inactiveSubscribers;
        }

        /// <summary>
        /// Return the album corresponding to the given ID in the database.
        /// </summary>
        /// <param name="ID"> the ID of the album </param>
        /// <returns> an Album object </returns>
        public ALBUMS GetAlbumWithID(int ID)
        {
            ALBUMS theAlbum = (from album in this.Connection.ALBUMS
                               where album.CODE_ALBUM == ID
                               select album).FirstOrDefault();

            return theAlbum;
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
