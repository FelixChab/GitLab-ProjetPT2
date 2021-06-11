using System;
using System.Drawing;
using System.Windows.Forms;

namespace Discotèque
{
    /// <summary>
    /// Class representing the view of a Login window.
    /// </summary>
    public partial class LoginView : Form
    {
        /// <summary>
        /// The view to create a new account.
        /// </summary>
        private readonly CreateAccountView _CreateAccountView;

        /// <summary>
        /// The database containing all the data.
        /// </summary>
        private readonly Database _Database = Database.GetInstance();

        /// <summary>
        /// Non parametorised constructor creating a new LoginView object.
        /// </summary>
        public LoginView()
        {
            InitializeComponent();
            this._CreateAccountView = new CreateAccountView(this._Database);
        }
        /// <summary>
        /// Event triggered when key down on password label
        /// </summary>
        /// <param name="sender"> the concerned object </param>
        /// <param name="e"> the event </param>
        private void PasswordLabel_KeyDown(object sender, KeyEventArgs e)
        {
           if((char)e.KeyCode == 13)
            {
                ConnectionButton_Click(null, null);
            }
        }


        /// <summary>
        /// Event triggered when creating a new account.
        /// </summary>
        /// <param name="sender"> the concerned object </param>
        /// <param name="e"> the event </param>
        private void CreateAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            if (this._CreateAccountView.ShowDialog() == DialogResult.OK)
            {
                ClearConnectionLabels();
                ErrorLabel.Visible = true;
                ErrorLabel.ForeColor = Color.Green;
                ErrorLabel.Text = "Compte abonné créé";               
            }
            this.Show();
        }

        /// <summary>
        /// Fucntion of the "connection" button
        /// </summary>
        /// <param name="sender"> the object concerned </param>
        /// <param name="e"> the event </param>
        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            string theLogin = LoginLabel.Text;
            string password = PasswordLabel.Text;

            Account theAccount = this._Database.Login(theLogin, password);
            if (theAccount == null)
            {
                ClearConnectionLabels();
                ErrorLabel.Visible = true;
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Mot de passe incorrect";
            }
            else
            {
                ErrorLabel.Visible = false;
                Login(theAccount);
            }
        }

        /// <summary>
        /// Clear the different connection labels.
        /// </summary>
        private void ClearConnectionLabels()
        {
            LoginLabel.Text = PasswordLabel.Text = "";
        }

        /// <summary>
        /// Open the view of the given account.
        /// </summary>
        /// <param name="theAccount"> the account to log in </param>
        private void Login(Account theAccount)
        {
            this.Hide();
            if (!theAccount.IsAdministrator)
            {
                SubscriberView theView = new SubscriberView(theAccount, this._Database);
                theView.ShowDialog();
            }
            else
            {
                AdministratorView theView = new AdministratorView(theAccount);
                theView.ShowDialog();
            }
            this.ClearConnectionLabels();
            this.Show();
        }
    }
}