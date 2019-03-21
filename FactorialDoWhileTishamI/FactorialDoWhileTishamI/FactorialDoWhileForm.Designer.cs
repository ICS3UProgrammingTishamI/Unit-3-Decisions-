namespace FactorialDoWhileTishamI
{
    partial class frmFactorialDoWhile
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
            this.lstFactorialMultipliers = new System.Windows.Forms.ListBox();
            this.lblEnterNumber = new System.Windows.Forms.Label();
            this.txtFactorialNumber = new System.Windows.Forms.TextBox();
            this.lblFactorialAnswer = new System.Windows.Forms.Label();
            this.btnFactorialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFactorialMultipliers
            // 
            this.lstFactorialMultipliers.FormattingEnabled = true;
            this.lstFactorialMultipliers.Location = new System.Drawing.Point(44, 118);
            this.lstFactorialMultipliers.Name = "lstFactorialMultipliers";
            this.lstFactorialMultipliers.Size = new System.Drawing.Size(379, 173);
            this.lstFactorialMultipliers.TabIndex = 0;
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.Location = new System.Drawing.Point(90, 45);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(199, 13);
            this.lblEnterNumber.TabIndex = 1;
            this.lblEnterNumber.Text = "Enter the number you want to factorialize";
            // 
            // txtFactorialNumber
            // 
            this.txtFactorialNumber.Location = new System.Drawing.Point(323, 45);
            this.txtFactorialNumber.Name = "txtFactorialNumber";
            this.txtFactorialNumber.Size = new System.Drawing.Size(100, 20);
            this.txtFactorialNumber.TabIndex = 2;
            // 
            // lblFactorialAnswer
            // 
            this.lblFactorialAnswer.AutoSize = true;
            this.lblFactorialAnswer.Location = new System.Drawing.Point(93, 304);
            this.lblFactorialAnswer.Name = "lblFactorialAnswer";
            this.lblFactorialAnswer.Size = new System.Drawing.Size(84, 13);
            this.lblFactorialAnswer.TabIndex = 3;
            this.lblFactorialAnswer.Text = "Hidden For Now";
            // 
            // btnFactorialize
            // 
            this.btnFactorialize.Font = new System.Drawing.Font("Yu Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorialize.Location = new System.Drawing.Point(470, 12);
            this.btnFactorialize.Name = "btnFactorialize";
            this.btnFactorialize.Size = new System.Drawing.Size(280, 90);
            this.btnFactorialize.TabIndex = 4;
            this.btnFactorialize.Text = "FACTORIALIZE!";
            this.btnFactorialize.UseVisualStyleBackColor = true;
            this.btnFactorialize.Click += new System.EventHandler(this.btnFactorialize_Click);
            // 
            // frmFactorialDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFactorialize);
            this.Controls.Add(this.lblFactorialAnswer);
            this.Controls.Add(this.txtFactorialNumber);
            this.Controls.Add(this.lblEnterNumber);
            this.Controls.Add(this.lstFactorialMultipliers);
            this.Name = "frmFactorialDoWhile";
            this.Text = "Factorial Do While by Tisham Islam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFactorialMultipliers;
        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.TextBox txtFactorialNumber;
        private System.Windows.Forms.Label lblFactorialAnswer;
        private System.Windows.Forms.Button btnFactorialize;
    }
}

