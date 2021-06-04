using System.Linq;

namespace ProjetPT2K
{

	public class Database
	{
		/**
		 * The (unique) instance of the database.
		 */
		private static Database _Database;

		/**
		 * Attributes allowing the connection.
		 */
		private readonly MusiquePT2_KEntities Connection;
		
		/**
		 * The non-paraterised constructor creating a new instance of Database.
		 */
		private Database() {
			this.Connection = new MusiquePT2_KEntities();
		}

		/**
		 * Function that allows the instanciation of the database.
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
		 * Function responsible for the connection with the database.
		 */
		public MusiquePT2_KEntities GetConnection()
        {
			return this.Connection;
        }

		/**
		 * Function that allows a subscriber to log itself the application.
		 * 
		 * @param login, the login of the subscriber.
		 * @param password, the passeword of the subscriber.
		 * */
		public ABONNÉS Login(string login, string password)
		{
			var request = from subscriber in this.Connection.ABONNÉS
						  where (subscriber.LOGIN_ABONNÉ == login)
						  && (subscriber.PASSWORD_ABONNÉ == password)
						  select subscriber;
			return (ABONNÉS)request.FirstOrDefault();
		}
	}
}