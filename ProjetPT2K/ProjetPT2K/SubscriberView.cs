using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ProjetPT2K
{
    public partial class SubscriberView : Form
    {
        /**
         * The index of the selected item of the main menu.
         */
        private int MenuIndex;

        /**
         * The currently logged in subscriber.
         */
        private readonly ABONNÉS Subscriber;

        /**
         * Parametorised constructor creating a new SubscriberView object.
         * 
         * @param subscriber the logged in account
         */
        public SubscriberView(Account subscriber)
        {
            InitializeComponent();
            this.Subscriber = (ABONNÉS)subscriber;
            MainMenu();
        }

        /**
         * Display the main menu on the form.
         */
        private void MainMenu()
        {
            mainMenuListBox.Items.Clear();
            mainMenuListBox.Items.Add("Abonné");
            mainMenuListBox.Items.Add("1. Emprunter un album");
            mainMenuListBox.Items.Add("2. Lister les emprunts");
        }

        private void SelectionButton_Click(object sender, EventArgs e)
        {
            this.MenuIndex = mainMenuListBox.SelectedIndex;
            switch (this.MenuIndex)
            {
                case 1:
                    InitializeAlbumList();
                    break;
                case 2:
                    ListLoans();
                    break;
            }
        }

        private void InitializeAlbumList()
        {
            actionListBox.Items.Clear();
            List<ALBUMS> albums = Database.GetInstance().GetAllAlbums();
            albums.ForEach(album => actionListBox.Items.Add(album));
            albumTitleTextBox.Enabled = albumTitleTextBox.Visible = true;
            
        }

        private void RefreshAlbumList()
        {
            actionListBox.Items.Clear();
            string pattern = albumTitleTextBox.Text;
            List<ALBUMS> albums = Database.GetInstance().GetAlbumsContaining(pattern);
            albums.ForEach(album => actionListBox.Items.Add(album));
        }

        private void RefreshLoanList()
        {
            this.actionListBox.Items.Clear();
            var loans = this.Subscriber.EMPRUNTER;
            foreach (EMPRUNTER loan in loans)
            {
                this.actionListBox.Items.Add(loan);
            }
        }

        private void ListLoans()
        {
            RefreshLoanList();
            extendAllButton.Visible = extendAllButton.Enabled = true;
        }

        private void AlbumTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshAlbumList();
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            switch (this.MenuIndex)
            {
                case 1:
                    ALBUMS album = (ALBUMS)actionListBox.SelectedItem;
                    this.Subscriber.BorrowAlbum(album);
                    break;
                case 2:
                    EMPRUNTER loan = (EMPRUNTER)actionListBox.SelectedItem;
                    if (loan != null)
                    {
                        loan.Extend();
                        RefreshLoanList();
                    }
                    break;
            }
        }

        private void ActionListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (this.MenuIndex == 1)
            {
                actionButton.Text = "Emprunter";
                actionButton.Enabled = actionButton.Visible = true;
            }
            else if (this.MenuIndex == 2)
            {
                EMPRUNTER loan = (EMPRUNTER)actionListBox.SelectedItem;
                if (!loan.HasBeenExtended())
                {
                    actionButton.Text = "Prolonger";
                    actionButton.Enabled = actionButton.Visible = true;
                }
            }
        }

        /**
         * Event triggered when the extendAll button is clicked.
         */
        private void ExtendAllButton_Click(object sender, EventArgs e)
        {
            foreach (EMPRUNTER loan in this.Subscriber.EMPRUNTER)
            {
                if (!loan.HasBeenExtended())
                    loan.Extend();
            }
            RefreshLoanList();
        }
    }
}