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

        string[] cccArray = new string[9];
        string[] brandA = new string[9];
        string[] brandC = new string[9];
        string[] brandX = new string[9];

        string cccArrayList,brandAList,brandCList,brandXList;


        /*
        string[] ar1 = new string[9];
        string[] ar2 = new string[9];
        string[] ar3 = new string[9];
        string[] ar4 = new string[9];
        string filePath = ("test.txt");
        StreamReader sr = new StreamReader("C:\\Users\\bryantt\\Desktop\\project 4 test\\WindowsFormsApplication1\\bin\\Debug\\test.txt");

        
        string[] cccArray = new string[9];
        string[] brandA = new string[9] ;
        string[] brandC = new string[9] ;
        string[] brandX = new string[9] ;
        */

        /*
        string[] cccArray = new string[9] { "PR214", "PR223", "PR224", "PR246", "PR247", "PR248", "PR324", "PR326", "PR444"};
        string[] brandA = new string[9] { "MR43T", "R43", "R43N", "R46N", "R46TS", "R46TX", "S46", "SR46E", "47L", };
        string[] brandC = new string[9] { "RBL8", "RJ6", "RN4", "RN8", "RBL17Y", "RBL12-6", "J11", "XEJ8", "H12", };
        string[] brandX = new string[9] { "14K22", "14K24", "14K30", "14K32", "14K33", "14K35", "14K38", "14K40", "14K44" };
        */

        public Form1()
        {
            InitializeComponent();
        }

        private void lookUpButton_Click(object sender, EventArgs e)
        {
            String[] cccArray = cccArrayList.ToArray();
            String[] brandA = brandAList.ToArray();
            String[] brandC = brandCList.ToArray();
            String[] brandX = brandXList.ToArray();

            using (var reader = new System.IO.StreamReader(@"C:\\Users\\bryantt\\Desktop\\project 4 test\\WindowsFormsApplication1\\bin\\Debug\\car center.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    var fields = line.Split(new Char[] { @"\W+" }, StringSplitOptions.RemoveEmptyEntries);
                    cccArrayList.Add(fields[0]);
                    if (fields.Length > 1)
                        brandAList.Add(fields[1]);
                    if (fields.Length > 2)
                        brandCList.Add(fields[2]);
                    if (fields.Length > 3)
                        brandXList.Add(fields[3]);
                }
            }
                /*
                    var list = new List<string[]>();
                    using (StreamReader reader = new StreamReader("Test.txt"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            list.Add(line.Split(' '));
                        }
                    }
                    string firstWord = list[0][0]; //12345 
                    string secondWord = list[0][1]; //Test
            }            
            
            //int i = 0;
            //bool foundBool = false;

            do
            {
                if (partNumberTextBox.Text == ar2[i] ||
                    partNumberTextBox.Text == ar3[i] ||
                    partNumberTextBox.Text == ar4[i])
                {
                    cccPartNumberTextBox.Text = ar1[i];

                    foundBool = true;
                }
                else
                    i++;
            } while (i < 9 && !foundBool);
            if (!foundBool)
                MessageBox.Show("Invalid group!");


            */
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            try
            {

            }
            catch
            {
            }
             */

        }
    }
}
