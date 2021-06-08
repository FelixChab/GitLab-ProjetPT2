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

        public Login()
        {
            InitializeComponent();
            errorLabel.Visible = false;
        }

        // clique sur création de compte
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccountView accountView = new NewAccountView();
            accountView.Show();
            if(accountView.DialogResult == DialogResult.OK && accountView.Created)
            {
                errorLabel.Text = "Votre compte a bien été créer.";
                errorLabel.ForeColor = Color.LightBlue;
                errorLabel.Visible = true;
            }

        }




        // clique sur connexion
        private void connectionButton_Click(object sender, EventArgs e)
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
                string accountType = account.IsAdministrator ? "(administrateur)" : "(abonné)";

                errorLabel.ForeColor = Color.LightGreen;

                if (!account.IsAdministrator)
                {
                    errorLabel.Text = "Succés ! (ABONNÉ)";
                    // todo show subscriber panel
                }
                else
                {
                    errorLabel.Text = "Succés ! (ADMIN)";
                    FormAdmin formAdmin = new FormAdmin((Admin)account);
                    formAdmin.Show();
                }
                errorLabel.Visible = true;

            }
        }
    }
}
