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
        public Login()
        {
            InitializeComponent();
            errorLabel.Visible = false;
        }

        // clique sur création de compte
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        // clique sur connexion
        private void connectionButton_Click(object sender, EventArgs e)
        {
            string login = userlabel.Text;
            string password = passwordlabel.Text;

            Account account = Database.GetInstance().Login(login, password);
            if (account == null)
            {
                errorLabel.Text = "Mauvais identifiant ou mauvais mot de passe";
                userlabel.Text = passwordlabel.Text = "";
                errorLabel.Visible = true;
            }
            else
            {
                string accountType = account.IsAdministrator ? "(administrateur)" : "(abonné)";
               
                errorLabel.ForeColor = Color.Green;
                
                if (!account.IsAdministrator)
                {
                    errorLabel.Text = "Connexion réussi ! (ABONNÉ)";
                    // todo show subscriber panel
                }
                else
                {
                    errorLabel.Text = "Connexion réussi ! (ADMIN)";
                    // TODO show admin panel
                }
                errorLabel.Visible = true;

            }
        }
    }
}
