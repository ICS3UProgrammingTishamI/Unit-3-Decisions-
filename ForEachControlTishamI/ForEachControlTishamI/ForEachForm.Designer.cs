namespace ForEachControlTishamI
{
    partial class frmForEach
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
            this.lblBasicName = new System.Windows.Forms.Label();
            this.lblColours = new System.Windows.Forms.Label();
            this.btnColours = new System.Windows.Forms.Button();
            this.lst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblBasicName
            // 
            this.lblBasicName.AutoSize = true;
            this.lblBasicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicName.Location = new System.Drawing.Point(82, 151);
            this.lblBasicName.Name = "lblBasicName";
            this.lblBasicName.Size = new System.Drawing.Size(381, 25);
            this.lblBasicName.TabIndex = 0;
            this.lblBasicName.Text = "I don\'t know what to name these labels";
            // 
            // lblColours
            // 
            this.lblColours.AutoSize = true;
            this.lblColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColours.Location = new System.Drawing.Point(298, 231);
            this.lblColours.Name = "lblColours";
            this.lblColours.Size = new System.Drawing.Size(402, 25);
            this.lblColours.TabIndex = 1;
            this.lblColours.Text = "Click the button to make colours change!";
            // 
            // btnColours
            // 
            this.btnColours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColours.Location = new System.Drawing.Point(279, 12);
            this.btnColours.Name = "btnColours";
            this.btnColours.Size = new System.Drawing.Size(360, 76);
            this.btnColours.TabIndex = 2;
            this.btnColours.Text = "COLOUR CHANGE!";
            this.btnColours.UseVisualStyleBackColor = true;
            this.btnColours.Click += new System.EventHandler(this.btnColours_Click);
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.Location = new System.Drawing.Point(87, 253);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(120, 95);
            this.lst.TabIndex = 3;
            // 
            // frmForEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.btnColours);
            this.Controls.Add(this.lblColours);
            this.Controls.Add(this.lblBasicName);
            this.Name = "frmForEach";
            this.Text = "For Each by Tisham Islam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBasicName;
        private System.Windows.Forms.Label lblColours;
        private System.Windows.Forms.Button btnColours;
        private System.Windows.Forms.ListBox lst;
    }
}

