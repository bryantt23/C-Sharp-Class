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
        decimal summarySubTotalDec,summarySalesTaxDec,summaryTotalDec;

        public decimal SummarySubTotal
        {    
            set
            {
            summarySubTotalDec = value;
            }
        }

        public decimal SummarySalesTax
        {
            set
            {
                summarySalesTaxDec = value;
            }
        }
        public decimal SummaryTotal
        {
            set
            {
                summaryTotalDec = value;
            }
        }
                
        public SummaryForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            summaryLabel.Text = "The culmulative Subtotal" + "\r\n" + " for parts and labor is " + 
                summarySubTotalDec.ToString("c") + "\r\n" + "\r\n" +
                "The culmulative Sales Tax is " + summarySalesTaxDec.ToString("c") + "\r\n" + "\r\n" + 
                "The culmulative Total is " + summaryTotalDec.ToString("c");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
