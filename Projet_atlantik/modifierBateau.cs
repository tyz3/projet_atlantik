using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projet_atlantik
{
    public partial class modifierBateau : Form
    {
        private MySqlConnection maCnx;

        public modifierBateau(MySqlConnection connection)
        {
            InitializeComponent();
            this.maCnx = connection;
        }

        private void modifierBateau_Load(object sender, EventArgs e)
        {
            RemplirNomBateau();
        }

        public void RemplirNomBateau()
        {
            cmbbxBateauNom.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT nom, nobateau FROM bateau";
            MySqlCommand cmd = new MySqlCommand(query, maCnx);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    bateauClass b = new bateauClass(reader.GetString("nom"), reader.GetInt32("nobateau"));
                    cmbbxBateauNom.Items.Add(b);
                }
            }
            maCnx.Close();
        }

        private void cmbbxBateauNom_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbbxBateauNom.SelectedItem is bateauClass selectedBateau)
            {
                ChargerDonneesBateau(selectedBateau.GetNoBateau());
            }
        }

        private void ChargerDonneesBateau(int idbateau)
        {
            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();
            string query = "SELECT CAPACITEMAX, LETTRECATEGORIE FROM contenir WHERE NOBATEAU = @nobateau";
            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            {
                cmd.Parameters.AddWithValue("@nobateau", idbateau);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                

                    while (reader.Read())
                    {
                        string categorie = reader.GetString("LETTRECATEGORIE");
                        int capaciteMax = reader.GetInt32("CAPACITEMAX");

                        foreach (Control ctrl in gbxModifierBateau.Controls)
                        {
                            if (ctrl is TextBox tbx)
                            {
                                if (tbx.Tag.ToString() == categorie)
                                {
                                    tbx.Text = capaciteMax.ToString();
                                }
                            }
                        }
                    }
                }
            }
            maCnx.Close();
        }





        private void btnModifBateau_Click(object sender, EventArgs e)
        {
            if (!(cmbbxBateauNom.SelectedItem is bateauClass selectedBateau))
            {
                MessageBox.Show("Veuillez sélectionner un bateau.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxPassagerModif.Text) ||
                string.IsNullOrWhiteSpace(tbxVehiculeBModif.Text) ||
                string.IsNullOrWhiteSpace(tbxVehiculeCModif.Text))
            {
                MessageBox.Show("Veuillez renseigner toutes les capacités.");
                return;
            }

            try
            {
                if (maCnx.State == ConnectionState.Closed)
                    maCnx.Open();

                string queryUpdateContenir = "UPDATE contenir SET CAPACITEMAX = @capacitemax WHERE NOBATEAU = @nobateau AND LETTRECATEGORIE = @lettrecategorie;";
                using (MySqlCommand cmd = new MySqlCommand(queryUpdateContenir, maCnx))
                {
                    cmd.Parameters.AddWithValue("@nobateau", selectedBateau.GetNoBateau());

                    cmd.Parameters.AddWithValue("@lettrecategorie", "A");
                    cmd.Parameters.AddWithValue("@capacitemax", Convert.ToInt32(tbxPassagerModif.Text));
                    cmd.ExecuteNonQuery();

                    cmd.Parameters["@lettrecategorie"].Value = "B";
                    cmd.Parameters["@capacitemax"].Value = Convert.ToInt32(tbxVehiculeBModif.Text);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters["@lettrecategorie"].Value = "C";
                    cmd.Parameters["@capacitemax"].Value = Convert.ToInt32(tbxVehiculeCModif.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification du bateau : {ex.Message}");
                return;
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                    maCnx.Close();
            }

            MessageBox.Show("Bateau modifié avec succès !");
        }
    }
}
