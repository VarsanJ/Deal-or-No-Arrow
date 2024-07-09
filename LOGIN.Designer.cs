namespace Deal_Or_No_Arrow
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.txtCreate = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.pcbDeco2 = new System.Windows.Forms.PictureBox();
            this.pcbBriefCase = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeco2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBriefCase)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCreate
            // 
            this.txtCreate.BackColor = System.Drawing.Color.White;
            this.txtCreate.Location = new System.Drawing.Point(22, 189);
            this.txtCreate.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreate.MaxLength = 10;
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(294, 22);
            this.txtCreate.TabIndex = 0;
            this.txtCreate.TextChanged += new System.EventHandler(this.txtCreate_TextChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(22, 244);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(224, 48);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "PROCEED";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.Yellow;
            this.lblDetails.Location = new System.Drawing.Point(4, 489);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(1065, 20);
            this.lblDetails.TabIndex = 5;
            this.lblDetails.Text = "Please enter your username. If you want to try and beat a previous score, enter t" +
    "hat username! Username max 10 characters.";
            this.lblDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNew.Location = new System.Drawing.Point(13, 9);
            this.lblNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(170, 54);
            this.lblNew.TabIndex = 7;
            this.lblNew.Text = "LOGIN";
            this.lblNew.Click += new System.EventHandler(this.lblNew_Click);
            // 
            // pcbDeco2
            // 
            this.pcbDeco2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pcbDeco2.Location = new System.Drawing.Point(-4, 439);
            this.pcbDeco2.Margin = new System.Windows.Forms.Padding(4);
            this.pcbDeco2.Name = "pcbDeco2";
            this.pcbDeco2.Size = new System.Drawing.Size(1171, 30);
            this.pcbDeco2.TabIndex = 8;
            this.pcbDeco2.TabStop = false;
            // 
            // pcbBriefCase
            // 
            this.pcbBriefCase.BackColor = System.Drawing.Color.Yellow;
            this.pcbBriefCase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbBriefCase.BackgroundImage")));
            this.pcbBriefCase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbBriefCase.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pcbBriefCase.Location = new System.Drawing.Point(399, 12);
            this.pcbBriefCase.Name = "pcbBriefCase";
            this.pcbBriefCase.Size = new System.Drawing.Size(670, 420);
            this.pcbBriefCase.TabIndex = 9;
            this.pcbBriefCase.TabStop = false;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1163, 554);
            this.Controls.Add(this.pcbBriefCase);
            this.Controls.Add(this.pcbDeco2);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtCreate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeco2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBriefCase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.PictureBox pcbDeco2;
        private System.Windows.Forms.PictureBox pcbBriefCase;
    }
}