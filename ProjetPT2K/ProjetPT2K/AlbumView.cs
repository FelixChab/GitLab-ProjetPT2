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
    /// <summary>
    /// Class representing the view of an album
    /// </summary>
    public partial class AlbumView : Form
    {
        private readonly ALBUMS album;
        private readonly ABONNÉS account;

        public AlbumView(ALBUMS album, ABONNÉS account)
        {
            InitializeComponent();
            this.album = album;
            this.account = account;
        }

        /**
         * Method to navigate to the subscriber "main" page.
         */
        private void PictureBoxAccount_Click(object sender, EventArgs e)
        {
            Close();
            AccountView main = new AccountView(account);
            main.Show();
        }

        /**
         * Method that let the user use a searchbar to find albums (?).
         */
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // TODO
        }

        /**
         * Method to loan the current album the user is looking at.
         */
        private void ButtonLoan_Click(object sender, EventArgs e)
        {
            account.BorrowAlbum(album);
        }

        /**
         * Method to navigate to log-in page.
         */
        private void PictureBoxLogo_Click(object sender, EventArgs e)
        {
            SubscriberView main = new SubscriberView(account);
            main.ShowDialog();
            Close();
        }

        private void AlbumView_Paint(object sender, PaintEventArgs e)
        {
            LabelTitle.Text = album.TITRE_ALBUM;
            LabelEditor.Text = "Editeur: " + album.EDITEURS.NOM_EDITEUR;
            if (album.EDITEURS.PAYS == null)
            {
                LabelEditorCountry.Text = "null";
            }
            else
            {
                LabelEditorCountry.Text = "Pays: " + album.EDITEURS.PAYS.NOM_PAYS;
            }
            LabelYear.Text = album.ANNÉE_ALBUM.ToString();
            LabelGenre.Text = album.GENRES.LIBELLÉ_GENRE;
            LabelAlley.Text = "Allée: " + album.ALLÉE_ALBUM;
            LabelLocker.Text = "Casier: " + album.CASIER_ALBUM.ToString();
            LabelPrice.Text = album.PRIX_ALBUM.ToString() + "€";
            DisplayAlbum displayalbum = new DisplayAlbum(album, PictureBoxCover.Location, PictureBoxCover.Size);
            PictureBoxCover.Image = displayalbum.GetImage();
        }
    }
}
