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
    public partial class tarif : Form
    {

        private MySqlConnection maCnx;
        public tarif(MySqlConnection connection)
        {
            InitializeComponent();
            this.maCnx = connection;
            RemplirSecteurs();
            RemplirLiaison();
            RemplirPeriode();

        }

       
        private void tarif_Load(object sender, EventArgs e)
        {
            
                if (maCnx.State == ConnectionState.Closed)
                {
                    maCnx.Open();
                }

                try
                {
                    
                    if (maCnx.State == ConnectionState.Closed)
                        maCnx.Open();

                    string query = "SELECT * FROM type";
                    int i = 1;
                    Label lblTarifsTypeCategorieText = new Label();
                    lblTarifsTypeCategorieText.Text = "Catégorie - Type";
                    lblTarifsTypeCategorieText.Location = new Point(5, i * 25);
                    gbxTarif.Controls.Add(lblTarifsTypeCategorieText);
                    Label lblTarifsTypeCategorieText2 = new Label();
                    lblTarifsTypeCategorieText2.Text = "Tarif";
                    lblTarifsTypeCategorieText2.Location = new Point(125, i * 25);
                    gbxTarif.Controls.Add(lblTarifsTypeCategorieText2);
                    i++;
                    MySqlCommand cmd = new MySqlCommand(query, maCnx);
                    MySqlDataReader jeuEnr = cmd.ExecuteReader();
                    {
                        while (jeuEnr.Read())
                        {
                            Label lblTarifsTypeCategorie = new Label();
                            lblTarifsTypeCategorie.Text = jeuEnr["lettrecategorie"] + jeuEnr["notype"].ToString() + " - " + jeuEnr["libelle"];
                            lblTarifsTypeCategorie.Location = new Point(5, i * 25);
                            gbxTarif.Controls.Add(lblTarifsTypeCategorie);

                            TextBox tbxTarifsTypeCategorie = new TextBox();
                            tbxTarifsTypeCategorie.Tag = jeuEnr["lettrecategorie"] + jeuEnr["notype"].ToString();
                            tbxTarifsTypeCategorie.Location = new Point(125, i * 25);
                            gbxTarif.Controls.Add(tbxTarifsTypeCategorie);
                            i++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (maCnx.State == ConnectionState.Open)
                    {
                        maCnx.Close();
                    }
                }
            }
        




        public void RemplirSecteurs()
        {
            lstbxTarif.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOM FROM secteur";
            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lstbxTarif.Items.Add(reader["NOM"].ToString());
                }
            }
            maCnx.Close();
        }


        public void RemplirLiaison()
        {
            cmbbxTarifLiaison.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOPORT_DEPART, NOPORT_ARRIVEE, NOM " +
                       "FROM port p " +
                       "INNER JOIN liaison l ON p.NOPORT = l.NOPORT_DEPART";

            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                   

                    cmbbxTarifLiaison.Items.Add(new LiaisonTarif(reader.GetInt32("NOPORT_DEPART"),  reader.GetInt32("NOPORT_ARRIVEE"), reader.GetString("NOM")));
                }
            }
            maCnx.Close();
        }


        private void RemplirPeriode()
        {
            string query = "SELECT datedebut, datefin, noperiode FROM periode";

            if (maCnx.State == ConnectionState.Closed)
            {
                maCnx.Open();
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                { 
                    
                   cmbbxTarifPeriode.Items.Add(new Periode(reader.GetDateTime("datedebut"), reader.GetDateTime("datefin"), reader.GetInt32("noPeriode")));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }

        public void ChargerTarif()
        {

        }

        private void lstbxTarif_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secteurNom = lstbxTarif.SelectedItem.ToString();
            
        }

        private void btnAjouterTarif_Click(object sender, EventArgs e)
        {
            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();
            try
            {
                string query = "INSERT INTO tarifer (NOPERIODE, LETTRECATEGORIE, NOTYPE, NOLIAISON, TARIF) " +
                               "VALUES (@periode, @categorie, @type, @liaison, @tarif)";

                using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
                {
                    cmd.Parameters.AddWithValue("@periode", (Periode)cmbbxTarifPeriode.SelectedItem);
                    cmd.Parameters.AddWithValue("@categorie", lstbxTarif.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@type", gbxTarif.Text);
                    cmd.Parameters.AddWithValue("@liaison", (LiaisonTarif)cmbbxTarifLiaison.SelectedItem);
                    cmd.Parameters.AddWithValue("@tarif", gbxTarif.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Ajouté avec succès.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de l'ajout: " + ex.Message);
            }
            maCnx.Close();
        }





    }


}

