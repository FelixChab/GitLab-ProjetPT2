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

    public partial class CreateAccountView : Form
    {
        /*Attributs*/
        public string FirstName { get { return firstNameTextBox.Text; } }

        public string LastName { get { return lastNameTextBox.Text; } }

        public string Login { get { return logintextBox.Text; } }
        
        public string Password { get { return passwordtextBox.Text; } }

        public PAYS Country { get { return (PAYS)countryComboBox.SelectedItem; } }

        /// <summary>
        /// Constructor of the account view.
        /// </summary>
        public CreateAccountView()
        {
            InitializeComponent();
            InitializeCountryComboBox();
        }


        /// <summary>
        /// Function responsible of the initialization of the countryComboBox.
        /// </summary>
        private void InitializeCountryComboBox()
        {
            Database database = Database.GetInstance();
            var countries = (from country in database.GetConnection().PAYS
                             select country);

            foreach (var country in countries)
            {
                countryComboBox.Items.Add(country);
            }
        }

        /// <summary>
        /// Function that indicate if a the passeword or the name box are filled.
        /// </summary>
        /// <returns> true if it's filled and false if it's not </returns>
        public bool IsFilled()
        {
            return FirstName.Length > 0 && LastName.Length > 0 && Login.Length > 0
                && Password.Length > 0 && countryComboBox.SelectedItem != null;
        }

        /// <summary>
        /// Function that is responsible of the display of the account creation.
        /// </summary>
        /// <param name="sender"> the object conserned </param>
        /// <param name="e"> the event.</param>
        private void CreateAccountView_Paint(object sender, PaintEventArgs e)
        {
            if (this.IsFilled())
            {
                validateButton.Enabled = true;
            }
        }
    }
}
