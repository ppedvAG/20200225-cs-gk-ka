using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DClass
{
    public class TestClassProperties
    {
        //fields
        //Optional bzw. unnötig, wenn wir die get und set Methoden nicht ändern
        //private string firstname;
        //private string lastname;

        //properties
        //Konvention: großgeschrieben
        //snippet prop tab tab
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Construktor
        //snippet ctor tab tab
        public TestClassProperties(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;

        }

    }
}
