using System;

namespace Projet_atlantik
{
    internal class secteurClass
    {
        private int noSecteur;
        private string nom;

        public secteurClass(string nom, int noSecteur)
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
