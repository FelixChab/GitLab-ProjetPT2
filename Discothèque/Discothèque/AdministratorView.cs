using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discotèque
{
    /// <summary>
    /// Class representing the view for the administrator account.
    /// </summary>
    public partial class AdministratorView : Form
    {
        /// <summary>
        /// The administrator of the form
        /// </summary>
        private readonly Administrator _Administrator;

        /// <summary>
        /// Parametorised constructor creating a new AdminView object.
        /// </summary>
        /// <param name="theAdministrator"> the administrator of the view </param>
        public AdministratorView(Account theAccount)
        {
            InitializeComponent();
            loadingLabel.Visible = false;
            this._Administrator = (Administrator)theAccount;
            printContent(readExtentedLoans, "|                  Emprunts étendus :                  |");

        }

        #region page system
        private String header;
        private Func<Task> function;
        private int count;
        private int page = 0;
        private int perPage = 10;

        public void printContent(Func<Task> function, String header)
        {
            this.page = 0;
            this.header = header;
            this.function = function;
            ResultListBox.Items.Clear();
            ResultListBox.Items.Add(header);
            showCurrent();
            updatePageLabel();
        }
        public int getPageCount()
        {
            return count % perPage == 0 ? count / perPage : ((count / perPage) + 1);
        }
        public async void showCurrent()
        {
            setAllButton(false);
            ResultListBox.Items.Clear();
            loadingLabel.Visible = true;
            Refresh();
            ResultListBox.Items.Add(header);
            Task task = function.Invoke();
            task.Wait(500);
            await task;
            loadingLabel.Visible = false;
            updatePageLabel();
            Refresh();
            setAllButton(true);
        }

        public void setAllButton(Boolean enabled)
        {
            buttonsubsribers.Enabled = enabled;
            ButtonExtendedLoans.Enabled = enabled;
            ButtonLateLoans.Enabled = enabled;
            ButtonLessLoaned.Enabled = enabled;
            ButtonMostLoaned.Enabled = enabled;
            ButtonCleanse.Enabled = enabled;
        }
        public void updatePageLabel()
        {
            pageLabel.Text = (page + 1) + "/" + getPageCount();
        }
        public void nextPage()
        {
            if (page == (getPageCount() - 1)) return;
            page++;
            showCurrent();
        }

        public void previousPage()
        {
            if (page == 0) return;
            page--;
            showCurrent();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            previousPage();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            nextPage();
        }
        #endregion

        #region extended and late loans
        /// <summary>
        /// Funtction that extends loans by clicking on the button.
        /// </summary>
        /// <param name="sender"> the object that is concerned </param>
        /// <param name="e"> the event </param>
        private void ButtonExtendedLoans_Click(object sender, EventArgs e)
        {
            printContent(readExtentedLoans, "|                  Emprunts étendus :                  |");
        }


        /// <summary>
        /// Function responsible of the display of Extended loans
        /// </summary>
        public async Task readExtentedLoans()
        {
            List<EMPRUNTER> list = _Administrator.GetExtendedLoans();
            this.count = list.Count();
            int start = perPage * page;
            int size = count < start + perPage ? (count - start) : perPage;
            foreach (EMPRUNTER emprunt in list.OrderBy(x => x.CODE_ALBUM).Skip(start).Take(size))
            {
                ResultListBox.Items.Add(emprunt.ToString());
                ResultListBox.Items.Add("____________________________________________________________________________________"); ;

            }
        }


        /// <summary>
        /// Function responsible to display late loans when the button is clicked.
        /// </summary>
        /// <param name="sender">  the object that is concerned </param>
        /// <param name="e"> the event</param>
        private void ButtonLateLoans_Click(object sender, EventArgs e)
        {
            printContent(readLateLoans, "|                  Abonnés en retards d'emprunt :                  |");

        }


        /// <summary>
        /// Function that is responsible of the display of late loans.
        /// </summary>
        public async Task readLateLoans()
        {
            List<ABONNÉS> list = _Administrator.GetLateSubscribers();
            this.count = list.Count();
            int start = perPage * page;
            int size = count < start + perPage ? (count - start) : perPage;
            foreach (ABONNÉS sub in list.OrderBy(x => x.CODE_ABONNÉ).Skip(start).Take(size))
            {
                ResultListBox.Items.Add(sub.ToString());
                ResultListBox.Items.Add("____________________________________________________________________________________"); ;

            }
        }
        #endregion

        #region purge

        /// <summary>
        /// Function responsible of the cleanse display of the base when the button is clicked.
        /// </summary>
        /// <param name="sender"> the object that is concerned</param>
        /// <param name="e"> the event </param>
        private void ButtonCleanse_Click(object sender, EventArgs e)
        {

            printContent(readPurge, "| Purge de la base de donnée...");
        }


        /// <summary>
        /// Function that is responsible of reading the database purge.
        /// </summary>
        public async Task readPurge()
        {
            List<ABONNÉS> subList = _Administrator.PurgeDatabase();
            foreach (ABONNÉS sub in subList)
            {
                this.ResultListBox.Items.Add("L'abonné " + sub.NOM_ABONNÉ + " " + sub.PRÉNOM_ABONNÉ + " à été supprimé.");
            }
            int count = subList.Count();
            if (count > 0)
            {
                this.ResultListBox.Items.Add(subList.Count() + " abonné" + (count < 2 ? " a" : "s ont") + " été supprimé.");
            }
            else
            {
                this.ResultListBox.Items.Add("Aucun abonné n'a été supprimé.");

            }
        }
        #endregion

        #region most loaned

        /// <summary>
        /// Funciton that is responsble of the display of the most loaned albums when the button is clicked.
        /// </summary>
        /// <param name="sender"> the object that is concerned </param>
        /// <param name="e"> the event </param>
        private void ButtonMostLoaned_Click(object sender, EventArgs e)
        {

            printContent(readMostLoaned, FormatText(new string[] { "#", "Album", "Emprunts" }));


        }

        /// <summary>
        /// Function responsible of the reading of the most Loaned albums.
        /// </summary>
        public async Task readMostLoaned()
        {
            MusiquePT2_KEntities db = Database.GetInstance().GetConnection();
            this.count = 10;
            int i = 0;
            foreach (var entry in Database.GetInstance().GetMostBorrowedAlbums())
            {
                i++;
                ResultListBox.Items.Add(FormatText(new string[] { i.ToString(), entry.Key.ToString(), entry.Value + " fois" }));
            }
        }
        #endregion


        #region less loaned

        /// <summary>
        /// Function responsible of the  display of the less loaned albums when the button is clicked.
        /// </summary>
        /// <param name="sender"> the object that is concerned</param>
        /// <param name="e"> the event </param>
        private void ButtonLessLoaned_Click(object sender, EventArgs e)
        {

            printContent(readLessLoaned, "|            Albums non-empruntés depuis 1 an             |");
        }

        /// <summary>
        /// Function responsible of the reading of the less loans albums
        /// </summary>
        public async Task readLessLoaned()
        {
            MusiquePT2_KEntities db = Database.GetInstance().GetConnection();
            List<ALBUMS> albums = _Administrator.GetUnpopularAlbums();
            this.count = albums.Count();
            int start = perPage * page;
            int size = count < start + perPage ? (count - start) : perPage;
            foreach (ALBUMS album in albums.OrderBy(x => x.EMPRUNTER.Count()).Skip(start).Take(size))
            {
                ResultListBox.Items.Add(album.ToString());
                ResultListBox.Items.Add("____________________________________________________________________________________"); ;

            }
        }
        #endregion

        #region subsriber


        private void buttonsubsribers_Click(object sender, EventArgs e)
        {
            printContent(readSubscriber, FormatText(new string[] { "Nom", "Prénom", "Emprunts" }));
        }

        public async Task readSubscriber()
        {
            this.count = Database.GetInstance().GetConnection().ABONNÉS.Count();
            int start = perPage * page;
            int size = perPage;
            if (count < start + size)
            {
                size = count - start;
            }
            MusiquePT2_KEntities db = Database.GetInstance().GetConnection();
            foreach (ABONNÉS sub in db.ABONNÉS.OrderBy(x => x.CODE_ABONNÉ).Skip(start).Take(size))
            {
                ResultListBox.Items.Add(FormatText(new string[] { sub.NOM_ABONNÉ, sub.PRÉNOM_ABONNÉ, sub.EMPRUNTER.Count() + "" })); ;
                ResultListBox.Items.Add("____________________________________________________________________________________"); ;

            }
        }
        #endregion

        #region format

        /// <summary>
        /// Format the String array into columns.
        /// </summary>
        /// <param name="args"> String to format </param>
        /// <returns></returns>
        public String FormatText(String[] args)
        {
            StringBuilder line = new StringBuilder();
            for (int i = 0; i < args.Length; i++)

            {
                String s = args[i].Trim();
                line.Append(s.PadRight(50));
                line.Append("|");
            }
            return line.ToString();
        }
        #endregion 


    }
}
