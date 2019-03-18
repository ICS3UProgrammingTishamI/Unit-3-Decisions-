namespace RockPaperScissors
{
    partial class frmRockPaperScissors
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblPlay = new System.Windows.Forms.Label();
            this.grbComputerChoice = new System.Windows.Forms.GroupBox();
            this.radScissorsC = new System.Windows.Forms.RadioButton();
            this.radPaperC = new System.Windows.Forms.RadioButton();
            this.radRockC = new System.Windows.Forms.RadioButton();
            this.grbPlayerChoice = new System.Windows.Forms.GroupBox();
            this.radScissorsP = new System.Windows.Forms.RadioButton();
            this.radRockP = new System.Windows.Forms.RadioButton();
            this.radPaperP = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.grbComputerChoice.SuspendLayout();
            this.grbPlayerChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(266, 365);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(234, 73);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "PLAY!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.Location = new System.Drawing.Point(24, 41);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(437, 25);
            this.lblPlay.TabIndex = 1;
            this.lblPlay.Text = "Choose your fighter, then hit the play button!";
            // 
            // grbComputerChoice
            // 
            this.grbComputerChoice.Controls.Add(this.radScissorsC);
            this.grbComputerChoice.Controls.Add(this.radPaperC);
            this.grbComputerChoice.Controls.Add(this.radRockC);
            this.grbComputerChoice.Location = new System.Drawing.Point(476, 99);
            this.grbComputerChoice.Name = "grbComputerChoice";
            this.grbComputerChoice.Size = new System.Drawing.Size(308, 251);
            this.grbComputerChoice.TabIndex = 2;
            this.grbComputerChoice.TabStop = false;
            this.grbComputerChoice.Text = "Computer\'s \"Choice\"";
            // 
            // radScissorsC
            // 
            this.radScissorsC.AutoSize = true;
            this.radScissorsC.Location = new System.Drawing.Point(112, 182);
            this.radScissorsC.Name = "radScissorsC";
            this.radScissorsC.Size = new System.Drawing.Size(64, 17);
            this.radScissorsC.TabIndex = 3;
            this.radScissorsC.TabStop = true;
            this.radScissorsC.Text = "Scissors";
            this.radScissorsC.UseVisualStyleBackColor = true;
            // 
            // radPaperC
            // 
            this.radPaperC.AutoSize = true;
            this.radPaperC.Location = new System.Drawing.Point(112, 113);
            this.radPaperC.Name = "radPaperC";
            this.radPaperC.Size = new System.Drawing.Size(53, 17);
            this.radPaperC.TabIndex = 2;
            this.radPaperC.TabStop = true;
            this.radPaperC.Text = "Paper";
            this.radPaperC.UseVisualStyleBackColor = true;
            // 
            // radRockC
            // 
            this.radRockC.AutoSize = true;
            this.radRockC.Location = new System.Drawing.Point(112, 55);
            this.radRockC.Name = "radRockC";
            this.radRockC.Size = new System.Drawing.Size(51, 17);
            this.radRockC.TabIndex = 1;
            this.radRockC.TabStop = true;
            this.radRockC.Text = "Rock";
            this.radRockC.UseVisualStyleBackColor = true;
            // 
            // grbPlayerChoice
            // 
            this.grbPlayerChoice.Controls.Add(this.radScissorsP);
            this.grbPlayerChoice.Controls.Add(this.radRockP);
            this.grbPlayerChoice.Controls.Add(this.radPaperP);
            this.grbPlayerChoice.Location = new System.Drawing.Point(29, 99);
            this.grbPlayerChoice.Name = "grbPlayerChoice";
            this.grbPlayerChoice.Size = new System.Drawing.Size(308, 251);
            this.grbPlayerChoice.TabIndex = 3;
            this.grbPlayerChoice.TabStop = false;
            this.grbPlayerChoice.Text = "Your Choice";
            // 
            // radScissorsP
            // 
            this.radScissorsP.AutoSize = true;
            this.radScissorsP.Location = new System.Drawing.Point(78, 182);
            this.radScissorsP.Name = "radScissorsP";
            this.radScissorsP.Size = new System.Drawing.Size(64, 17);
            this.radScissorsP.TabIndex = 2;
            this.radScissorsP.TabStop = true;
            this.radScissorsP.Text = "Scissors";
            this.radScissorsP.UseVisualStyleBackColor = true;
            // 
            // radRockP
            // 
            this.radRockP.AutoSize = true;
            this.radRockP.Location = new System.Drawing.Point(78, 55);
            this.radRockP.Name = "radRockP";
            this.radRockP.Size = new System.Drawing.Size(51, 17);
            this.radRockP.TabIndex = 1;
            this.radRockP.TabStop = true;
            this.radRockP.Text = "Rock";
            this.radRockP.UseVisualStyleBackColor = true;
            // 
            // radPaperP
            // 
            this.radPaperP.AutoSize = true;
            this.radPaperP.Location = new System.Drawing.Point(78, 113);
            this.radPaperP.Name = "radPaperP";
            this.radPaperP.Size = new System.Drawing.Size(53, 17);
            this.radPaperP.TabIndex = 0;
            this.radPaperP.TabStop = true;
            this.radPaperP.Text = "Paper";
            this.radPaperP.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Onky", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(535, 52);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(190, 21);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Hidden for now";
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grbPlayerChoice);
            this.Controls.Add(this.grbComputerChoice);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.btnPlay);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock Paper Scissors by Tisham Islam";
            this.grbComputerChoice.ResumeLayout(false);
            this.grbComputerChoice.PerformLayout();
            this.grbPlayerChoice.ResumeLayout(false);
            this.grbPlayerChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.GroupBox grbComputerChoice;
        private System.Windows.Forms.GroupBox grbPlayerChoice;
        private System.Windows.Forms.RadioButton radScissorsC;
        private System.Windows.Forms.RadioButton radPaperC;
        private System.Windows.Forms.RadioButton radRockC;
        private System.Windows.Forms.RadioButton radScissorsP;
        private System.Windows.Forms.RadioButton radRockP;
        private System.Windows.Forms.RadioButton radPaperP;
        private System.Windows.Forms.Label lblResult;
    }
}

