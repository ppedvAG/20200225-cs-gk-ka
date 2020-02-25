using System;

namespace DString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            #region M2

            Console.WriteLine("\n ### string literals ###");
            Console.WriteLine("Variante 1: doppelte Anführungszeichen");
            string Alter = "sechsundzwanzig";
            string Stadt = "Mannheim";


            Console.WriteLine("\n ### string possible values ###");
            Console.WriteLine("theoretisch könnte ein string 1,073,741,823 Zeichen lang sein");

            Console.WriteLine("\n ### string operators ###");
            Console.WriteLine("string = string + string"); //contatinate
            Console.WriteLine(Alter + Stadt is string); // string

            Console.WriteLine("string = string + int"); // casting implicit

            int Jahr = 2000;
            Console.WriteLine(Stadt+Jahr);
            Console.WriteLine("Stadt+Jahr is string: ",Stadt + Jahr is string); //  true



            Console.WriteLine("\n ### string literals ###");
            Console.WriteLine("Variante 2: $ \"some text {} \" (interpolated strings)");

            string Satz = $"Satz + Jahr is string: {Stadt + Jahr is string} und noch Text {true}";
            Console.WriteLine(Satz);


            Console.WriteLine("\n ### escape sequenzen ###");
            Console.WriteLine("vor dem Tabulator \t nach dem Tabulator");
            Console.WriteLine("C:\\Programme\\irgendwas.doc");


            Console.WriteLine("\n ### string literals  ###");
            Console.WriteLine("\n ### Variante 3: verbatim strings  ###");
            Satz = @"vor dem tab     nach dem tab
nach dem Zeilenbruch";

            Console.WriteLine(Satz); //übernimmt white spaces und ähnliches Kram



            Console.WriteLine("\n ### string literals  ###");
            Console.WriteLine("\n ### Variante 4: kombi verbatim & interpolation strings  ###");
            Satz = $@"vor dem tab     nach dem tab{Jahr}
nach dem Zeilenbruch";

            Console.WriteLine(Satz); //übernimmt white spaces und ähnliches Kram




            #endregion


        }
    }
}
