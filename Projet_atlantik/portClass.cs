using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_atlantik
{
    internal class portClass
    {
        private string nom;
        private int noPort;

        public portClass(string nom, int noPort)
        {
            this.nom = nom;
            this.noPort = noPort;

        }



        public string GetNom()
        {
            return nom;
        }


        public int GetNoSecteur()
        {
            return noPort;

        }

        public override string ToString()
        {
            return nom;
        }
    }
}