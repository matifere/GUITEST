namespace GUI.Forms
{
    partial class Settings
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
            this.LeftPanelSizeLabel = new System.Windows.Forms.Label();
            this.LeftPanelSize = new System.Windows.Forms.TextBox();
            this.SaveAllBtn = new System.Windows.Forms.Button();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.ResetSetBtn = new System.Windows.Forms.Button();
            this.SaveLPSBtn = new System.Windows.Forms.Button();
            this.PanelSave = new System.Windows.Forms.Panel();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.settingPanelText = new System.Windows.Forms.Panel();
            this.lbAutoApply = new System.Windows.Forms.Label();
            this.DefaultWinSize = new System.Windows.Forms.Label();
            this.TextBoxPanel = new System.Windows.Forms.Panel();
            this.CbSavAplAuto = new System.Windows.Forms.CheckBox();
            this.SelectWin = new System.Windows.Forms.ComboBox();
            this.panelsaveconfig = new System.Windows.Forms.Panel();
            this.SaveWinSize = new System.Windows.Forms.Button();
            this.PanelSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.settingPanelText.SuspendLayout();
            this.TextBoxPanel.SuspendLayout();
            this.panelsaveconfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanelSizeLabel
            // 
            this.LeftPanelSizeLabel.AutoSize = true;
            this.LeftPanelSizeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftPanelSizeLabel.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftPanelSizeLabel.Location = new System.Drawing.Point(0, 40);
            this.LeftPanelSizeLabel.Name = "LeftPanelSizeLabel";
            this.LeftPanelSizeLabel.Size = new System.Drawing.Size(220, 25);
            this.LeftPanelSizeLabel.TabIndex = 0;
            this.LeftPanelSizeLabel.Text = "Left panel size:";
            // 
            // LeftPanelSize
            // 
            this.LeftPanelSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeftPanelSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftPanelSize.Font = new System.Drawing.Font("Unispace", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftPanelSize.Location = new System.Drawing.Point(0, 40);
            this.LeftPanelSize.Name = "LeftPanelSize";
            this.LeftPanelSize.Size = new System.Drawing.Size(134, 28);
            this.LeftPanelSize.TabIndex = 1;
            this.LeftPanelSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaveAllBtn
            // 
            this.SaveAllBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveAllBtn.FlatAppearance.BorderSize = 0;
            this.SaveAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAllBtn.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAllBtn.Location = new System.Drawing.Point(0, 80);
            this.SaveAllBtn.Name = "SaveAllBtn";
            this.SaveAllBtn.Size = new System.Drawing.Size(251, 40);
            this.SaveAllBtn.TabIndex = 2;
            this.SaveAllBtn.Text = "Save all";
            this.SaveAllBtn.UseVisualStyleBackColor = true;
            this.SaveAllBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ApplyBtn.FlatAppearance.BorderSize = 0;
            this.ApplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyBtn.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyBtn.Location = new System.Drawing.Point(0, 0);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(251, 40);
            this.ApplyBtn.TabIndex = 3;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // ResetSetBtn
            // 
            this.ResetSetBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ResetSetBtn.FlatAppearance.BorderSize = 0;
            this.ResetSetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetSetBtn.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetSetBtn.Location = new System.Drawing.Point(0, 40);
            this.ResetSetBtn.Name = "ResetSetBtn";
            this.ResetSetBtn.Size = new System.Drawing.Size(251, 40);
            this.ResetSetBtn.TabIndex = 5;
            this.ResetSetBtn.Text = "Reset";
            this.ResetSetBtn.UseVisualStyleBackColor = false;
            this.ResetSetBtn.Click += new System.EventHandler(this.ResetSetBtn_Click);
            // 
            // SaveLPSBtn
            // 
            this.SaveLPSBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveLPSBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveLPSBtn.FlatAppearance.BorderSize = 0;
            this.SaveLPSBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveLPSBtn.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLPSBtn.Image = global::GUI.Properties.Resources.miniSave;
            this.SaveLPSBtn.Location = new System.Drawing.Point(0, 40);
            this.SaveLPSBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SaveLPSBtn.Name = "SaveLPSBtn";
            this.SaveLPSBtn.Padding = new System.Windows.Forms.Padding(1);
            this.SaveLPSBtn.Size = new System.Drawing.Size(36, 29);
            this.SaveLPSBtn.TabIndex = 4;
            this.SaveLPSBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.SaveLPSBtn.UseVisualStyleBackColor = true;
            this.SaveLPSBtn.Click += new System.EventHandler(this.SaveBtn_Click_1);
            // 
            // PanelSave
            // 
            this.PanelSave.Controls.Add(this.LogoBox);
            this.PanelSave.Controls.Add(this.SaveAllBtn);
            this.PanelSave.Controls.Add(this.ResetSetBtn);
            this.PanelSave.Controls.Add(this.ApplyBtn);
            this.PanelSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelSave.Location = new System.Drawing.Point(549, 0);
            this.PanelSave.Name = "PanelSave";
            this.PanelSave.Size = new System.Drawing.Size(251, 450);
            this.PanelSave.TabIndex = 6;
            // 
            // LogoBox
            // 
            this.LogoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoBox.Image = global::GUI.Properties.Resources.guitestback;
            this.LogoBox.Location = new System.Drawing.Point(0, 120);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(251, 378);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            // 
            // settingPanelText
            // 
            this.settingPanelText.Controls.Add(this.lbAutoApply);
            this.settingPanelText.Controls.Add(this.DefaultWinSize);
            this.settingPanelText.Controls.Add(this.LeftPanelSizeLabel);
            this.settingPanelText.Dock = System.Windows.Forms.DockStyle.Left;
            this.settingPanelText.Location = new System.Drawing.Point(0, 0);
            this.settingPanelText.Name = "settingPanelText";
            this.settingPanelText.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.settingPanelText.Size = new System.Drawing.Size(297, 450);
            this.settingPanelText.TabIndex = 7;
            // 
            // lbAutoApply
            // 
            this.lbAutoApply.AutoSize = true;
            this.lbAutoApply.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAutoApply.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutoApply.Location = new System.Drawing.Point(0, 94);
            this.lbAutoApply.Name = "lbAutoApply";
            this.lbAutoApply.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbAutoApply.Size = new System.Drawing.Size(299, 29);
            this.lbAutoApply.TabIndex = 2;
            this.lbAutoApply.Text = "save and apply automatically:";
            // 
            // DefaultWinSize
            // 
            this.DefaultWinSize.AutoSize = true;
            this.DefaultWinSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.DefaultWinSize.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultWinSize.Location = new System.Drawing.Point(0, 65);
            this.DefaultWinSize.Name = "DefaultWinSize";
            this.DefaultWinSize.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.DefaultWinSize.Size = new System.Drawing.Size(209, 29);
            this.DefaultWinSize.TabIndex = 1;
            this.DefaultWinSize.Text = "Default window size:";
            // 
            // TextBoxPanel
            // 
            this.TextBoxPanel.Controls.Add(this.CbSavAplAuto);
            this.TextBoxPanel.Controls.Add(this.SelectWin);
            this.TextBoxPanel.Controls.Add(this.LeftPanelSize);
            this.TextBoxPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TextBoxPanel.Location = new System.Drawing.Point(297, 0);
            this.TextBoxPanel.Name = "TextBoxPanel";
            this.TextBoxPanel.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.TextBoxPanel.Size = new System.Drawing.Size(134, 450);
            this.TextBoxPanel.TabIndex = 8;
            // 
            // CbSavAplAuto
            // 
            this.CbSavAplAuto.AutoSize = true;
            this.CbSavAplAuto.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CbSavAplAuto.Dock = System.Windows.Forms.DockStyle.Top;
            this.CbSavAplAuto.FlatAppearance.BorderSize = 0;
            this.CbSavAplAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbSavAplAuto.Location = new System.Drawing.Point(0, 96);
            this.CbSavAplAuto.MinimumSize = new System.Drawing.Size(50, 25);
            this.CbSavAplAuto.Name = "CbSavAplAuto";
            this.CbSavAplAuto.Size = new System.Drawing.Size(134, 25);
            this.CbSavAplAuto.TabIndex = 3;
            this.CbSavAplAuto.UseVisualStyleBackColor = true;
            this.CbSavAplAuto.CheckedChanged += new System.EventHandler(this.CbSavAplAuto_CheckedChanged);
            // 
            // SelectWin
            // 
            this.SelectWin.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectWin.Font = new System.Drawing.Font("Unispace", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectWin.FormattingEnabled = true;
            this.SelectWin.Items.AddRange(new object[] {
            "Record",
            "Maximized",
            "Default"});
            this.SelectWin.Location = new System.Drawing.Point(0, 68);
            this.SelectWin.Name = "SelectWin";
            this.SelectWin.Size = new System.Drawing.Size(134, 28);
            this.SelectWin.TabIndex = 2;
            // 
            // panelsaveconfig
            // 
            this.panelsaveconfig.Controls.Add(this.SaveWinSize);
            this.panelsaveconfig.Controls.Add(this.SaveLPSBtn);
            this.panelsaveconfig.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsaveconfig.Location = new System.Drawing.Point(431, 0);
            this.panelsaveconfig.Name = "panelsaveconfig";
            this.panelsaveconfig.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.panelsaveconfig.Size = new System.Drawing.Size(36, 450);
            this.panelsaveconfig.TabIndex = 9;
            // 
            // SaveWinSize
            // 
            this.SaveWinSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveWinSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveWinSize.FlatAppearance.BorderSize = 0;
            this.SaveWinSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveWinSize.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveWinSize.Image = global::GUI.Properties.Resources.miniSave;
            this.SaveWinSize.Location = new System.Drawing.Point(0, 69);
            this.SaveWinSize.Margin = new System.Windows.Forms.Padding(0);
            this.SaveWinSize.Name = "SaveWinSize";
            this.SaveWinSize.Padding = new System.Windows.Forms.Padding(1);
            this.SaveWinSize.Size = new System.Drawing.Size(36, 29);
            this.SaveWinSize.TabIndex = 5;
            this.SaveWinSize.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.SaveWinSize.UseVisualStyleBackColor = true;
            this.SaveWinSize.Click += new System.EventHandler(this.SaveWinSize_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelsaveconfig);
            this.Controls.Add(this.TextBoxPanel);
            this.Controls.Add(this.settingPanelText);
            this.Controls.Add(this.PanelSave);
            this.Name = "Settings";
            this.Text = "Settings";
            this.PanelSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.settingPanelText.ResumeLayout(false);
            this.settingPanelText.PerformLayout();
            this.TextBoxPanel.ResumeLayout(false);
            this.TextBoxPanel.PerformLayout();
            this.panelsaveconfig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LeftPanelSizeLabel;
        private System.Windows.Forms.TextBox LeftPanelSize;
        private System.Windows.Forms.Button SaveAllBtn;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Button SaveLPSBtn;
        private System.Windows.Forms.Button ResetSetBtn;
        private System.Windows.Forms.Panel PanelSave;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Panel settingPanelText;
        private System.Windows.Forms.Panel TextBoxPanel;
        private System.Windows.Forms.Panel panelsaveconfig;
        private System.Windows.Forms.Label DefaultWinSize;
        private System.Windows.Forms.ComboBox SelectWin;
        private System.Windows.Forms.Button SaveWinSize;
        private System.Windows.Forms.Label lbAutoApply;
        private System.Windows.Forms.CheckBox CbSavAplAuto;
    }
}