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
        }
        /*
        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add the current item price and quantity to the order.
            if (groupComboBox.SelectedIndex == -1)
            {
            MessageBox.Show("You must select a part to repair.");
            }
            else
            {
                try
                {
                groupNumberInteger = groupComboBox.SelectedIndex;
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
                salesTaxDec = partsChargesDec * .1m;

                laborChargesDec = hoursOfLaborDec * 50m;

                subTotalDec = partsChargesDec + laborChargesDec;

                totalDec = subTotalDec + salesTaxDec;

                //Display the results

                salesTaxInfoLabel.Text = salesTaxDec.ToString("C");
                subtotalInfoLabel.Text = subTotalDec.ToString("C");
                totalInfoLabel.Text = totalDec.ToString("C");


                //Increase job number
                //On a X Button click increment the number
                number++;
                //Update the label. Convert the number to a string
                jobLabel.Text = number.ToString();
            }
            catch
            {
                //MessageBox.Show("Missing entry");
            }

            }
        }
        */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {         

            // clear boxes
            customerNameTextBox.Text = "";
            hoursOfLaborTextBox.Text = "";
            groupComboBox.Text = "";

            //enable calculate
            calculateButton.Enabled = true;
                         
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutForm = new AboutBox1();
            aboutForm.ShowDialog();
        }

        private void jobLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add the current item price and quantity to the order.
            if (groupComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a part to repair.");
            }
            if (hoursOfLaborTextBox.Text == "")
            {
                MessageBox.Show("You must record hours of labor.");
            }
            else
            {
                try
                {
                    groupNumberInteger = groupComboBox.SelectedIndex;
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
                                        
                    decimal hoursOfLaborDec = decimal.Parse(hoursOfLaborTextBox.Text);
                    // Calculate values.
                    salesTaxDec = partsChargesDec * .1m;

                    laborChargesDec = hoursOfLaborDec * 50m;

                    subTotalDec = partsChargesDec + laborChargesDec;

                    totalDec = subTotalDec + salesTaxDec;

                    //Display the results

                    salesTaxInfoLabel.Text = salesTaxDec.ToString("C");
                    subtotalInfoLabel.Text = subTotalDec.ToString("C");
                    totalInfoLabel.Text = totalDec.ToString("C");


                    //Increase job number
                    //On a X Button click increment the number
                    number++;
                    //Update the label. Convert the number to a string
                    jobLabel.Text = number.ToString();

                    //disable calculate
                    calculateButton.Enabled = false;
                }
                catch
                {
                    //MessageBox.Show("Missing entry");
                }

            }
        }
        
    }
}
