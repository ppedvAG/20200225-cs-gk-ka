﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLibrary
{
    public class MyClassWProps
    {
        // fields 
        // manuelle Eingabe von Feldern beim Benutzen von props unnötig, wenn wir die get und set Methoden nicht ändern
        //private string firstname;
        //private string lastname;
        // props //Konvention: props Großgeschrieben
        //snippet prop
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        //constructor
        //snippet ctor
        public MyClassWProps(string fn, string ln)
        {
            Firstname = fn;
            Lastname = ln;
        }
    }
}
