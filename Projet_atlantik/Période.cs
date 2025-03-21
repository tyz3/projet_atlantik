using System;

namespace Projet_atlantik
{
    internal class Periode
    {
        private DateTime dateDebut;
        private DateTime dateFin;
        private int noPeriode;

        public Periode(DateTime dateDebut, DateTime dateFin, int noPeriode)
        {
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.noPeriode = noPeriode;
        }

        public DateTime GetDateDebut()
        {
            return dateDebut;
        }

        public DateTime GetDateFin()
        {
            return dateFin;
        }

        public int GetNoPeriode()
        {
            return noPeriode;
        }

        public override string ToString()
        {
            return $"{dateDebut.ToShortDateString()} au {dateFin.ToShortDateString()}";
        }
    }
}
