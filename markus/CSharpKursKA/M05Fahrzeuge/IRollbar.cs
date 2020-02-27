using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Fahrzeuge
{
    interface IRollbar
    {
        int AnzahlRäder { get; set; }
        void Crash();

    }
}
