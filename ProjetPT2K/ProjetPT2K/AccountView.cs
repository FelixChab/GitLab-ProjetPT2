﻿using System;
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
    public partial class AccountView : Form
    {
        private readonly ABONNÉS Account;
        ABONNÉS Subriber;
        
        public AccountView(ABONNÉS acount )
        {
            InitializeComponent();
            this.Subriber = acount;
            this.listeAlbum.Padding = new System.Windows.Forms.Padding(50);
            name.Text = Subriber.NOM_ABONNÉ.Trim();
            firstname.Text = Subriber.PRÉNOM_ABONNÉ.Trim();
            username.Text = Subriber.LOGIN_ABONNÉ.Trim();
            password.Text = "*******".Trim();
            country.Text = ""+Subriber.PAYS;
            ListLoans();
            this.Account = acount;
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

        private void button1_Click(object sender, EventArgs e)
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
            var loans = this.Subriber.EMPRUNTER;
            foreach (EMPRUNTER loan in loans)
            {
                this.actionListBox.Items.Add(loan);
            }
        }

        private void ExtendAllButton_Click(object sender, EventArgs e)
        { 
                foreach (EMPRUNTER loan in this.Subriber.EMPRUNTER)
                {
                    if (!loan.HasBeenExtended())
                        loan.Extend();
                }
                RefreshLoanList();
        }

        private void listeAlbum_TextChanged(object sender, EventArgs e)
        {
            RefreshAlbumList();
        }


        private void RefreshAlbumList()
        {
            listeAlbum.Items.Clear();
            string pattern = listeAlbum.Text;
            List<ALBUMS> albums = Database.GetInstance().GetAlbumsContaining(pattern);
            albums.ForEach(album => listeAlbum.Items.Add(album));
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            MainView view = new MainView(Account);
            view.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
