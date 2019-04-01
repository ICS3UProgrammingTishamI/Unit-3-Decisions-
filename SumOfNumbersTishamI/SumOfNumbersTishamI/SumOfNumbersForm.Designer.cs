namespace SumOfNumbersTishamI
{
    partial class frmSumOfNumbers
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
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.btnCalculatirize = new System.Windows.Forms.Button();
            this.lblFunFact = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(193, 102);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(282, 238);
            this.lstNumbers.TabIndex = 1;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(21, 374);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(412, 25);
            this.lblSum.TabIndex = 2;
            this.lblSum.Text = "Your sum is arriving soon, please wait . . .";
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(274, 33);
            this.nudNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(120, 20);
            this.nudNumber.TabIndex = 3;
            // 
            // btnCalculatirize
            // 
            this.btnCalculatirize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatirize.Location = new System.Drawing.Point(181, 59);
            this.btnCalculatirize.Name = "btnCalculatirize";
            this.btnCalculatirize.Size = new System.Drawing.Size(306, 37);
            this.btnCalculatirize.TabIndex = 4;
            this.btnCalculatirize.Text = "CALCULATIRIZE";
            this.btnCalculatirize.UseVisualStyleBackColor = true;
            this.btnCalculatirize.Click += new System.EventHandler(this.btnCalculatirize_Click);
            // 
            // lblFunFact
            // 
            this.lblFunFact.AutoSize = true;
            this.lblFunFact.Font = new System.Drawing.Font("Adobe Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunFact.Location = new System.Drawing.Point(65, 357);
            this.lblFunFact.Name = "lblFunFact";
            this.lblFunFact.Size = new System.Drawing.Size(279, 17);
            this.lblFunFact.TabIndex = 5;
            this.lblFunFact.Text = "Fun fact: The equation to calculate this is x * (x/2 + 0.5)";
            // 
            // frmSumOfNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.lblFunFact);
            this.Controls.Add(this.btnCalculatirize);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lstNumbers);
            this.Name = "frmSumOfNumbers";
            this.Text = "Sum of Numbers By Tisham Islam";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Button btnCalculatirize;
        private System.Windows.Forms.Label lblFunFact;
    }
}

