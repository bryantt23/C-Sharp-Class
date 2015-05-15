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
        public struct GroupInfo
        {
            //public string groupNumberString;
            public decimal totalDecimal, groupNumberDecimal, totalsDecimal;

             public int groupNumberInteger;
        }
        public GroupInfo[] arrayGroup = new GroupInfo[4]; 

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the group numbers.
            arrayGroup[0].groupNumberInteger = 100;
            arrayGroup[1].groupNumberInteger = 5000;
            arrayGroup[2].groupNumberInteger = 1;
            arrayGroup[3].groupNumberInteger = 50;
        }
                
        // Declare the variables.

        decimal partsChargesDec, subTotalDec, hoursOfLaborDec,
            salesTaxDec, totalDec, laborChargesDec, totalsDecimal;
            //groupNumberDec;
        int number, groupNumberInteger;

        public Form1()
        {
            InitializeComponent();
            //Intialize the variable to 1
            number = 1;
            //Probably a good idea to intialize the label to 1 as well
            jobLabel.Text = number.ToString();

            //Declare class-level variable.
            decimal[] totalsDecimal = new decimal[4];
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (groupComboBox.SelectedIndex != -1)
                {
                // Convert input group number to a subscript.
                    groupNumberInteger = groupComboBox.SelectedIndex;
                // Add sale to correct total.
                //decimal saleDecimal = decimal.Parse(salesTextBox.Text);
                // totalsDecimal[groupNumberInteger] += saleDecimal;
                // Clear the entries.
                    //groupComboBox.SelectedIndex = -1;
                // salesTextBox.Clear();
                }
                else
                {
                //MessageBox.Show("Select a group.", "Data Entry Error",
                    //MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            
                // Convert input values to numeric and assign to variables.

                //partsChargesDec = decimal.Parse(partsChargesTextBox.Text);
                hoursOfLaborDec = decimal.Parse(hoursOfLaborTextBox.Text);
            }

            

            // To catch bad input.
            catch
            {
                // MessageBox.Show("Bad input");
            }

            {

                switch (groupComboBox.SelectedIndex)
                {
                    case 0:
                        partsChargesDec = 100m;
                        break;
                    case 1:
                        partsChargesDec = 5000m;
                        break;
                    case 2:
                        partsChargesDec = 1m;
                        break;
                    case 3:
                        partsChargesDec = 50m;
                        break;
                }
                
                
                // Calculate values.

                // totalsDecimal[groupNumberInteger] += saleDecimal;
                salesTaxDec = partsChargesDec * .1m;
                    //* .1m;
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
