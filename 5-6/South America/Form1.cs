using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                //declare a variable to hold a country name
                string countryName;

                //declare a streamreader variable
                StreamReader inputFile;

                //open the file and get a streamreader object
                inputFile = File.OpenText("Countries.txt");

                //clear anything currently in the listbox
                countriesListBox.Items.Clear();

                //read the file's contents
                while(!inputFile.EndOfStream)
                {
                    //get a country name
                    countryName = inputFile.ReadLine();

                    //add the country name to the listbox
                    countriesListBox.Items.Add(countryName);
                }

                //close the file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                //display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
