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
            this.SaveLPSBtn = new System.Windows.Forms.Button();
            this.ResetSetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeftPanelSizeLabel
            // 
            this.LeftPanelSizeLabel.AutoSize = true;
            this.LeftPanelSizeLabel.Location = new System.Drawing.Point(48, 67);
            this.LeftPanelSizeLabel.Name = "LeftPanelSizeLabel";
            this.LeftPanelSizeLabel.Size = new System.Drawing.Size(75, 13);
            this.LeftPanelSizeLabel.TabIndex = 0;
            this.LeftPanelSizeLabel.Text = "Left panel size";
            // 
            // LeftPanelSize
            // 
            this.LeftPanelSize.Location = new System.Drawing.Point(129, 64);
            this.LeftPanelSize.Name = "LeftPanelSize";
            this.LeftPanelSize.Size = new System.Drawing.Size(100, 20);
            this.LeftPanelSize.TabIndex = 1;
            // 
            // SaveAllBtn
            // 
            this.SaveAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveAllBtn.Location = new System.Drawing.Point(713, 415);
            this.SaveAllBtn.Name = "SaveAllBtn";
            this.SaveAllBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveAllBtn.TabIndex = 2;
            this.SaveAllBtn.Text = "Save all";
            this.SaveAllBtn.UseVisualStyleBackColor = true;
            this.SaveAllBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyBtn.Location = new System.Drawing.Point(622, 415);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(75, 23);
            this.ApplyBtn.TabIndex = 3;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // SaveLPSBtn
            // 
            this.SaveLPSBtn.Location = new System.Drawing.Point(249, 61);
            this.SaveLPSBtn.Name = "SaveLPSBtn";
            this.SaveLPSBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveLPSBtn.TabIndex = 4;
            this.SaveLPSBtn.Text = "Save";
            this.SaveLPSBtn.UseVisualStyleBackColor = true;
            this.SaveLPSBtn.Click += new System.EventHandler(this.SaveBtn_Click_1);
            // 
            // ResetSetBtn
            // 
            this.ResetSetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetSetBtn.Location = new System.Drawing.Point(541, 415);
            this.ResetSetBtn.Name = "ResetSetBtn";
            this.ResetSetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetSetBtn.TabIndex = 5;
            this.ResetSetBtn.Text = "Reset";
            this.ResetSetBtn.UseVisualStyleBackColor = true;
            this.ResetSetBtn.Click += new System.EventHandler(this.ResetSetBtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetSetBtn);
            this.Controls.Add(this.SaveLPSBtn);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.SaveAllBtn);
            this.Controls.Add(this.LeftPanelSize);
            this.Controls.Add(this.LeftPanelSizeLabel);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LeftPanelSizeLabel;
        private System.Windows.Forms.TextBox LeftPanelSize;
        private System.Windows.Forms.Button SaveAllBtn;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Button SaveLPSBtn;
        private System.Windows.Forms.Button ResetSetBtn;
    }
}