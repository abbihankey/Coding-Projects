using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripCalculator
{
    public partial class Tripcalc : Form
    {   // Abagail Hankey
        // Intro to C#: CH.9 E.5
        // Assignment 9
        // This program calculates miles per gallon using a windows form
        public Tripcalc()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int miles;
            int gallons;
            double result;
            int.TryParse(textBox2.Text, out miles);
            int.TryParse(textBox3.Text, out gallons);
            result = miles / gallons;
            label4.Text = "Miles per gallon: " + (result);
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox3.Text = "0";
        }
    }
}
