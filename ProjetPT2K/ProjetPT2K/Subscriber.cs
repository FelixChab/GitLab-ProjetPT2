using System;

namespace ProjetPT2K
{
    public partial class ABONNÉS : Account
    {

        /**
         * Function that allows to borrow an album.
         *
         * @param album the album the subscriber want to borrow
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

        /**
         * Return the string representation of the subscriber
         */
        public override String ToString()
        {
            return NOM_ABONNÉ + " " + PRÉNOM_ABONNÉ + " (" + CODE_ABONNÉ + ")";
        }

    }
}
