using System;

namespace Projet_atlantik
{
    internal class LiaisonTarif
    {
        private int noPortDepart;
        private int noPortArrivee;
        private string numLiaison;

        public LiaisonTarif(int noPortDepart, int noPortArrivee, string numLiaison)
        {
            this.noPortDepart = noPortDepart;
            this.noPortArrivee = noPortArrivee;
            this.numLiaison = numLiaison;
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
            return numLiaison;
        }

        public override string ToString()
        {
            return $"{noPortDepart} -> {noPortArrivee}";
        }

        public void liaisonTrajet()
        {

        }
    }

    
    
}
