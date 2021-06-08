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

        Admin currentAdmin;

        /* Constructeur par défaut */
        public FormAdmin()
        {
            InitializeComponent();
        }

        /* Constructeur surcharge admin */
        public FormAdmin(Admin admin)
        {
            this.currentAdmin = admin;
            InitializeComponent();
        }

        private void ButtonExtendedLoans_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void ButtonLateLoans_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void ButtonCleanse_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void ButtonMostLoaned_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void ButtonLessLoaned_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
