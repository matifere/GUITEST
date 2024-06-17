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
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}