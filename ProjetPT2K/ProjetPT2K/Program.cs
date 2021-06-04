using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetPT2K
{
    public static class Program
    {


        /// <summary>
        /// Application main starting point
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainMenu();
        }

        private static void MainMenu()
        {
            string choice;
            bool onTheApp = true;
            Console.ReadLine();
            while (onTheApp)
            {
                Console.WriteLine("\nApplication\n");
                Console.WriteLine("1. Se connecter");
                Console.WriteLine("2. Créer un compte");
                Console.WriteLine("3. Quitter");

                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Login();
                        break;
                    case "2":
                        break;
                    case "3":
                        onTheApp = false;
                        break;
                }
            }
        }

        private static void Login()
        {
            string login = Console.ReadLine();
            string password = Console.ReadLine();
            ABONNÉS subscriber = Database.GetInstance().Login(login, password);
            if (subscriber == null)
                Console.WriteLine("Mauvais identifiant ou mauvais mot de passe");
            else
                Console.WriteLine("A décommenter");
                // subscriber.Menu();
        }

    }
}
