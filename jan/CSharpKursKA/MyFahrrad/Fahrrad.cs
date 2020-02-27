using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFahrrad
{
    public class Fahrrad
    {
        public  enum ZFahrrad {  stehend, fahrend }
        public ZFahrrad Zustand { get; set; }
        public string Name { get; set; }
        public int Reifengröße { get; set; }
        public int Sattelhöhe { get; set; }
        public int Reifendruck { get; set; }

        public Fahrrad(string Nm, int Rg, int Sh, int Rd)
        {
            Zustand = ZFahrrad.stehend;
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

        public ZFahrrad Fahren()
        {
            if(Zustand == ZFahrrad.stehend)
            {
                Zustand = ZFahrrad.fahrend;
            }
            else
            {
                Zustand = ZFahrrad.stehend;
            }
            return Zustand;
        }
    }
}
