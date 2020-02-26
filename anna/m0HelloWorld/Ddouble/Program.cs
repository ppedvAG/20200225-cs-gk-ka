using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ddouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie eome Double-Zahl ein: ");
            double Input = double.Parse(Console.ReadLine());
            Console.WriteLine(Input);

            string ichWillEinDoubleSein = "3.55";
            double dblFromStr = double.Parse(ichWillEinDoubleSein, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("dblFromstr: {0}", dblFromStr);

            Console.WriteLine("Ich sage Tschüss");

            Console.ReadKey();
       
        }
    }
}
