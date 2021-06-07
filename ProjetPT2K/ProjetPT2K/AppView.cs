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
         * The connection to the database.
         */
        private Database Database;

        /**
         * The non-paratorised constructor creating a new AppView object.
         */
        public AppView()
        {
            InitializeComponent();
            this.MenuIndex = 0;
            this.Database = Database.GetInstance();
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

            Account account = this.Database.Login(login, password);
            if (account == null)
            {
                mainMenuText.Items.Add("Mauvais identifiant ou mauvais mot de passe");
                loginTextBox.Text = passwordTextBox.Text = "";
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
            switch (this.MenuIndex)
            {
                case 1:
                    loginTextBox.Enabled = mainMenuButton.Enabled = true;
                    connexionButton.Enabled = passwordTextBox.Enabled = true;
                    break;
                case 2:
                    AttemptSubscriberCreation();
                    break;
            }
        }

        /**
         * Try to create a new subscriber account with the information given by the user.
         */
        private void AttemptSubscriberCreation()
        {
            CreateAccountView view = new CreateAccountView();
            if (view.ShowDialog() == Form.Answer.Validate)
            {
                if (!this.Database.LoginExists(view.Login))
                {
                    PAYS country = (from country in this.Database.GetConnection().PAYS
                            where (country.NOM_PAYS == view.Country)
                            select country).FirstOrDefault();

                    if (country == null)
                    {
                        // TODO: handle (somehow) the error message (alertBox ?)
                        mainMenuText.Items.Add("Le pays '" + view.Country + "' n'est pas valide");
                    }
                    else
                    {
                        this.Database.CreateAccount(view.FirstName, view.LastName, 
                                country.CODE_PAYS, view.Login, view.Password);
                        mainMenuText.Items.Add("Compte abonné créé avec succès");
                    }
                }
                else
                {
                    mainMenuText.Items.Add("Un compte possèdant le login '" + view.Login + "' existe déjà");
                }
            }

        }

    }
}
