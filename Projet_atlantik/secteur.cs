using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        private void tbxSecteur_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnSecteur_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxSecteur.Text))
            {
                try
                {
                    string query = "INSERT INTO secteur (NOM) VALUES (@nom);";
                    using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
                    {
                        cmd.Parameters.AddWithValue("@nom", tbxSecteur.Text);
                        cmd.ExecuteNonQuery();
                    }
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
