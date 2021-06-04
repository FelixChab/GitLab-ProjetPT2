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
            
            ABONNÉS sub = LoginUser();
            if (sub == null)
            {
                Console.WriteLine("Mauvais identifiant ou mauvais mot de passe");
            }
        }

        private static ABONNÉS LoginUser()
        {
            string login = Console.ReadLine();
            string password = Console.ReadLine();
            Database database = Database.GetInstance();
            return database.Login(login, password);
        }

    }
}
