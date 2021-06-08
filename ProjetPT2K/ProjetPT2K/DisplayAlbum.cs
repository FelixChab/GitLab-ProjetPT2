using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPT2K
{
    class DisplayAlbum : ALBUMS
    {
        //List<ALBUMS> albums;
        private ALBUMS album;
        //private List<byte[]> pictures { get; set; }

        private byte[] picture { get; set; }
        private string title { get { return this.title; } set { this.title = TITRE_ALBUM; } }
        private string editor { get { return this.editor; } set { this.editor = EDITEURS.NOM_EDITEUR; } }
        private Point position { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="album">The album to draw</param>
        /// <param name="position">The position of the draw</param>
        public DisplayAlbum(ALBUMS album, Point position)
        {
            this.album = album;
            this.position = position;
            //this.pictures = new List<byte[]>();
            //this.albums.ForEach(a => pictures.Add(a.POCHETTE));
        }

        /// <summary>
        ///  Return an image from a bytes arrray
        /// </summary>
        public Image getImages()
        {
            List<Image> images = new List<Image>();
            //foreach (byte[] pictureInBytes in pictures)
            //{
            MemoryStream ms = new MemoryStream(picture);
            Image img = Image.FromStream(ms);
            images.Add(img);

            //}
            return img;
        }

        /// <summary>
        /// Draw an album
        /// </summary>
        /// <param name="g">The graphics</param>
        public void drawAlbum(Graphics g)
        {
            if (getImages() != null)
            {
                //foreach (Image image in getImages())
                //{
                g.DrawImage(getImages(), position.X, position.Y, 50, 50);
                position = new Point(position.X + 200, position.Y);
                g.DrawString("Titre : " + title, new Font(("Comic sans MS"), 11), new SolidBrush(Color.Black), new Point(position.X, getImages().Height + 20));
                g.DrawString("Éditeur : " + editor, new Font(("Comic sans MS"), 9), new SolidBrush(Color.Black), new Point(position.X, getImages().Height + 40));
                //}
            }
            else
            {
                g.DrawString("Pas assez d'albums n'ont été emprunté ! \n" +
                    "Le top 10 s'affichera ici au fur et à mesure une fois " +
                    "qu'au moins \n" +
                    "10 albums auront étaient empruntés.", new Font("Comic Sans MS", 12), new SolidBrush(Color.Red), position);
            }
        }
    }
}
