using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetPT2K
{
    public partial class AdminView : Form
    {

        private Administrator CurrentAdmin;

        private String header;
        private Action function;
        private int count;
        private int page = 0;
        private int perPage = 20;

        public void printContent(Action function, String header)
        {
            this.page = 0;
            this.header = header;
            this.function = function;
            listBoxAdminResults.Items.Clear();
            listBoxAdminResults.Items.Add(header);
            showCurrent();
            updatePageLabel();
        }
        public int getPageCount()
        {
            return count % perPage == 0 ? count / perPage : ((count / perPage) + 1);
        }
        public void showCurrent()
        {
            listBoxAdminResults.Items.Clear();
            listBoxAdminResults.Items.Add(header);
            function.Invoke();
            updatePageLabel();
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

        /* Constructeur surcharge admin */
        public AdminView(Administrator admin)
        {
            this.CurrentAdmin = admin;
            InitializeComponent();
            this.listBoxAdminResults.ScrollAlwaysVisible = false;

        }

        private void ButtonExtendedLoans_Click(object sender, EventArgs e)
        {
            listBoxAdminResults.Items.Clear();
            listBoxAdminResults.Items.Add("| Emprunts étendus :");
            listBoxAdminResults.Items.Add(" ");
            CurrentAdmin.GetExtendedLoans().ForEach(a => listBoxAdminResults.Items.Add(a));
        }

        private void ButtonLateLoans_Click(object sender, EventArgs e)
        {
            listBoxAdminResults.Items.Clear();
            listBoxAdminResults.Items.Add("| Abonnés en retards d'emprunt :");
            listBoxAdminResults.Items.Add(" ");
            CurrentAdmin.GetLateSubscribers().ForEach(s => listBoxAdminResults.Items.Add(s));
        }

        private void ButtonCleanse_Click(object sender, EventArgs e)
        {
            listBoxAdminResults.Items.Clear();
            CurrentAdmin.PurgeDatabase();
            listBoxAdminResults.Items.Add("| Purge de la base de donnée...");
            listBoxAdminResults.Items.Add(" ");
            listBoxAdminResults.Items.Add("Base de données purgée.");
        }

        private void ButtonMostLoaned_Click(object sender, EventArgs e)
        {
            int i = 0;
            listBoxAdminResults.Items.Clear();
            int[] padding = new int[] { 20, 50, 20};

            listBoxAdminResults.Items.Add(FormatText(new string[]{"Classement", "Album", "Emprunts"}, padding));
            listBoxAdminResults.Items.Add(" ");
            foreach (var entry in Database.GetInstance().GetMostBorrowedAlbums())
            {
                i++;
                listBoxAdminResults.Items.Add(FormatText(new string[] { i.ToString(), entry.Key.ToString(), entry.Value + " fois" }, padding));
            }
        }

        private void ButtonLessLoaned_Click(object sender, EventArgs e)
        {
            listBoxAdminResults.Items.Clear();
            listBoxAdminResults.Items.Add("|            Albums non-empruntés depuis 1 an             |");
            listBoxAdminResults.Items.Add(" ");
            CurrentAdmin.GetUnpopularAlbums().ForEach(a => listBoxAdminResults.Items.Add(a.ToString()));
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private int[] SubscriberPadding = new int[] { 25, 25, 15, 15 };

        private void buttonsubsribers_Click(object sender, EventArgs e)
        {
            printContent(readSubscriber, FormatText(new string[] { "Nom", "Prénom", "Emprunts" }, SubscriberPadding));
        }

        public void readSubscriber()
        {
            this.count = Database.GetInstance().GetConnection().ABONNÉS.Count();
            int start = perPage * page;
            listBoxAdminResults.Items.Clear();
            foreach (ABONNÉS sub in Database.GetInstance().GetConnection().ABONNÉS.Skip(start).Take(perPage))
            {
                listBoxAdminResults.Items.Add(header);
                listBoxAdminResults.Items.Add(FormatText(new string[] { sub.NOM_ABONNÉ, sub.PRÉNOM_ABONNÉ, sub.EMPRUNTER.Count()+""}, SubscriberPadding)); ;
            }
        }

        public String FormatText(String[] args, int[] padding)
        {
            StringBuilder line = new StringBuilder();
            for (int i = 0; i < args.Length; i++)

            {
                String s = args[i];
                int targetPadding = padding[i];
            
                line.Append(s.PadRight(targetPadding));
                line.Append("|");
            }
            return line.ToString();
        }

        private void listBoxAdminResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            previousPage();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            nextPage();
        }
    }
}