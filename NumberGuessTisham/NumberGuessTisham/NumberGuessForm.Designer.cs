namespace NumberGuessTisham
{
    partial class frmNumberGuess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumGuess = new System.Windows.Forms.TextBox();
            this.lblGuessANumber = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.picRightWrong = new System.Windows.Forms.PictureBox();
            this.lblRightWrong = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picRightWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumGuess
            // 
            this.txtNumGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumGuess.Location = new System.Drawing.Point(688, 82);
            this.txtNumGuess.MaxLength = 1;
            this.txtNumGuess.Name = "txtNumGuess";
            this.txtNumGuess.Size = new System.Drawing.Size(100, 31);
            this.txtNumGuess.TabIndex = 0;
            // 
            // lblGuessANumber
            // 
            this.lblGuessANumber.AutoSize = true;
            this.lblGuessANumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessANumber.Location = new System.Drawing.Point(12, 82);
            this.lblGuessANumber.Name = "lblGuessANumber";
            this.lblGuessANumber.Size = new System.Drawing.Size(671, 25);
            this.lblGuessANumber.TabIndex = 1;
            this.lblGuessANumber.Text = "Guess a number from 1-10, maybe you\'ll get it right, maybe you won\'t";
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(58, 124);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(489, 88);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "GUESS!";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // picRightWrong
            // 
            this.picRightWrong.Image = global::NumberGuessTisham.Properties.Resources.checkmark1;
            this.picRightWrong.Location = new System.Drawing.Point(855, 40);
            this.picRightWrong.Name = "picRightWrong";
            this.picRightWrong.Size = new System.Drawing.Size(521, 490);
            this.picRightWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRightWrong.TabIndex = 4;
            this.picRightWrong.TabStop = false;
            // 
            // lblRightWrong
            // 
            this.lblRightWrong.AutoSize = true;
            this.lblRightWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightWrong.Location = new System.Drawing.Point(21, 339);
            this.lblRightWrong.Name = "lblRightWrong";
            this.lblRightWrong.Size = new System.Drawing.Size(156, 25);
            this.lblRightWrong.TabIndex = 5;
            this.lblRightWrong.Text = "Hidden for now";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(26, 457);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(335, 178);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "PLAY!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmNumberGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 660);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblRightWrong);
            this.Controls.Add(this.picRightWrong);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblGuessANumber);
            this.Controls.Add(this.txtNumGuess);
            this.Name = "frmNumberGuess";
            this.Text = "Number Guessing Game by Tisham, Islam";
            ((System.ComponentModel.ISupportInitialize)(this.picRightWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumGuess;
        private System.Windows.Forms.Label lblGuessANumber;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.PictureBox picRightWrong;
        private System.Windows.Forms.Label lblRightWrong;
        private System.Windows.Forms.Button btnPlay;
    }
}

