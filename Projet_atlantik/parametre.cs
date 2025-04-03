using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_atlantik
{
    internal class parametres
    {
        private int sitepb;
        private int rangpb;
        private int idSite;
        private int cleHMAC;
        private bool production;
        private string melSite;


        public  parametres(int sitepb, int rangpb, int idSite, int cleHMAC, bool production, string melSite)
        {
            this.sitepb = sitepb;
            this.rangpb = rangpb;
            this.idSite = idSite;
            this.cleHMAC = cleHMAC;
            this.production = production;
            this.melSite = melSite;
        }


         public int GetSitepb()
        {
            return sitepb;
        }

        public int GetRangpb()
        {
            return rangpb;
        }

        public int GetIdSite()
        {
            return idSite;
        }

        public int GetCleHMAC()
        {
            return cleHMAC;
        }

        public bool GetProduction()
        {
            return production;
        }

        public string GetMelSite()
        {
            return melSite;
        }


    }
}
