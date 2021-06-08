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
    public partial class AccountView : Form
    {
        private readonly ABONNÉS Acount;
        ABONNÉS Subriber;
        public AccountView(ABONNÉS acount )
        {
            InitializeComponent();
            this.Subriber = acount;
            label6.Text = Subriber.NOM_ABONNÉ.Trim();
            label7.Text = Subriber.PRÉNOM_ABONNÉ.Trim();
            label8.Text = Subriber.LOGIN_ABONNÉ.Trim();
            label9.Text = "*******".Trim();
            label10.Text = ""+Subriber.PAYS;
            ListLoans();
            this.Acount = acount;
        }

        private void InitializeAlbumList()
        {
            actionListBox.Items.Clear();
            List<ALBUMS> albums = Database.GetInstance().GetAllAlbums();
            albums.ForEach(album => actionListBox.Items.Add(album));
        }

        private void ListLoans()
        {
            RefreshLoanList();
            extendAllButton.Visible = extendAllButton.Enabled = true;
        }

        private void AccountView_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EMPRUNTER loan = (EMPRUNTER)actionListBox.SelectedItem;
            if (loan != null)
            {
                loan.Extend();
                RefreshLoanList();
            }
        }

        private void RefreshLoanList()
        {
            this.actionListBox.Items.Clear();
            var loans = this.Subriber.EMPRUNTER;
            foreach (EMPRUNTER loan in loans)
            {
                this.actionListBox.Items.Add(loan);
            }
        }

        private void ExtendAllButton_Click(object sender, EventArgs e)
        { 
                foreach (EMPRUNTER loan in this.Subriber.EMPRUNTER)
                {
                    if (!loan.HasBeenExtended())
                        loan.Extend();
                }
                RefreshLoanList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
