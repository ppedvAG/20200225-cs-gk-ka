// Mittels der USING-Anweisung kann ein vereinfacher Zugriff 
//auf Programm-Externe KLassen oder Namensräume ermöglicht werden

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Namespase - Umgebung für unser Program. 
namespace m0HelloWorld
{
    // Die Program-Klasse ist Einstiegspunkt für unsere Anwendung 
    class Program
    {
        //Die MAIN-methode ist Bootstrap-Punkt für jedes C#-Programm
        //Methoden in C# werden großgeschrieben
        static void Main(string[] args)
        {
            // Es gibt auch  Klassen, fie für den Programmiere schon vorprogrammiert sind. 
            // Man verwendet sie als Werkzeuge. 
            //Console ist eine vorprogrammierte Klasse 
            Console.WriteLine("Hello World!"); 

            // Variablen sind Eigenschaften der Klasse
            string varZumKurzenAufbewahrenVonText = "Buchstabensalat";
            Console.WriteLine(varZumKurzenAufbewahrenVonText);

            // Ein Befehl, damit die Anwendung kurz wartet
            Console.ReadKey();
        }
    }
}