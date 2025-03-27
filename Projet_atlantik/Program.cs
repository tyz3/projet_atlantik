using MySql.Data.MySqlClient;
using ProjetAtlantik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_atlantik
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MySqlConnection maCnx = null;
            string connectionString = "server=localhost;database=projet_atlantik;user=root;password=;";
            try
            {
                maCnx = new MySqlConnection(connectionString);
                maCnx.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /// Application.Run(new ProjetAtlantik.Secteur(maCnx));
             Application.Run(new ajouterBateau(maCnx));
        }
    }
}
