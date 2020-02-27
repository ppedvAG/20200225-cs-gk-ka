using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeug
{
    public interface IBeladbar

        //in Interfaces sind keine Zugriffmodifiziere erlaubt (keine Modifzierer)
    {
        Fahrzeug Ladung { get; set; }
        void Belade(Fahrzeug fz);
        void Entlade(); 
    }
}
