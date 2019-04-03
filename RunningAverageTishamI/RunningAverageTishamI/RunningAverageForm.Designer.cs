namespace RunningAverageTishamI
{
    partial class frmRunningAverage
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
            this.lblRunningAverage = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nudNumbers = new System.Windows.Forms.NumericUpDown();
            this.lblNotice = new System.Windows.Forms.Label();
            this.lblCalculations = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRunningAverage
            // 
            this.lblRunningAverage.AutoSize = true;
            this.lblRunningAverage.Location = new System.Drawing.Point(240, 24);
            this.lblRunningAverage.Name = "lblRunningAverage";
            this.lblRunningAverage.Size = new System.Drawing.Size(144, 13);
            this.lblRunningAverage.TabIndex = 0;
            this.lblRunningAverage.Text = "Enter a number from 0 to 100";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(232, 110);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(168, 65);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nudNumbers
            // 
            this.nudNumbers.Location = new System.Drawing.Point(243, 64);
            this.nudNumbers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudNumbers.Name = "nudNumbers";
            this.nudNumbers.Size = new System.Drawing.Size(120, 20);
            this.nudNumbers.TabIndex = 2;
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Location = new System.Drawing.Point(236, 37);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(164, 13);
            this.lblNotice.TabIndex = 3;
            this.lblNotice.Text = "Enter -1 in order to reset the thing";
            // 
            // lblCalculations
            // 
            this.lblCalculations.AutoSize = true;
            this.lblCalculations.Location = new System.Drawing.Point(232, 214);
            this.lblCalculations.Name = "lblCalculations";
            this.lblCalculations.Size = new System.Drawing.Size(79, 13);
            this.lblCalculations.TabIndex = 4;
            this.lblCalculations.Text = "Hidden for now";
            // 
            // frmRunningAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCalculations);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.nudNumbers);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblRunningAverage);
            this.Name = "frmRunningAverage";
            this.Text = "Running Average";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRunningAverage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudNumbers;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Label lblCalculations;
    }
}

