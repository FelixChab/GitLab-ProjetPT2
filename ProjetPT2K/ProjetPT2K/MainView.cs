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
        public MainView(Account account)
        {
            InitializeComponent();
            this.account = (ABONNÉS) account;
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

            Point position = tagRecommandations.Location;
            foreach (ALBUMS album in account.GetRecommandations().Keys)
            {
                DisplayAlbum display = new DisplayAlbum(album, position);
                display.DrawAlbum(e.Graphics);
                position = new Point(position.X + 100, position.Y);
            }
            position = tagBestAlbums.Location;
            foreach (ALBUMS album in Database.GetInstance().GetBestAlbums().Keys)
            {
                DisplayAlbum display = new DisplayAlbum(album, position);
                display.DrawAlbum(e.Graphics);
                position = new Point(position.X + 100, position.Y);
            }
            
            
        }

        private void GoToAccountView_Click(object sender, EventArgs e)
        {
            // Open account view
        }
    }
}
