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
        private ALBUMS album;
        private byte[] picture { get; set; }
        private string title;
        public string Title { get { return this.title; } set { this.title = TITRE_ALBUM; } }
        private string editor;
        public string Editor { get { return this.editor; } set { this.editor = EDITEURS.NOM_EDITEUR; } }
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
            this.picture = album.POCHETTE;
        }

        /// <summary>
        ///  Return an image from a bytes arrray
        /// </summary>
        public Image GetImage()
        {
            MemoryStream ms = new MemoryStream(picture);
            Image img = Image.FromStream(ms);
            return img;
        }

        /// <summary>
        /// Draw an album
        /// </summary>
        /// <param name="g">The graphics</param>
        public void DrawAlbum(Graphics g)
        {
            if (GetImage() != null)
            {
                g.DrawImage(GetImage(), position.X, position.Y, 75, 75);
                g.DrawString("Titre : " + title, new Font(("Comic sans MS"), 11), new SolidBrush(Color.Black), new Point(position.X, position.Y  + 95));
                g.DrawString("Éditeur : " + editor, new Font(("Comic sans MS"), 9), new SolidBrush(Color.Black), new Point(position.X, position.Y + 115));
            }
            else
            {
                g.DrawString("Pas assez d'albums n'ont été emprunté ! \n" +
                    "Le top 10 s'affichera ici au fur et à mesure une fois " +
                    "qu'au moins \n" +
                    "10 albums auront étaient empruntés.", new Font("Comic Sans MS", 12), new SolidBrush(Color.Red), position);
            }
        }

        public bool Contains (Point p)
        {
            return true;
        }
    }
}
