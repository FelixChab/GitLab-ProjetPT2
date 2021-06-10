using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ProjetPT2K
{
    /// <summary>
    /// Class representing the view of a CreateAccount window.
    /// </summary>
    public partial class CreateAccountView : Form
    {
        /// <summary>
        /// The database containing all the data.
        /// </summary>
        private readonly Database _Database;

        /// <summary>
        /// Non parametorised constructor creating a new CreateAccountView object.
        /// </summary>
        public CreateAccountView(Database theDatabase)
        {
            InitializeComponent();
            this._Database = theDatabase;
            FillCountryComboBox();
        }

        /// <summary>
        /// Fill the CountryComboBox with all the available countries from the database.
        /// </summary>
        private void FillCountryComboBox()
        {
            List<PAYS> theCountries = this._Database.GetConnection().PAYS.ToList();
            theCountries.ForEach(theCountry => CountryComboBox.Items.Add(theCountry));
        }

        /// <summary>
        /// Event triggered when the SignUp button is clicked.
        /// </summary>
        /// <param name="sender"> the object concerned </param>
        /// <param name="e"> the event </param>
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string theFirstName = FistNameLabel.Text;
            string theLastName = LastNameLabel.Text;

            PAYS theCountry = (PAYS)CountryComboBox.SelectedItem;
            
            string theLogin = LoginLabel.Text;
            string thePassword = PasswordLabel.Text;

            try
            {
                this._Database.AttemptAccountCreation(theFirstName, theLastName, theCountry, theLogin, thePassword);
                this.Close();
            }
            catch (Exception theException)
            {
                ClearSignUpLabels();
                ErrorLabel.Visible = true;
                ErrorLabel.Text = theException.Message;
            }
        }

        /// <summary>
        ///  Clear the sign up labels.
        /// </summary>
        public void ClearSignUpLabels()
        {
            FistNameLabel.Text = "";
            LastNameLabel.Text = "";
            LoginLabel.Text = "";
            PasswordLabel.Text = "";
        }
    }
}
