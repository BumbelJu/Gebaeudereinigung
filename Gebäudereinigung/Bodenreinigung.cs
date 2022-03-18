using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebäudereinigung
{


    class Bodenreinigung : Reinigung
    {
        private int Anzahl_Quadratmeter;

        public Bodenreinigung(int Anzahl_Quadratmeter,double Kosten, string Kunden, DateTime Datum, string Mitarbeiter, string Putzmaterial) : base(Kosten, Kunden, Datum, Mitarbeiter, Putzmaterial)
        {
            this.Anzahl_Quadratmeter = Anzahl_Quadratmeter; 
        }
        
       public int get_Anzahl_Quadratmeter()
        {
            return Anzahl_Quadratmeter;
        }
     
      
    } 
}
