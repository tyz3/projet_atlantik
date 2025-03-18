using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_atlantik
{
    internal class liaisonClass
    {
        private int noPortDepart;
        private int noPortArrivee;
        private int noSecteur;
        private float distance;


        public liaisonClass(int noPortDepart, int noPortArrivee, int noSecteur, float distance)
        {
            this.noPortDepart = noPortDepart;
            this.noPortArrivee = noPortArrivee;
            this.noSecteur = noSecteur;
            this.distance = distance;


        }

        public int GetNoPortDepart()
        {
            return noPortDepart;
        }

        public int GetNoPortArrivee()
        {
            return noPortArrivee;
        }


        public int GetNoSecteur()
        {
            return noSecteur;
        }

        public float GetDistance()
        {
            return distance;
        }


        public override string ToString()
        {
            return noPortDepart.ToString() + noPortArrivee.ToString() + noSecteur.ToString() + distance.ToString();
        }
    }
}
