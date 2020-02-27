using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFahrrad
{
    public class Fahrrad
    {
        public string Name { get; set; }
        public int Reifengröße { get; set; }
        public int Sattelhöhe { get; set; }
        public int Reifendruck { get; set; }

        public Fahrrad(string Nm, int Rg, int Sh, int Rd)
        {
            Name = Nm;
            Reifengröße = Rg;
            Sattelhöhe = Sh;
            Reifendruck = Rd;
        }

        public int Sattelverstellen(int wert)
        {
            Sattelhöhe = Sattelhöhe + wert;
            return Sattelhöhe;
        }
    }
}
