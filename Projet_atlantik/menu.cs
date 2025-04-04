using MySql.Data.MySqlClient;
using ProjetAtlantik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_atlantik
{
    public partial class menu : Form
    {

     

        private MySqlConnection maCnx;
        public menu(MySqlConnection connection)
        {
            InitializeComponent();
            this.maCnx = connection;

        }


        private void unSecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Secteur secteurForm = new Secteur(maCnx);
            secteurForm.Show();
        }

        private void menuAjouterPort_Click(object sender, EventArgs e)
        {
            port portForm = new port(maCnx);
            portForm.Show();
        }

        private void menuAjouterLiaison_Click(object sender, EventArgs e)
        {
            liaison liaisonForm = new liaison(maCnx);
            liaisonForm.Show();
        }

        private void menuAjouterTarif_Click(object sender, EventArgs e)
        {
            tarif tarifForm = new tarif(maCnx);
            tarifForm.Show();
        }

        private void menuAjouterBateau_Click(object sender, EventArgs e)
        {
            ajouterBateau ajouterBateauForm = new ajouterBateau(maCnx);
            ajouterBateauForm.Show();
        }

        private void menuAjouterTraversée_Click(object sender, EventArgs e)
        {
            ajouterTraversée ajouterTraverséeForm = new ajouterTraversée(maCnx);
            ajouterTraverséeForm.Show();

        }

        private void menuModifierBateau_Click(object sender, EventArgs e)
        {
            modifierBateau modifierBateauForm = new modifierBateau(maCnx);
            modifierBateauForm.Show();
        }

        private void menuModifierParametre_Click(object sender, EventArgs e)
        {
            modifierParametre modifierParametreForm = new modifierParametre(maCnx);
            modifierParametreForm.Show();
        }

        private void menuAfficherTraversée_Click(object sender, EventArgs e)
        {
            afficherTraversée afficherTraverséeForm = new afficherTraversée(maCnx);
            afficherTraverséeForm.Show();
        }

        private void menuAfficherRéservation_Click(object sender, EventArgs e)
        {
            détailRéservation détailRéservationForm = new détailRéservation(maCnx);
            détailRéservationForm.Show();
        }
    }
}
