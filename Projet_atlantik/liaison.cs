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
            MySqlCommand cmd = new MySqlCommand(query, maCnx);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                secteurClass s = new secteurClass(reader.GetString("nom"), reader.GetInt32("noSecteur"));
                lstbxSecteursLiaison.Items.Add(s);
            }
            reader.Close();
            maCnx.Close();
        }

        public void RemplirDépart()
        {
            cmbbxDepartLiaison.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOM FROM port";
            MySqlCommand cmd = new MySqlCommand(query, maCnx);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbbxDepartLiaison.Items.Add(reader["NOM"].ToString());
            }
            reader.Close();
            maCnx.Close();
        }

        public void RemplirArrivee()
        {
            cmbbxArriveeLiaison.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOM FROM port";
            MySqlCommand cmd = new MySqlCommand(query, maCnx);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbbxArriveeLiaison.Items.Add(reader["NOM"].ToString());
            }
            reader.Close();
            maCnx.Close();
        }

        private void btnAjouterLiaison_Click(object sender, EventArgs e)
        {
            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();
            try
            {
                string query = "INSERT INTO liaison (NOPORT_DEPART, NOSECTEUR, NOPORT_ARRIVEE, DISTANCE) " +
                               "VALUES ((SELECT NOPORT FROM port WHERE NOM = @numPortDepart), " +
                               "(SELECT NOSECTEUR FROM secteur WHERE NOM = @numSecteur), " +
                               "(SELECT NOPORT FROM port WHERE NOM = @numPortArrivee), @Distance)";

                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                cmd.Parameters.AddWithValue("@numPortDepart", cmbbxDepartLiaison.Text);
                cmd.Parameters.AddWithValue("@numSecteur", lstbxSecteursLiaison.Text);
                cmd.Parameters.AddWithValue("@numPortArrivee", cmbbxArriveeLiaison.Text);
                cmd.Parameters.AddWithValue("@Distance", tbxDistanceLiaison.Text);
                cmd.ExecuteNonQuery();


                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de l'ajout: " + ex.Message);
            }
            MessageBox.Show("Liaison ajouté avec succès.");
            maCnx.Close();
        }
   
    }
}
