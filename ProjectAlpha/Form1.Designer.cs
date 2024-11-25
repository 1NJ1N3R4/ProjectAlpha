namespace ProjectAlpha
{
    partial class ProjectAlpha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectAlpha));
            this.closeButton = new System.Windows.Forms.Button();
            this.minimiseButton = new System.Windows.Forms.Button();
            this.helmetSelect = new System.Windows.Forms.Button();
            this.chestplateSelect = new System.Windows.Forms.Button();
            this.legginsSelect = new System.Windows.Forms.Button();
            this.bootsSelect = new System.Windows.Forms.Button();
            this.switchbootsSelect = new System.Windows.Forms.Button();
            this.switchlegginsSelect = new System.Windows.Forms.Button();
            this.switchchestplateSelect = new System.Windows.Forms.Button();
            this.switchhelmetSelect = new System.Windows.Forms.Button();
            this.selectHotkey = new System.Windows.Forms.Button();
            this.selectInventoryKey = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.milisecondsChange = new System.Windows.Forms.TrackBar();
            this.milisecondsValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.milisecondsChange)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.closeButton.Location = new System.Drawing.Point(277, 2);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "✕";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimiseButton
            // 
            this.minimiseButton.FlatAppearance.BorderSize = 0;
            this.minimiseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.minimiseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.minimiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimiseButton.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.minimiseButton.Location = new System.Drawing.Point(257, 2);
            this.minimiseButton.Margin = new System.Windows.Forms.Padding(2);
            this.minimiseButton.Name = "minimiseButton";
            this.minimiseButton.Size = new System.Drawing.Size(20, 20);
            this.minimiseButton.TabIndex = 1;
            this.minimiseButton.Text = "🗕";
            this.minimiseButton.UseVisualStyleBackColor = true;
            this.minimiseButton.Click += new System.EventHandler(this.minimiseButton_Click);
            // 
            // helmetSelect
            // 
            this.helmetSelect.BackColor = System.Drawing.SystemColors.Highlight;
            this.helmetSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helmetSelect.Image = ((System.Drawing.Image)(resources.GetObject("helmetSelect.Image")));
            this.helmetSelect.Location = new System.Drawing.Point(12, 12);
            this.helmetSelect.Name = "helmetSelect";
            this.helmetSelect.Size = new System.Drawing.Size(50, 50);
            this.helmetSelect.TabIndex = 2;
            this.helmetSelect.UseVisualStyleBackColor = false;
            this.helmetSelect.Click += new System.EventHandler(this.helmetSelect_Click);
            // 
            // chestplateSelect
            // 
            this.chestplateSelect.BackColor = System.Drawing.SystemColors.Highlight;
            this.chestplateSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chestplateSelect.Image = ((System.Drawing.Image)(resources.GetObject("chestplateSelect.Image")));
            this.chestplateSelect.Location = new System.Drawing.Point(68, 12);
            this.chestplateSelect.Name = "chestplateSelect";
            this.chestplateSelect.Size = new System.Drawing.Size(50, 50);
            this.chestplateSelect.TabIndex = 3;
            this.chestplateSelect.UseVisualStyleBackColor = false;
            this.chestplateSelect.Click += new System.EventHandler(this.chestplateSelect_Click);
            // 
            // legginsSelect
            // 
            this.legginsSelect.BackColor = System.Drawing.SystemColors.Highlight;
            this.legginsSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.legginsSelect.Image = ((System.Drawing.Image)(resources.GetObject("legginsSelect.Image")));
            this.legginsSelect.Location = new System.Drawing.Point(124, 12);
            this.legginsSelect.Name = "legginsSelect";
            this.legginsSelect.Size = new System.Drawing.Size(50, 50);
            this.legginsSelect.TabIndex = 4;
            this.legginsSelect.UseVisualStyleBackColor = false;
            this.legginsSelect.Click += new System.EventHandler(this.legginsSelect_Click);
            // 
            // bootsSelect
            // 
            this.bootsSelect.BackColor = System.Drawing.SystemColors.Highlight;
            this.bootsSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootsSelect.Image = ((System.Drawing.Image)(resources.GetObject("bootsSelect.Image")));
            this.bootsSelect.Location = new System.Drawing.Point(180, 12);
            this.bootsSelect.Name = "bootsSelect";
            this.bootsSelect.Size = new System.Drawing.Size(50, 50);
            this.bootsSelect.TabIndex = 5;
            this.bootsSelect.UseVisualStyleBackColor = false;
            this.bootsSelect.Click += new System.EventHandler(this.bootsSelect_Click);
            // 
            // switchbootsSelect
            // 
            this.switchbootsSelect.BackColor = System.Drawing.SystemColors.Highlight;
            this.switchbootsSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchbootsSelect.Image = ((System.Drawing.Image)(resources.GetObject("switchbootsSelect.Image")));
            this.switchbootsSelect.Location = new System.Drawing.Point(180, 68);
            this.switchbootsSelect.Name = "switchbootsSelect";
            this.switchbootsSelect.Size = new System.Drawing.Size(50, 50);
            this.switchbootsSelect.TabIndex = 9;
            this.switchbootsSelect.UseVisualStyleBackColor = false;
            this.switchbootsSelect.Click += new System.EventHandler(this.switchbootsSelect_Click);
            // 
            // switchlegginsSelect
            // 
            this.switchlegginsSelect.BackColor = System.Drawing.SystemColors.Highlight;
            this.switchlegginsSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchlegginsSelect.Image = ((System.Drawing.Image)(resources.GetObject("switchlegginsSelect.Image")));
            this.switchlegginsSelect.Location = new System.Drawing.Point(124, 68);
            this.switchlegginsSelect.Name = "switchlegginsSelect";
            this.switchlegginsSelect.Size = new System.Drawing.Size(50, 50);
            this.switchlegginsSelect.TabIndex = 8;
            this.switchlegginsSelect.UseVisualStyleBackColor = false;
            this.switchlegginsSelect.Click += new System.EventHandler(this.switchlegginsSelect_Click);
            // 
            // switchchestplateSelect
            // 
            this.switchchestplateSelect.BackColor = System.Drawing.SystemColors.Highlight;
            this.switchchestplateSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchchestplateSelect.Image = ((System.Drawing.Image)(resources.GetObject("switchchestplateSelect.Image")));
            this.switchchestplateSelect.Location = new System.Drawing.Point(68, 68);
            this.switchchestplateSelect.Name = "switchchestplateSelect";
            this.switchchestplateSelect.Size = new System.Drawing.Size(50, 50);
            this.switchchestplateSelect.TabIndex = 7;
            this.switchchestplateSelect.UseVisualStyleBackColor = false;
            this.switchchestplateSelect.Click += new System.EventHandler(this.switchchestplateSelect_Click);
            // 
            // switchhelmetSelect
            // 
            this.switchhelmetSelect.BackColor = System.Drawing.SystemColors.Highlight;
            this.switchhelmetSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchhelmetSelect.Image = ((System.Drawing.Image)(resources.GetObject("switchhelmetSelect.Image")));
            this.switchhelmetSelect.Location = new System.Drawing.Point(12, 68);
            this.switchhelmetSelect.Name = "switchhelmetSelect";
            this.switchhelmetSelect.Size = new System.Drawing.Size(50, 50);
            this.switchhelmetSelect.TabIndex = 6;
            this.switchhelmetSelect.UseVisualStyleBackColor = false;
            this.switchhelmetSelect.Click += new System.EventHandler(this.switchhelmetSelect_Click);
            // 
            // selectHotkey
            // 
            this.selectHotkey.BackColor = System.Drawing.SystemColors.Highlight;
            this.selectHotkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectHotkey.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.selectHotkey.Location = new System.Drawing.Point(12, 155);
            this.selectHotkey.Name = "selectHotkey";
            this.selectHotkey.Size = new System.Drawing.Size(218, 44);
            this.selectHotkey.TabIndex = 10;
            this.selectHotkey.Text = "PRESS TO ADD HOTKEY";
            this.selectHotkey.UseVisualStyleBackColor = false;
            this.selectHotkey.Click += new System.EventHandler(this.selectHotkey_Click);
            // 
            // selectInventoryKey
            // 
            this.selectInventoryKey.BackColor = System.Drawing.SystemColors.Highlight;
            this.selectInventoryKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectInventoryKey.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.selectInventoryKey.Location = new System.Drawing.Point(244, 155);
            this.selectInventoryKey.Name = "selectInventoryKey";
            this.selectInventoryKey.Size = new System.Drawing.Size(44, 44);
            this.selectInventoryKey.TabIndex = 11;
            this.selectInventoryKey.Text = "?";
            this.selectInventoryKey.UseVisualStyleBackColor = false;
            this.selectInventoryKey.Click += new System.EventHandler(this.selectInventoryKey_Click);
            this.selectInventoryKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.selectInventoryKey_KeyDown);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(12, 125);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 24);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "SAVE SETTINGS";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold);
            this.loadButton.Location = new System.Drawing.Point(124, 125);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(106, 24);
            this.loadButton.TabIndex = 13;
            this.loadButton.Text = "LOAD SETTINGS";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // milisecondsChange
            // 
            this.milisecondsChange.Location = new System.Drawing.Point(232, 27);
            this.milisecondsChange.Maximum = 40;
            this.milisecondsChange.Name = "milisecondsChange";
            this.milisecondsChange.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.milisecondsChange.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.milisecondsChange.RightToLeftLayout = true;
            this.milisecondsChange.Size = new System.Drawing.Size(45, 91);
            this.milisecondsChange.TabIndex = 14;
            this.milisecondsChange.TickStyle = System.Windows.Forms.TickStyle.None;
            this.milisecondsChange.Scroll += new System.EventHandler(this.milisecondsChange_Scroll);
            // 
            // milisecondsValue
            // 
            this.milisecondsValue.AutoSize = true;
            this.milisecondsValue.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold);
            this.milisecondsValue.Location = new System.Drawing.Point(241, 125);
            this.milisecondsValue.Name = "milisecondsValue";
            this.milisecondsValue.Size = new System.Drawing.Size(37, 13);
            this.milisecondsValue.TabIndex = 15;
            this.milisecondsValue.Text = "0 : MS";
            // 
            // ProjectAlpha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(299, 210);
            this.Controls.Add(this.milisecondsValue);
            this.Controls.Add(this.milisecondsChange);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.selectInventoryKey);
            this.Controls.Add(this.selectHotkey);
            this.Controls.Add(this.switchbootsSelect);
            this.Controls.Add(this.switchlegginsSelect);
            this.Controls.Add(this.switchchestplateSelect);
            this.Controls.Add(this.switchhelmetSelect);
            this.Controls.Add(this.bootsSelect);
            this.Controls.Add(this.legginsSelect);
            this.Controls.Add(this.chestplateSelect);
            this.Controls.Add(this.helmetSelect);
            this.Controls.Add(this.minimiseButton);
            this.Controls.Add(this.closeButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProjectAlpha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1NJ1N3R4 MACRO SWITCH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.milisecondsChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimiseButton;
        private System.Windows.Forms.Button helmetSelect;
        private System.Windows.Forms.Button chestplateSelect;
        private System.Windows.Forms.Button legginsSelect;
        private System.Windows.Forms.Button bootsSelect;
        private System.Windows.Forms.Button switchbootsSelect;
        private System.Windows.Forms.Button switchlegginsSelect;
        private System.Windows.Forms.Button switchchestplateSelect;
        private System.Windows.Forms.Button switchhelmetSelect;
        private System.Windows.Forms.Button selectHotkey;
        private System.Windows.Forms.Button selectInventoryKey;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TrackBar milisecondsChange;
        private System.Windows.Forms.Label milisecondsValue;
    }
}

