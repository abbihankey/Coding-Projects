using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Application
{
    public partial class CalculatorApp : Form
    {   // Abagail Hankey
        // Intro to C#: Ch.9 E.3
        // W10b GE
        // 7/21/2020
        // This program uses windows forms to add and multiply numbers and outputs color coded information about te results
        public CalculatorApp()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            
            bool val1 = Int32.TryParse(firstValBox.Text, out number1);
            bool val2 = Int32.TryParse(secondValBox.Text, out number2);

            if (val1 && val2)
            {
                if (number1 > 0 && number2 > 0)
                {
                    outputLabel.ForeColor = Color.Yellow;
                    outputLabel.Text = (number1 + number2).ToString();
                }
                {
                    outputLabel.ForeColor = Color.Red;
                    outputLabel.Text = "Value must be numeric and >0";
                }
            }
            else
            {
                outputLabel.ForeColor = Color.Red;
                outputLabel.Text = "Value must be numeric and >0";
            }
        }
        private void mulButton_Click(object sender, EventArgs e)
        {
            int number1, number2;
            bool val1 = Int32.TryParse(firstValBox.Text, out number1);
            bool val2 = Int32.TryParse(secondValBox.Text, out number2);
            if (val1 && val2) 
            {
                if (number1 > 0 && number2 > 0)
                {
                    outputLabel.ForeColor = Color.Yellow;
                    outputLabel.Text = (number1 * number2).ToString();
                }
                else 
                {
                    outputLabel.ForeColor = Color.Red;
                    outputLabel.Text = "Value must be numeric and >0";
                }
            }
            else
            {
                outputLabel.ForeColor = Color.Red;
                outputLabel.Text = "Value must be numeric and >0";
            }
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            firstValBox.Text = "";
            secondValBox.Text = "";
            outputLabel.Text = "";
        }
    }
}



   
