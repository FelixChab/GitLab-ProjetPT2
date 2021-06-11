using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discotèque
{
    public partial class AccountView : Form
    {
        private readonly ABONNÉS _Subscriber;

        /// <summary>
        /// Concstructor
        /// </summary>
        /// <param name="account"></param>
        public AccountView(ABONNÉS account)
        {
            InitializeComponent();
            this._Subscriber = account;

            name.Text = _Subscriber.NOM_ABONNÉ.Trim();
            firstname.Text = _Subscriber.PRÉNOM_ABONNÉ.Trim();
            username.Text = _Subscriber.LOGIN_ABONNÉ.Trim();
            country.Text = "" + _Subscriber.PAYS;
            ListLoans();
        }


        /// <summary>
        /// Method that initialize Albums list from database
        /// </summary>
        private void InitializeAlbumList()
        {
            actionListBox.Items.Clear();
            List<ALBUMS> albums = Database.GetInstance().GetAllAlbums();
            albums.ForEach(album => actionListBox.Items.Add(album));
        }


        /// <summary>
        /// Methode that liste loans
        /// </summary>
        private void ListLoans()
        {
            RefreshLoanList();
            extendAllButton.Visible = extendAllButton.Enabled = true;
        }


        /// <summary>
        /// Method that allows to borrow albums by clicking on a button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void extendLoanButton_Click(object sender, EventArgs e)
        {
            EMPRUNTER loan = (EMPRUNTER)actionListBox.SelectedItem;
            if (!loan.HasBeenExtended())
            {
                loan.Extend();
                MessageBox.Show("L'emprunt a bien été prolongé");
                RefreshLoanList();
            }
            else
            {
                MessageBox.Show("L'emprunt a déjà été prolongé");
            }
        }

        /// <summary>
        /// Methode that refresh loans list
        /// </summary>
        private void RefreshLoanList()
        {
            this.actionListBox.Items.Clear();
            var loans = this._Subscriber.EMPRUNTER;
            foreach (EMPRUNTER loan in loans)
            {
                this.actionListBox.Items.Add(loan);

            }
        }

        /// <summary>
        /// Method that allows to extend all the loans.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExtendAllButton_Click(object sender, EventArgs e)
        {
            bool extended = false;
            foreach (EMPRUNTER loan in this._Subscriber.EMPRUNTER)
            {
                if (!loan.HasBeenExtended())
                {
                    MessageBox.Show("Tous les emprunts ont bien été prolongés");
                    loan.Extend();
                    extended = true;
                    RefreshLoanList();
                }
            }
            if (!extended)
            {
                MessageBox.Show("Tous les emprunts ont déjà été prolongés");
            }
            RefreshLoanList();
        }


        /// <summary>
        /// Method that allows to close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Logo_Click(object sender, EventArgs e)
        {
            Close();
        }




 
        /// <summary>
        /// Method that allows to go back to the main menu/ refresh the page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAccount_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
