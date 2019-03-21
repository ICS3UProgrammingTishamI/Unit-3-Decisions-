/*
 * Created by: Tisham Islam
 * Created on: 20/03/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 - Walking Man
 * This program dispplays ten images of a man walking in quick succession to make it seem as if there's a single animated image, all done upon the button being clicked
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
using System.Threading;

namespace WalkingManTishamI
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        //variables
        int frameCounter = 0;
        const int MAX_FRAMES = 10;
        
        private void btnWalk_Click(object sender, EventArgs e)
        {
            //resets the image
            frameCounter = 0;
            do
            {
                //each time the image will change
                frameCounter = frameCounter + 1;
                if (frameCounter == 1)
                {
                    picWalker.Image = Properties.Resources.walk1;
                }
                else if (frameCounter == 2)
                {
                    picWalker.Image = Properties.Resources.walk2;
                }
                else if (frameCounter == 3)
                {
                    picWalker.Image = Properties.Resources.walk3;
                }
                else if (frameCounter == 4)
                {
                    picWalker.Image = Properties.Resources.walk4;
                }
                else if (frameCounter == 5)
                {
                    picWalker.Image = Properties.Resources.walk5;
                }
                else if (frameCounter == 6)
                {
                    picWalker.Image = Properties.Resources.walk6;
                }
                else if (frameCounter == 7)
                {
                    picWalker.Image = Properties.Resources.walk7;
                }
                else if (frameCounter == 8)
                {
                    picWalker.Image = Properties.Resources.walk8;
                }
                else if (frameCounter == 9)
                {
                    picWalker.Image = Properties.Resources.walk9;
                }
                else if (frameCounter == 10)
                {
                    picWalker.Image = Properties.Resources.walk10;
                }
                //refreshes the form so that the image will actually show
                this.Refresh();

                //this makes the program wait 100 milliseconds before continuing the loop, 
                //so that the animation effect is properly shown
                Thread.Sleep(100);
            } while (frameCounter < MAX_FRAMES + 1);
        }
    }
}
