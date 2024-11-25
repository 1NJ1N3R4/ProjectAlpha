namespace ProjectAlpha
{
    partial class LoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.siticoneProgressBar1 = new Siticone.Desktop.UI.WinForms.SiticoneProgressBar();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.credits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneProgressBar1
            // 
            this.siticoneProgressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.siticoneProgressBar1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.siticoneProgressBar1.Location = new System.Drawing.Point(12, 147);
            this.siticoneProgressBar1.Name = "siticoneProgressBar1";
            this.siticoneProgressBar1.ProgressColor = System.Drawing.SystemColors.Highlight;
            this.siticoneProgressBar1.ProgressColor2 = System.Drawing.SystemColors.Highlight;
            this.siticoneProgressBar1.Size = new System.Drawing.Size(376, 30);
            this.siticoneProgressBar1.TabIndex = 1;
            this.siticoneProgressBar1.Text = "siticoneProgressBar1";
            this.siticoneProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.siticoneProgressBar1.ValueChanged += new System.EventHandler(this.siticoneProgressBar1_ValueChanged);
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(140, 15);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.Size = new System.Drawing.Size(128, 128);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticonePictureBox1.TabIndex = 2;
            this.siticonePictureBox1.TabStop = false;
            this.siticonePictureBox1.UseTransparentBackground = true;
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.credits.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.credits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.credits.Location = new System.Drawing.Point(153, 180);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(105, 13);
            this.credits.TabIndex = 3;
            this.credits.Text = "MADE BY 1NJ1N3R4";
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.siticonePictureBox1);
            this.Controls.Add(this.siticoneProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WELCOME";
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneProgressBar siticoneProgressBar1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private System.Windows.Forms.Label credits;
    }
}