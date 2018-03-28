using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TotalSalesEnhanced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //variables
                decimal sales; //to hold a sales amount
                decimal total = 0m; //accumulator, set to 0

                //declare a streamreader variable
                StreamReader inputFile;

                //open the file and get a streamreader object
                inputFile = File.OpenText("sales.txt");

                //read the files contents
                while (!inputFile.EndOfStream)
                {
                    //get a sales amount
                    sales = decimal.Parse(inputFile.ReadLine());

                    //add the sales amount to the total
                    total += sales;
                }

                //close the file
                inputFile.Close();

                //Display the total
                totalLabel.Text = total.ToString("C");
            }
            catch (Exception ex)
            {
                //display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
