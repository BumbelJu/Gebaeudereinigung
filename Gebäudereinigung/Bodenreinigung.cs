using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebäudereinigung
{


   public class Bodenreinigung : Reinigung
    {
        public Bodenreinigung(int Kosten , string Kunden , DateTime Zeit , DateTime Datum , string Mitarbeiter , string Putzmaterial ) : base(Kosten, Kunden, Zeit, Datum, Mitarbeiter, Putzmaterial);
        
       
        int Anzahl_Quadratmeter;
      
    }
}
