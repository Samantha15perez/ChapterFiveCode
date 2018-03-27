using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinToss
{
    public partial class CoinToss : Form
    {
        public CoinToss()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {

            try
            {
                //variable to indicate which side is up
                int sideUp;

                //create a random object
                Random rand = new Random();

                //get a random integer in the range of 0 through 1
                //0 means tails up, 1 means heads up
                sideUp = rand.Next(2);

                //Display the side that is up
                if (sideUp == 0)
                {
                    //display tails up
                    tailsPictureBox.Visible = true;
                    headsPictureBox.Visible = false;
                }
                else
                {
                    //display heads up
                    headsPictureBox.Visible = true;
                    tailsPictureBox.Visible = false;
                }
            }
            catch (Exception ex)
            {
                //display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form.
            this.Close();
        }
    }
}
