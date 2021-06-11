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

        private void InitializeAlbumList()
        {
            actionListBox.Items.Clear();
            List<ALBUMS> albums = Database.GetInstance().GetAllAlbums();
            albums.ForEach(album => actionListBox.Items.Add(album));
        }

        private void ListLoans()
        {
            RefreshLoanList();
            extendAllButton.Visible = extendAllButton.Enabled = true;
        }

        private void extendLoanButton_Click(object sender, EventArgs e)
        {
            EMPRUNTER loan = (EMPRUNTER)actionListBox.SelectedItem;
            if (loan != null)
            {
                loan.Extend();
                MessageBox.Show("L'emprunt a bien été prolongé");
                RefreshLoanList();
            }
            else// if (loan ==  )
            {
                MessageBox.Show("L'emprunt a déjà été prolongé");
            }
        }

        private void RefreshLoanList()
        {
            this.actionListBox.Items.Clear();
            var loans = this._Subscriber.EMPRUNTER;
            foreach (EMPRUNTER loan in loans)
            {
                this.actionListBox.Items.Add(loan);
            }
        }

        private void ExtendAllButton_Click(object sender, EventArgs e)
        {
            bool extended = false;
            foreach (EMPRUNTER loan in this._Subscriber.EMPRUNTER)
            {
                if (!loan.HasBeenExtended())
                {
                    loan.Extend();
                    MessageBox.Show("Tous les emprunts ont bien été prolongés");
                    extended = true;
                }

            } 
            if (!extended)
            {
                MessageBox.Show("Tous les emprunts ont déjà été prolongés");
            }




            RefreshLoanList();
        }



        private void Logo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO (?)
        }

        private void SearchResults_Leave(object sender, EventArgs e)
        {
            // TODO: faire disparaître la search bar en cliquant à l'extérieur
        }



        // liste les albums dans l'actionListBox (à droite) ??? à vérif
        private void actionListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //
        }

        // Retour au menu compte (donc refresh)
        private void pictureBoxAccount_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
