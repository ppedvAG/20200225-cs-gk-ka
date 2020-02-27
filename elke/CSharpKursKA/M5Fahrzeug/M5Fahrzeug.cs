using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeug
{
    public class M5FahrzeugClass
    {
        //  -Name
        public string sName { get; set; }

        //   -Maximal-Geschwindigkeit
        public int iMaxGeschwindigkeit { get; set; }


        //  -Preis
        public int iPreis { get; set; }


        //   -Aktuelle-Geschwindigkeit
        public int iaktGeschwindigkeit { get; set; }


        //   -Zustand(Stehend/Fahrend)
        public string sZustand { get; set; }

        public M5FahrzeugClass(string Name, int MaxG, int Preis, int AktG, string Zustand)
        {
            sName = Name;
            iMaxGeschwindigkeit = MaxG;
            iPreis = Preis;
            iaktGeschwindigkeit = AktG;
            sZustand = Zustand;
        }

        public string StarteMotor ()
        {
            sZustand = "fahrend";
            return sZustand;
        }

        public string StoppeMotor()
        {
            sZustand = "stehend";
            return sZustand;
        }

        public int Beschleunigung(int kmh)
        {
            int newGeschw = iaktGeschwindigkeit + kmh;
            if (newGeschw > iMaxGeschwindigkeit)
            {
                iaktGeschwindigkeit = iMaxGeschwindigkeit;
            }
            else
            {
                iaktGeschwindigkeit = newGeschw;
            }
            return iaktGeschwindigkeit;
        }

    }
}
