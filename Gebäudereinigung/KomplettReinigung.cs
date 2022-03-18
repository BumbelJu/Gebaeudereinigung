using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebäudereinigung
{
    class KomplettReinigung : Reinigung
    {
        private int Anzahl_Räume;
        private int Anzahl_Fenster; 



        public KomplettReinigung(int Anzahl_Räume, int Anzahl_Fenster, double Kosten,string Kunden,DateTime Datum,string Mitarbeiter,string Putzmaterial ) : base(Kosten, Kunden,Datum, Mitarbeiter, Putzmaterial)
        {
            this.Anzahl_Räume = Anzahl_Räume;
            this.Anzahl_Fenster = Anzahl_Fenster;
        }
        public int get_Anzahl_Räume()
        {
            return Anzahl_Räume;
        }
        public int get_Anzahl_Fenster()
        {
            return Anzahl_Fenster;
        }

    }
}
