using System;
using System.Windows.Forms;

namespace Discotèque
{
    /// <summary>
    /// Class representing the view of an album
    /// </summary>
    public partial class AlbumView : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ALBUMS _Album;

        private readonly ABONNÉS _Account;

        public AlbumView(ALBUMS theAlbum, ABONNÉS theAccount)
        {
            InitializeComponent();
            this._Album = theAlbum;
            this._Account = theAccount;
        }

        /**
         * Method to navigate to the subscriber "main" page.
         */
        private void PictureBoxAccount_Click(object sender, EventArgs e)
        {
            Close();
            AccountView main = new AccountView(_Account);
            main.Show();
        }

        /**
         * Method to loan the current album the user is looking at.
         */
        private void ButtonLoan_Click(object sender, EventArgs e)
        {
            _Account.BorrowAlbum(_Album);
        }

        /**
         * Method to navigate to log-in page.
         */
        private void PictureBoxLogo_Click(object sender, EventArgs e)
        {
            // SubscriberView main = new SubscriberView(account);
            // main.ShowDialog();
            Close();
        }

        private void AlbumView_Paint(object sender, PaintEventArgs e)
        {
            LabelTitle.Text = _Album.TITRE_ALBUM;
            LabelEditor.Text = "Editeur: " + _Album.EDITEURS.NOM_EDITEUR;
            if (_Album.EDITEURS.PAYS == null)
            {
                LabelEditorCountry.Text = "null";
            }
            else
            {
                LabelEditorCountry.Text = "Pays: " + _Album.EDITEURS.PAYS.NOM_PAYS;
            }
            LabelYear.Text = _Album.ANNÉE_ALBUM.ToString();
            LabelGenre.Text = _Album.GENRES.LIBELLÉ_GENRE;
            LabelAlley.Text = "Allée: " + _Album.ALLÉE_ALBUM;
            LabelLocker.Text = "Casier: " + _Album.CASIER_ALBUM.ToString();
            LabelPrice.Text = _Album.PRIX_ALBUM.ToString() + "€";
            AlbumDisplay displayalbum = new AlbumDisplay(_Album, PictureBoxCover.Location);
            //PictureBoxCover.Image = displayalbum.GetAlbumCover();
        }
    }
}
