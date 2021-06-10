using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace ProjetPT2K
{
    public partial class Login : Form
    {
        private MusiquePT2_KEntities database = Database.GetInstance().GetConnection();

        /* Constructeur standard */
        public Login()
        {
            InitializeComponent();
            errorLabel.Visible = false;
        }

        /* Method of the "create account" button */
        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccountView accountView = new NewAccountView(this);
            accountView.Show();
        }

        /* Method of the "connection" button */
        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            string login = userlabel.Text;
            string password = passwordlabel.Text;
            if (login.Length <= 1 || password.Length <= 1)
            {
                return;
            }
            Account account = Database.GetInstance().Login(login, password);
            if (account == null)
            {
                errorLabel.Text = "Mot de passe incorrect";
                userlabel.Text = passwordlabel.Text = "";
                errorLabel.Visible = true;
            }
            else
            {
                string AccountType = account.IsAdministrator ? "(administrateur)" : "(abonné)";
                errorLabel.ForeColor = Color.LightGreen;
                if (!account.IsAdministrator)
                {
                    MainView view = new MainView(account);
                    view.ShowDialog();
                }
                else
                {
                    AdminView formAdmin = new AdminView((Administrator)account);
                    formAdmin.Show();
                }
                errorLabel.Text = "Succés ! " + "(" + AccountType + ")";
                errorLabel.Visible = true;
            }
        }

        public Label GetErrorLabel()
        {
            return errorLabel;
        }
    }
}
