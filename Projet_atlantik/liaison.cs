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

            lstbxSecteursLiaison.Items.Clear();
            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT NOM FROM secteur";
            using (MySqlCommand cmd = new MySqlCommand(query, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lstbxSecteursLiaison.Items.Add(reader["NOM"].ToString());
                }
            }
        }

        private void lstbxSecteursLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbxSecteursLiaison.Items.Clear();
            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string querySecteur = "SELECT NOM FROM secteur";
            using (MySqlCommand cmd = new MySqlCommand(querySecteur, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lstbxSecteursLiaison.Items.Add(reader["NOM"].ToString());
                }
            }
        }

        private void cmbbxDepartLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {
     
            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string queryPort = "SELECT NOM FROM port";
            using (MySqlCommand cmd = new MySqlCommand(queryPort, maCnx))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmbbxDepartLiaison.Items.Add(reader["NOM"].ToString());
                }
            }
        }


    }
}
