namespace GUI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonBckMenu = new System.Windows.Forms.Button();
            this.PanelSideMenu = new System.Windows.Forms.Panel();
            this.PanelLogData = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.Button();
            this.PanelHomeSubmenu = new System.Windows.Forms.Panel();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.PanelSideMenu.SuspendLayout();
            this.PanelLogData.SuspendLayout();
            this.PanelHomeSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Imagen
            // 
            this.Imagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Imagen.BackgroundImage")));
            this.Imagen.Image = ((System.Drawing.Image)(resources.GetObject("Imagen.Image")));
            this.Imagen.Location = new System.Drawing.Point(3, 12);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(52, 54);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imagen.TabIndex = 9;
            this.Imagen.TabStop = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(61, 25);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(61, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // buttonBckMenu
            // 
            this.buttonBckMenu.Location = new System.Drawing.Point(61, 41);
            this.buttonBckMenu.Name = "buttonBckMenu";
            this.buttonBckMenu.Size = new System.Drawing.Size(81, 25);
            this.buttonBckMenu.TabIndex = 10;
            this.buttonBckMenu.Text = "Back to menu";
            this.buttonBckMenu.UseVisualStyleBackColor = true;
            this.buttonBckMenu.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // PanelSideMenu
            // 
            this.PanelSideMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PanelSideMenu.Controls.Add(this.PanelHomeSubmenu);
            this.PanelSideMenu.Controls.Add(this.BtnHome);
            this.PanelSideMenu.Controls.Add(this.PanelLogData);
            this.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelSideMenu.Name = "PanelSideMenu";
            this.PanelSideMenu.Size = new System.Drawing.Size(168, 540);
            this.PanelSideMenu.TabIndex = 11;
            // 
            // PanelLogData
            // 
            this.PanelLogData.Controls.Add(this.Imagen);
            this.PanelLogData.Controls.Add(this.buttonBckMenu);
            this.PanelLogData.Controls.Add(this.labelName);
            this.PanelLogData.Controls.Add(this.labelEmail);
            this.PanelLogData.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogData.Location = new System.Drawing.Point(0, 0);
            this.PanelLogData.Name = "PanelLogData";
            this.PanelLogData.Size = new System.Drawing.Size(168, 73);
            this.PanelLogData.TabIndex = 0;
            // 
            // BtnHome
            // 
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnHome.Location = new System.Drawing.Point(0, 73);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.BtnHome.Size = new System.Drawing.Size(168, 45);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.UseVisualStyleBackColor = true;
            // 
            // PanelHomeSubmenu
            // 
            this.PanelHomeSubmenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PanelHomeSubmenu.Controls.Add(this.SettingsBtn);
            this.PanelHomeSubmenu.Controls.Add(this.AboutBtn);
            this.PanelHomeSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHomeSubmenu.Location = new System.Drawing.Point(0, 118);
            this.PanelHomeSubmenu.Name = "PanelHomeSubmenu";
            this.PanelHomeSubmenu.Size = new System.Drawing.Size(168, 50);
            this.PanelHomeSubmenu.TabIndex = 2;
            // 
            // AboutBtn
            // 
            this.AboutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutBtn.FlatAppearance.BorderSize = 0;
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AboutBtn.Location = new System.Drawing.Point(0, 0);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.AboutBtn.Size = new System.Drawing.Size(168, 23);
            this.AboutBtn.TabIndex = 0;
            this.AboutBtn.Text = "About";
            this.AboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutBtn.UseVisualStyleBackColor = true;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SettingsBtn.Location = new System.Drawing.Point(0, 23);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SettingsBtn.Size = new System.Drawing.Size(168, 23);
            this.SettingsBtn.TabIndex = 2;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.PanelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.PanelSideMenu.ResumeLayout(false);
            this.PanelLogData.ResumeLayout(false);
            this.PanelLogData.PerformLayout();
            this.PanelHomeSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonBckMenu;
        private System.Windows.Forms.Panel PanelSideMenu;
        private System.Windows.Forms.Panel PanelLogData;
        private System.Windows.Forms.Panel PanelHomeSubmenu;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Button AboutBtn;
    }
}