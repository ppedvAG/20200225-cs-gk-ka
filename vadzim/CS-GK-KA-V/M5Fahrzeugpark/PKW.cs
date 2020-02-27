using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeugpark
{
    public class PKW : Fahrzeug, IRollbar
    {
        public int AnzahlTüren { get; set; }
        public int AnzahlRäder { get; set; }

        public PKW(string name, int maxG, int preis, int anzTüren) : base(name, maxG, preis)
        {
            this.AnzahlTüren = anzTüren;
            this.AnzahlRäder = 4;
        }
        public void Crash()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Du hast einen Baum übersehen.");
            // this.AnzahlRäder = this.AnzahlRäder - 1;
            // this.AnzahlRäder -= 2;
            
            this.AnzahlRäder--;
        }

    }
}
