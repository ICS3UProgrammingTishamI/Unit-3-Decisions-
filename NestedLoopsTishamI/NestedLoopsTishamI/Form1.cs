/*
 * Created by: Tisham Islam
 * Created on: 02/04/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Numbers Nested Loops
 * This program shows a capital letter, followed by a lowercase letter. 
 * It then does it again but the lowercase letter 
 * is moved one place forward in alphabetical order
 * Once the lowercase letter reaches "z", 
 * the capital letter shifts forward in alphabetical order
 * and the lowercase letter goes back to "a"
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

namespace NestedLoopsTishamI
{
    public partial class frmNestedLoops : Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void btnListUnicode_Click(object sender, EventArgs e)
        {
            string character;
            string character2;
            int counter;
            int counter2;

            lstUnicode.Items.Clear();

            for (counter = 65; counter <= 90; counter++)
            {
                for (counter2 = 97; counter2 <= 122; counter2++)
                {
                    character = Char.ConvertFromUtf32(counter);
                    character2 = Char.ConvertFromUtf32(counter2);
                    lstUnicode.Items.Add(character + "->" + character2);
                }
            }


        }
    }
}
