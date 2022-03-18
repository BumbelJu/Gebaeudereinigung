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
        public List<Bodenreinigung> AufträgeB = new List<Bodenreinigung>();
        public Bodenreinigung(int Anzahl_Quadratmeter,double Kosten, string Kunden, DateTime Datum, string Mitarbeiter, string Putzmaterial) : base(Kosten, Kunden, Datum, Mitarbeiter, Putzmaterial)
        {
            this.Anzahl_Quadratmeter = Anzahl_Quadratmeter; 
        }
        
       public int get_Anzahl_Quadratmeter()
        {
            return Anzahl_Quadratmeter;
        }
     
         public void AuftragerstellenB(int anzahl_quadramtmeter , double kosten , string kunden , DateTime datum , string mitarbeiter , string putzmaterial)
        {
            AufträgeB.Add(new Bodenreinigung( anzahl_quadramtmeter, kosten, kunden, datum, mitarbeiter, putzmaterial));
        }

     
      
    } 
}
