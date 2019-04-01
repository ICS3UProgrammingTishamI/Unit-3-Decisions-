/*
 * Created by: Tisham Islam
 * Created on: 25/03/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Perfect Squares
 * This program that displays all the perfect squares 
 * under a number chosen by the user
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

namespace PerfectSquareTishamI
{
    public partial class frmPerfectSquare : Form
    {
        public frmPerfectSquare()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //variables
            int endingValue;
            int value = 1;
            double sqrtAsDouble;
            int sqrtAsInt;

            lstSquares.Items.Clear();
            endingValue = Convert.ToInt32(nudEndVal.Value);

            while (value <= endingValue)
            {
                sqrtAsDouble = Math.Sqrt(value);
                sqrtAsInt = Convert.ToInt32(sqrtAsDouble);

                if (sqrtAsInt == sqrtAsDouble)
                {
                    this.lstSquares.Items.Add(value + " is a perfect square");
                    this.Refresh();
                }
                value = value + 1;
            }
        }
    }
}
