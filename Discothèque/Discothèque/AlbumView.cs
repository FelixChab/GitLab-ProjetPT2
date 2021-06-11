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
        private ALBUMS _Album;

        /// <summary>
        /// 
        /// </summary>
        private readonly ABONNÉS _Subscriber;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="theAccount"></param>
        public AlbumView(ABONNÉS theAccount)
        {
            InitializeComponent();
            this._Subscriber = theAccount;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="theAlbum"></param>
        public void ChangeAlbum(ALBUMS theAlbum)
        {
            this._Album = theAlbum;
            InitializeLabels();
            UpdateActionButton();
        }

        private void InitializeLabels()
        {
            this.Text = this._Album.TITRE_ALBUM;
            LabelTitle.Text = this._Album.TITRE_ALBUM;
            LabelEditor.Text = "Editeur: " + this._Album.EDITEURS.NOM_EDITEUR;
            if (_Album.EDITEURS.PAYS == null)
            {
                LabelEditorCountry.Text = "Pays: inconnu";
            }
            else
            {
                LabelEditorCountry.Text = "Pays: " + this._Album.EDITEURS.PAYS.NOM_PAYS;
            }
            LabelYear.Text = _Album.ANNÉE_ALBUM.ToString();
            LabelGenre.Text = _Album.GENRES.LIBELLÉ_GENRE;
            LabelAlley.Text = "Allée: " + _Album.ALLÉE_ALBUM;
            LabelLocker.Text = "Casier: " + _Album.CASIER_ALBUM.ToString();
            LabelPrice.Text = _Album.PRIX_ALBUM.ToString() + "€";

            AlbumCoverBox.Image = this._Album.DisplayableAlbumCover;
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateActionButton()
        {
            ActionButton.Enabled = true;
            if (this._Album.IsAvailable())
            {
                ActionButton.Text = "Emprunter";
            }
            else
            {
                EMPRUNTER theLoan = this._Subscriber.GetLoanOfAlbum(this._Album);
                if (theLoan != null)
                    ActionButton.Text = "Rendre";
                else
                {
                    ActionButton.Text = "Indisponible";
                    ActionButton.Enabled = false;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLoan_Click(object sender, EventArgs e)
        {
            if (this._Album.IsAvailable())
                this._Subscriber.BorrowAlbum(_Album);
            else
            {
                EMPRUNTER theLoan = this._Subscriber.GetLoanOfAlbum(this._Album);
                theLoan.Return();
            }
            UpdateActionButton();
        }

        /**
         * Method to navigate to log-in page.
         */
        private void PictureBoxLogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
