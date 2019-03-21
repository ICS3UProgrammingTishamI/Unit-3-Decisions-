/*
 * Created by: Tisham Islam
 * Created on: 18/03/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program calculates a factorial based on user input.
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

namespace FactorialDoWhileTishamI
{
    public partial class frmFactorialDoWhile : Form
    {

        public frmFactorialDoWhile()
        {
            InitializeComponent();
            //hide your label until it's needed
            this.lblFactorialAnswer.Hide();
        }
        

        private void btnFactorialize_Click(object sender, EventArgs e)
        {
            //Variables
            Double factorialNumber;
            Double factorialAnswer = 1;
            int factorialCounter = 0;
            
            //no one wants to see the old numbers
            this.lstFactorialMultipliers.Items.Clear();

            //get the inputted number the user wants to factorialize
            factorialNumber = Convert.ToDouble(this.txtFactorialNumber.Text);
            do
            {
                //increments the counter each time the loop goes through
                factorialCounter = factorialCounter + 1;

                //calculate the factorial by multiplying it by the next number
                factorialAnswer = factorialAnswer * factorialCounter;

                //add the numbers multiplied to the list
                this.lstFactorialMultipliers.Items.Add(factorialCounter);

                //show and properly display the information
                this.lblFactorialAnswer.Show();
                lblFactorialAnswer.Text = Convert.ToString(factorialNumber) + "! = " + Convert.ToString(factorialAnswer);
            } while (factorialCounter < factorialNumber); 



        }
    }
}
