using System;

namespace Projet_atlantik
{
    internal class LiaisonTarif
    {
        private int noPortDepart;
        private int noPortArrivee;
        private int noLiaison;
        private string nom;

        public LiaisonTarif(int noLiaison, int noPortDepart, int noPortArrivee, string nom)
        {
            this.noLiaison = noLiaison;
            this.noPortDepart = noPortDepart;
            this.noPortArrivee = noPortArrivee;
            this.nom = nom;
        }
        public int GetNoLiaison()
        {
            return noLiaison;
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
            return nom;
        }
        public override string ToString()
        {
            return $"{noPortDepart} -> {noPortArrivee}";
        }
    }

    
    
}
