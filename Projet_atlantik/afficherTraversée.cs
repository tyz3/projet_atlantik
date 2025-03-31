using MySql.Data.MySqlClient;
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
    public partial class afficherTraversée : Form
    {
        private MySqlConnection maCnx;

        public afficherTraversée(MySqlConnection connection)
        {
            InitializeComponent();
            this.maCnx = connection;
        }

        private void afficherTraversée_Load(object sender, EventArgs e)
        {
            RemplirLiaison();
            RemplirSecteurs();
         
    

        }




        public void RemplirSecteurs()
        {
            lstbxSecteursAfficherTraversée.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOM, NOSECTEUR FROM secteur";
            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    secteurClass s = new secteurClass(reader.GetString("nom"), reader.GetInt32("noSecteur"));
                    lstbxSecteursAfficherTraversée.Items.Add(s);
                }
            }
            maCnx.Close();
        }




       


        private void ChargerLiaisonsPourSecteur(string secteurNom)
        {
            cmbbxLiaisonAfficherTraversée.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOPORT_DEPART, NOPORT_ARRIVEE, NOLIAISON, NOM " +
                           "FROM port p " +
                           "INNER JOIN liaison l ON p.NOPORT = l.NOPORT_DEPART " +
                           "WHERE l.NOSECTEUR = (SELECT NOSECTEUR FROM secteur WHERE NOM = @secteurNom)";

            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            {
                cmd.Parameters.AddWithValue("@secteurNom", secteurNom);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbbxLiaisonAfficherTraversée.Items.Add(new liaisonClass(reader.GetInt32("NOPORT_DEPART"), reader.GetInt32("NOPORT_ARRIVEE"), reader.GetInt32("NOLIAISON"), reader.GetString("NOM")));
                    }
                }
            }
            maCnx.Close();
        }

        private void lstbxSecteursAfficherTraversée_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerLiaisonsPourSecteur(lstbxSecteursAfficherTraversée.SelectedItem.ToString());
        }


        public void RemplirLiaison()
        {
            cmbbxLiaisonAfficherTraversée.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();


            string query = "SELECT l.NOLIAISON, l.NOPORT_DEPART, l.NOPORT_ARRIVEE, " +
                           "p1.NOM AS NomDepart, p2.NOM AS NomArrivee " +
                           "FROM liaison l " +
                           "INNER JOIN port p1 ON l.NOPORT_DEPART = p1.NOPORT " +
                           "INNER JOIN port p2 ON l.NOPORT_ARRIVEE = p2.NOPORT";

            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                
                    liaisonClass l = new liaisonClass(reader.GetInt32("NOLIAISON"), reader.GetInt32("NOPORT_DEPART"), reader.GetInt32("NOPORT_ARRIVEE"), reader.GetString("NomDepart") + " -> " + reader.GetString("NomArrivee"));
                    cmbbxLiaisonAfficherTraversée.Items.Add(l);
                }
            }

            maCnx.Close();
        }


        
        public void RemplirTraversée()
        {
            lvAfficherTraversée.Items.Clear();

            lvAfficherTraversée.View = View.Details;
            lvAfficherTraversée.GridLines = true;
            lvAfficherTraversée.FullRowSelect = true;

            lvAfficherTraversée.Columns.Add("N°", 50);
            lvAfficherTraversée.Columns.Add("Heure", 70);
            lvAfficherTraversée.Columns.Add("Bateau", 90);
            lvAfficherTraversée.Columns.Add("A Passager", 80);
            lvAfficherTraversée.Columns.Add("B - Véh.inf.2m", 80);
            lvAfficherTraversée.Columns.Add("C - Véh.sup.2m", 80);


        }


        private void btnAfficherTraversées_Click(object sender, EventArgs e)
        {
            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            try
            {
                string query = "SELECT traversee.NOTRAVERSEE, traversee.DATEHEUREDEPART, traversee.NOBATEAU, bateau.NOM, contenir.CAPACITEMAX, contenir.LETTRECATEGORIE, enregistrer.QUANTITERESERVEE, (contenir.CAPACITEMAX - enregistrer.QUANTITERESERVEE) AS PLACES_DISPOS" +
                    "FROM traversee" +
                    "JOIN bateau ON traversee.NOBATEAU = bateau.NOBATEAU" +
                    "JOIN enregistrer ON contenir.LETTRECATEGORIE = enregistrer.LETTRECATEGORIE" +
                    "JOIN reservation ON traversee.NOTRAVERSEE = reservation.NOTRAVERSEE" +
                    "JOIN client ON reservation.NOCLIENT = client.NOCLIENT";

                ;
                using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
                {
                
                
                }

                RemplirTraversée();
            }


            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification du bateau : {ex.Message}");
                return;
            }

        }

        
    }
}
