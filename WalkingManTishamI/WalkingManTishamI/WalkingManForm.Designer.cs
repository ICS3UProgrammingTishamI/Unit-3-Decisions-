namespace WalkingManTishamI
{
    partial class frmWalkingMan
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
            this.picWalker = new System.Windows.Forms.PictureBox();
            this.btnWalk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWalker)).BeginInit();
            this.SuspendLayout();
            // 
            // picWalker
            // 
            this.picWalker.Image = global::WalkingManTishamI.Properties.Resources.walk10;
            this.picWalker.Location = new System.Drawing.Point(230, 130);
            this.picWalker.Name = "picWalker";
            this.picWalker.Size = new System.Drawing.Size(259, 231);
            this.picWalker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWalker.TabIndex = 0;
            this.picWalker.TabStop = false;
            // 
            // btnWalk
            // 
            this.btnWalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWalk.Location = new System.Drawing.Point(253, 45);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(202, 79);
            this.btnWalk.TabIndex = 1;
            this.btnWalk.Text = "Walk, man!";
            this.btnWalk.UseVisualStyleBackColor = true;
            this.btnWalk.Click += new System.EventHandler(this.btnWalk_Click);
            // 
            // frmWalkingMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWalk);
            this.Controls.Add(this.picWalker);
            this.Name = "frmWalkingMan";
            this.Text = "Walking Man By Tisham Islam";
            ((System.ComponentModel.ISupportInitialize)(this.picWalker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picWalker;
        private System.Windows.Forms.Button btnWalk;
    }
}

