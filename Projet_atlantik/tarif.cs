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
    public partial class tarif : Form
    {

        private MySqlConnection maCnx;
        public tarif(MySqlConnection connection)
        {
            InitializeComponent();
            this.maCnx = connection;
            RemplirSecteurs();
            RemplirPeriode();
            RemplirLiaison();

        }

        public void RemplirSecteurs()
        {
            lstbxTarif.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOM FROM secteur";
            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lstbxTarif.Items.Add(reader["NOM"].ToString());
                }
            }
            maCnx.Close();
        }


        public void RemplirLiaison()
        {
            cmbbxTarifLiaison.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOPORT_DEPART, NOPORT_ARRIVEE, NOM " +
                       "FROM port p " +
                       "INNER JOIN liaison l ON p.NOPORT = l.NOPORT_DEPART";

            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                   

                    cmbbxTarifLiaison.Items.Add(new LiaisonTarif(reader.GetInt32("NOPORT_DEPART"),  reader.GetInt32("NOPORT_ARRIVEE"), reader.GetString("NOM")));
                }
            }
            maCnx.Close();
        }


        private void RemplirPeriode()
        {
            string query = "SELECT datedebut, datefin, noperiode FROM periode";

            if (maCnx.State == ConnectionState.Closed)
            {
                maCnx.Open();
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, maCnx);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                { 
                    
                   cmbbxTarifPeriode.Items.Add(new Periode(reader.GetDateTime("datedebut"), reader.GetDateTime("datefin"), reader.GetInt32("noPeriode")));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }



     

    }

    
}

