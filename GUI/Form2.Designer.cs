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
            this.PanelLogData = new System.Windows.Forms.Panel();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FormShow = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.PanelSideMenu.SuspendLayout();
            this.PanelLogData.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
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
            this.PanelSideMenu.Controls.Add(this.button3);
            this.PanelSideMenu.Controls.Add(this.button2);
            this.PanelSideMenu.Controls.Add(this.button1);
            this.PanelSideMenu.Controls.Add(this.BtnHome);
            this.PanelSideMenu.Controls.Add(this.PanelLogData);
            resources.ApplyResources(this.PanelSideMenu, "PanelSideMenu");
            this.PanelSideMenu.Name = "PanelSideMenu";
            // 
            // PanelLogData
            // 
            this.PanelLogData.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanelLogData.Controls.Add(this.Imagen);
            this.PanelLogData.Controls.Add(this.buttonBckMenu);
            this.PanelLogData.Controls.Add(this.labelName);
            this.PanelLogData.Controls.Add(this.labelEmail);
            resources.ApplyResources(this.PanelLogData, "PanelLogData");
            this.PanelLogData.Name = "PanelLogData";
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.SystemColors.Highlight;
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
            resources.ApplyResources(this.FormShow, "FormShow");
            this.FormShow.Name = "FormShow";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Image = global::GUI.Properties.Resources.database_solid;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::GUI.Properties.Resources.clipboard_solid;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::GUI.Properties.Resources.gear;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Imagen
            // 
            resources.ApplyResources(this.Imagen, "Imagen");
            this.Imagen.Name = "Imagen";
            this.Imagen.TabStop = false;
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
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel FormShow;
    }
}