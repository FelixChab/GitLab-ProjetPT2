using System;

public class App
{
	private static App app;

	public App()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);

		string username = Console.ReadLine();
		string password = Console.ReadLine();
	}
}
