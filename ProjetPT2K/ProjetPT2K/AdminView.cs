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
        Admin admin;
        public AdminView(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void extendedLoansButton_Click(object sender, EventArgs e)
        {
            result.Items.Clear();
            admin.GetLateLoans().ForEach(a => result.Items.Add(a));
        }

        private void inLateButton_Click(object sender, EventArgs e)
        {
            result.Items.Clear();
            admin.GetLateSubscribers().ForEach(s=>result.Items.Add(s));
        }

        private void purgeButton_Click(object sender, EventArgs e)
        {
            result.Items.Clear();
            admin.PurgeDatabase();
            result.Items.Add("Base de données purgée");
        }

        private void mostBorrowedAlbumsButton_Click(object sender, EventArgs e)
        {
            result.Items.Clear();
            foreach(ALBUMS albums in admin.GetBestAlbums().Keys){
                result.Items.Add(albums);
            }
        }

        private void albumNotCheckedButton_Click(object sender, EventArgs e)
        {
            result.Items.Clear();
            admin.GetAlbumsNoLoan().ForEach(a => result.Items.Add(a));
        }
    }
}
