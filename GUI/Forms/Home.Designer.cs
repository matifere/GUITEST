namespace GUI.Forms
{
    partial class Home
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
            this.LabelText = new System.Windows.Forms.Label();
            this.LabelGuitest = new System.Windows.Forms.Label();
            this.logoHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoHome)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelText
            // 
            this.LabelText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelText.AutoSize = true;
            this.LabelText.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelText.Location = new System.Drawing.Point(480, 71);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(274, 62);
            this.LabelText.TabIndex = 1;
            this.LabelText.Text = "...still thinking";
            // 
            // LabelGuitest
            // 
            this.LabelGuitest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelGuitest.AutoSize = true;
            this.LabelGuitest.BackColor = System.Drawing.Color.White;
            this.LabelGuitest.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGuitest.Location = new System.Drawing.Point(327, 239);
            this.LabelGuitest.Name = "LabelGuitest";
            this.LabelGuitest.Size = new System.Drawing.Size(104, 37);
            this.LabelGuitest.TabIndex = 2;
            this.LabelGuitest.Text = "Gui Test";
            // 
            // logoHome
            // 
            this.logoHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoHome.Image = global::GUI.Properties.Resources.LogoGuiTest;
            this.logoHome.Location = new System.Drawing.Point(0, 0);
            this.logoHome.Name = "logoHome";
            this.logoHome.Size = new System.Drawing.Size(800, 450);
            this.logoHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoHome.TabIndex = 0;
            this.logoHome.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelGuitest);
            this.Controls.Add(this.LabelText);
            this.Controls.Add(this.logoHome);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoHome;
        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.Label LabelGuitest;
    }
}