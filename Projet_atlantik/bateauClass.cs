using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_atlantik
{
    internal class bateauClass
    {
        private string nom;
        private int noBateau;


        public bateauClass(string nom,int noBateau)
        {
            this.nom = nom;
            this.noBateau = noBateau;


        }


        public string GetNomBateau()
        {
            return nom;
        }

        public int GetNoBateau()
        {
            return noBateau;
        }


        


        public override string ToString()
        {
            return nom;
        }
    
    }
}
