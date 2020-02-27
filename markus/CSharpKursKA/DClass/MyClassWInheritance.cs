using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DClass
{
    // Die Methode Random.Next() wollen wir erben und anpassen
    class MyClassWInheritance : Random
    { 
        public int NextInclusive(int min, int max)
        {
            return base.Next(min, max + 1);
        }
    }
}
