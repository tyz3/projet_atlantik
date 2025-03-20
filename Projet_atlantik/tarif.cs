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
            cmbbxTarif.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOM" +
                " FROM port p " +
                " INNER JOIN liaison l ON p.NOPORT = l.NOPORT ";
            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmbbxTarif.Items.Add(reader["NOM"].ToString());
                }
            }
            maCnx.Close();
        }

        private void ChargerPeriode()
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
                {
                    while (reader.Read())
                    {
                        periode pe = new periode(reader.GetDateTime("datedebut"), reader.GetDateTime("datefin"), reader.GetInt32("noPeriode"));
                        cmbbxPeriode.Items.Add(pe);
                    }
                }
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
