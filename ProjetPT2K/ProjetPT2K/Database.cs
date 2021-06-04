using System.Linq;

namespace ProjetPT2K
{

	public class Database
	{
		private static Database _Database;

		private readonly MusiquePT2_KEntities Connection;
		
		private Database() {
			this.Connection = new MusiquePT2_KEntities();
		}

		public static Database GetInstance()
		{
			if (_Database == null)
			{
				_Database = new Database();
			}
			return _Database;
		}

		public MusiquePT2_KEntities GetConnection()
        {
			return this.Connection;
        }

		public ABONNÉS Login(string login, string password)
		{
			var request = from subscriber in this.Connection.ABONNÉS
						  where (subscriber.LOGIN_ABONNÉ == login)
						  && (subscriber.PASSWORD_ABONNÉ == password)
						  select subscriber;
			return (ABONNÉS)request.First();
		}
	}
}