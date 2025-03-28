using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
                MessageBox.Show("Veuillez entrer un nom pour le bateau.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxPassager.Text) || string.IsNullOrWhiteSpace(tbxVehiculeB.Text) || string.IsNullOrWhiteSpace(tbxVehiculeC.Text))
            {
                MessageBox.Show("Veuillez renseigner toutes les capacités.");
                return;
            }

            int idbateau = -1;
            try
            {
                if (maCnx.State == ConnectionState.Closed)
                    maCnx.Open();

                string query = "INSERT INTO bateau (NOM) VALUES (@nom); SELECT LAST_INSERT_ID();";
                using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
                {
                    cmd.Parameters.AddWithValue("@nom", tbxAjoutBateau.Text);
                    idbateau = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du bateau : {ex.Message}");
                return;
            }

            if (idbateau == -1)
            {
                MessageBox.Show("Erreur : L'ID du bateau n'a pas été récupéré.");
                return;
            }

            try
            {
                string query = "INSERT INTO contenir (LETTRECATEGORIE, NOBATEAU, CAPACITEMAX) VALUES (@lettrecategorie, @nobateau, @capacitemax)";
                using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
                {
                    cmd.Parameters.AddWithValue("@nobateau", idbateau);

                    cmd.Parameters.AddWithValue("@lettrecategorie", "A");
                    cmd.Parameters.AddWithValue("@capacitemax", Convert.ToInt32(tbxPassager.Text));
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nobateau", idbateau);
                    cmd.Parameters.AddWithValue("@lettrecategorie", "B");
                    cmd.Parameters.AddWithValue("@capacitemax", Convert.ToInt32(tbxVehiculeB.Text));
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nobateau", idbateau);
                    cmd.Parameters.AddWithValue("@lettrecategorie", "C");
                    cmd.Parameters.AddWithValue("@capacitemax", Convert.ToInt32(tbxVehiculeC.Text));
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

            MessageBox.Show("Bateau ajouté avec succès !");
        }
    }
}
