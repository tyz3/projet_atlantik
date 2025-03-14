using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_atlantik
{
    internal class Secteur
    {
        public string nom;
        public int noSecteur;

        public Secteur(string nom, int noSecteur)
        {
            this.nom = nom;
            this.noSecteur = noSecteur;

            

        }



        public string GetNom()
        {
            return nom;
        }


        public int GetNoSecteur()
        {
            return noSecteur;

        }
    }
}
