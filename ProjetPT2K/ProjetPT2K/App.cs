using System;

namespace ProjetPT2K
{

	public class App
	{
		private static App app;

		private MusiquePT2_KEntities Connection;
		
		public App()
		{
			app = this;
			Connection = new MusiquePT2_KEntities();

			string username = Console.ReadLine();
			string password = Console.ReadLine();
		}

		public static App getInstance()
		{
			return app;
		}

		public MusiquePT2_KEntities getConnection()
        {
			return this.Connection;
        }
	}
}