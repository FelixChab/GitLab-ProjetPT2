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
        /// 
        /// </summary>
        private readonly AlbumSlider _Recommandations;

        /// <summary>
        /// 
        /// </summary>
        private readonly AlbumSlider _MostBorrowedAlbums;

        List<AlbumDisplay> AlbumsDisplayed = new List<AlbumDisplay>();

        ALBUMS[][] AlbumsPagesRecommanded;
        ALBUMS[][] AlbumsPagesBest;

        int indexRecommanded = 0;
        int indexBest = 0;
        int totalPageRecommandated = 0;
        int totalPageBest = 0;

        /// <summary>
        /// Parametorised constructor creating a new Subscriber object.
        /// </summary>
        /// <param name="theAccount"> the account of the subscriber </param>
        public SubscriberView(Account theAccount, Database theDatabase)
        {
            InitializeComponent();
            this._Subscriber = (ABONNÉS)theAccount;
            this._Database = theDatabase;
        }

        /// <summary>
        /// Paint method of the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">The event</param>
        private void MainView_Paint(object sender, PaintEventArgs e)
        {
            List<ALBUMS> recommandatedAlbums = _Subscriber.GetRecommandations().Keys.ToList();
            List<ALBUMS> bestAlbums = _Database.GetMostBorrowedAlbums().Keys.ToList();
            AlbumDisplay display;
            Point position = tagRecommandations.Location;
            totalPageRecommandated = recommandatedAlbums.Count() % 5 == 0 ? (recommandatedAlbums.Count() / 5) : (recommandatedAlbums.Count() / 5) + 1;
            totalPageBest = (bestAlbums.Count() / 5) + 1;
            AlbumsPagesRecommanded = new ALBUMS[totalPageRecommandated][];
            AlbumsPagesBest = new ALBUMS[totalPageBest][];
            int index = 0;
            int count = 5;
            for (int i = 0; i < totalPageRecommandated; i++)
            {
                AlbumsPagesRecommanded[i] = SplitArrayAlbum(bestAlbums, index, count);
                if (recommandatedAlbums.Count() - (index + count) >= 5)
                {
                    index += count;
                }
                else
                {
                    count = recommandatedAlbums.Count() % 5;
                    index += count;
                }
            }

            index = 0;
            count = 5;
            for (int i = 0; i < totalPageBest; i++)
            {
                AlbumsPagesBest[i] = SplitArrayAlbum(bestAlbums, index, count);
                if (bestAlbums.Count() - (index + count) >= 5)
                {
                    index += 5;
                }
                else
                {
                    count = bestAlbums.Count() % 5;
                    index += count;
                }
            }


            for (int i = 0; i < AlbumsPagesRecommanded[indexRecommanded].Length; i++)
            {
                if (AlbumsPagesRecommanded[indexRecommanded][i] != null)
                {
                    ALBUMS album = AlbumsPagesRecommanded[indexRecommanded][i];
                    display = new AlbumDisplay(album, position);
                    display.Draw(e.Graphics);
                    AlbumsDisplayed.Add(display);
                    position = new Point(position.X + display.GetImageWidth().Width + 20, position.Y);
                    RecommandedPageLabel.Text = (indexRecommanded + 1) + "/" + (totalPageRecommandated);
                }
            }

            position = tagBestAlbums.Location;

            for (int i = 0; i < AlbumsPagesBest[indexBest].Length; i++)
            {
                if (AlbumsPagesBest[indexBest][i] != null)
                {
                    ALBUMS album = AlbumsPagesRecommanded[indexBest][i];
                    display = new AlbumDisplay(album, position);
                    display.Draw(e.Graphics);
                    AlbumsDisplayed.Add(display);
                    position = new Point(position.X + display.GetImageWidth().Width + 20, position.Y);
                    BestPageLabel.Text = (indexBest + 1) + "/" + (totalPageBest);
                }
            }
        }

        private ALBUMS GetAlbumUnderMouse()
        {
            //
            return null;
        }

        private void MainView_MouseClick(object sender, MouseEventArgs e)
        {
            ALBUMS theAlbum = GetAlbumUnderMouse();
            if (theAlbum != null)
            {
                this.Hide();
                AlbumView theView = new AlbumView(theAlbum, this._Subscriber);
                theView.ShowDialog();
                this.Show();
            }
        }

        /// <summary>
        /// Event truggered when the account icon is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountView theView = new AccountView(_Subscriber);
            theView.ShowDialog();
            this.Show();
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            //
        }

        private void PreviousRecommandedAlbums_Click(object sender, EventArgs e)
        {
            if (indexRecommanded > 0)
                indexRecommanded--;
            Refresh();
        }

        private void PreviousBestAlbums_Click(object sender, EventArgs e)
        {
            if (indexBest > 0)
                indexBest--;
            Refresh();
        }

        private void NextRecommandedAlbums_Click(object sender, EventArgs e)
        {
            if (indexRecommanded < totalPageRecommandated - 1)
                indexRecommanded++;
            Refresh();
        }

        private void NextBestAlbums_Click(object sender, EventArgs e)
        {
            if (indexBest < totalPageBest - 1)
                indexBest++;
            Refresh();
        }

        public ALBUMS[] SplitArrayAlbum(List<ALBUMS> AllAlbum, int indexSource, int count)
        {
            ALBUMS[] result = new ALBUMS[count];
            int j = 0;
            for (int i = 0; i < AllAlbum.Count(); i++)
            {
                if (i >= indexSource && i <= indexSource + count - 1)
                {
                    result[j] = AllAlbum[i];
                    j++;
                }
            }
            return result;
        }
    }
}
