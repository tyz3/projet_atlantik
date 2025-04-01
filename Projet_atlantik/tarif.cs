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
           
        }

        private void tarif_Load(object sender, EventArgs e)
        {
            RemplirSecteurs();
            RemplirLiaison();
            RemplirPeriode();


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
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Label lblTarifsTypeCategorie = new Label();
                        lblTarifsTypeCategorie.Text = reader["lettrecategorie"] + reader["notype"].ToString() + " - " + reader["libelle"];
                        lblTarifsTypeCategorie.Location = new Point(5, i * 25);
                        gbxTarif.Controls.Add(lblTarifsTypeCategorie);

                        TextBox tbxTarifsTypeCategorie = new TextBox();
                        tbxTarifsTypeCategorie.Tag = reader["lettrecategorie"] + reader["notype"].ToString();
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

            string query = "SELECT NOM, nosecteur FROM secteur";
            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    secteurClass s = new secteurClass(reader.GetString("nom"), reader.GetInt32("noSecteur"));
                    lstbxTarif.Items.Add(s);
                }
            }
            maCnx.Close();
        }

        public void RemplirLiaison()
        {
            cmbbxTarifLiaison.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOLIAISON, NOPORT_DEPART, NOPORT_ARRIVEE, NOM " +
                           "FROM port p " +
                           "INNER JOIN liaison l ON p.NOPORT = l.NOPORT_DEPART";

            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    liaisonClass l = new liaisonClass(reader.GetInt32("NOLIAISON"), reader.GetInt32("NOPORT_DEPART"), reader.GetInt32("NOPORT_ARRIVEE"), reader.GetString("NOM"));
                    cmbbxTarifLiaison.Items.Add(l);
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
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbbxTarifPeriode.Items.Add(new Periode(reader.GetDateTime("datedebut"), reader.GetDateTime("datefin"), reader.GetInt32("noPeriode")));
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

        private void lstbxTarif_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerLiaisonsPourSecteur(lstbxTarif.SelectedItem.ToString());
        }

        private void ChargerLiaisonsPourSecteur(string noSecteur)
        {
            cmbbxTarifLiaison.Items.Clear();

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
                        cmbbxTarifLiaison.Items.Add(l);
                    }
                }
            }

            maCnx.Close();
        }

        private void btnAjouterTarif_Click(object sender, EventArgs e)
        {
            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            if (lstbxTarif.SelectedItem == null || cmbbxTarifLiaison.SelectedItem == null || cmbbxTarifPeriode.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un secteur, une liaison et une période.");
                return;
            }

            Periode periode = (Periode)cmbbxTarifPeriode.SelectedItem;
            liaisonClass liaison = (liaisonClass)cmbbxTarifLiaison.SelectedItem;

            bool tarifSaisi = false;
            List<TextBox> textBoxes = new List<TextBox>();

            foreach (Control control in gbxTarif.Controls)
            {
                if (control is TextBox tbxTarif)
                {
                    textBoxes.Add(tbxTarif);
                }
            }

            foreach (TextBox tbxTarif in textBoxes)
            {
                if (!string.IsNullOrEmpty(tbxTarif.Text))
                {
                    tarifSaisi = true; 
                    break;
                }
            }

            if (!tarifSaisi)
            {
                MessageBox.Show("Veuillez renseigner au moins un tarif.");
                return;
            }


            foreach (TextBox tbxTarif in textBoxes)
            {
                string lettreCategorie = tbxTarif.Tag.ToString().Substring(0, 1);
                string type = tbxTarif.Tag.ToString().Substring(1);
                double tarif;

                if (double.TryParse(tbxTarif.Text, out tarif))
                {
                    string query = "INSERT INTO tarifer (NOPERIODE, LETTRECATEGORIE, NOTYPE, NOLIAISON, TARIF) " +
                                   "VALUES (@periode, @lettrecategorie, @notype, @noliaison, @tarif)";

                    try
                    {
                        if (maCnx.State == ConnectionState.Closed)
                            maCnx.Open();

                        MySqlCommand cmd = new MySqlCommand(query, maCnx);
                        cmd.Parameters.AddWithValue("@periode", periode.GetNoPeriode());
                        cmd.Parameters.AddWithValue("@lettrecategorie", lettreCategorie);
                        cmd.Parameters.AddWithValue("@notype", type);
                        cmd.Parameters.AddWithValue("@noliaison", liaison.GetNoLiaison());
                        cmd.Parameters.AddWithValue("@tarif", tarif);
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erreur lors de l'ajout: " + ex.Message);
                    }
                    finally
                    {
                        maCnx.Close();
                    }
                }
            }
        }


    }
}
