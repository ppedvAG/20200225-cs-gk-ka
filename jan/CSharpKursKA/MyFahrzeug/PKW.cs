using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFahrzeug
{
    public class PKW : MyFahrzeugClass, IRollbar
    {
        public int AnzahlTüren { get; set; }

        public int AnzahlRäder { get; set; }

        public PKW(string Nm, int MG, int Pr, int AG, string Zs, int anzahlTüren) : base(Nm, MG, Pr, AG, Zs)
        {
            this.AnzahlTüren = anzahlTüren;
            this.AnzahlRäder = 4;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $" und der PKW hat {AnzahlTüren} Türen.";
        }

        public void Crash()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Du hast einen Baum übersehen.");
            // this.AnzahlRäder = this.AnzahlRäder - 1;
            this.AnzahlRäder--;
        }
    }
}
