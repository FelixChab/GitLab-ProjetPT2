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
    public partial class FormAdmin : Form
    {

        private Admin CurrentAdmin;

        /* Constructeur surcharge admin */
        public FormAdmin(Admin admin)
        {
            this.CurrentAdmin = admin;
            this.listBoxAdminResults.ScrollAlwaysVisible = false;
            InitializeComponent();
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
            listBoxAdminResults.Items.Add("| Top 10 Albums :");
            listBoxAdminResults.Items.Add(" ");
            foreach (var entry in CurrentAdmin.GetBestAlbums())
            {
                i++;
                listBoxAdminResults.Items.Add("(" + i + ")" + " " + entry.Key.ToString() + " - Emprunté " + entry.Value + " fois");
            }
        }

        private void ButtonLessLoaned_Click(object sender, EventArgs e)
        {
            listBoxAdminResults.Items.Clear();
            listBoxAdminResults.Items.Add("| Albums non-empruntés depuis 1 an :");
            listBoxAdminResults.Items.Add(" ");
            CurrentAdmin.GetAlbumsNoLoan().ForEach(a => listBoxAdminResults.Items.Add(a));
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void buttonsubsribers_Click(object sender, EventArgs e)
        {
            listBoxAdminResults.Items.Clear();
            listBoxAdminResults.Items.Add(FormatText(new String[]{ "Abonné", "Emprunts"}));

            Database.GetInstance().GetConnection().ABONNÉS.ToList().ForEach(p =>
            {
                String text = p.ToString();
                listBoxAdminResults.Items.Add(FormatText(new String[] { text, p.EMPRUNTER.Count+""}));

            });
        }


        public String FormatText(String[] args)
        {
            String text = "";
            foreach (String s in args)
            {
                String user = s;
                if (user.Length > 20)
                {
                    user.Substring(0, 20);
                }
                text = text + user;
                for (int i = 0; i < 20 - user.Length; i++)
                {
                    text = text + " ";
                }
                text = text + " | ";
            }
            return text;
        }
    }
}