/*
 * Created by: Tisham Islam
 * Created on: 28/02/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #24 - Unicode
 * This program shows all the characters from A to Z and their coresponding unicode values
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

namespace UnicodeTishamI
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //variables
            string character;
            int counter;

            //empty out the list beforehand
            lstUnicode.Items.Clear();

            //65 is the decimal value for A in Unicode, 
            //90 is the decimal value for Z in Unicode 
            for (counter = 65; counter <= 90; counter++)
            {
                //Convert and then add to the list the character + its unicode value
                character = Char.ConvertFromUtf32(counter);
                lstUnicode.Items.Add(character + " -> " + Convert.ToString(counter));
            }
        }
    }
}
