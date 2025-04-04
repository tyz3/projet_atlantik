using MySql.Data.MySqlClient;
using Projet_atlantik;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjetAtlantik
{
    public partial class détailRéservation : Form
    {
        private MySqlConnection maCnx;

        public détailRéservation(MySqlConnection connexion)
        {
            InitializeComponent();
            this.maCnx = connexion;
        }

        private void détailRéservation_Load(object sender, EventArgs e)
        {
            lvRéservation.View = View.Details;
            lvRéservation.GridLines = true;
            lvRéservation.FullRowSelect = true;
            lvRéservation.Columns.Add("N° Réservation", 100);
            lvRéservation.Columns.Add("Liaison", 150);
            lvRéservation.Columns.Add("N° Traversée", 100);
            lvRéservation.Columns.Add("Date Départ", 150);

            ChargerClient();
        }

        private void cmbbxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxClient.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un client.");
                return;
            }

            if (cmbbxClient.SelectedItem is clientClass clientSelectionne)
            {
                ChargerRéservation(clientSelectionne.getNoClient().ToString());
            }
        }

        private void ChargerClient()
        {
            if (maCnx == null)
            {
                MessageBox.Show("Connexion à la base de données non initialisée.");
                return;
            }

            string query = "SELECT noclient, nom, prenom FROM client";

            try
            {
                if (maCnx.State == ConnectionState.Closed)
                {
                    maCnx.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                MySqlDataReader reader = cmd.ExecuteReader();

                cmbbxClient.Items.Clear();

                while (reader.Read())
                {
                    clientClass client = new clientClass(reader.GetInt32("noclient"), reader.GetString("nom"), reader.GetString("prenom"));

                    if (!cmbbxClient.Items.Cast<object>().Any(item =>
                        item is clientClass c && c.getNoClient() == client.getNoClient()))
                    {
                        cmbbxClient.Items.Add(client);
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des clients : " + ex.Message);
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }

        private void ChargerRéservation(string clientId)
        {
            if (maCnx == null)
            {
                MessageBox.Show("Connexion à la base de données non initialisée.");
                return;
            }

            if (string.IsNullOrWhiteSpace(clientId))
            {
                MessageBox.Show("Client invalide.");
                return;
            }

            string query = @"
                SELECT 
                r.NORESERVATION, CONCAT(p1.NOM, ' - ', p2.NOM) AS Liaison,r.NOTRAVERSEE, t.DATEHEUREDEPART 
                FROM reservation r
                JOIN traversee t ON r.NOTRAVERSEE = t.NOTRAVERSEE
                JOIN liaison l ON t.NOLIAISON = l.NOLIAISON
                JOIN port p1 ON l.NOPORT_DEPART = p1.NOPORT
                JOIN port p2 ON l.NOPORT_ARRIVEE = p2.NOPORT
                WHERE r.NOCLIENT = @clientId";

            try
            {
               
                lvRéservation.Items.Clear();

                if (maCnx.State == ConnectionState.Closed)
                {
                    maCnx.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                cmd.Parameters.AddWithValue("@clientId", clientId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("Aucune réservation trouvée pour ce client.");
                    return;
                }

                while (reader.Read())
                {
                    var tabItem = new string[4]
                    {
                        reader.GetInt32("NORESERVATION").ToString(),
                        reader.GetString("Liaison"),
                        reader.GetInt32("NOTRAVERSEE").ToString(),
                        reader.GetDateTime("DATEHEUREDEPART").ToString("dd/MM/yyyy HH:mm")
                    };

                    ListViewItem item = new ListViewItem(tabItem);
                    item.Tag = tabItem[0];
                    lvRéservation.Items.Add(item);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des réservations : " + ex.Message);
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }





        private void AfficherDétailsRéservation(string noReservation)
        {
            if (maCnx == null)
            {
                MessageBox.Show("Connexion à la base de données non initialisée.");
                return;
            }

            if (string.IsNullOrWhiteSpace(noReservation))
            {
                MessageBox.Show("Numéro de réservation invalide.");
                return;
            }

 
            ViderGbx(gbxRéservation);

            string query = @"
        SELECT 
            SUM(CASE WHEN t.LIBELLE LIKE 'Adulte%' THEN e.QUANTITERESERVEE ELSE 0 END) AS nbAdultes,
            SUM(CASE WHEN t.LIBELLE LIKE 'Junior%' THEN e.QUANTITERESERVEE ELSE 0 END) AS nbJuniors,
            SUM(CASE WHEN t.LIBELLE LIKE 'Enfant%' THEN e.QUANTITERESERVEE ELSE 0 END) AS nbEnfants,
            SUM(CASE WHEN t.LIBELLE LIKE 'Voiture%' THEN e.QUANTITERESERVEE ELSE 0 END) AS nbVoitures,
            r.MONTANTTOTAL, 
            r.MODEREGLEMENT
        FROM enregistrer e
        JOIN type t ON e.LETTRECATEGORIE = t.LETTRECATEGORIE AND e.NOTYPE = t.NOTYPE
        JOIN reservation r ON e.NORESERVATION = r.NORESERVATION
        WHERE e.NORESERVATION = @noReservation
        GROUP BY r.MONTANTTOTAL, r.MODEREGLEMENT";

            try
            {
                if (maCnx.State == ConnectionState.Closed)
                {
                    maCnx.Open();
                }

                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                cmd.Parameters.AddWithValue("@noReservation", noReservation);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblAdulte2.Text = reader.GetInt32("nbAdultes").ToString();
                    lblAdulte2.Tag = "del";
                    lblJunior2.Text = reader.GetInt32("nbJuniors").ToString();
                    lblJunior2.Tag = "del";
                    lblEnfant2.Text = reader.GetInt32("nbEnfants").ToString();
                    lblEnfant2.Tag = "del";
                    lblVoiture2.Text = reader.GetInt32("nbVoitures").ToString();
                    lblVoiture2.Tag = "del";
                    lblmontant2.Text = reader.GetDecimal("MONTANTTOTAL").ToString("C2");
                    lblmontant2.Tag = "del";
                    lblPayement2.Text = reader.GetString("MODEREGLEMENT");
                    lblPayement2.Tag = "del";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des détails de la réservation : " + ex.Message);
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }




        private void lvRéservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRéservation.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une réservation.");
                return;
            }



            string noReservation = lvRéservation.SelectedItems[0].Tag.ToString();
            AfficherDétailsRéservation(noReservation);
        }
        private void ViderGbx(GroupBox gbx)
        {
            foreach (var label in gbx.Controls.OfType<Label>().ToList())
            {
                if (label.Tag == "del")
                    lblAdulte2.Text = "";
                lblJunior2.Text = "";
                lblEnfant2.Text = "";
                lblVoiture2.Text = "";
                lblmontant2.Text = "";
                lblPayement2.Text = "";
            }
        }
        
    }
}
