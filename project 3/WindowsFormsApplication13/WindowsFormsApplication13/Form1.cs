/*  Program:     Cool Boards
    Author:      Bryant Tunbutr
    Class:	     CISP41-22726201220
    Date:	     10/11/12
    Description: This project calculates the amount due
    based on the customer selection
    and accumulates summary data for all customers.
    Includes menus, common dialog boxes, and general methods.

    I certify that the code below is my own work.
	
	Exception(s): N/A

*/
using System;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        // Declare class variables.
        private decimal itemPriceDecimal,
                        totalOrderDecimal,
                        shirtPriceDecimal,
                        totalSalesDecimal;
        private int shirtsInteger,
                         ordersInteger;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // To close program.
            this.Close();
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            // Add the current item price and quantity to the order.
            int extrasInteger = 0;
            if (noSizeRadioButton.Checked)
            {
                // Error message for missing info.  
                MessageBox.Show("You must select a shirt size.",
                    "Missing required entry");
            }
            if (customerTextBox.Text == "")
            {
                // Error message for missing info.   
                      MessageBox.Show("You must enter customer name.",
                    "Missing required entry");
                  }
            else
            {
                try
                {
                    // Calculate price based on size and quantity.   
                    int quantityInteger = int.Parse(quantityTextBox.Text);
                    if (quantityInteger != 0)
                    {
                        if (smallRadioButton.Checked)
                        {
                            itemPriceDecimal = 10m;
                        }
                        if (mediumRadioButton.Checked)
                        {
                            itemPriceDecimal = 10m;
                        }
                        if (largeRadioButton.Checked)
                        {
                            itemPriceDecimal = 10m;
                        }
                        else if (extraLargeRadioButton.Checked)
                        {
                            itemPriceDecimal = 11m;
                        }
                        else if (xxlRadioButton.Checked)
                        {
                            itemPriceDecimal = 12m;
                        }

                        // Calculate price based on pockets and monograms.   
                        extrasInteger = 0;
                        if (pocketCheckBox.Checked)
                        {
                            extrasInteger++;
                        }
                        if (monogramCheckBox.Checked)
                        {
                            extrasInteger+=2;
                        }
                        itemPriceDecimal += extrasInteger * 1m; // 1 dollar for each item.  

                        // display price of one shirt.   
                        shirtPriceDecimal = findshirtPriceDecimal(itemPriceDecimal, quantityInteger);
                        shirtPriceTextBox.Text = itemPriceDecimal.ToString("C");   

                        shirtPriceTextBox.Text = itemPriceDecimal.ToString("C");
                        
                        // running total of shirts
                        shirtsInteger += quantityInteger;

                        // running total of orders
                         totalOrderDecimal += shirtPriceDecimal;

                         // total of cost of order
                         orderTotalTextBox.Text = totalOrderDecimal.ToString("C");

                         customerTextBox.Enabled = false;
                         orderTextBox.Enabled = false;
                         orderCompleteButton.Enabled = true;

                    }
                    else
                    {
                        // Error message for missing info.   
                        MessageBox.Show("Please enter a quantity.",
                            "Missing Required Entry");
                    }

                }
                catch (FormatException)
                {
                    // Error message for bad info.   
                    MessageBox.Show("Invalid quantity.", "Data Entry Error");
                    quantityTextBox.Focus();
                    quantityTextBox.SelectAll();
                }
                }
        }

        private decimal findshirtPriceDecimal(decimal itemPriceDecimal, int quantityInteger)
        {
            // method to find price.   
            return (itemPriceDecimal * quantityInteger);
        }

        private void clearOrderButton_Click(object sender, EventArgs e)
        {
            // clear everything for next customer   
            customerTextBox.Text = "";
            orderTextBox.Text = "";
            quantityTextBox.Text = "";
            shirtPriceTextBox.Text = "";
            orderTotalTextBox.Text = "";
            totalOrderDecimal = 0;
            customerTextBox.Enabled = true;
            orderTextBox.Enabled = true;
            summaryOfAllOrdersButton.Enabled = false;
        }

        private void orderCompleteButton_Click(object sender, EventArgs e)
        {

            // Order is complete, add to summary and clear order.

            // Check if the last item was added to the total.
            if (shirtPriceTextBox.Text != "")
            {
                DialogResult responseDialogResult;
                string messageString = "Current Item not recorded. Add to order?";
                responseDialogResult = MessageBox.Show(messageString,
                    "Verify Last Shirt Purchase",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (responseDialogResult == DialogResult.Yes)
                {
                    addToOrderButton_Click(sender, e);
                }
            }

            // Display amount due.
            string dueString = "Amount Due " + totalOrderDecimal.ToString("C");
            MessageBox.Show(dueString, "Order Complete");

            // Add to summary totals.
            ordersInteger++;
            totalSalesDecimal += totalOrderDecimal;

            // Reset buttons and total for new order.
            summaryOfAllOrdersButton.Enabled = true;
            orderCompleteButton.Enabled = false;
            totalOrderDecimal = 0m;
        }

        private void summaryOfAllOrdersButton_Click(object sender, EventArgs e)
        {
            // Display the summary information in a message box.

            string summaryString = "Shirts Sold:      "
                    + shirtsInteger.ToString()
                    + "\n\n" + "Number of Orders: "
                    + ordersInteger.ToString()
                    + "\n\n" + "Total Sales:      "
                    + totalSalesDecimal.ToString("C");
            MessageBox.Show(summaryString, "Shirt Sales Summary",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // show programmer info.   
            AboutBox1 aboutForm = new AboutBox1();
            aboutForm.ShowDialog();
        }
                }
        }
  
