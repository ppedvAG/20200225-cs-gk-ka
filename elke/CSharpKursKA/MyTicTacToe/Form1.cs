using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 0;

        void checkWinner(string xoro)
        {
            if (button1.Text== xoro && button2.Text == xoro && button3.Text == xoro)
            {
                MessageBox.Show(xoro + " hat gewonnen!", "S U P E R");
            }
            else if (button4.Text == xoro && button5.Text == xoro && button6.Text == xoro)
            {
                MessageBox.Show(xoro + " hat gewonnen!", "S U P E R");
            }
            else if (button7.Text == xoro && button8.Text == xoro && button9.Text == xoro)
            {
                MessageBox.Show(xoro + " hat gewonnen!", "S U P E R");
            }
            else if (button1.Text == xoro && button4.Text == xoro && button7.Text == xoro)
            {
                MessageBox.Show(xoro + " hat gewonnen!", "S U P E R");
            }
            else if (button2.Text == xoro && button5.Text == xoro && button8.Text == xoro)
            {
                MessageBox.Show(xoro + " hat gewonnen!", "S U P E R");
            }
            else if (button3.Text == xoro && button6.Text == xoro && button9.Text == xoro)
            {
                MessageBox.Show(xoro + " hat gewonnen!", "S U P E R");
            }
            else if (button1.Text == xoro && button5.Text == xoro && button9.Text == xoro)
            {
                MessageBox.Show(xoro + " hat gewonnen!", "S U P E R");
            }
            else if (button3.Text == xoro && button5.Text == xoro && button7.Text == xoro)
            {
                MessageBox.Show(xoro + " hat gewonnen!", "S U P E R");
            }
            else if (counter == 8)
            {
                MessageBox.Show("Das Spiel ist unentschieden.","SPIELENDE");
                //Beendung der Anwendung forcieren
                Environment.Exit(0);
            }
        }


        void stepFunction(object senderopbj)
        {
            string buttontext = ((Button)senderopbj).Text;
            if (buttontext =="")
            {
                if (counter % 2 == 0) //Counter ist gerade
                {
                    ((Button)senderopbj).Text = "0";
                    checkWinner("0");
                }
                else// ungerade
                {
                    ((Button)senderopbj).Text = "X";
                    checkWinner("X");
                }
                counter++;
            }
            else
            {
                MessageBox.Show("Klick wo anders!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stepFunction(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stepFunction(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stepFunction(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stepFunction(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stepFunction(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stepFunction(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            stepFunction(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            stepFunction(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            stepFunction(sender);

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
