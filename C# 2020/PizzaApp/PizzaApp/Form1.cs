using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApp
{   // Abagail Hankey
    // Intro to C#: CH. 10 E.10
    // This program uses GUI to take a pizza order
    public partial class Form1 : Form
    {
        double pizzaPrice;
        double smallPizza = 5.00;
        double mediumPizza = 10.00;
        double largePizza = 15.00;
        double TAX = .06;
        double salesTax = 0;
        double total;

        public Form1()
        {
            InitializeComponent();
            cardtxtbx.Visible = false;
            nametxtbx.Visible = false;
            addresslbl.Visible = false;
            nametxtbx.Visible = false;
            namelbl.Visible = false;
            numberlbl.Visible = false;
            numbertxtbx.Visible = false;
            cardtxtbx.Visible = false;
            addresstxtbx.Visible = false;
            cardlbl.Visible = false;
            registerbtn.Visible = false;
        }

        private void contbtn_Click(object sender, EventArgs e)
        {
            makeorderlbl.Visible = false;
            contbtn.Visible = false;
            cardtxtbx.Visible = true; 
            nametxtbx.Visible = true; 
            addresslbl.Visible = true; 
            nametxtbx.Visible = true; 
            namelbl.Visible = true; 
            numberlbl.Visible = true;
            numbertxtbx.Visible = true;
            cardtxtbx.Visible = true;
            addresstxtbx.Visible = true;
            cardlbl.Visible = true;
            registerbtn.Visible = true;
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registered");
            pizzatabControl.SelectTab(1);
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            pizzatabControl.SelectTab(2);
            reviewlbl.Text = "Your order: " + "\nSize: " + sizecbbx.Text + "\nCrust: " + crustcbbx.Text;
            reviewlbl.Text += "\nToppings: ";
            foreach (String l in toppinglistbx.SelectedItems)
            {
                reviewlbl.Text += l;
            }
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            pizzatabControl.SelectTab(1);
        }
        private void paymentbtn_Click(object sender, EventArgs e)
        {
            pizzatabControl.SelectTab(3);
            calculateOrder();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void calculateOrder()
        {

            if (sizecbbx.Text.Equals("Small"))
            {
                pizzaPrice = smallPizza;
            }
            else if (sizecbbx.Text.Equals("Large"))
            {
                pizzaPrice = largePizza;
            }
            else pizzaPrice = mediumPizza;

            salesTax = pizzaPrice * TAX;
            total = pizzaPrice + salesTax;

            receiptlbl.Text = string.Format("\nPrice: {0:C} \nTax: {1:C} \nTotal: {2:C}", pizzaPrice, salesTax, total);
        }
    }
}

