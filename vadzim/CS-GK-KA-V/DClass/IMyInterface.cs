using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLibrary
{
    // Konvention: Interfacesnamen fangen mit I an
    interface IMyInterface
    {
        int FancyLevel { get; set; }
        int ChangeFancyLevel(int fl, int FancyLevel);
        string SayHalloInYourWay(); 
    }
}
