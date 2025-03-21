using System;

namespace Projet_atlantik
{
    internal class Secteur
    {
        private int noSecteur;
        private string nom;

        public Secteur(int noSecteur, string nom)
        {
            this.noSecteur = noSecteur;
            this.nom = nom;
        }

        public int GetNoSecteur()
        {
            return noSecteur;
        }

        public string GetNom()
        {
            return nom;
        }

        public override string ToString()
        {
            return nom;
        }
    }
}
