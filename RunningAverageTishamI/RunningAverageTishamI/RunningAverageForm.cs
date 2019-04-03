/*
 * Created by: Tisham Islam
 * Created on: 03/04/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Running Average
 * This program claculates the average of numbers entered in separately.
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

namespace RunningAverageTishamI
{
    public partial class frmRunningAverage : Form
    {
        public frmRunningAverage()
        {
            InitializeComponent();
            //Hide this for now
            lblCalculations.Hide();
        }

        //variables
        int numbersCount = 0;
        int number = 0;
        int sum = 0;
        double average = 0;
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //this will let us divide by the number of all numbers inputted
            numbersCount++;

            //get the number from the nud
            number = (int)nudNumbers.Value;

            //add the inputted number into the total
            sum += number;

            //caluclate the average of every number inputted
            average = sum / numbersCount;

            //Change the label's text
            lblCalculations.Text = "Your average is " + Convert.ToString(Math.Round(average, 2));

            //When you wanna reset
            if (number == -1)
            {
                //resetting all variables
                numbersCount = 0;
                number = 0;
                sum = 0;
                average = 0;

                //Hiding the label once again
                lblCalculations.Hide();
            }
            else
            {
                //Show the label and subsequently the average
                lblCalculations.Show();
            }

        }
    }
}
