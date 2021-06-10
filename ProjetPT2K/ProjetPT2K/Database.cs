using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
        /// <param name="theLogin"> the login of the account </param>
        /// <param name="thePassword"> the password of the account </param>
        /// <returns></returns>
        public Account Login(string theLogin, string thePassword)
        {
            if (theLogin == Administrator.LOGIN && thePassword == Administrator.PASSWORD)
                return new Administrator();
            return FetchSubscriberAccount(theLogin, thePassword);
        }

        /// <summary>
        /// Retrieve the subscriber account corresponding to the given login and password.
        /// </summary>
        /// <param name="theLogin"> the login of the subscriber </param>
        /// <param name="thePassword"> the password of the subscriber </param>
        /// <returns> an Account object </returns>
        private Account FetchSubscriberAccount(string theLogin, string thePassword)
        {
            List<ABONNÉS> theSubscribers = this.Connection.ABONNÉS.ToList();
            return theSubscribers.Find(subsbcriber =>
                subsbcriber.LOGIN_ABONNÉ.Trim() == theLogin &&
                subsbcriber.PASSWORD_ABONNÉ.Trim() == thePassword);
        }

        /// <summary>
        /// Return true if an account with the given login already exists in the database
        /// </summary>
        /// <param name="theLogin"> the login we are looking for </param>
        /// <returns> a boolean </returns>
        public bool AccountExists(string theLogin)
        {
            List<ABONNÉS> theSubscribers = this.Connection.ABONNÉS.ToList();
            return theSubscribers.Find(subsbcriber =>
                subsbcriber.LOGIN_ABONNÉ.Trim() == theLogin) != null;
        }

        /// <summary>
        /// Verify thepossibility to create a new subscriber account in the database. Creates it if possible.
        /// </summary>
        /// <param name="firstname"> the firstname of the user </param>
        /// <param name="lastname"> the lastname of the user </param>
        /// <param name="countryCode"> the code of the user's country</param>
        /// <param name="login"> the login of the user </param>
        /// <param name="password"> the password of the user </param>
        public void AttemptAccountCreation(string firstname, string lastname, int countryCode, string login, string password)
        {
            if (!AccountExists(login) && CredentialsAreValid(login, password))
                CreateAccount(firstname, lastname, countryCode, login, password);
            else
                throw new Exception("Nom d'utilisateur indisponible");
        }

        /// <summary>
        /// Create a new subscriber account in the database
        /// </summary>
        /// <param name="firstname"> the firstname of the user </param>
        /// <param name="lastname"> the lastname of the user </param>
        /// <param name="countryCode"> the code of the user's country</param>
        /// <param name="login"> the login of the user </param>
        /// <param name="password"> the password of the user </param>
<<<<<<< HEAD
        public void AttemptAccountCreation(string firstname, string lastname, int countryCode, string login, string password)
        {
            try
            {
                CredentialsAreValid(firstname, lastname, login, password);
            } 
            catch
            {
                throw;
            }
            if (AccountExists(login) || !CredentialsAreValid(firstname, lastname, login, password))
                throw new Exception("Nom d'utilisateur indisponible");
            CreateAccount(firstname, lastname, countryCode, login, password);
        }

        /// <summary>
        /// Return true if the login and the password are valid.
        /// </summary>
        /// <param name="theCredentials"> the list of credentials (login & password) </param>
        /// <returns></returns>
        private bool CredentialsAreValid(params string[] theCredentials)
        {
            Regex theRegex = new Regex("^[A-Za-z0-9]*$");
            foreach (string theCredential in theCredentials)
            {
                if (theCredential.Length == 0)
                    throw new Exception("Les champs ne doivent pas être vides");
                if (theCredential.Length > 32)
                    throw new Exception("Les champs ne doivent pas dépasser 32 caractères");
                if (!theRegex.IsMatch(theCredential))
                    throw new Exception("Les champs ne peuvent contenir que des lettres et des chiffres");
            }
            return true;
        }

        /// <summary>
        /// Create a new subscriber account in the database
        /// </summary>
        /// <param name="countryCode"> the code of the user's country</param>
        /// <param name="login"> the login of the user </param>
        /// <param name="password"> the password of the user </param>
        private void CreateAccount(string firstname, string lastname, int countryCode, string login, string password)
        {
            ABONNÉS theSubscriber = new ABONNÉS
            {
                NOM_ABONNÉ = lastname,
                PRÉNOM_ABONNÉ = firstname,
                LOGIN_ABONNÉ = login,
                PASSWORD_ABONNÉ = password
            };

            if (countryCode > 0)
                theSubscriber.CODE_PAYS = countryCode;

            this.Connection.ABONNÉS.Add(theSubscriber);
            this.Connection.SaveChanges();
        }


        /// <summary>
        /// Return all the allbums of the database.
        /// </summary>
        /// <returns> a list of Album objects </returns>
        public List<ALBUMS> GetAllAlbums()
        {
            return this.Connection.ALBUMS.ToList();
        }

        /// <summary>
        /// Return all the albums of the database whose name contains the given pattern.
        /// </summary>
        /// <param name="thePattern"> the given pattern </param>
        /// <returns> a list of Albums objects </returns>
        public List<ALBUMS> GetAlbumsContaining(string thePattern)
        {
            List<ALBUMS> theAlbums = this.GetAllAlbums();
            return theAlbums.FindAll(album => album.TITRE_ALBUM.Contains(thePattern));
        }

        /// <summary>
        /// Return the list of all the inactive subscribers of the database (those who have not borrowed an album in a year).
        /// </summary>
        /// <returns> a list of Abonné objects </returns>
        public List<ABONNÉS> GetInactiveSubscribers()
        {
            List<ABONNÉS> theInactiveSubscribers = new List<ABONNÉS>();
            List<ABONNÉS> theSubscribers = this.Connection.ABONNÉS.ToList();
            foreach (ABONNÉS theSubscriber in theSubscribers)
            {
                if (!theSubscriber.IsActive())
                    theInactiveSubscribers.Add(theSubscriber);
            }
            return theInactiveSubscribers;
        }

        /// <summary>
        /// Return the album corresponding to the given ID in the database.
        /// </summary>
        /// <param name="theID"> the ID of the album </param>
        /// <returns> an Album object </returns>
        public ALBUMS GetAlbumWithID(int theID)
        {
            List<ALBUMS> theAlbums = this.GetAllAlbums();
            return theAlbums.Find(theAlbum => theAlbum.CODE_ALBUM == theID);
        }

        /// <summary>
        /// Return the 10 most borrowed albums of the year of the given genre.
        /// </summary>
        /// <param name="theGenre"> the considered genre </param>
        /// <returns> a dictionnary of Album objects and int </returns>
        public Dictionary<ALBUMS, int> GetMostBorrowedAlbumsOfGenre(GENRES theGenre)
        {
            List<EMPRUNTER> theLoans = this.Connection.EMPRUNTER.ToList();
            Dictionary<ALBUMS, int> topAlbums = new Dictionary<ALBUMS, int>();
            foreach (EMPRUNTER theLoan in theLoans)
            {
                if (topAlbums.ContainsKey(theLoan.ALBUMS))
                    topAlbums[theLoan.ALBUMS]++;
                else if ((theLoan.DATE_EMPRUNT.Year == DateTime.Now.Year) && (theLoan.ALBUMS.GENRES == theGenre))
                    topAlbums[theLoan.ALBUMS] = 1;
            }
            return topAlbums.OrderBy(pair => pair.Value).Take(10)
                .ToDictionary(entry => entry.Key, entry => entry.Value);
        }

        /// <summary>
        /// Return the 10 most borrowed albums of the year.
        /// </summary>
        /// <returns> a dictionnary of Album objects and int </returns>
        public Dictionary<ALBUMS, int> GetMostBorrowedAlbums()
        {
            List<EMPRUNTER> theLoans = this.Connection.EMPRUNTER.ToList();
            Dictionary<ALBUMS, int> topAlbums = new Dictionary<ALBUMS, int>();
            foreach (EMPRUNTER theLoan in theLoans)
            {
                if (topAlbums.ContainsKey(theLoan.ALBUMS))
                    topAlbums[theLoan.ALBUMS]++;
                else if (theLoan.DATE_EMPRUNT.Year == DateTime.Now.Year)
                    topAlbums[theLoan.ALBUMS] = 1;
            }
            return topAlbums.OrderBy(pair => pair.Value).Take(10)
                .ToDictionary(entry => entry.Key, entry => entry.Value);
        }
    }
}
