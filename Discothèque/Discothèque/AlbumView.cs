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
        /// Attributes that represent the current album the user is viewing.
        /// </summary>
        private ALBUMS _Album;

        /// <summary>
        /// Attributes that represent the user, the current status of the account.
        /// </summary>
        private readonly ABONNÉS _Subscriber;

        /// <summary>
        /// Builder of the class.
        /// </summary>
        /// <param name="theAccount"></param>
        public AlbumView(ABONNÉS theAccount)
        {
            InitializeComponent();
            this._Subscriber = theAccount;
        }

        /// <summary>
        /// Method that change the current album to the one in display.
        /// </summary>
        /// <param name="theAlbum"></param>
        public void ChangeAlbum(ALBUMS theAlbum)
        {
            this._Album = theAlbum;
            InitializeLabels();
            UpdateActionButton();
        }

        /// <summary>
        /// Method initialize the labels of the current album (display of all informations)
        /// </summary>
        private void InitializeLabels()
        {
            this.Text = this._Album.TITRE_ALBUM;
            LabelTitle.Text = this._Album.TITRE_ALBUM;
            LabelEditor.Text = this._Album.EDITEURS.NOM_EDITEUR;
            LabelEditorCountry.Text = (_Album.EDITEURS.PAYS == null) ? "Pays inconnu" : this._Album.EDITEURS.PAYS.NOM_PAYS;
            LabelYear.Text = _Album.ANNÉE_ALBUM.ToString();
            LabelGenre.Text = _Album.GENRES.LIBELLÉ_GENRE;
            LabelAlley.Text = "Allée: " + _Album.ALLÉE_ALBUM;
            LabelLocker.Text = "Casier: " + _Album.CASIER_ALBUM.ToString();
            LabelPrice.Text = _Album.PRIX_ALBUM.ToString() + "€";
            AlbumCoverBox.Image = this._Album.DisplayableAlbumCover;
            if (_Subscriber.GetLoanOfAlbum(_Album) != null && _Subscriber.GetLoanOfAlbum(_Album).DATE_RETOUR == null)
            {
                LabelReturnDate.Visible = true;
                LabelReturnDate.Text = "à rendre avant le : " + _Subscriber.GetLoanOfAlbum(this._Album).DATE_RETOUR_ATTENDUE;
            }
            else
            {
                LabelReturnDate.Visible = false;
            }
        }

        /// <summary>
        /// Method that update the status of the "action" button which let user loan or return albums.
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
                {
                    ActionButton.Text = "Rendre";
                }
                else
                {
                    ActionButton.Text = "Indisponible";
                    ActionButton.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Method of the "loan" button that let the user loan the current album by clicking the button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLoan_Click(object sender, EventArgs e)
        {
            if (this._Album.IsAvailable())
            {
                this._Subscriber.BorrowAlbum(_Album);
            } 
            else
            {
                EMPRUNTER theLoan = this._Subscriber.GetLoanOfAlbum(this._Album);
                theLoan.Return();
            }
            UpdateActionButton();
        }

        /// <summary>
        /// Method to navigate to log-in page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxLogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
