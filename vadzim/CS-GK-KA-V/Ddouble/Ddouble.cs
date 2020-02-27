using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ddouble
{
    class Ddouble
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie eine Double-Zahl ein: ");
            double Input = double.Parse(Console.ReadLine()); // Eingabe mit Punkt - Punkt fliegt raus
            // Eingabe mit Komma funktioniert.
            Console.WriteLine(Input);

            string ichWillEinDoubleSein = "3.55"; 
            double dblFromStr = double.Parse(ichWillEinDoubleSein, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("dblFromStr: {0}", dblFromStr);

            Console.WriteLine("Ich sage Tschüss!");

            Console.ReadKey();
        }
    }
}
