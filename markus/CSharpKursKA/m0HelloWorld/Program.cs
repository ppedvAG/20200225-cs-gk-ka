// Mittels der Using Anweisungen kann ein vereinfachter Zugriff auf 
// Programm-Externe Klassen oder Namensräume ermöglicht werden
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace: Umgebung für unser Program.
namespace m0HelloWorld
{
    // Die Program-Klasse ist Einstiegspunkt für unsere Anwendung.
    class Program
    {
        // Die Main-Methode ist BOOTSTRAP-Punkt für jedes C#-Programm.
        // Methoden in C# werden großgeschrieben.
        static void Main(string[] args)
        {
            // Es gibt auch Klassen, die für den Programmierer schon vorprogrammiert sind.
            // Man verwendet sie als Werkzeuge.
            // Console ist eine vorprogrammierte Klasse.
            Console.WriteLine("Hello World!");

            // Variablen
            string varZumKurzenAufbewahrenVonText = "Buchstabensalat";
            Console.WriteLine(varZumKurzenAufbewahrenVonText);

            // Ein Befehl, damit die Anwendung kurz wartet.
            Console.ReadKey();
        }
    }
}
