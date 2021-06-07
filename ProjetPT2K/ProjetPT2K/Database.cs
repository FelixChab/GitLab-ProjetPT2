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
        private Database() {
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
    }
}
