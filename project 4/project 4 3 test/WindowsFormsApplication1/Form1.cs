﻿using System;
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

        //     string[] column = new string[9];           
        
        public Form1()
        {
            InitializeComponent();
        }

        private void lookUpButton_Click(object sender, EventArgs e)
        {
            /*
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
            */
             
            int brandsInteger = brandListBox.SelectedIndex;
            int lengthInteger = 9;

            if (partNumberTextBox.Text != "" && brandsInteger != -1) 
           
                for (int indexInteger = 0; indexInteger < lengthInteger; indexInteger++)
                {
                    //check for exeption.

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
            

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Load our text file
            TextReader tr = new StreamReader("C:\\Users\\bryantt\\Desktop\\project 4 3 test\\WindowsFormsApplication1\\bin\\Debug\\test.txt");

            //How many lines should be loaded?
            int NumberOfLines = 5;

            //Make our array for each line
            string[] ListLines = new string[NumberOfLines];

            //Read the number of lines and put them in the array
            for (int i = 1; i < NumberOfLines; i++)
            {
                ListLines[i] = tr.ReadLine();
            }

            //This will write the 5th line into the console
            Console.WriteLine(ListLines[4]);
            //This will write the 1st line into the console
            Console.WriteLine(ListLines[1]);


            //textBox1.Text = ListLines[3].ToString();

            Console.ReadLine();



            //Make our array for each line
            string[] ccc = ListLines[1].Split(new Char[] { ',' });
            string[] brandsA = ListLines[2].Split(new Char[] { ',' });
            string[] brandsB = ListLines[3].Split(new Char[] { ',' });
            string[] brandsC = ListLines[4].Split(new Char[] { ',' });

            //Read the number of lines and put them in the array
           // for (int i = 1; i < 10; i++)
            {
          //      ListLines[i] = tr.ReadLine();
            }
            textBox1.Text = brandsB[3].ToString();

            //How many Prices should be loaded?
            // int NumberOfPrices = 9;

            //Make our array for each line
            //  string[] ListLines = new string[NumberOfPrices];

            //Read the number of lines and put them in the array
            //  for (int i = 1; i < NumberOfLines; i++)
            {
                //       ListLines[i] = tr.ReadLine();
            }
            /*

            string[,] brandsBF = new string[brandsB, 0];

            for (int i = 0; i < NumberOfPrices; i++)
            {

                {
                    brandsBF[i, j] = brandsB(j);
                }
            }

            */

            


           // textBox1.Text = ccc[8].ToString() + brandsB[7].ToString();

            // close the stream
         //     tr.Close();






        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}