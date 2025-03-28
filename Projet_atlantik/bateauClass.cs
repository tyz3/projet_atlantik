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
        private string libelle;

        public bateauClass(string nom,int noBateau, string libelle)
        {
            this.nom = nom;
            this.noBateau = noBateau;
            this.libelle = libelle;

        }


        public string GetNomBateau()
        {
            return nom;
        }

        public int GetNoBateau()
        {
            return noBateau;
        }


        public string GetLibelle()
        {
            return libelle;
        }


        public override string ToString()
        {
            return nom + "ajouté !";
        }
    
    }
}
