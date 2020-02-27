using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2MiniRechner
{
    class MiniRechner
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.Write("Bitte geben Sie eine Integer-Zahl ein: ");
            int intZahl = int.Parse(Console.ReadLine());
            Console.Write("Bitte geben Sie eine Double-Zahl ein: ");
            double doubleZahl = double.Parse(Console.ReadLine());
            int intSumme = intZahl + (int)doubleZahl;
            double doubleSumme = intZahl + doubleZahl;
            Console.WriteLine($"{intZahl} + {doubleZahl} als Integer = {intSumme}");
            Console.WriteLine($"{intZahl} + {doubleZahl} als Double = {doubleSumme}");
            // Console.WriteLine($"{Math.Max(intZahl, (int)doubleZahl)} / {Math.Min(intZahl, (int)doubleZahl)} = {Math.Max((double)intZahl, doubleZahl) / Math.Min((double)intZahl, doubleZahl)}");
            Console.ReadKey();
        }
    }
}
