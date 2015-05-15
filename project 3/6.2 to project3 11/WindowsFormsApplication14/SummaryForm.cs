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
    public partial class SummaryForm : Form
    {
        private decimal summarySubTotalDec;

        public decimal TotalSales
        {    
        set
        {
            summarySubTotalDec = value;
        }
        }

        public SummaryForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Get and display the summary data.
            // summarySubTotal.Text = summarySubTotalDec.ToString("C");

            richTextBox1.Text = "subtotal" + summarySubTotalDec.ToString("c");// +
                //   "sales tax" + summarySalesTaxDec.ToString("c") +
              //   "total" + summaryTotalDec.ToString("c");
        }
    }
}
