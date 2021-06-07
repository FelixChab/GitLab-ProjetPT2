using System;

namespace ProjetPT2K
{
    public partial class ABONNÉS : Account
    {

        /**
         * Function responsible of the dialogue with subscriber in aims to search an album by its title
         */
        public void MainMenu()
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
         * Function that allows to borrow an album
         * Function that allows to borrow an album.
         *
         * @param title, the title of the album that the subscriber wants to borrow
         */
        public void BorrowAlbum(ALBUMS album)
        {
            EMPRUNTER borrow = new EMPRUNTER
            {
                CODE_ABONNÉ = this.CODE_ABONNÉ,
                CODE_ALBUM = album.CODE_ALBUM,
                DATE_EMPRUNT = DateTime.Today,
                DATE_RETOUR_ATTENDUE = DateTime.Today.AddDays(album.GENRES.DÉLAI)
            };

            this.Connection.EMPRUNTER.Add(borrow);
            this.Connection.SaveChanges();
        }

        /*  public void changeTheExpectedReturnDate()
       {
           foreach (EMPRUNTER emp in EMPRUNTER)
           {
               listBox1.Items.Add(emp.ToString());
           }

           string answer = textBox1.Text;
           EMPRUNTER emprunt = this.EMPRUNTER.ElementAt(Int32.Parse(answer));

           emprunt.DATE_RETOUR_ATTENDUE = DateTime.Now.AddDays(31);
           Connection.SaveChanges();

       }
    */


        /**
         * Method that returns a list of active loans
         */
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
         * Method that returns a list of recommendations (albums based on genre) to the subscriber
         */
        public List<ALBUMS> GetRecommendations()
        {
            var recommendations = from e in Connection.EMPRUNTER
                                  join al in Connection.ALBUMS
                                  on e.CODE_ALBUM equals al.CODE_ALBUM
                                  join g in Connection.GENRES
                                  on al.CODE_GENRE equals g.CODE_GENRE
                                  orderby g.LIBELLÉ_GENRE
                                  select al;

            return recommendations.ToList();
        }


        /**
         * Function that allows to extend borrows date
         */
        public void ExtendBorrowDate()
        {
            foreach (EMPRUNTER e in this.EMPRUNTER)
            {
                e.DATE_RETOUR = DateTime.Today.AddDays(30);
            }
            this.Connection.SaveChanges();
        }

        /**
         * Return the string representation of the subscriber
         */
        public override String ToString()
        {
            return NOM_ABONNÉ + " " + PRÉNOM_ABONNÉ + " (" + CODE_ABONNÉ + ")";
        }

    }
}
