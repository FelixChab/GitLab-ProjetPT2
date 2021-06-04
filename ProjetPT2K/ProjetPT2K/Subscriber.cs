using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPT2K
{
    public partial class ABONNÉS : Account
    {
        // Penser à ajouter une méthode ToString() (Override)


        /**
         *Function that allows to borrow an album.
         *@param title, the title that the subscriber cwants to borrow.
         */
        public void BorrowAlbum(string title)
        {
            ALBUMS theAlbum = (from album in this.Connection.ALBUMS
                            where album.TITRE_ALBUM == title
                            select album).First();

            GENRES theGenre = (from genre in this.Connection.GENRES
                        where genre.CODE_GENRE == theAlbum.CODE_GENRE
                        select genre).First();

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

        /**
         * Function responsible of the dialogue with subscriber in aims to search an album by its title.
         * */
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
                switch(choice)
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

        public List<ALBUMS> GetLoans()
        {
            MusiquePT2_KEntities connection = Database.GetInstance().GetConnection();
            List<ALBUMS> loans = (from a in connection.ALBUMS
                                  join e in connection.EMPRUNTER
                                  on a.CODE_ALBUM equals e.CODE_ALBUM
                                  join ab in connection.ABONNÉS on e.CODE_ABONNÉ equals CODE_ABONNÉ
                                  select a).ToList();
            return loans;
        }

        public override String ToString()
        {
            return NOM_ABONNÉ + " " + PRÉNOM_ABONNÉ + " (" + CODE_ABONNÉ + ")";
        }
    }
}
