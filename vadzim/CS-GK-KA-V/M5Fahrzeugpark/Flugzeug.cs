using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeugpark
{
    public class Flugzeug : Fahrzeug, IRollbar
    {
        public int MaxFlughöhe { get; set; }
        public int AnzahlRäder { get; set; }

        public Flugzeug(string name, int maxG, int preis, int maxFH) : base(name, maxG, preis)
        {
            this.MaxFlughöhe = maxFH;
            this.AnzahlRäder = 10;
        }
        public void Crash()
        {
            Console.WriteLine("Da war ein Vogel im Weg");
            this.AnzahlRäder -= 2;
        }
    }
}
