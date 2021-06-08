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
    public partial class NewAccountView : Form
    {
        public Login login;
        private readonly MusiquePT2_KEntities Connection = Database.GetInstance().GetConnection();

        /* Constructeur */
        public NewAccountView(Login l)
        {
            InitializeComponent();
            login = l;
            List<PAYS> list = (from a in Connection.PAYS select a).ToList();
            foreach(PAYS p in list)
            {
                countryboxlabel.Items.Add(p);
            }
        }

        /* Function of the inscription button */
        private void InscriptionButton(object sender, EventArgs e)
        {
            String prenom = namelabel.Text;
            String nom = familyNameLabel.Text;
            PAYS pays = (PAYS)countryboxlabel.SelectedItem;
            String username = userlabel.Text;
            String password = passwordlabel.Text;
            if (!ValidArgs(new string[] { prenom, nom, pays.ToString(), username, password}))
            {
                errorLabel.Text = "Une des informations est incorrecte.";
                errorLabel.Visible = true;
                Reset();
                return;
            }
            if(Database.GetInstance().AccountExists(username))
            {
                errorLabel.Text = "Identifiant non disponible.";
                errorLabel.Visible = true;
                Reset();
                return;
            }
            Database.GetInstance().CreateAccount(prenom, nom, pays.CODE_PAYS, username, password);
            login.GetErrorLabel().Text = "Votre compte a bien été créer.";
            login.GetErrorLabel().ForeColor = Color.LightGreen;
            login.GetErrorLabel().Visible = true;
            Close();
        }

        /* Method of reset */
        public void Reset()
        {
            namelabel.Text = "";
            familyNameLabel.Text = "";
            userlabel.Text = "";
            passwordlabel.Text = "";
        }

        /* ??? */
        private Boolean ValidArgs(String[] args)
        {
            foreach(String s in args)
            {
                if (s.Length <= 1) return false;
            }
            return true;
        }

        private void PictureBoxLogo_Click(object sender, EventArgs e)
        {
            // TODO (retour accueil / connexion)
        }
    }
}
