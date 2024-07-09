namespace Deal_Or_No_Arrow
{
    partial class Form1
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
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.btnHelp1 = new System.Windows.Forms.Button();
            this.btnInfo1 = new System.Windows.Forms.Button();
            this.btnLeaderboard1 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTitle1.Location = new System.Drawing.Point(211, 53);
            this.lblTitle1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(663, 91);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "Deal or No Arrow";
            // 
            // btnHelp1
            // 
            this.btnHelp1.BackColor = System.Drawing.Color.Khaki;
            this.btnHelp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp1.ForeColor = System.Drawing.Color.Black;
            this.btnHelp1.Location = new System.Drawing.Point(373, 263);
            this.btnHelp1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHelp1.Name = "btnHelp1";
            this.btnHelp1.Size = new System.Drawing.Size(333, 81);
            this.btnHelp1.TabIndex = 2;
            this.btnHelp1.Text = "HELP";
            this.btnHelp1.UseVisualStyleBackColor = false;
            this.btnHelp1.Click += new System.EventHandler(this.btnHelp1_Click);
            // 
            // btnInfo1
            // 
            this.btnInfo1.BackColor = System.Drawing.Color.Khaki;
            this.btnInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo1.ForeColor = System.Drawing.Color.Black;
            this.btnInfo1.Location = new System.Drawing.Point(16, 263);
            this.btnInfo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInfo1.Name = "btnInfo1";
            this.btnInfo1.Size = new System.Drawing.Size(333, 81);
            this.btnInfo1.TabIndex = 3;
            this.btnInfo1.Text = "INFO";
            this.btnInfo1.UseVisualStyleBackColor = false;
            this.btnInfo1.Click += new System.EventHandler(this.btnInfo1_Click);
            // 
            // btnLeaderboard1
            // 
            this.btnLeaderboard1.BackColor = System.Drawing.Color.Khaki;
            this.btnLeaderboard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderboard1.ForeColor = System.Drawing.Color.Black;
            this.btnLeaderboard1.Location = new System.Drawing.Point(717, 263);
            this.btnLeaderboard1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeaderboard1.Name = "btnLeaderboard1";
            this.btnLeaderboard1.Size = new System.Drawing.Size(333, 81);
            this.btnLeaderboard1.TabIndex = 4;
            this.btnLeaderboard1.Text = "STATS";
            this.btnLeaderboard1.UseVisualStyleBackColor = false;
            this.btnLeaderboard1.Click += new System.EventHandler(this.btnLeaderboard1_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.YellowGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(16, 402);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(415, 137);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(636, 402);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(415, 137);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLeaderboard1);
            this.Controls.Add(this.btnInfo1);
            this.Controls.Add(this.btnHelp1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitle1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Button btnHelp1;
        private System.Windows.Forms.Button btnInfo1;
        private System.Windows.Forms.Button btnLeaderboard1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
    }
}

