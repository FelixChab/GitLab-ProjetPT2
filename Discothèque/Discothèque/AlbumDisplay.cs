using System.IO;
using System.Drawing;

namespace Discotèque
{
    /// <summary>
    /// Class representing a new AlbumDisplay.
    /// </summary>
    class AlbumDisplay
    {
        /// <summary>
        /// The album displayed.
        /// </summary>
        public readonly ALBUMS Album;

        /// <summary>
        /// The position of the current AlbumDisplay.
        /// </summary>
        private readonly Point _Position;

        /// <summary>
        /// The margin between each AlbumDisplay.
        /// </summary>
        public static readonly Size Size = new Size(100, 100);

        /// <summary>
        /// Parametorised constructor creating a new AlbumDisplay object.
        /// </summary>
        /// <param name="theAlbum"> the album to display </param>
        /// <param name="thePosition"> the position of the AlbumDisplay </param>
        public AlbumDisplay(ALBUMS theAlbum, Point thePosition)
        {
            this.Album = theAlbum;
            this._Position = thePosition;
        }

        /// <summary>
        /// Draw the AlbumDisplay on screen.
        /// </summary>
        /// <param name="theScreen"> the screen </param>
        public void Draw(Graphics theScreen)
        {
            Image theCover = this.Album.DisplayableAlbumCover;
            theScreen.DrawImage(theCover, this._Position.X, this._Position.Y,
                        Size.Width, Size.Height);
        }

        /// <summary>
        /// Return true if the given point is contained in the current DisplayAlbum.
        /// </summary>
        /// <param name="thePoint"> the considered point </param>
        /// <returns> a boolean </returns>
        public bool Contains(Point thePoint)
        {
            Rectangle theRectangle = new Rectangle(_Position, Size);
            return theRectangle.Contains(thePoint);
        }

        /// <summary>
        ///  Return an image from a bytes arrray
        /// </summary>
        private Image AlbumCover
        {

            get
            {
                return (_Album.POCHETTE!=null && _Album.POCHETTE.Length>0) ? new Bitmap(new MemoryStream(this._Album.POCHETTE)) :  ProjetPT2K.Properties.Resources.defaultPicture;
            }

        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
