﻿using System;
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
            this.SearchBar.Padding = new System.Windows.Forms.Padding(50);
            name.Text = _Subscriber.NOM_ABONNÉ.Trim();
            firstname.Text = _Subscriber.PRÉNOM_ABONNÉ.Trim();
            username.Text = _Subscriber.LOGIN_ABONNÉ.Trim();
            password.Text = "*******".Trim();
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
                RefreshLoanList();
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
                foreach (EMPRUNTER loan in this._Subscriber.EMPRUNTER)
                {
                    if (!loan.HasBeenExtended())
                        loan.Extend();
                }
                RefreshLoanList();
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            RefreshAlbumList();
            SearchResults.Visible = true;
        }


        private void RefreshAlbumList()
        {
            SearchResults.Items.Clear();
            string pattern = SearchBar.Text;
            List<ALBUMS> albums = Database.GetInstance().GetAlbumsContaining(pattern);
            albums.ForEach(album => SearchResults.Items.Add(album));
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

        private void SearchResults_MouseClick(object sender, MouseEventArgs e)
        {
            SearchResults.Visible = false;
            ALBUMS album = (ALBUMS)SearchResults.SelectedItem;
            if (album != null)
            {
                this.Hide();
                AlbumView theView = new AlbumView(album, this._Subscriber);
                theView.ShowDialog();
                this.Show();
            }
        }

        // liste les albums dans l'actionListBox (à droite) ??? à vérif
        private void actionListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            InitializeAlbumList();
        }

        // Retour au menu compte (donc refresh)
        private void pictureBoxAccount_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
