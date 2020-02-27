using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeugpark
{
    interface IRollbar
    {
        int AnzahlRäder { get; set; }
        void Crash();
    }
}
