/*
 * Created by: Tisham Islam
 * Created on: 01/04/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #25 - For Each
 * This program changes the objects' properties by using a foreach function
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

namespace ForEachControlTishamI
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void btnColours_Click(object sender, EventArgs e)
        {
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.ForeColor = Color.LightGreen;

                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Purple;
                }
                if (aControlObject.GetType() == typeof(Button))
                {
                    aControlObject.BackColor = Color.PaleVioletRed;
                }
                if (aControlObject.GetType() == typeof(ListBox))
                {
                    aControlObject.BackColor = Color.AliceBlue;
                }


            }
        }
    }
}
