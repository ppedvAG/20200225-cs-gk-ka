using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWForm
{

    //Mit Partial kann man eine KLasse über mehrere Dateien aufteilen 
    public partial class btnLeft : Form
    {
        public btnLeft()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLinks.Left--;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnLinks.Left++;

        }

        private void btnRechts_Click(object sender, EventArgs e)
        {
            btnRechts.Left--;
        }
    }
}
