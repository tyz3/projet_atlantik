using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

namespace Projet_atlantik
{
    public partial class port : Form
    {
        private MySqlConnection maCnx;
        public port(MySqlConnection connection)
        {
            InitializeComponent();
            this.maCnx = connection;
        }

        private void port_Load(object sender, EventArgs e)
        {
        }

        private void tbxPort_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAjoutPort_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxPort.Text))
            {
                try
                {
                    string query = "INSERT INTO port (NOM) VALUES (@nom);";
                    MySqlCommand cmd = new MySqlCommand(query, maCnx);
                    cmd.Parameters.AddWithValue("@nom", tbxPort.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(tbxPort.Text + " ajouté avec succès.");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout: " + ex.Message);
                }
            }
        }
    }
}