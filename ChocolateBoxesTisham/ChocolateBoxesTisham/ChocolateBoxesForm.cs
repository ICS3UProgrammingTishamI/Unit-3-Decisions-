/*
 * Created by: Tisham Islam
 * Created on: 08/03/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program gives you a large prize for selling over 20 boxes, 
 * a small prize for selling 10-20 boxes, 
 * and gives you an hounourable mention for anything less than 10 bozes.
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

namespace ChocolateBoxesTisham
{
    public partial class frmChocolateBoxes : Form
    {
        public frmChocolateBoxes()
        {
            InitializeComponent();
            this.lblPrize.Hide();
        }

        int boxesSold;


        private void btnPrize_Click(object sender, EventArgs e)
        {
            boxesSold = int.Parse(txtNumberSold.Text);
            if (boxesSold > 20)
            {
                lblPrize.Text = "You get a large prize for your incredibly generous contributions";
                this.lblPrize.Show();
            }
            else if (boxesSold < 10)
            {
                lblPrize.Text = "You get an honourable mention for your less than generous contributions";
                this.lblPrize.Show();
            }
            else
            {
                lblPrize.Text = "You get a small prize for your respectable contributions";
                this.lblPrize.Show();
            }
        }
    }
}
