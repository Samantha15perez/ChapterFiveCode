using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Friend_File
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

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                //declare a streamwriter variable
                StreamWriter outputfile;

                //open the friend.txt file for appending and get a streamwriter object
                outputfile = File.AppendText("Friend.txt");

                //write the friend's name to the file
                outputfile.WriteLine(nameTextBox.Text);

                //close the file
                outputfile.Close();

                //let the user know the name was written
                MessageBox.Show("The name was written");

                //clear the nametextbox control
                nameTextBox.Text = "";

                //give the focus to the nametextbox control
                nameTextBox.Focus();
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
