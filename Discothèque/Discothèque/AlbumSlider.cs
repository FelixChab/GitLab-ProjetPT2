using System.Drawing;
using System.Collections.Generic;

namespace Discotèque
{
    /// <summary>
    /// 
    /// </summary>
    class AlbumSlider
    {
        /// <summary>
        /// 
        /// </summary>
        public int PageIndex = 1;

        /// <summary>
        /// 
        /// </summary>
        private int PageNumber = 1;

        private int SeenAlbums = 0;

        private int LastPage;

        private readonly Size _Size;

        private readonly Point _Position;

        private static readonly int Margin = 20;

        private readonly List<AlbumDisplay> theDisplays;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="theSize"></param>
        /// <param name="thePosition"></param>
        /// <param name="theAlbums"></param>
        public AlbumSlider(Size theSize, Point thePosition, List<ALBUMS> theAlbums)
        {
            this._Size = theSize;
            this._Position = thePosition;
            this.LastPage = theAlbums.Count % 5;
            this.PageNumber += (LastPage > 0) ? 1 : 0; 

            InitializeSlider(theAlbums);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="theAlbums"></param>
        private void InitializeSlider(List<ALBUMS> theAlbums)
        {
            Point thePoint = new Point(this._Position.X, this._Position.Y);
            foreach (ALBUMS theAlbum in theAlbums)
            {
                //AlbumDisplay theDisplay = new AlbumDisplay(theAlbum, thePoint);
                //this.theDisplays.Add(theDisplay);
                thePoint.X += Margin;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void NextPage()
        {
            if (this.PageIndex < this.PageNumber)
                this.PageIndex++;
        }

        /// <summary>
        /// 
        /// </summary>
        public void PreviousPage()
        {
            if (this.PageIndex > 0)
                this.PageIndex--;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="theScreen"></param>
        public void Draw(Graphics theScreen)
        {
            for (int i = this.SeenAlbums; i < this.theDisplays.Count; i++)
                this.theDisplays[i].Draw(theScreen);
        }

    }
}
