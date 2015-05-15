/*
* Project: Exercise 6.2
* Programmer: Bryant Tunbutr
* Date: October 22 2012
* Description: Calculates and displays the cost for autoshop materials and labor
 * I certify that the code below is my own work.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        // Declare the variables.

        decimal partsChargesDec, subTotalDec, hoursOfLaborDec, 
            salesTaxDec, totalDec, laborChargesDec;
        int number;

        public Form1()
        {
            InitializeComponent();
            //Intialize the variable to 1
            number = 1;
            //Probably a good idea to intialize the label to 1 as well
            jobLabel.Text = number.ToString();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert input values to numeric and assign to variables.

                partsChargesDec = decimal.Parse(partsChargesTextBox.Text);
                hoursOfLaborDec = decimal.Parse(hoursOfLaborTextBox.Text);

            }

            // To catch bad input.
            catch
            {
                // MessageBox.Show("Bad input");
            }

            {

                // Calculate values.

                salesTaxDec = partsChargesDec * .1m;
                laborChargesDec = hoursOfLaborDec * 50m;

                subTotalDec = partsChargesDec + laborChargesDec;

                totalDec = subTotalDec + salesTaxDec;

                //Display the results

                salesTaxInfoLabel.Text = salesTaxDec.ToString("C");
                subtotalInfoLabel.Text = subTotalDec.ToString("C");
                totalInfoLabel.Text = totalDec.ToString("C");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // clear boxes
            // jobNumberTextBox.Text = "";
            customerNameTextBox.Text = "";
            partsChargesTextBox.Text = "";
            hoursOfLaborTextBox.Text = "";
            
            // reset focus
            hoursOfLaborTextBox.Focus();

            //Increase job number
            //On a X Button click increment the number
            number++;
            //Update the label. Convert the number to a string
            jobLabel.Text = number.ToString();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutForm = new AboutBox1();
            aboutForm.ShowDialog();
        }

        private void jobLabel_Click(object sender, EventArgs e)
        {

        }
        
    }
}
