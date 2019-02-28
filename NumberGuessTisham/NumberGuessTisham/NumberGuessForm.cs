using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessTisham
{
    public partial class frmNumberGuess : Form
    {
        public frmNumberGuess()
        {
            InitializeComponent();
            this.picRightWrong.Hide();
            this.lblRightWrong.Hide();
        }
        const int Answer = 6;
        System.Media.SoundPlayer WrongNoise = new System.Media.SoundPlayer(@"N:\Wrong Answer Sound Effect.wav");
        System.Media.SoundPlayer CorrectNoise = new System.Media.SoundPlayer(@"N:\Correct Answer Sound Effect.wav");
        private void btnGuess_Click(object sender, EventArgs e)
        {
            int Guess = int.Parse(txtNumGuess.Text);
            if (Answer == Guess)
            {
                picRightWrong.Image = Properties.Resources.checkmark;
                this.picRightWrong.Show();
                lblRightWrong.Text = "Ding ding, you got it right!";
                this.lblRightWrong.Show();
                CorrectNoise.Play();
            }
            else
            {
                picRightWrong.Image = Properties.Resources.red_x;
                this.picRightWrong.Show();
                lblRightWrong.Text = "Dong dong, you got it wrong";
                this.lblRightWrong.Show();
                WrongNoise.Play();
            }
        }

    }
}
