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
        //Create arrays
        string[,] brandsString = new string[9, 3];
        string[] cccString = new string[9];           
        
        public Form1()
        {
            InitializeComponent();
        }

        private void lookUpButton_Click(object sender, EventArgs e)
        {
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

            int brandsInteger = brandListBox.SelectedIndex;
            int lengthInteger = 9;

            if (partNumberTextBox.Text != "" && brandsInteger != -1) 
           
                for (int indexInteger = 0; indexInteger < lengthInteger; indexInteger++)
                {
                    //Check for exceptions, missing information.

                    if (partNumberTextBox.Text == brandsString[indexInteger, brandsInteger])
                        {
                                cccPartNumberTextBox.Text = cccString[indexInteger];
                        }                       
                }
            
            else
            {
                MessageBox.Show("Missing entry", "Incorrect");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                // Read entire file into a single string.
                string fileString = File.ReadAllText("C:\\Users\\bryantt\\Desktop\\project 4 1\\WindowsFormsApplication1\\bin\\Debug\\car center.txt");
                // Split the string into individual fields of a string array.
                string[] aFieldString = fileString.Split('\n');
                // Display the array in a list box.
                phoneListBox.Items.AddRange(aFieldString);
            }
            catch
            {
                MessageBox.Show("File or path not found or invalid.");
            }
             */

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
