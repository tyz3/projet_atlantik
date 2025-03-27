using MySql.Data.MySqlClient;
using Projet_atlantik;
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
            if (!string.IsNullOrWhiteSpace(tbxAjoutBateau.Text))
            {
                try
                {
                    string query = "INSERT INTO bateau nom, lettrecategorie " +
                        " VALUES (@nom, (SELECT nobateau FROM bateau WHERE nobateau = @nobateau));";
                    using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
                    {
                        cmd.Parameters.AddWithValue("@nom", tbxAjoutBateau.Text);
                        cmd.Parameters.AddWithValue("@passager", tbxPassager.Text);
                        cmd.Parameters.AddWithValue("@vehiB", tbxVehiculeB.Text);
                        cmd.Parameters.AddWithValue("@vehiC", tbxVehiculeC.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Bateau ajouté avec succès !");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout: " + ex.Message);
                }
            }
        }
    }
}


