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
    public partial class MainView : Form
    {
        ABONNÉS account;
        List<DisplayAlbum> AlbumsDisplayed = new List<DisplayAlbum>();
        public MainView(Account account)
        {
            InitializeComponent();
            this.account = (ABONNÉS)account;
        }

        private void mainMenuListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void MainView_Paint(object sender, PaintEventArgs e)
        {
            List<ALBUMS> albums = new List<ALBUMS>();
            /*foreach (ALBUMS album in Database.GetInstance().GetBestAlbums().Keys)
            {
                albums.Add(album);
            }*/
            //ALBUMS album;
            DisplayAlbum display;
            Point position = tagRecommandations.Location;
            foreach (ALBUMS album in account.GetRecommandations().Keys)
            {
                display = new DisplayAlbum(album, position, new Size(75, 75));
                display.DrawAlbum(e.Graphics);
                AlbumsDisplayed.Add(display);
                position = new Point(position.X + 100, position.Y);
            }
            position = tagBestAlbums.Location;
            foreach (ALBUMS album in Database.GetInstance().GetMostBorrowedAlbums().Keys)
            {
                display = new DisplayAlbum(album, position, new Size(75, 75));
                display.DrawAlbum(e.Graphics);
                AlbumsDisplayed.Add(display);
                position = new Point(position.X + 100, position.Y);
            }
        }

        private void GoToAccountView_Click(object sender, EventArgs e)
        {
            // Open account view
        }

        private void MainView_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void MainView_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (DisplayAlbum display in AlbumsDisplayed)
            {
                if (display.Contains(e.Location))
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        MainView view = new MainView(account);
                        view.ShowDialog();

                    }
                    /*else
                    {
                        ContextMenuStrip contextMenuAlbum = new ContextMenuStrip();
                        contextMenuAlbum.Items.Add("Afficher les détails");
                        contextMenuAlbum.Items.Add("Emprunter");

                        contextMenuAlbum.Show(e.Location);
                    }*/
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AccountView accountDetails = new AccountView(account);
            accountDetails.ShowDialog();
            this.Close();
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
