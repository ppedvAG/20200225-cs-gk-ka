using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Fahrzeuge
{
    public interface IBeladbar
    {
        // In Interfaces sind keine Zugriffsmidifizierer erlaubt. (Kein private etc.)
        FahrzeugLib Ladung { get; set; }
        void Beladen(FahrzeugLib fz);
        void Entlade();
    }
}
