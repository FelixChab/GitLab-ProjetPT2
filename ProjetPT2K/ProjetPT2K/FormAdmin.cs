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
    public partial class FormAdmin : Form
    {

        private Administrator CurrentAdmin;

        /* Constructeur surcharge admin */
        public FormAdmin(Administrator admin)
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
            foreach (var entry in CurrentAdmin.GetMostBorrowedAlbums())
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
            CurrentAdmin.GetUnpopularAlbums().ForEach(a => listBoxAdminResults.Items.Add(a));
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void buttonsubsribers_Click(object sender, EventArgs e)
        {
            listBoxAdminResults.Items.Clear();
            listBoxAdminResults.Items.Add("| Liste des abonnés :");

            Database.GetInstance().GetConnection().ABONNÉS.ToList().ForEach(p =>
            {
                String text = p.ToString();
                listBoxAdminResults.Items.Add(text);

            });
        }
    }
}
