namespace Deal_Or_No_Arrow
{
    partial class TheEnd
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
            this.lblEarnedPts = new System.Windows.Forms.Label();
            this.lblBriefcaseVal = new System.Windows.Forms.Label();
            this.lblEarn = new System.Windows.Forms.Label();
            this.lblBrief = new System.Windows.Forms.Label();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.btnSaveScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEarnedPts
            // 
            this.lblEarnedPts.AutoSize = true;
            this.lblEarnedPts.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarnedPts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEarnedPts.Location = new System.Drawing.Point(351, 17);
            this.lblEarnedPts.Name = "lblEarnedPts";
            this.lblEarnedPts.Size = new System.Drawing.Size(244, 54);
            this.lblEarnedPts.TabIndex = 21;
            this.lblEarnedPts.Text = "0 POINTS";
            // 
            // lblBriefcaseVal
            // 
            this.lblBriefcaseVal.AutoSize = true;
            this.lblBriefcaseVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBriefcaseVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblBriefcaseVal.Location = new System.Drawing.Point(351, 108);
            this.lblBriefcaseVal.Name = "lblBriefcaseVal";
            this.lblBriefcaseVal.Size = new System.Drawing.Size(244, 54);
            this.lblBriefcaseVal.TabIndex = 22;
            this.lblBriefcaseVal.Text = "0 POINTS";
            // 
            // lblEarn
            // 
            this.lblEarn.AutoSize = true;
            this.lblEarn.Font = new System.Drawing.Font("Broadway", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarn.ForeColor = System.Drawing.Color.Yellow;
            this.lblEarn.Location = new System.Drawing.Point(12, 37);
            this.lblEarn.Name = "lblEarn";
            this.lblEarn.Size = new System.Drawing.Size(284, 32);
            this.lblEarn.TabIndex = 23;
            this.lblEarn.Text = "YOUR EARNINGS:";
            // 
            // lblBrief
            // 
            this.lblBrief.AutoSize = true;
            this.lblBrief.Font = new System.Drawing.Font("Broadway", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrief.ForeColor = System.Drawing.Color.Yellow;
            this.lblBrief.Location = new System.Drawing.Point(12, 127);
            this.lblBrief.Name = "lblBrief";
            this.lblBrief.Size = new System.Drawing.Size(299, 32);
            this.lblBrief.TabIndex = 24;
            this.lblBrief.Text = "YOUR BRIEFCASE:";
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReturnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMenu.Location = new System.Drawing.Point(18, 342);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(756, 85);
            this.btnReturnMenu.TabIndex = 25;
            this.btnReturnMenu.Text = "RETURN TO MENU";
            this.btnReturnMenu.UseVisualStyleBackColor = false;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // btnSaveScore
            // 
            this.btnSaveScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSaveScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveScore.Location = new System.Drawing.Point(18, 236);
            this.btnSaveScore.Name = "btnSaveScore";
            this.btnSaveScore.Size = new System.Drawing.Size(756, 85);
            this.btnSaveScore.TabIndex = 26;
            this.btnSaveScore.Text = "SAVE SCORE";
            this.btnSaveScore.UseVisualStyleBackColor = false;
            this.btnSaveScore.Click += new System.EventHandler(this.btnSaveScore_Click);
            // 
            // TheEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveScore);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.lblBrief);
            this.Controls.Add(this.lblEarn);
            this.Controls.Add(this.lblBriefcaseVal);
            this.Controls.Add(this.lblEarnedPts);
            this.Name = "TheEnd";
            this.Text = "TheEnd";
            this.Load += new System.EventHandler(this.TheEnd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEarnedPts;
        private System.Windows.Forms.Label lblBriefcaseVal;
        private System.Windows.Forms.Label lblEarn;
        private System.Windows.Forms.Label lblBrief;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Button btnSaveScore;
    }
}