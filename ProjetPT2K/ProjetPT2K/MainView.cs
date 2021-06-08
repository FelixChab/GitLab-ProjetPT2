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
        Account account;
        public MainView(Account account)
        {
            InitializeComponent();
            this.account = account;
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
            Point position = tagBestAlbums.Location;
            foreach (ALBUMS album in Database.GetInstance().GetBestAlbums().Keys)
            {
                DisplayAlbum display = new DisplayAlbum(album, position);
                display.drawAlbum(e.Graphics);
            }
        }

        private void GoToAccountView_Click(object sender, EventArgs e)
        {
            // Open account view
        }
    }
}
