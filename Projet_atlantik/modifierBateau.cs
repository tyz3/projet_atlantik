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
    public partial class modifierBateau : Form
    {
        private MySqlConnection maCnx;

        public modifierBateau(MySqlConnection connection)
        {
            InitializeComponent();
            this.maCnx = connection;

        }

        private void modifierBateau_Load(object sender, EventArgs e)
        {
            RemplirNomBateau();
        }



        public void RemplirNomBateau()
        {

            cmbbxBateauNom.Items.Clear();

            if (maCnx.State != ConnectionState.Open)
                maCnx.Open();

            string query = "SELECT nom FROM bateau";
            MySqlCommand cmd = new MySqlCommand(query, maCnx);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    bateauClass b = new bateauClass(reader.GetString("nom"), reader.GetInt32("nobateau"));
                    cmbbxBateauNom.Items.Add(b);
                }
            }
            maCnx.Close();
        }




        private void btnModifBateau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbbxBateauNom.Text))
            {
                MessageBox.Show("Veuillez sélectionner un bateau.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxPassagerModif.Text) ||
                string.IsNullOrWhiteSpace(tbxVehiculeBModif.Text) ||
                string.IsNullOrWhiteSpace(tbxVehiculeCModif.Text))
            {
                MessageBox.Show("Veuillez renseigner toutes les capacités.");
                return;
            }

            int idbateau = -1;

            try
            {
                if (maCnx.State == ConnectionState.Closed)
                    maCnx.Open();

                string querySelect = "SELECT nobateau FROM bateau WHERE nom = @nom;";
                using (MySqlCommand cmd = new MySqlCommand(querySelect, maCnx))
                {
                    cmd.Parameters.AddWithValue("@nom", cmbbxBateauNom.Text);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        idbateau = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Bateau introuvable.");
                        return;
                    }
                }

                string queryUpdateBateau = "UPDATE bateau SET nom = @nom WHERE nobateau = @nobateau;";
                using (MySqlCommand cmd = new MySqlCommand(queryUpdateBateau, maCnx))
                {
                    cmd.Parameters.AddWithValue("@nom", cmbbxBateauNom.Text);
                    cmd.Parameters.AddWithValue("@nobateau", idbateau);
                    cmd.ExecuteNonQuery();
                }

                string queryUpdateContenir = "UPDATE contenir SET CAPACITEMAX = @capacitemax WHERE NOBATEAU = @nobateau AND LETTRECATEGORIE = @lettrecategorie;";
                using (MySqlCommand cmd = new MySqlCommand(queryUpdateContenir, maCnx))
                {
                    cmd.Parameters.AddWithValue("@nobateau", idbateau);

                    cmd.Parameters.AddWithValue("@lettrecategorie", "A");
                    cmd.Parameters.AddWithValue("@capacitemax", Convert.ToInt32(tbxPassagerModif.Text));
                    cmd.ExecuteNonQuery();

                    cmd.Parameters["@lettrecategorie"].Value = "B";
                    cmd.Parameters["@capacitemax"].Value = Convert.ToInt32(tbxVehiculeBModif.Text);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters["@lettrecategorie"].Value = "C";
                    cmd.Parameters["@capacitemax"].Value = Convert.ToInt32(tbxVehiculeCModif.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification du bateau : {ex.Message}");
                return;
            }
            finally
            {
                if (maCnx.State == ConnectionState.Open)
                    maCnx.Close();
            }

            MessageBox.Show("Bateau modifié avec succès !");
        }

    }
}



