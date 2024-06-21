namespace GUI.Forms
{
    partial class Notes
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
            this.PanelLeftContainer = new System.Windows.Forms.Panel();
            this.PanelRightContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.TbNote = new System.Windows.Forms.TextBox();
            this.BtnFont = new System.Windows.Forms.Button();
            this.BtnFontColor = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.FdFont = new System.Windows.Forms.FontDialog();
            this.CdFontColor = new System.Windows.Forms.ColorDialog();
            this.SfdSave = new System.Windows.Forms.SaveFileDialog();
            this.OfdOpen = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PanelLeftContainer.SuspendLayout();
            this.PanelRightContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeftContainer
            // 
            this.PanelLeftContainer.Controls.Add(this.BtnFontColor);
            this.PanelLeftContainer.Controls.Add(this.BtnFont);
            this.PanelLeftContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeftContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelLeftContainer.Name = "PanelLeftContainer";
            this.PanelLeftContainer.Size = new System.Drawing.Size(200, 450);
            this.PanelLeftContainer.TabIndex = 0;
            // 
            // PanelRightContainer
            // 
            this.PanelRightContainer.Controls.Add(this.BtnSave);
            this.PanelRightContainer.Controls.Add(this.BtnOpen);
            this.PanelRightContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelRightContainer.Location = new System.Drawing.Point(600, 0);
            this.PanelRightContainer.Name = "PanelRightContainer";
            this.PanelRightContainer.Size = new System.Drawing.Size(200, 450);
            this.PanelRightContainer.TabIndex = 0;
            // 
            // TbNote
            // 
            this.TbNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbNote.Location = new System.Drawing.Point(200, 0);
            this.TbNote.Multiline = true;
            this.TbNote.Name = "TbNote";
            this.TbNote.Size = new System.Drawing.Size(400, 450);
            this.TbNote.TabIndex = 1;
            // 
            // BtnFont
            // 
            this.BtnFont.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFont.Location = new System.Drawing.Point(0, 0);
            this.BtnFont.Name = "BtnFont";
            this.BtnFont.Size = new System.Drawing.Size(200, 23);
            this.BtnFont.TabIndex = 0;
            this.BtnFont.Text = "Font";
            this.BtnFont.UseVisualStyleBackColor = true;
            this.BtnFont.Click += new System.EventHandler(this.BtnFont_Click);
            // 
            // BtnFontColor
            // 
            this.BtnFontColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFontColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFontColor.Location = new System.Drawing.Point(0, 23);
            this.BtnFontColor.Name = "BtnFontColor";
            this.BtnFontColor.Size = new System.Drawing.Size(200, 23);
            this.BtnFontColor.TabIndex = 1;
            this.BtnFontColor.Text = "Font Color";
            this.BtnFontColor.UseVisualStyleBackColor = true;
            this.BtnFontColor.Click += new System.EventHandler(this.BtnFontColor_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Location = new System.Drawing.Point(3, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(200, 23);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpen.Location = new System.Drawing.Point(3, 32);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(200, 23);
            this.BtnOpen.TabIndex = 3;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // OfdOpen
            // 
            this.OfdOpen.FileName = "openFileDialog1";
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbNote);
            this.Controls.Add(this.PanelRightContainer);
            this.Controls.Add(this.PanelLeftContainer);
            this.Name = "Notes";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Notes_Load);
            this.PanelLeftContainer.ResumeLayout(false);
            this.PanelRightContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeftContainer;
        private System.Windows.Forms.FlowLayoutPanel PanelRightContainer;
        private System.Windows.Forms.TextBox TbNote;
        private System.Windows.Forms.Button BtnFont;
        private System.Windows.Forms.Button BtnFontColor;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.FontDialog FdFont;
        private System.Windows.Forms.ColorDialog CdFontColor;
        private System.Windows.Forms.SaveFileDialog SfdSave;
        private System.Windows.Forms.OpenFileDialog OfdOpen;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}