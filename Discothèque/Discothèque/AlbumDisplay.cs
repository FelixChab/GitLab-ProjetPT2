using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discotèque
{
    /// <summary>
    /// 
    /// </summary>
    class AlbumDisplay
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ALBUMS _Album;

        private readonly Point _Position;

        public static readonly Size Size = new Size(100, 100);

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubscriberView));

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="theAlbum">The album to draw</param>
        /// <param name="thePosition">The position of the draw</param>
        public AlbumDisplay(ALBUMS theAlbum, Point thePosition)
        {
            this._Album = theAlbum;
            this._Position = thePosition;
            /*
            if (this._Album != null)
            {
                if (this._Album.POCHETTE != null)
                {
                    this.Picture = theAlbum.POCHETTE;
                }
                else
                {
                    this.Picture = ImageToByteArray((Image)resources.GetObject("defaultPicture.png"));
                }
            }
            else
            {

            }
            */
        }

        /// <summary>
        /// Draw an album
        /// </summary>
        /// <param name="theScreen">The graphics</param>
        public void Draw(Graphics theScreen)
        {
            theScreen.DrawImage(this._AlbumCover, this._Position.X, this._Position.Y,
                        Size.Width, Size.Height);
            /*
            if (GetAlbumCover() != null)
            {
                if (_Album != null)
                {
                    
                }
            }
            else
            {
                theScreen.DrawString("Pas assez d'albums n'ont été emprunté ! \n" +
                    "Le top 10 s'affichera ici au fur et à mesure une fois " +
                    "qu'au moins \n" +
                    "10 albums auront étaient empruntés.", new Font("Comic Sans MS", 12), new SolidBrush(Color.Red), _Position);
            }
            */
        }

        /// <summary>
        /// If a point is in the album size.
        /// </summary>
        /// <param name="thePoint">The point</param>
        /// <returns>True if a point is in the album, false else</returns>
        public bool Contains(Point thePoint)
        {
            Rectangle theRectangle = new Rectangle(_Position, Size);
            return theRectangle.Contains(thePoint);
        }

        /// <summary>
        ///  Return an image from a bytes arrray
        /// </summary>
        private Image _AlbumCover
        {
            get
            {
                MemoryStream theStream = new MemoryStream(this._Album.POCHETTE);
                return new Bitmap(theStream);
            }
        }

        /// <summary>
        /// The size of the picture of an album.
        /// </summary>
        /// <returns>The size of the picture of an album</returns>
        public Size GetImageWidth()
        {
            return Size;
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
