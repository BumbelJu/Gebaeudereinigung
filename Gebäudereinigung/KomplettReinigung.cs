using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebäudereinigung
{
    class KomplettReinigung : Reinigung
    {
        private string Anzahl_Räume;
        private string Anzahl_Fenster; 



        public KomplettReinigung(string Anzahl_Räume, string Anzahl_Fenster, double Kosten,string Kunden,string Zeit,string Datum,string Mitarbeiter,string Putzmaterial ) : base(Kosten, Kunden, Zeit, Datum, Mitarbeiter, Putzmaterial)
        {
            this.Anzahl_Räume = Anzahl_Räume;
            this.Anzahl_Fenster = Anzahl_Fenster;
        }
        public string get_Anzahl_Räume()
        {
            return Anzahl_Räume;
        }
        public string get_Anzahl_Fenster()
        {
            return Anzahl_Fenster;
        }

    }
}
