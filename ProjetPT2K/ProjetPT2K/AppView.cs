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

        private int MenuIndex;

        public AppView()
        {
            InitializeComponent();
            this.MenuIndex = 0;
            MainMenu();
        }

        private void MainMenu()
        {
            mainMenuText.Items.Add("\nApplication\n");
            mainMenuText.Items.Add("1. Se connecter");
            mainMenuText.Items.Add("2. Créer un compte");
            mainMenuText.Items.Add("3. Quitter");
        }

        private void Login()
        {
            string login = passwordTextBox.Text;
            string password = loginTextBox.Text;

            ABONNÉS subscriber = Database.GetInstance().Login(login, password);
            if (subscriber == null)
                mainMenuText.Items.Add("Mauvais identifiant ou mauvais mot de passe");
            else
                mainMenuText.Items.Add("A décommenter");
            //    subscriber.Menu();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void ConnexionButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Length > 0 && loginTextBox.Text.Length > 0 && this.MenuIndex == 1)
                Login();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
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
