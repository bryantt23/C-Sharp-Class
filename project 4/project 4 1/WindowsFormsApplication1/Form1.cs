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
        string[] cccArray = new string[9] { "PR214", "PR223", "PR224", "PR246", "PR247", "PR248", "PR324", "PR326", "PR444"};
        string[] brandA = new string[9] { "MR43T", "R43", "R43N", "R46N", "R46TS", "R46TX", "S46", "SR46E", "47L", };
        string[] brandC = new string[9] { "RBL8", "RJ6", "RN4", "RN8", "RBL17Y", "RBL12-6", "J11", "XEJ8", "H12", };
        string[] brandX = new string[9] { "14K22", "14K24", "14K30", "14K32", "14K33", "14K35", "14K38", "14K40", "14K44" };
        
        public Form1()
        {
            InitializeComponent();
        }

        private void lookUpButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            bool foundBool = false;

            do
            {
                if (partNumberTextBox.Text == brandA[i] ||
                    partNumberTextBox.Text == brandC[i] ||
                    partNumberTextBox.Text == brandX[i])
                {
                    cccPartNumberTextBox.Text = cccArray[i];

                    foundBool = true;
                }
                else
                    i++;
            } while (i < 9 && !foundBool);
            if (!foundBool)
                MessageBox.Show("Invalid group!");
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
    }
}
