using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetPT2K
{
    public partial class AppView : Form
    {
        /**
         * The index of the selected item of the main menu.
         */
        private int MenuIndex;

        /**
         * The non-paratorised constructor creating a new AppView object.
         */
        public AppView()
        {
            InitializeComponent();
            this.MenuIndex = 0;
            MainMenu();
        }

        /**
         * Display the main menu on the form.
         */
        private void MainMenu()
        {
            mainMenuText.Items.Add("\nApplication\n");
            mainMenuText.Items.Add("1. Se connecter");
            mainMenuText.Items.Add("2. Créer un compte");
            mainMenuText.Items.Add("3. Quitter");
        }

        /**
         * Attempt to connect the user to the database.
         */
        private void Login()
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            Account account = Database.GetInstance().Login(login, password);
            if (account == null)
            {
                mainMenuText.Items.Add("Mauvais identifiant ou mauvais mot de passe");
                loginTextBox.Text = "";
                passwordTextBox.Text = "";
            }
            else
            {
                string accountType = account.isAdministrator ? "(administrateur)" : "(abonné)";
                mainMenuText.Items.Add("Compte récupéré " + accountType);
                // subscriber.Menu();
            }
        }

        /**
         * Event triggered when the connexionButton is clicked.
         */
        private void ConnexionButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Length > 0 && loginTextBox.Text.Length > 0 && this.MenuIndex == 1)
                Login();
        }

        /**
         * Event triggered when the mainMenuButton is clicked.
         */
        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            this.MenuIndex = mainMenuText.SelectedIndex;
            if (this.MenuIndex == 1)
            {
                connexionButton.Enabled = true;
                passwordTextBox.Enabled = true;
                loginTextBox.Enabled = true;
                mainMenuButton.Enabled = true;
            }
        }
    }
}
