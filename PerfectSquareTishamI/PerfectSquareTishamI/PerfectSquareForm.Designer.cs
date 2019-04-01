namespace PerfectSquareTishamI
{
    partial class frmPerfectSquare
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nudEndVal = new System.Windows.Forms.NumericUpDown();
            this.lstSquares = new System.Windows.Forms.ListBox();
            this.lblSquareDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndVal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(305, 51);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(153, 40);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nudEndVal
            // 
            this.nudEndVal.Location = new System.Drawing.Point(305, 115);
            this.nudEndVal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudEndVal.Name = "nudEndVal";
            this.nudEndVal.Size = new System.Drawing.Size(120, 20);
            this.nudEndVal.TabIndex = 1;
            // 
            // lstSquares
            // 
            this.lstSquares.FormattingEnabled = true;
            this.lstSquares.Location = new System.Drawing.Point(283, 151);
            this.lstSquares.Name = "lstSquares";
            this.lstSquares.Size = new System.Drawing.Size(198, 134);
            this.lstSquares.TabIndex = 2;
            // 
            // lblSquareDisplay
            // 
            this.lblSquareDisplay.AutoSize = true;
            this.lblSquareDisplay.Location = new System.Drawing.Point(305, 314);
            this.lblSquareDisplay.Name = "lblSquareDisplay";
            this.lblSquareDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblSquareDisplay.TabIndex = 3;
            // 
            // frmPerfectSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSquareDisplay);
            this.Controls.Add(this.lstSquares);
            this.Controls.Add(this.nudEndVal);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmPerfectSquare";
            this.Text = "Perfect Square by Tisham Islam";
            ((System.ComponentModel.ISupportInitialize)(this.nudEndVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudEndVal;
        private System.Windows.Forms.ListBox lstSquares;
        private System.Windows.Forms.Label lblSquareDisplay;
    }
}

