using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DClass
{
    public class MyClassWInhNCtor : MyClassWProps
    {
        // Neue Prop in der abgeleiteten Klasse
        public string Wohnort { get; set; }

        // ctor generiert mit 'Werkzeug' -> Generate Constructor 
        public MyClassWInhNCtor(string fn, string ln, string wohnort) : base(fn, ln)
        {
            Wohnort = wohnort;
        }

        public string BeschreibeMich()
        {
            return $"\nFirstname: {Firstname}\nLastname: {Lastname}\nWohnort: {Wohnort}";
        }

    }
}
