using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Fahrzeuge
{
    public class Fahrzeug
    {
        public string Name { get; set; }
        public int MaxGeschwindigkeit { get; set; }
        public int Preis { get; set; }
        public int AktuelleGeschwindigkeit { get; set; }
        public int Zustand { get; set; }
        public Fahrzeug(string strName, int MaxV, int iPreis, int AktuellV, int zustand)
        {
            Zustand = zustand;
            Name = strName;
            MaxGeschwindigkeit = MaxV;
            Preis = iPreis;
            AktuelleGeschwindigkeit = AktuellV;
        }
        public int Beschleunigen()
        {
            if (AktuelleGeschwindigkeit < MaxGeschwindigkeit)
            {
                AktuelleGeschwindigkeit += 1;
            }
            return AktuelleGeschwindigkeit;
        }

        public int StarteMotor()
        {
            Zustand = 1;
            return Zustand;
        }

        public int StoppeMotor()
        {
            Zustand = 0;
            return Zustand;
        }

    }
}
