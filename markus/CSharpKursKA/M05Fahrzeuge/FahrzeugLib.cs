using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Fahrzeuge
{
    public class FahrzeugLib
    {
        // Datentypen und Konstanten
        public enum FZustand { Stehend, Fahrend };

        // Eigenschaften und Felder
        public string Name { get; private set; }
        public int MaxGeschwindigkeit { get; private set; }
        public int Preis { get; set; }
        private int aktuelleGeschwindigkeit;
        
       public int AktuelleGeschwindigkeit 
        {
            get { return aktuelleGeschwindigkeit; }
            private set
            {
                aktuelleGeschwindigkeit = value;
            }
        }
        public FZustand Zustand { get; set; }

        // Konstruktoren
        public FahrzeugLib(string strName, int MaxV, int iPreis)
        {
            this.Zustand = FZustand.Stehend;
            this.Name = strName;
            this.MaxGeschwindigkeit = MaxV;
            this.Preis = iPreis;
            this.AktuelleGeschwindigkeit = 0;
        }


        // Methoden
        public int Beschleunigen()
        {
            if (AktuelleGeschwindigkeit < MaxGeschwindigkeit && Zustand == FZustand.Fahrend)
            {
                AktuelleGeschwindigkeit += 1;
            }
            return AktuelleGeschwindigkeit;
        }

        public FZustand StarteMotor()
        {
            if (Zustand == FZustand.Stehend && AktuelleGeschwindigkeit == 0)
            {
                Zustand = FZustand.Fahrend;
            }
            return Zustand;
        }

        public FZustand StoppeMotor()
        {
            if (AktuelleGeschwindigkeit == 0)
            {
                Zustand = FZustand.Stehend;
            }
            return Zustand;
        }

        public virtual string BeschreibeMich()
        {
            return $"Auto: {Name}\nMax Geschw: {MaxGeschwindigkeit}\nPreis: {Preis} €\nAktuelle Geschw: {AktuelleGeschwindigkeit} km/h\nZustand: {Zustand}";
        }

    }
}
