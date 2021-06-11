using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Discotèque
{
    /// <summary>
    /// Class representing the view of a Subscriber window.
    /// </summary>
    public partial class SubscriberView : Form
    {
        /// <summary>
        /// The database containing the data.
        /// </summary>
        private readonly Database _Database;

        /// <summary>
        /// The subscriber the view is about.
        /// </summary>
        private readonly ABONNÉS _Subscriber;

        /// <summary>
        /// The slider of the popular albums.
        /// </summary>
        private AlbumSlider _PopularAlbums;

        /// <summary>
        /// The slider of the recommanded albums.
        /// </summary>
        private AlbumSlider _Recommandations;

        /// <summary>
        /// 
        /// </summary>
        private readonly AlbumView _AlbumView;

        /// <summary>
        /// Parametorised constructor creating a new Subscriber object.
        /// </summary>
        /// <param name="theAccount"> the account of the subscriber </param>
        public SubscriberView(Account theAccount, Database theDatabase)
        {
            InitializeComponent();
            this._Database = theDatabase;
            this._Subscriber = (ABONNÉS)theAccount;
            this._AlbumView = new AlbumView(this._Subscriber);

            this.Text = this._Subscriber.ToString();
            InitializeSliders();
        }

        /// <summary>
        /// Populate the sliders with their respective albums.
        /// </summary>
        private void InitializeSliders()
        {
            List<ALBUMS> theRecommandations = this._Subscriber.GetRecommandations().Keys.ToList();
            this._Recommandations = new AlbumSlider(theRecommandations, 5, RecommandationsTag.Location);

            List<ALBUMS> thePopularAlbums = this._Database.GetMostBorrowedAlbums().Keys.ToList();
            this._PopularAlbums = new AlbumSlider(thePopularAlbums, 5, PopularAlbumsTag.Location);
        }

        /// <summary>
        /// Update the sliders labels (page number).
        /// </summary>
        private void UpdateSliderLabels()
        {
            this.RecommandedPageLabel.Text = this._Recommandations.CurrentPageIndex + "/" + this._Recommandations.TotalPageNumber;
            this.BestPageLabel.Text = this._PopularAlbums.CurrentPageIndex + "/" + this._PopularAlbums.TotalPageNumber;
        }

        /// <summary>
        /// Event triggered on each refresh of the screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">The event</param>
        private void MainView_Paint(object sender, PaintEventArgs e)
        {
            UpdateSliderLabels();

            this._Recommandations.Draw(e.Graphics);
            this._PopularAlbums.Draw(e.Graphics);
        }

        /// <summary>
        /// Return the AlbumDisplay found at the given position.
        /// </summary>
        /// <param name="theMouse"> the considered position </param>
        /// <returns> an AlbumDisplay object </returns>
        private AlbumDisplay GetAlbumUnderMouse(Point theMouse)
        {
            AlbumDisplay theAlbum = this._Recommandations.GetAlbumUnderMouse(theMouse);
            if (theAlbum == null)
                theAlbum = this._PopularAlbums.GetAlbumUnderMouse(theMouse);
            return theAlbum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainView_MouseClick(object sender, MouseEventArgs e)
        {
            AlbumDisplay theDisplay = GetAlbumUnderMouse(e.Location);
            if (theDisplay != null)
            {
                this._AlbumView.ChangeAlbum(theDisplay.Album);
                this._AlbumView.ShowDialog();
            }
        }

        /// <summary>
        /// Event truggered when the account icon is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountIcon_Click(object sender, EventArgs e)
        {
            AccountView theView = new AccountView(_Subscriber);
            theView.ShowDialog();
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            //
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousRecommandation_Click(object sender, EventArgs e)
        {
            this._Recommandations.PreviousPage();
            Refresh();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousPopularAlbums_Click(object sender, EventArgs e)
        {
            this._PopularAlbums.PreviousPage();
            Refresh();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextRecommandation_Click(object sender, EventArgs e)
        {
            this._Recommandations.NextPage();
            Refresh();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextPopularAlbums_Click(object sender, EventArgs e)
        {
            this._PopularAlbums.NextPage();
            Refresh();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            UpdateSearchResults();
            SearchResults.Visible = true;
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateSearchResults()
        {
            SearchResults.Items.Clear();
            string pattern = SearchBar.Text;
            List<ALBUMS> albums = Database.GetInstance().GetAlbumsContaining(pattern);
            albums.ForEach(album => SearchResults.Items.Add(album));
        }

        /// <summary>
        /// Event triggered when an element of the SearchResults list is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchResults_MouseClick(object sender, MouseEventArgs e)
        {
            ALBUMS theAlbum = (ALBUMS)SearchResults.SelectedItem;
            if (theAlbum != null)
            {
                this._AlbumView.ChangeAlbum(theAlbum);
                this._AlbumView.ShowDialog();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            SearchResults.Visible = false;
            if (e.KeyChar == 13)
            {
                UpdateSearchResults();
                SearchResults.Visible = true;
            }
        }
    }
}