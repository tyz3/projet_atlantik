using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projet_atlantik
{
    public partial class ajouterBateau : Form
    {
        private MySqlConnection maCnx;

        public ajouterBateau(MySqlConnection connection)
        {
            InitializeComponent();
            this.maCnx = connection;
        }

        private void btnAjoutBateau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxAjoutBateau.Text))
            {
                MessageBox.Show("Veuillez entrer un nom pour le bateau.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbxAjoutBateau.Text.Length > 50)
            {
                MessageBox.Show("Le nom du bateau ne doit pas dépasser 50 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxPassager.Text) || string.IsNullOrWhiteSpace(tbxVehiculeB.Text) || string.IsNullOrWhiteSpace(tbxVehiculeC.Text))
            {
                MessageBox.Show("Veuillez renseigner toutes les capacités.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbxPassager.Text, out int capacitePassager) || capacitePassager <= 0)
            {
                MessageBox.Show("Veuillez entrer une valeur valide et positive pour la capacité des passagers.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbxVehiculeB.Text, out int capaciteVehiculeB) || capaciteVehiculeB < 0)
            {
                MessageBox.Show("Veuillez entrer une valeur valide et non négative pour la capacité des véhicules B.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbxVehiculeC.Text, out int capaciteVehiculeC) || capaciteVehiculeC < 0)
            {
                MessageBox.Show("Veuillez entrer une valeur valide et non négative pour la capacité des véhicules C.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idbateau = -1;
            try
            {
                if (maCnx.State == ConnectionState.Closed)
                    maCnx.Open();

                string query = "INSERT INTO bateau (NOM) VALUES (@nom); SELECT LAST_INSERT_ID();";
                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                cmd.Parameters.AddWithValue("@nom", tbxAjoutBateau.Text);
                idbateau = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du bateau : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (idbateau == -1)
            {
                MessageBox.Show("Erreur : L'ID du bateau n'a pas été récupéré.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = "INSERT INTO contenir (LETTRECATEGORIE, NOBATEAU, CAPACITEMAX) VALUES (@lettrecategorie, @nobateau, @capacitemax)";
                using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
                {
                    cmd.Parameters.AddWithValue("@nobateau", idbateau);

                    cmd.Parameters.AddWithValue("@lettrecategorie", "A");
                    cmd.Parameters.AddWithValue("@capacitemax", capacitePassager);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nobateau", idbateau);
                    cmd.Parameters.AddWithValue("@lettrecategorie", "B");
                    cmd.Parameters.AddWithValue("@capacitemax", capaciteVehiculeB);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nobateau", idbateau);
                    cmd.Parameters.AddWithValue("@lettrecategorie", "C");
                    cmd.Parameters.AddWithValue("@capacitemax", capaciteVehiculeC);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout des capacités du bateau : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                    maCnx.Close();
            }

            MessageBox.Show("Bateau ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
