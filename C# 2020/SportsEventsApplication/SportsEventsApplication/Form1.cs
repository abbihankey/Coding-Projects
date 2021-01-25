using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsEventsApplication
{
    public partial class sportEvent : Form
    {   // Abagail Hankey
        // Intro to C#: Ch.10 E.4
        // This program allows users to sign up for a sporting event
        public sportEvent()
        {
            InitializeComponent();
            soccerPictureBox.Hide();
            footballPictureBox.Hide();
            swimmingPictureBox.Hide();
            cyclingPictureBox.Hide();
            tennisPictureBox.Hide();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            soccerPictureBox.Hide();
            footballPictureBox.Hide();
            swimmingPictureBox.Hide();
            cyclingPictureBox.Hide();
            tennisPictureBox.Hide();
            if (soccerRadioButton.Checked)
            {
                soccerPictureBox.Show();
                MessageBox.Show("Sign Up Complete, don't forget your cleats!");
            }
            if (footballRadioButton.Checked)
            {
                footballPictureBox.Show();
                MessageBox.Show("Sign Up Complete, don't forget your mouth gaurd!");
            } 
            if (cyclingRadioButton.Checked)
            { 
                cyclingPictureBox.Show();
                MessageBox.Show("Sign Up Complete, don't forget your helmet!");
            }
            else if (swimmingRadioButton.Checked)
            {
                swimmingPictureBox.Show();
                MessageBox.Show("Sign Up Complete, don't forget your goggles!");
            }
            else if (tennisRadioButton.Checked)
            {
                tennisPictureBox.Show();
                MessageBox.Show("Sign Up Complete, don't forget your racket!");
            }
        }
    }
}

