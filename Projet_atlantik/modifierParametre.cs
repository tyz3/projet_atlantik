using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projet_atlantik
{
    public partial class modifierParametre : Form
    {
        private MySqlConnection maCnx;

        public modifierParametre(MySqlConnection connection)
        {
            InitializeComponent();
            this.maCnx = connection;
            ChargerParametres();
        }

        private void ChargerParametres()
        {

            try
            {




                if (maCnx.State != ConnectionState.Open)
                {
                    maCnx.Open();
                }


                string query = "SELECT SITE_PB, RANG_PB, IDENTIFIANT_PB, CLEHMAC_PB, ENPRODUCTION, MELSITE FROM parametres LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    tbxsiteParametre.Text = reader["SITE_PB"].ToString();
                    tbxRangParametre.Text = reader["RANG_PB"].ToString();
                    tbxIdentifiantParametre.Text = reader["IDENTIFIANT_PB"].ToString();
                    tbxHMACParametre.Text = reader["CLEHMAC_PB"].ToString();
                    ckbxParametreProduction.Checked = Convert.ToBoolean(reader["ENPRODUCTION"]);
                    tbxMelSiteParametre.Text = reader["MELSITE"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des paramètres : {ex.Message}\n{ex.StackTrace}");
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                    maCnx.Close();
            }
        }

        private void btnParametre_Click(object sender, EventArgs e)
        {
            if (maCnx.State != ConnectionState.Open)
            {
                maCnx.Open();
            }

            if (string.IsNullOrWhiteSpace(tbxsiteParametre.Text) ||
                string.IsNullOrWhiteSpace(tbxRangParametre.Text) ||
                string.IsNullOrWhiteSpace(tbxIdentifiantParametre.Text) ||
                string.IsNullOrWhiteSpace(tbxHMACParametre.Text) ||
                string.IsNullOrWhiteSpace(tbxMelSiteParametre.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            try
            {
                string query = "UPDATE parametres SET SITE_PB = @sitepb, RANG_PB = @rangpb, IDENTIFIANT_PB = @identifiantpb, " +
                               "CLEHMAC_PB = @clehmac, ENPRODUCTION = @enproduction, MELSITE = @melsite";

                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                cmd.Parameters.AddWithValue("@sitepb", tbxsiteParametre.Text);
                cmd.Parameters.AddWithValue("@rangpb", tbxRangParametre.Text);
                cmd.Parameters.AddWithValue("@identifiantpb", tbxIdentifiantParametre.Text);
                cmd.Parameters.AddWithValue("@clehmac", tbxHMACParametre.Text);
                cmd.Parameters.AddWithValue("@enproduction", ckbxParametreProduction.Checked);
                cmd.Parameters.AddWithValue("@melsite", tbxMelSiteParametre.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Paramètres modifiés avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification des paramètres : {ex.Message}\n{ex.StackTrace}");
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                    maCnx.Close();
            }
        }
    }
}
