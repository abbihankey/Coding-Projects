using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorApplication
{
    public partial class colorApp : Form
    {
        public colorApp()
        {
            InitializeComponent();
        }
        // green button 
        private void GreenButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        } 
        // red button 
        private void RedButton_Click(object sender, EventArgs e) 
        {
            this.BackColor = Color.Red; 
        }
        // reset button 
        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}  


