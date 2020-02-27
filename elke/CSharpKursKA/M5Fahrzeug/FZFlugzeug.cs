using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeug
{
    public class FZFlugzeug : M5FahrzeugClass
    {
        public string Flugzeugtyp { get; set; }
        public FZFlugzeug(string Name, int MaxG, int Preis, int AktG, string Zustand, string flugzeugtyp) : base(Name, MaxG, Preis, AktG, Zustand)
        {
            Flugzeugtyp = flugzeugtyp;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $" Zusatz für Flugzeug: Flugzeugtyp = {Flugzeugtyp}";
        }
    }

}
