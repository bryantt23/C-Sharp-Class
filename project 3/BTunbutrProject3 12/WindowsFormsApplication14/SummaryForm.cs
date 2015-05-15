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
            richTextBox1.Text = "subtotal" + summarySubTotalDec.ToString("c") +
                  "sales tax" + summarySalesTaxDec.ToString("c") +
                "total" + summaryTotalDec.ToString("c");
        }
    }
}
