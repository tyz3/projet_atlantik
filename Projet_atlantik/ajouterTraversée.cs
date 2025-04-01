using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Dynamic;
using System.Windows.Forms;

namespace Projet_atlantik
{
    public partial class ajouterTraversée : Form
    {
        private MySqlConnection maCnx;

        public ajouterTraversée(MySqlConnection connection)
        {
            InitializeComponent();
            this.maCnx = connection;
        }

        private void ajouterTraversée_Load(object sender, EventArgs e)
        {
            RemplirNomBateau();
            RemplirSecteurs();
            RemplirLiaison();
            
            dtpTraverséeJourDépart.CustomFormat = "MM/dd/yyyy";
            dtpTraverséeJourDépart.Format = DateTimePickerFormat.Custom;
            dtpTraverséeDateHeureDépart.CustomFormat = "HH:mm";
            dtpTraverséeDateHeureDépart.Format = DateTimePickerFormat.Custom;
            dtpTraverséeDateHeureDépart.ShowUpDown = true;
            dtpTraverséeDateJourArrivée.CustomFormat = "MM/dd/yyyy";
            dtpTraverséeDateJourArrivée.Format = DateTimePickerFormat.Custom;
            dtpTraverséeDateHeureArrivée.CustomFormat = "HH:mm";
            dtpTraverséeDateHeureArrivée.Format = DateTimePickerFormat.Custom;
            dtpTraverséeDateHeureArrivée.ShowUpDown = true;
        }

        public void RemplirNomBateau()
        {

            cmbbxBateauAjouterTraversée.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT nom, nobateau FROM bateau";
            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    bateauClass b = new bateauClass(reader.GetString("nom"), reader.GetInt32("nobateau"));
                    cmbbxBateauAjouterTraversée.Items.Add(b);
                }
            }
            maCnx.Close();
        }

        public void RemplirSecteurs()
        {
            lstbxSecteursAjouterTraversée.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOM, nosecteur FROM secteur";
            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    secteurClass s = new secteurClass(reader.GetString("nom"), reader.GetInt32("noSecteur"));
                    lstbxSecteursAjouterTraversée.Items.Add(s);
                }
            }
            maCnx.Close();
        }

        public void RemplirLiaison()
        {
            cmbbxLiaisonAjouterTraversée.Items.Clear();

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
                    cmbbxLiaisonAjouterTraversée.Items.Add(l);
                }
            }

            maCnx.Close();
        }

        private void ChargerLiaisonsPourSecteur(string noSecteur)
        {
            cmbbxLiaisonAjouterTraversée.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOPORT_DEPART, NOPORT_ARRIVEE, NOLIAISON, NOM " +
                           "FROM port p " +
                           "INNER JOIN liaison l ON p.NOPORT = l.NOPORT_DEPART " +
                           "WHERE l.NOSECTEUR = (SELECT NOSECTEUR FROM secteur WHERE NOSECTEUR = @noSecteur)";

            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            {
                cmd.Parameters.AddWithValue("@noSecteur", noSecteur);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        liaisonClass l = new liaisonClass(reader.GetInt32("NOPORT_DEPART"), reader.GetInt32("NOPORT_ARRIVEE"), reader.GetInt32("NOLIAISON"), reader.GetString("NOM"));
                        cmbbxLiaisonAjouterTraversée.Items.Add(l);
                    }
                }
            }
            maCnx.Close();
        }

        private void lstbxSecteursAjouterTraversée_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerLiaisonsPourSecteur(lstbxSecteursAjouterTraversée.SelectedItem.ToString());
        }

        private void btnAjouterTraversée_Click(object sender, EventArgs e)
        {
            try
            {
                if (maCnx.State != ConnectionState.Open)
                    maCnx.Open();

                liaisonClass l = (liaisonClass)cmbbxLiaisonAjouterTraversée.SelectedItem;
                bateauClass b = (bateauClass)cmbbxBateauAjouterTraversée.SelectedItem;
                secteurClass secteur = (secteurClass)lstbxSecteursAjouterTraversée.SelectedItem;

                string query = "INSERT INTO traversee (NOLIAISON, NOBATEAU, DATEHEUREDEPART, DATEHEUREARRIVEE) " +
                    "VALUES (@noliaison, @nobateau, @dateheuredepart, @dateheurearrivee)";
                using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
                {
                    cmd.Parameters.AddWithValue("@noliaison", l.GetNoLiaison());
                    cmd.Parameters.AddWithValue("@nobateau", b.GetNoBateau());
                    cmd.Parameters.AddWithValue("@dateheuredepart", dtpTraverséeJourDépart.Value.Date.Add(dtpTraverséeDateHeureDépart.Value.TimeOfDay).AddSeconds(-dtpTraverséeDateHeureDépart.Value.Second));
                    cmd.Parameters.AddWithValue("@dateheurearrivee", dtpTraverséeDateJourArrivée.Value.Date.Add(dtpTraverséeDateHeureArrivée.Value.TimeOfDay).AddSeconds(-dtpTraverséeDateHeureArrivée.Value.Second));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout des capacités du bateau : {ex.Message}");
                return;
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                    maCnx.Close();
            }
            MessageBox.Show("Traversée ajoutée avec succès !");
        }
    }
}
