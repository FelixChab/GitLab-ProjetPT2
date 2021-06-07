using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPT2K
{
    public partial class ABONNÉS : Account
    {

        /**
         * Function responsible of the dialogue with subscriber in aims to search an album by its title.
         */
        public void Menu()
        {
            bool connected = true;


            while (connected)
            {
                Console.WriteLine("Menu abonné\n");
                Console.WriteLine("1. Emprunter un livre");
                Console.WriteLine("2. Deconnexion");

                string choice = Console.ReadLine();
                string title;
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Quel album souhaitez vous emprunter ?");
                        title = Console.ReadLine();
                        BorrowAlbum(title);
                        break;
                    case "2":
                        connected = false;
                        break;
                }
            }

        }

        /**
         * Function that allows to borrow an album.
         *
         * @param title, the title that the subscriber cwants to borrow.
         */
        public void BorrowAlbum(string title)
        {
            ALBUMS theAlbum = (from album in this.Connection.ALBUMS
                               where album.TITRE_ALBUM == title
                               select album).FirstOrDefault();

            GENRES theGenre = (from genre in this.Connection.GENRES
                               where genre.CODE_GENRE == theAlbum.CODE_GENRE
                               select genre).FirstOrDefault();

            if (theAlbum == null || theGenre == null)
                return;

            EMPRUNTER borrow = new EMPRUNTER
            {
                CODE_ABONNÉ = this.CODE_ABONNÉ,
                    CODE_ALBUM = theAlbum.CODE_ALBUM,
                    DATE_EMPRUNT = DateTime.Today,
                    DATE_RETOUR_ATTENDUE = DateTime.Today.AddDays(theGenre.DÉLAI)
            };

            this.Connection.EMPRUNTER.Add(borrow);
            this.Connection.SaveChanges();
        }

        public List<ALBUMS> GetLoans()
        {
            var loans = from album in this.Connection.ALBUMS
                        join borrower in this.Connection.EMPRUNTER
                        on album.CODE_ALBUM equals borrower.CODE_ALBUM
                        join subscriber in this.Connection.ABONNÉS
                        on borrower.CODE_ABONNÉ equals CODE_ABONNÉ
                        select album;

            return loans.ToList();
        }

        /**
         * Return the string representation of the Subscriber.
         */
        public override String ToString()
        {
            return NOM_ABONNÉ + " " + PRÉNOM_ABONNÉ + " (" + CODE_ABONNÉ + ")";
        }
    }
}
