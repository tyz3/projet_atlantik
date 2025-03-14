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
    public partial class Form1 : Form
    {
        private MySqlConnection maCnx;

        public Form1(MySqlConnection connection)
        {
            InitializeComponent();
            this.maCnx = connection;
        }

        private void tbxSecteur_TextChanged(object sender, EventArgs e)
        {
            // Logique si nécessaire
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
                    MessageBox.Show("Erreur lors de l'ajout du secteur : " + ex.Message);
                }
            }
            
        }
    }

    
}
