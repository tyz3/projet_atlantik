using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace Projet_atlantik
{
    public partial class liaison : Form
    {
        private MySqlConnection maCnx;

        public liaison(MySqlConnection connection)
        {
            InitializeComponent();
            this.maCnx = connection;

            RemplirSecteurs();
            RemplirDépart();
            RemplirArrivee();
        }

        public void RemplirSecteurs()
        {
            lstbxSecteursLiaison.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOM, nosecteur FROM secteur";
            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    secteurClass s = new secteurClass(reader.GetString("nom"), reader.GetInt32("noSecteur"));
                    lstbxSecteursLiaison.Items.Add(s);
                }
            }
            maCnx.Close();
        }

        public void RemplirDépart()
        {
            cmbbxDepartLiaison.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOM FROM port";
            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmbbxDepartLiaison.Items.Add(reader["NOM"].ToString());
                }
            }
            maCnx.Close();
        }

        public void RemplirArrivee()
        {
            cmbbxArriveeLiaison.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOM FROM port";
            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmbbxArriveeLiaison.Items.Add(reader["NOM"].ToString());
                }
            }
            maCnx.Close();
        }

        private void btnAjouterLiaison_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbbxDepartLiaison.Text) ||
                string.IsNullOrWhiteSpace(cmbbxArriveeLiaison.Text) ||
                lstbxSecteursLiaison.SelectedItem == null ||
                string.IsNullOrWhiteSpace(tbxDistanceLiaison.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(tbxDistanceLiaison.Text, out double distance) || distance <= 0)
            {
                MessageBox.Show("Veuillez entrer une distance valide et positive.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbbxDepartLiaison.Text == cmbbxArriveeLiaison.Text)
            {
                MessageBox.Show("Le port de départ et le port d'arrivée ne peuvent pas être identiques.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            try
            {
                string query = "INSERT INTO liaison (NOPORT_DEPART, NOSECTEUR, NOPORT_ARRIVEE, DISTANCE) " +
                               "VALUES ((SELECT NOPORT FROM port WHERE NOM = @numPortDepart), " +
                               "(SELECT NOSECTEUR FROM secteur WHERE NOM = @numSecteur), " +
                               "(SELECT NOPORT FROM port WHERE NOM = @numPortArrivee), @Distance)";

                using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
                {
                    cmd.Parameters.AddWithValue("@numPortDepart", cmbbxDepartLiaison.Text);
                    cmd.Parameters.AddWithValue("@numSecteur", ((secteurClass)lstbxSecteursLiaison.SelectedItem).GetNoSecteur());
                    cmd.Parameters.AddWithValue("@numPortArrivee", cmbbxArriveeLiaison.Text);
                    cmd.Parameters.AddWithValue("@Distance", distance);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Liaison ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de l'ajout: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                maCnx.Close();
            }
        }
    }
}
