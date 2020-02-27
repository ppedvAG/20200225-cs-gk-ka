using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindowsForm
{
    //mit Partial kann man eine KLasse über mehrere Dateine aufteilen
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            KlickMe1.Left--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KlickMe2.Left++;

        }
    }
}
