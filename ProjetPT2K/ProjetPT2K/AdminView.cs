﻿using System;
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

        #region page system
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            previousPage();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            nextPage();
        }
        #endregion

        /* Constructeur surcharge admin */
        public AdminView(Administrator admin)
        {
            this.CurrentAdmin = admin;
            InitializeComponent();
            this.listBoxAdminResults.ScrollAlwaysVisible = false;
            ButtonExtendedLoans_Click(null, null);
            printContent(readLateLoans, "|                  Abonnés en retards d'emprunt :                  |");

        }
        #region extended and late loans
        private void ButtonExtendedLoans_Click(object sender, EventArgs e)
        {
            printContent(readExtentedLoans, "|                  Emprunts étendus :                  |");
        }

        public void readExtentedLoans()
        {
            List<EMPRUNTER> list = CurrentAdmin.GetExtendedLoans();
            this.count = list.Count();
            int start = perPage * page;
            int size = count < start + perPage ? (count - start) : perPage;
            foreach (EMPRUNTER emprunt in list.OrderBy(x => x.CODE_ALBUM).Skip(start).Take(size))
            {
                listBoxAdminResults.Items.Add(emprunt.ToString());
                listBoxAdminResults.Items.Add("____________________________________________________________________________________"); ;

            }
        }


        private void ButtonLateLoans_Click(object sender, EventArgs e)
        {
            printContent(readLateLoans, "|                  Abonnés en retards d'emprunt :                  |");

        }

        public void readLateLoans()
        {
            List<ABONNÉS> list = CurrentAdmin.GetLateSubscribers();
            this.count = list.Count();
            int start = perPage * page;
            int size = count < start + perPage ? (count - start) : perPage;
            foreach (ABONNÉS sub in list.OrderBy(x => x.CODE_ABONNÉ).Skip(start).Take(size))
            {
                listBoxAdminResults.Items.Add(sub.ToString());
                listBoxAdminResults.Items.Add("____________________________________________________________________________________"); ;

            }
        }
        #endregion

        #region purge
        private void ButtonCleanse_Click(object sender, EventArgs e)
        {
            
            printContent(readPurge, "| Purge de la base de donnée...");
        }

        public void readPurge()
        {
            List<ABONNÉS> subList =CurrentAdmin.PurgeDatabase();
            foreach(ABONNÉS sub in subList)
            {
                this.listBoxAdminResults.Items.Add("L'abonné " + sub.NOM_ABONNÉ + " " + sub.PRÉNOM_ABONNÉ + " à été supprimé.");
            }
            int count = subList.Count();
            if(count > 0)
            {
                this.listBoxAdminResults.Items.Add(subList.Count() + " abonné"+(count < 2 ? " a" : "s ont")+" été supprimé.");
            }
            else
            {
                this.listBoxAdminResults.Items.Add("Aucun abonné n'a été supprimé.");

            }
        }
        #endregion

        #region most loaned

        private void ButtonMostLoaned_Click(object sender, EventArgs e)
        {
           
            printContent(readMostLoaned, FormatText(new string[] { "Classement", "Album", "Emprunts" }));
       
           
        }

        public void readMostLoaned()
        {
            MusiquePT2_KEntities db = Database.GetInstance().GetConnection();
            this.count = 10;
            int i = 0;
            foreach (var entry in Database.GetInstance().GetMostBorrowedAlbums())
            {
                i++;
                listBoxAdminResults.Items.Add(FormatText(new string[] { i.ToString(), entry.Key.ToString(), entry.Value + " fois" }));
            }
        }
        #endregion

        #region less loaned
        private void ButtonLessLoaned_Click(object sender, EventArgs e)
        {

            printContent(readLessLoaned, "|            Albums non-empruntés depuis 1 an             |");
        }

        public void readLessLoaned()
        {
            MusiquePT2_KEntities db = Database.GetInstance().GetConnection();
            List<ALBUMS> albums = CurrentAdmin.GetUnpopularAlbums();
            this.count = albums.Count();
            int start = perPage * page;
            int size = count < start + perPage ? (count - start) : perPage;
            foreach (ALBUMS album in albums.OrderBy(x => x.EMPRUNTER.Count()).Skip(start).Take(size))
            {
                listBoxAdminResults.Items.Add(album.ToString());
                listBoxAdminResults.Items.Add("____________________________________________________________________________________"); ;

            }
        }
        #endregion

        #region subsriber


        private void buttonsubsribers_Click(object sender, EventArgs e)
        {
            printContent(readSubscriber, FormatText(new string[] { "Nom", "Prénom", "Emprunts" }));
        }

        public void readSubscriber()
        {
            this.count = Database.GetInstance().GetConnection().ABONNÉS.Count();
            int start = perPage * page;
            int size = perPage;
            if (count < start + size)
            {
                size = count - start;
            }
            MusiquePT2_KEntities db = Database.GetInstance().GetConnection();
            foreach (ABONNÉS sub in db.ABONNÉS.OrderBy(x=>x.CODE_ABONNÉ).Skip(start).Take(size))
            {
                listBoxAdminResults.Items.Add(FormatText(new string[] { sub.NOM_ABONNÉ, sub.PRÉNOM_ABONNÉ, sub.EMPRUNTER.Count()+""})); ;
                listBoxAdminResults.Items.Add("____________________________________________________________________________________"); ;

            }
        }
        #endregion

        #region format
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