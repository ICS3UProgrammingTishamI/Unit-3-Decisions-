/*
 * Created by: Tisham
 * Created on: 1/01/2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #16 - Number Guess/Day #17 - Random Number
 * This program acquires a number inputted, and checks if it is the numbe rthat I've chosen. 
 * If it isn't then it sounds a buzzer and tells you the asnwer is wrong, while showing a red x. 
 * If it is right, it shows a checkmark, makes a noise of sweet victory, and tells you you got the number right
 * UPDATED: The number you must guess is now randomized, and you have a play button included as well
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
using System.Media;

namespace NumberGuessTisham
{
    public partial class frmNumberGuess : Form
    {
        //variables and constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 10;
        int randomNumber;
        Random numberGenerator = new Random();

        public frmNumberGuess()
        {
            InitializeComponent();
            //Hides the images and the text because you haven't answered yet
            this.picRightWrong.Hide();
            this.lblRightWrong.Hide();
            randomNumber = numberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
            this.btnPlay.Enabled = true;
            this.btnGuess.Enabled = false;
            this.lblGuessANumber.Enabled = false;
            this.lblRightWrong.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.btnPlay.Enabled = false;
            this.btnGuess.Enabled = true;
            this.lblGuessANumber.Enabled = true;
            this.lblRightWrong.Enabled = true;
            this.picRightWrong.Hide();
            this.lblRightWrong.Hide();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            //this turns your guess into a number value
            int Guess = int.Parse(txtNumGuess.Text);
            //this checks if your answer is right
            if (Guess == randomNumber)
            {
                //this shows a checkmark and an affirmation of success if you got it right
                picRightWrong.Image = Properties.Resources.checkmark;
                this.picRightWrong.Show();
                lblRightWrong.Text = "Ding ding, you got it right!";
                this.lblRightWrong.Show();
                //this is the code for playing sound, where the files are in the debug folder of this program
                SoundPlayer CorrectNoise = new SoundPlayer(@"CorrectAnswer.wav");
                CorrectNoise.Play();
                this.btnPlay.Enabled = true;
            }
            
            else
            {
                //this shows a red x and tells you that you got the answer wrong
                picRightWrong.Image = Properties.Resources.red_x;
                this.picRightWrong.Show();
                lblRightWrong.Text = "Dong dong, you got it wrong";
                this.lblRightWrong.Show();
                //this is the code for playing sound, where the files are in the debug folder of this program
                SoundPlayer WrongNoise = new SoundPlayer(@"WrongBuzzer.wav");
                WrongNoise.Play();
            }
        }

    }
}
