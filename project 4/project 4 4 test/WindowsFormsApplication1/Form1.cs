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
        //string[,] brandsString = new string[9, 3];
        //string[] cccString = new string[9];

        //     string[] column = new string[9];           
        
        public Form1()
        {
            InitializeComponent();
        }

        private void lookUpButton_Click(object sender, EventArgs e)
        {

            //Load our text file
            TextReader tr = new StreamReader("C:\\Users\\bryantt\\Desktop\\project 4 4 test\\WindowsFormsApplication1\\bin\\Debug\\test.txt");

            //How many lines should be loaded?
            int NumberOfLines = 5;

            //Make our array for each line
            string[] ListLines = new string[NumberOfLines];

            //Read the number of lines and put them in the array
            for (int i = 1; i < NumberOfLines; i++)
            {
                ListLines[i] = tr.ReadLine();
            }
            
            //Make our array for each line
            string[] ccc = ListLines[1].Split(new Char[] { ',' });
            string[] brandsA = ListLines[2].Split(new Char[] { ',' });
            string[] brandsC = ListLines[3].Split(new Char[] { ',' });
            string[] brandsX = ListLines[4].Split(new Char[] { ',' });

            // close the stream
            tr.Close();

            int j = 0;
            bool foundBool = false;

            do
            {
                if (partNumberTextBox.Text == brandsA[j] ||
                    partNumberTextBox.Text == brandsC[j] ||
                    partNumberTextBox.Text == brandsX[j])
                {
                    cccPartNumberTextBox.Text = ccc[j];

                    foundBool = true;
                }
                else
                    j++;

            } while (j < 9 && !foundBool);
            if (!foundBool)
                MessageBox.Show("Invalid group!");

            /*
            // int brandsInteger = brandListBox.SelectedIndex;
            int lengthInteger = 9;

            if (partNumberTextBox.Text != "" && brandListBox.SelectedIndex != -1) 
           
                for (int indexInteger = 0; indexInteger < lengthInteger; indexInteger++)
                {
                    //check for exeption.

                    if (partNumberTextBox.Text == brandsString[indexInteger])
                        {
                                cccPartNumberTextBox.Text = cccString[indexInteger];
                        }                       
                }
            
            else
            {
                MessageBox.Show("Missing entry", "Incorrect");
            }
             * 
             * 
             */ 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                // Read entire file into a single string.
                string fileString = File.ReadAllText("C:\\Users\\bryantt\\Desktop\\project 4 3 test\\WindowsFormsApplication1\\bin\\Debug\\car center.txt");
                // Split the string into individual fields of a string array.
                string[] aFieldString = fileString.Split('\n');
                // Display the array in a list box.
                // phoneListBox.Items.AddRange(aFieldString);

                //string[] column = new string[9];  
                string[] column = new String[aFieldString.Length];
                for (int i = 0; i < aFieldString.Length; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                            column[i] = aFieldString[j];
                        //column[j] = "";
                    }
                }
                phoneListBox.Items.AddRange(column);
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

        private void button2_Click(object sender, EventArgs e)
        {


        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
