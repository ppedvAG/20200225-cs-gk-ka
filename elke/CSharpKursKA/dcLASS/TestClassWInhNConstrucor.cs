using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLibrary
{
    //Classe mit Inhertiance and Constructor        
    public class TestClassWInhNConstrucor : TestClassProperties
    //TestClassWInhNConstrucor war rot unterstrichen mit Cursor rein (keine doppelclick)-> auf den Schraubenschlüssel -> Gereate Constructor für die TestClass
    {
        public string Wohnort { get; set; }

        //Wird durch die Aktion oben autom. erstellt
        public TestClassWInhNConstrucor(string fn, string ln, string wohnort) : base(fn, ln)
        {
            Wohnort = wohnort;
        }

        public string BeschreibeMich()
        {
            return $@"
Prop Firstname: {FirstName} 
Prop Lastname: {LastName} 
Prop Wohnort: {Wohnort} ";
        }
        

    }
}
