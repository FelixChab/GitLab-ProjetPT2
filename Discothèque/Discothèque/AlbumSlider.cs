using System.Drawing;
using System.Collections.Generic;

namespace Discotèque
{
    /// <summary>
    /// Class representing a slider of albums.
    /// </summary>
    class AlbumSlider
    {

        /// <summary>
        /// The number of albums displayed so far.
        /// </summary>
        private int _SeenAlbums = 0;

        /// <summary>
        /// The total number of pages of the slider.
        /// </summary>
        public int TotalPageNumber = 1;

        /// <summary>
        /// The position of the slider on the screen.
        /// </summary>
        private readonly Point _Position;

        /// <summary>
        /// The number of albums to display per pages of the slider.
        /// </summary>
        private readonly int AlbumsPerPages;

        /// <summary>
        /// the number of albums to display on the last page.
        /// </summary>
        private readonly int AlbumsOnLastPage;

        /// <summary>
        /// The margin between each slider element.
        /// </summary>
        public static readonly int Margin = 20;

        /// <summary>
        /// The list of DisplayAlbum to display on the slider.
        /// </summary>
        private readonly List<AlbumDisplay> theDisplays;

        /// <summary>
        /// Parametorised constructor creating a new AlbumSlider object.
        /// </summary>
        /// <param name="theAlbums"> the albums to display </param>
        /// <param name="theAlbumsPerPages"> the number of albums to display per slider page </param>
        /// <param name="thePosition"> the position of the slider </param>
        public AlbumSlider(List<ALBUMS> theAlbums, int theAlbumsPerPages, Point thePosition)
        {
            this._Position = thePosition;
            this.AlbumsOnLastPage = theAlbums.Count % 5;
            this.AlbumsPerPages = theAlbumsPerPages;
            this.TotalPageNumber += (AlbumsOnLastPage > 0) ? 1 : 0;
            this.theDisplays = new List<AlbumDisplay>();

            InitializeSlider(theAlbums);
        }

        /// <summary>
        /// The index of the current page.
        /// </summary>
        public int CurrentPageIndex
        {
            get
            {
                return (this._SeenAlbums / this.AlbumsPerPages) + 1;
            }
        }

        /// <summary>
        /// Populate the slider by giving each element a position on screen.
        /// </summary>
        /// <param name="theAlbums"> the list of albums </param>
        private void InitializeSlider(List<ALBUMS> theAlbums)
        {
            int i = 0;
            AlbumDisplay theDisplay;
            Point thePoint = new Point(this._Position.X, this._Position.Y);
            foreach (ALBUMS theAlbum in theAlbums)
            {
                theDisplay = new AlbumDisplay(theAlbum, thePoint);
                thePoint.X += AlbumDisplay.Size.Width + Margin;
                this.theDisplays.Add(theDisplay);

                i++;
                if (i == this.AlbumsPerPages)
                    thePoint.X = this._Position.X;
            }
        }

        /// <summary>
        /// Navigate to the next slider page.
        /// </summary>
        public void NextPage()
        {
            if (this.CurrentPageIndex < this.TotalPageNumber)
                this._SeenAlbums += this.AlbumsPerPages;
        }

        /// <summary>
        /// Navigate to the previous slider page.
        /// </summary>
        public void PreviousPage()
        {
            if (this.CurrentPageIndex > 1)
                this._SeenAlbums -= this.AlbumsPerPages;
        }

        /// <summary>
        /// Return the AlbumDisplay found at the given position.
        /// </summary>
        /// <param name="theMouse"> the considered position </param>
        /// <returns> an AlbumDisplay object </returns>
        public AlbumDisplay GetAlbumUnderMouse(Point theMouse)
        {
            List<AlbumDisplay> theDisplaysUnderMouse = this.theDisplays.FindAll(theDisplay => theDisplay.Contains(theMouse));
            int index = this.CurrentPageIndex - 1;
            if (index < theDisplaysUnderMouse.Count)
                return theDisplaysUnderMouse[this.CurrentPageIndex - 1];
            return null;
        }

        /// <summary>
        /// Draw the slider on the screen.
        /// </summary>
        /// <param name="theScreen"> the screen to draw on </param>
        public void Draw(Graphics theScreen)
        {
            int borne = this.AlbumsPerPages;
            if (this.CurrentPageIndex == this.TotalPageNumber)
                borne = this.AlbumsOnLastPage;
            for (int i = this._SeenAlbums; i < (this._SeenAlbums + borne); i++)
            {
                if (i < theDisplays.Count)
                    this.theDisplays[i].Draw(theScreen);
            }
        }
    }
}