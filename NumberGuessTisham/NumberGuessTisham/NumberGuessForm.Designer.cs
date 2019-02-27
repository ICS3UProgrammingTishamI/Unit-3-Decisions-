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
            this.picInCorrect = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picInCorrect)).BeginInit();
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
            // 
            // picInCorrect
            // 
            this.picInCorrect.Image = global::NumberGuessTisham.Properties.Resources.checkmark1;
            this.picInCorrect.Location = new System.Drawing.Point(855, 40);
            this.picInCorrect.Name = "picInCorrect";
            this.picInCorrect.Size = new System.Drawing.Size(521, 490);
            this.picInCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInCorrect.TabIndex = 4;
            this.picInCorrect.TabStop = false;
            // 
            // frmNumberGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 660);
            this.Controls.Add(this.picInCorrect);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblGuessANumber);
            this.Controls.Add(this.txtNumGuess);
            this.Name = "frmNumberGuess";
            this.Text = "Number Guessing Game by Tisham, Islam";
            ((System.ComponentModel.ISupportInitialize)(this.picInCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumGuess;
        private System.Windows.Forms.Label lblGuessANumber;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.PictureBox picInCorrect;
    }
}

