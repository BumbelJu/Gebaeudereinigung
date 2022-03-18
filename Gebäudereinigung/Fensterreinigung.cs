using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebäudereinigung
{
    class Fensterreinigung : Reinigung
    {
        private int Anzahl_Fenster;

        public Fensterreinigung(int Anzahl_Fenster,double Kosten, string Kunden, DateTime Datum, string Mitarbeiter, string Putzmaterial) : base(Kosten,Kunden,Datum,Mitarbeiter,Putzmaterial)
        {
            this.Anzahl_Fenster = Anzahl_Fenster;
        }

        public int get_Anzahl_Fenster()
        {
            return Anzahl_Fenster;
        }


    }
}
