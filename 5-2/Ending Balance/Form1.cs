using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ending_Balance
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

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //constant for the monthly interest rate.
            const decimal INTEREST_RATE = 0.005m;

            //local variables
            decimal balance; //account balance
            int months; //number of months
            int count = 1; //loop counter, initialized with 1

            //get the starting balance
            if (decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                //get the number of months
                if (int.TryParse(monthsTextBox.Text, out months))
                {
                    //the following loop calculates the ending balance
                    while (count <= months)
                    {
                        //add this months interest to the balance
                        balance = balance + (INTEREST_RATE * balance);

                        //display this month's ending balance
                        detailListBox.Items.Add("The ending balance " + "for month " + count + " is " + balance.ToString("c"));

                        //add one to the loop counter
                        count = count + 1;
                    }

                    //display the ending balance
                    endingBalanceLabel.Text = balance.ToString("c");
                }
                else
                {
                    //invalid number of months was entered
                    MessageBox.Show("invalid value for months");
                }
            }
            else
            {
                //invalid starting balance was entered
                MessageBox.Show("Invalid value for starting balance");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear the textboxes, the endingbalancelabel control, and the listbox
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();
           
            //reset the focus
            startingBalTextBox.Focus();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void endingBalanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void detailListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
