using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLibrary
{
    public class MyClWInhNCtor : MyClassWProps
    {
        // neue Prop in der abeleiteten Klasse
        public string Wohnort { get; set; }

        // ctor generiert mit: Cursor auf die Klasse > Schrauenzieher > generate constructor
        public MyClWInhNCtor(string fn, string ln, string wohnort) : base(fn, ln)
        {
            Wohnort = wohnort;
        }

        public string BeschreibeMich()
        {
            return $@"Prop Firstname: {Firstname}
            Prop Lastname: {Lastname}
            Prop Wohnort: {Wohnort}";
        }
        

    }
}
