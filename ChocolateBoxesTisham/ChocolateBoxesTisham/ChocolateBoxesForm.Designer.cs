namespace ChocolateBoxesTisham
{
    partial class frmChocolateBoxes
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
            this.lblBoxesSold = new System.Windows.Forms.Label();
            this.txtNumberSold = new System.Windows.Forms.TextBox();
            this.btnPrize = new System.Windows.Forms.Button();
            this.lblPrize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBoxesSold
            // 
            this.lblBoxesSold.AutoSize = true;
            this.lblBoxesSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxesSold.Location = new System.Drawing.Point(50, 62);
            this.lblBoxesSold.Name = "lblBoxesSold";
            this.lblBoxesSold.Size = new System.Drawing.Size(385, 25);
            this.lblBoxesSold.TabIndex = 0;
            this.lblBoxesSold.Text = "Enter the number of boxes you\'ve sold:";
            // 
            // txtNumberSold
            // 
            this.txtNumberSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberSold.Location = new System.Drawing.Point(489, 62);
            this.txtNumberSold.MaxLength = 2;
            this.txtNumberSold.Name = "txtNumberSold";
            this.txtNumberSold.Size = new System.Drawing.Size(100, 31);
            this.txtNumberSold.TabIndex = 1;
            // 
            // btnPrize
            // 
            this.btnPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrize.Location = new System.Drawing.Point(699, 25);
            this.btnPrize.Name = "btnPrize";
            this.btnPrize.Size = new System.Drawing.Size(185, 105);
            this.btnPrize.TabIndex = 2;
            this.btnPrize.Text = "Get Prize!";
            this.btnPrize.UseVisualStyleBackColor = true;
            this.btnPrize.Click += new System.EventHandler(this.btnPrize_Click);
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.Location = new System.Drawing.Point(29, 214);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(196, 31);
            this.lblPrize.TabIndex = 3;
            this.lblPrize.Text = "Hidden for now";
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 450);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.btnPrize);
            this.Controls.Add(this.txtNumberSold);
            this.Controls.Add(this.lblBoxesSold);
            this.Name = "frmChocolateBoxes";
            this.Text = "ChocolateBoxes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBoxesSold;
        private System.Windows.Forms.TextBox txtNumberSold;
        private System.Windows.Forms.Button btnPrize;
        private System.Windows.Forms.Label lblPrize;
    }
}

