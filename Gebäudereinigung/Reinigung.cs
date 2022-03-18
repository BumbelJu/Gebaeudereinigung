using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebäudereinigung
{
    abstract class Reinigung
    {

        private double Kosten;
        private string Kunden;
        private string Zeit;
        private string Datum;
        private string Mitarbeiter;
        private string Putzmaterial;

        public Reinigung(double Kosten,string Kunden,string Zeit,string Datum,string Mitarbeiter,string Putzmaterial)
        {
            this.Kosten = Kosten;
            this.Kunden = Kunden;
            this.Zeit = Zeit;
            this.Datum = Datum;
            this.Mitarbeiter = Mitarbeiter;
            this.Putzmaterial = Putzmaterial;
        }


        public double get_Kosten()
        {
            return Kosten; 
        }
        public string get_Kunden() 
        {
            return Kunden; 

        }
        public string get_Zeit()
        {
            return Zeit; 
        }
        public string get_Datum()
        {
            return Datum; 
        }
        public string get_Mitarbeiter() 
        {
            return Mitarbeiter; 
        }
        public string get_Putzmaterial()
        {
            return Putzmaterial;
        }

    }
}
