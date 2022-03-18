using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebäudereinigung
{


    class Bodenreinigung : Reinigung
    {
        double kosten;
        string kunden;
        string zeit;

        Bodenreinigung(double Kosten, string Kunden, string Zeit, string Datum, string Mitarbeiter, string Putzmaterial);
       
        int Anzahl_Quadratmeter;
      
    }
}
