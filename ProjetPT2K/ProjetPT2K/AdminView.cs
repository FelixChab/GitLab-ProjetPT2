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

        private Admin CurrentAdmin;

        private String header;
        private List<String> content = new List<string>();
        private int page = 0;
        private int perPage = 20;

        public void printContent(List<String> content, String header)
        {
            this.page = 0;
            this.header = header;
            this.content.Clear();
            listBoxAdminResults.Items.Clear();
            listBoxAdminResults.Items.Add(header);
            for (int i = 0; i<perPage; i++)
            {
                if (i >= content.Count) continue;
                this.content.Add(content[i]);
                listBoxAdminResults.Items.Add(content[i]);
            }
            updatePageLabel();
        }


        public void nextPage()
        {
            int total = this.content.Count / perPage;
            if (page == (total-1)) return;
            page++;
            printCurrent();
            

        }
        public void printCurrent()
        {
            listBoxAdminResults.Items.Clear();
            listBoxAdminResults.Items.Add(header);
            for (int i = page * perPage; i < ((page * perPage) + perPage); i++)
            {
                if (i >= content.Count) break;
                listBoxAdminResults.Items.Add(content[i]);
            }
            updatePageLabel();
        }

        public void updatePageLabel()
        {
            pageLabel.Text = (page + 1) + "/" + (content.Count / perPage);
        }

        public void previousPage()
        {
            if (page == 0) return;
            page--;
            printCurrent();

        }

        /* Constructeur surcharge admin */
        public AdminView(Admin admin)
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
            foreach (var entry in Database.GetInstance().GetBestAlbums())
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
            CurrentAdmin.GetAlbumsNoLoan().ForEach(a => listBoxAdminResults.Items.Add(a.ToString()));
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void buttonsubsribers_Click(object sender, EventArgs e)
        {
            int[] padding = new int[] { 25, 25, 15, 15 };
            listBoxAdminResults.Items.Clear();
            List<String> list = new List<string>();
            
            list.Add("_________________________________________________________________________________");
            Database.GetInstance().GetConnection().ABONNÉS.ToList().ForEach(p =>
            {
                String text = p.ToString();
                // TODO corriger affichage
                list.Add(FormatText(new String[] { p.NOM_ABONNÉ, p.PRÉNOM_ABONNÉ, "#"+ p.CODE_ABONNÉ, p.EMPRUNTER.Count.ToString() },
                               padding));
              list.Add("_________________________________________________________________________________");
            });
            printContent(list, FormatText(new String[] { "Nom", "Prénom", "Code-abonné", "Emprunts" }, padding));
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