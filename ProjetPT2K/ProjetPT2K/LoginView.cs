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

        private void enterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connect();
            }
        
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
            connect();
        }
        private void connect()
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
                errorLabel.Text = "Mot de passe incorect";
                userlabel.Text = passwordlabel.Text = "";
                errorLabel.Visible = true;
            }
            else
            {
                string AccountType = account.IsAdministrator ? "administrateur" : "abonné";
                errorLabel.ForeColor = Color.LightGreen;
                errorLabel.Text = "Succés ! " + "(" + AccountType + ")";
                errorLabel.Visible = true;
                Hide();
                if (!account.IsAdministrator)
                {
                    MainView view = new MainView(account);
                    view.ShowDialog();
                }
                else
                {
                    AdminView formAdmin = new AdminView((Administrator)account);
                    formAdmin.ShowDialog();
                    Show();
                }

            }
        }

        
    
        public Label GetErrorLabel()
        {
            return errorLabel;
        }

        private void passwordlabel_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
