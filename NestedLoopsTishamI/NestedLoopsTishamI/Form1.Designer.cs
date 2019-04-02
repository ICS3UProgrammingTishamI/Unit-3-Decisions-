namespace NestedLoopsTishamI
{
    partial class frmNestedLoops
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
            this.btnListUnicode = new System.Windows.Forms.Button();
            this.lstUnicode = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListUnicode
            // 
            this.btnListUnicode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListUnicode.Location = new System.Drawing.Point(236, 39);
            this.btnListUnicode.Name = "btnListUnicode";
            this.btnListUnicode.Size = new System.Drawing.Size(221, 90);
            this.btnListUnicode.TabIndex = 0;
            this.btnListUnicode.Text = "LIST UNICODE";
            this.btnListUnicode.UseVisualStyleBackColor = true;
            this.btnListUnicode.Click += new System.EventHandler(this.btnListUnicode_Click);
            // 
            // lstUnicode
            // 
            this.lstUnicode.FormattingEnabled = true;
            this.lstUnicode.Location = new System.Drawing.Point(236, 150);
            this.lstUnicode.Name = "lstUnicode";
            this.lstUnicode.Size = new System.Drawing.Size(221, 225);
            this.lstUnicode.TabIndex = 1;
            // 
            // frmNestedLoops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstUnicode);
            this.Controls.Add(this.btnListUnicode);
            this.Name = "frmNestedLoops";
            this.Text = "Nested Loops by Tisham Islam";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListUnicode;
        private System.Windows.Forms.ListBox lstUnicode;
    }
}

