/*
 * Created by: Tisham Islam
 * Created on: 25/03/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23 - Sum of Numbers
 * This program adds up all the integers sequentially up to the chosen number
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumOfNumbersTishamI
{
    public partial class frmSumOfNumbers : Form
    {
        public frmSumOfNumbers()
        {
            InitializeComponent();
        }

        private void btnCalculatirize_Click(object sender, EventArgs e)
        {
            int addNumber;
            int sum = 0;
            int addCounter;

            //no one wants to see the old numbers
            this.lstNumbers.Items.Clear();

            //get that number from the nud
            addNumber = Convert.ToInt32(nudNumber.Value);

            for (addCounter = 1; addCounter <= addNumber; addCounter++)
            {
                //calculate the sum by adding it by the next number
                sum = sum + addCounter;

                //add the numbers multiplied to the list
                this.lstNumbers.Items.Add(addCounter);

                //show and properly display the information
                lblSum.Text = "All the numbers that are added sequentially to " + Convert.ToString(addNumber) + " adds up to " + Convert.ToString(sum);
            }
        }
    }
}
