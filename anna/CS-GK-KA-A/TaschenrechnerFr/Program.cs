using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaschenrechnerFr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie eine Zahl ein: ");
            string a_1 = Console.ReadLine();


            Console.Write("Geben Sie eine Zahl ein: ");
            string a_2 = Console.ReadLine();

            int a_3;
            int a_4;

            a_3 = int.Parse(a_1) + int.Parse(a_2);

            Console.WriteLine($"{a_3}");

            a_4 = int.Parse(a_1) * int.Parse(a_2);

            Console.WriteLine($"{a_4}");
        }
    }
}
