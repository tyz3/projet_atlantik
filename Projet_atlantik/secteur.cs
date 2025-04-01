using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

namespace ProjetAtlantik
{
    public partial class Secteur : Form
    {
        private MySqlConnection maCnx;

        public Secteur(MySqlConnection connection)
        {
            InitializeComponent();
            this.maCnx = connection;
        }

        private void btnSecteur_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxSecteur.Text))
            {
                try
                {
                    string query = "INSERT INTO secteur (NOM) VALUES (@nom);";
                    MySqlCommand cmd = new MySqlCommand(query, maCnx);
                    cmd.Parameters.AddWithValue("@nom", tbxSecteur.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(tbxSecteur.Text + " ajouté avec succès.", "Succès");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout: " + ex.Message);
                }
            }
        }
    }
}
