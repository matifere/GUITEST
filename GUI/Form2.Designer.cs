namespace GUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonBckMenu = new System.Windows.Forms.Button();
            this.PanelSideMenu = new System.Windows.Forms.Panel();
            this.DataBtn = new System.Windows.Forms.Button();
            this.NotesBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.PanelLogData = new System.Windows.Forms.Panel();
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FormShow = new System.Windows.Forms.Panel();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelSideMenu.SuspendLayout();
            this.PanelLogData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.TitlePanel.SuspendLayout();
            this.FormShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            resources.ApplyResources(this.labelEmail, "labelEmail");
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEmail.Name = "labelEmail";
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelName.Name = "labelName";
            // 
            // buttonBckMenu
            // 
            this.buttonBckMenu.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonBckMenu, "buttonBckMenu");
            this.buttonBckMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBckMenu.Name = "buttonBckMenu";
            this.buttonBckMenu.UseVisualStyleBackColor = true;
            this.buttonBckMenu.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // PanelSideMenu
            // 
            this.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(63)))));
            this.PanelSideMenu.Controls.Add(this.DataBtn);
            this.PanelSideMenu.Controls.Add(this.NotesBtn);
            this.PanelSideMenu.Controls.Add(this.SettingsBtn);
            this.PanelSideMenu.Controls.Add(this.BtnHome);
            this.PanelSideMenu.Controls.Add(this.PanelLogData);
            resources.ApplyResources(this.PanelSideMenu, "PanelSideMenu");
            this.PanelSideMenu.Name = "PanelSideMenu";
            // 
            // DataBtn
            // 
            resources.ApplyResources(this.DataBtn, "DataBtn");
            this.DataBtn.FlatAppearance.BorderSize = 0;
            this.DataBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.DataBtn.Image = global::GUI.Properties.Resources.database_solid;
            this.DataBtn.Name = "DataBtn";
            this.DataBtn.UseVisualStyleBackColor = true;
            this.DataBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // NotesBtn
            // 
            resources.ApplyResources(this.NotesBtn, "NotesBtn");
            this.NotesBtn.FlatAppearance.BorderSize = 0;
            this.NotesBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.NotesBtn.Image = global::GUI.Properties.Resources.clipboard_solid;
            this.NotesBtn.Name = "NotesBtn";
            this.NotesBtn.UseVisualStyleBackColor = true;
            this.NotesBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // SettingsBtn
            // 
            resources.ApplyResources(this.SettingsBtn, "SettingsBtn");
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SettingsBtn.Image = global::GUI.Properties.Resources.gear;
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnHome
            // 
            resources.ApplyResources(this.BtnHome, "BtnHome");
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnHome.Image = global::GUI.Properties.Resources.house;
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // PanelLogData
            // 
            this.PanelLogData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(55)))), ((int)(((byte)(40)))));
            this.PanelLogData.Controls.Add(this.Imagen);
            this.PanelLogData.Controls.Add(this.buttonBckMenu);
            this.PanelLogData.Controls.Add(this.labelName);
            this.PanelLogData.Controls.Add(this.labelEmail);
            resources.ApplyResources(this.PanelLogData, "PanelLogData");
            this.PanelLogData.Name = "PanelLogData";
            // 
            // Imagen
            // 
            resources.ApplyResources(this.Imagen, "Imagen");
            this.Imagen.Name = "Imagen";
            this.Imagen.TabStop = false;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(58)))), ((int)(((byte)(44)))));
            this.TitlePanel.Controls.Add(this.TitleLabel);
            resources.ApplyResources(this.TitlePanel, "TitlePanel");
            this.TitlePanel.Name = "TitlePanel";
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // FormShow
            // 
            this.FormShow.Controls.Add(this.WelcomeLabel);
            this.FormShow.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.FormShow, "FormShow");
            this.FormShow.Name = "FormShow";
            // 
            // WelcomeLabel
            // 
            resources.ApplyResources(this.WelcomeLabel, "WelcomeLabel");
            this.WelcomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WelcomeLabel.Name = "WelcomeLabel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::GUI.Properties.Resources.guitestback;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.FormShow);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.PanelSideMenu);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.PanelSideMenu.ResumeLayout(false);
            this.PanelLogData.ResumeLayout(false);
            this.PanelLogData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.FormShow.ResumeLayout(false);
            this.FormShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonBckMenu;
        private System.Windows.Forms.Panel PanelSideMenu;
        private System.Windows.Forms.Panel PanelLogData;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Button NotesBtn;
        private System.Windows.Forms.Button DataBtn;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel FormShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}