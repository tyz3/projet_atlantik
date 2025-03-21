using System;

namespace Projet_atlantik
{
    internal class LiaisonTarif
    {
        private int noPortDepart;
        private int noPortArrivee;
        private string nomLiaison;

        public LiaisonTarif(int noPortDepart, int noPortArrivee, string nomLiaison)
        {
            this.noPortDepart = noPortDepart;
            this.noPortArrivee = noPortArrivee;
            this.nomLiaison = nomLiaison;
        }

        public int GetNoPortDepart()
        {
            return noPortDepart;
        }

        public int GetNoPortArrivee()
        {
            return noPortArrivee;
        }

        public string GetNomLiaison()
        {
            return nomLiaison;
        }

        public override string ToString()
        {
            return $"{noPortDepart} -> {noPortArrivee}";
        }
    }

    
    
}
