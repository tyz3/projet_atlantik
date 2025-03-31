using MySql.Data.MySqlClient;
using System;

namespace Projet_atlantik
{
    internal class liaisonClass
    {
        private int noPortDepart;
        private int noPortArrivee;
        private int noLiaison;
        private string nom;

        public liaisonClass(int noLiaison, int noPortDepart, int noPortArrivee, string nom)
        {
            this.noLiaison = noLiaison;
            this.noPortDepart = noPortDepart;
            this.noPortArrivee = noPortArrivee;
            this.nom = nom;
        }

        private static string connectionString = "server=localhost;database=projet_atlantik;user=root;password=;";

        public int GetNoLiaison() => noLiaison;

        private string GetNomPort(int noPort)
        {
            string portName = "";
            string query = "SELECT NOM FROM port WHERE NOPORT = @noport";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@noport", noPort);

                try
                {
                    connection.Open();
                    object nomliaison = command.ExecuteScalar();
                    if (nomliaison != null)
                    {
                        portName = nomliaison.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erreur lors de la récupération du nom du port : {ex.Message}");
                }
            }

            return portName;
        }

        public int GetNoPortDepart()
        {
            return noPortDepart;
        }
        public int GetNoPortArrivee()
        {

           return noPortArrivee;
        }
        public string GetNom()
        {
          return  nom;
        }

        public override string ToString()
        {
            return $"{GetNomPort(noPortDepart)} -> {GetNomPort(noPortArrivee)}";
        }
    }
}
