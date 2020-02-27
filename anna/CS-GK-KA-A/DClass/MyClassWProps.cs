using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLibrary
{
    public class MyClassWProps
    {
        //fields - manuelle Eingabe von Feldern beim Benutzen von Props  unnötig, wenn wir die get und set Methoden nich 
        private string firstname;
        private string lastname;
        //props grossgeschrieben prop ta tab 
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        //constructor 
        //snippet: ctor tab tab 
        public MyClassWProps(string fn, string ln)
        {
            Firstname = fn;
            Lastname = ln;
        }
    }
}
