/*
* Project: BtunbutrProject4
* Programmer: Bryant Tunbutr
* Date: Nov 22 2012
* Description: Uses array of structures to match part number with brand number
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
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //Create arrays, 2 dimensional for brands
        string[,] brandsString = new string[9, 3];
        string[] cccString = new string[9];
                
        public Form1()
        {
            InitializeComponent();
        }

        private void lookUpButton_Click(object sender, EventArgs e)
        {
            //Organize by having each brand have same second integer, 
            //i.e. Brand A has second integer of 0

            //Brand A        
            brandsString[0, 0] = "MR43T";
            brandsString[1, 0] = "R43";
            brandsString[2, 0] = "R43N";
            brandsString[3, 0] = "R46N";
            brandsString[4, 0] = "R46TS";
            brandsString[5, 0] = "R46TX";
            brandsString[6, 0] = "S46";
            brandsString[7, 0] = "SR46E";
            brandsString[8, 0] = "47L";

            //Brand C
            brandsString[0, 1] = "RBL8";
            brandsString[1, 1] = "RJ6";
            brandsString[2, 1] = "RN4";
            brandsString[3, 1] = "RN8";
            brandsString[4, 1] = "RBL17Y";
            brandsString[5, 1] = "RBL12-6";
            brandsString[6, 1] = "J11";
            brandsString[7, 1] = "XEJ8";
            brandsString[8, 1] = "H12";

            //Brand X
            brandsString[0, 2] = "14K22";
            brandsString[1, 2] = "14K24";
            brandsString[2, 2] = "14K30";
            brandsString[3, 2] = "14K32";
            brandsString[4, 2] = "14K33";
            brandsString[5, 2] = "14K35";
            brandsString[6, 2] = "14K38";
            brandsString[7, 2] = "14K40";
            brandsString[8, 2] = "14K44";

            //CCC NUMBER
            cccString[0] = "PR214";
            cccString[1] = "PR223";
            cccString[2] = "PR224";
            cccString[3] = "PR246";
            cccString[4] = "PR247";
            cccString[5] = "PR248";
            cccString[6] = "PR324";
            cccString[7] = "PR326";
            cccString[8] = "PR444";

            int brandInteger = brandListBox.SelectedIndex;
            int lengthInteger = 9;
           
            //make sure user has selected and entered data
            if (partNumberTextBox.Text != "" && brandInteger != -1) 
           
                for (int indexInteger = 0; indexInteger < lengthInteger; indexInteger++)
                {
                        //match part number with brand number.
                        if (partNumberTextBox.Text == brandsString[indexInteger, brandInteger])
                        {
                                //display result.
                                cccPartNumberTextBox.Text = cccString[indexInteger];
                        }                       
                }

            //check for exeption.
            else
            {
                MessageBox.Show("Missing entry", "Incorrect");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
