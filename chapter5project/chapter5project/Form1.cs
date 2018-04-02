using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter5project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //closes document
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //opens up the project for 5-1
            Ending_Balance.Form1 form1 = new Ending_Balance.Form1();
                    

            form1.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //opens up the project for 5-6
            South_America.Form1 form1 = new South_America.Form1();


            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //opens up the project for 5-3
            Speed_Converter.Form1 form1 = new Speed_Converter.Form1();


            form1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //opens up the project for 5-8
            CoinToss.Form1 form1 = new CoinToss.Form1();
           

            form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //opens up the project for 5-5
            FriendFileEnhanced.Form1 form1 = new FriendFileEnhanced.Form1();


            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //opens up the project for 5-2

            EndingBalanceEnhanced.Form1 form1 = new EndingBalanceEnhanced.Form1();


            form1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //opens up the project for 5-7
            Total_Sales_Enhanced.Form1 form1 = new Total_Sales_Enhanced.Form1();


            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //opens up the project for 5-4
            Friend_File.Form1 form1 = new Friend_File.Form1();


            form1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //opens up the project for 5-9
            South_America_Enhanced.Form1 form1 = new South_America_Enhanced.Form1();

            form1.Show();
        }
    }
}
