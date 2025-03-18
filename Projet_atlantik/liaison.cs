using MySql.Data.MySqlClient;
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
    public partial class liaison : Form
    {
        private MySqlConnection maCnx;

        public liaison(MySqlConnection connection)
        {
            InitializeComponent();
            this.maCnx = connection;

            List<string> secteurs = RemplirSecteurs();
            lstbxSecteursLiaison.Items.AddRange(secteurs.ToArray());

            List<string> departs = RemplirDépart();
            cmbbxDepartLiaison.Items.AddRange(departs.ToArray());


            List<string> arrivee = RemplirArrivee();
            cmbbxArriveeLiaison.Items.AddRange(arrivee.ToArray());


        }


        private void liaison_Load(object sender, EventArgs e)
        {

        }

        public List<string> RemplirSecteurs()
        {
            List<string> secteurs = new List<string>();
            lstbxSecteursLiaison.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOM FROM secteur";
            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nom = reader["NOM"].ToString();
                    secteurs.Add(nom);
                }
            }
            return secteurs;
        }


        
            public List<string> RemplirDépart()
            {
                List<string> departs = new List<string>();
                cmbbxDepartLiaison.Items.Clear();

                if (maCnx.State != ConnectionState.Open)
                    maCnx.Open();

                string query = "SELECT NOM FROM port"; 
                using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nom = reader["NOM"].ToString();
                        departs.Add(nom);
                    }
                }
                return departs;
            }

        public List<string> RemplirArrivee()
        {
            List<string> arrivee = new List<string>();
            cmbbxArriveeLiaison.Items.Clear(); 

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOM FROM port";
            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nom = reader["NOM"].ToString();
                    arrivee.Add(nom);
                }
            }
            return arrivee;
        }


        private void lstbxSecteursLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void cmbbxDepartLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbbxArriveeLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouterLiaison_Click(object sender, EventArgs e)
        {
            
                try
                {

                    string query = "INSERT INTO liaison (NOPORT_DEPART, NOSECTEUR, NOPORT_ARRIVEE, DISTANCE ) " +
                    "VALUES (@numPortDepart, @numSecteur, @numPortArrivee, @Distance);";
                    using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
                    {
                        
                        cmd.Parameters.AddWithValue("@numPortDepart", cmbbxDepartLiaison.Text);
                        cmd.Parameters.AddWithValue("@numSecteur", lstbxSecteursLiaison.Text);
                        cmd.Parameters.AddWithValue("@numPortArrivee", cmbbxArriveeLiaison.Text);
                        cmd.Parameters.AddWithValue("@Distance", tbxDistanceLiaison.Text);
                        cmd.ExecuteNonQuery();
                    }
                   
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout: " + ex.Message);
                }
            

        }

        
    }
   
}

