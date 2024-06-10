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
            this.DataList = new System.Windows.Forms.ListView();
            this.LabelDataSave = new System.Windows.Forms.TextBox();
            this.DataDataSave = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // Imagen
            // 
            this.Imagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Imagen.BackgroundImage")));
            this.Imagen.Image = ((System.Drawing.Image)(resources.GetObject("Imagen.Image")));
            this.Imagen.Location = new System.Drawing.Point(12, 12);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(52, 54);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imagen.TabIndex = 9;
            this.Imagen.TabStop = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(80, 25);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(80, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // buttonBckMenu
            // 
            this.buttonBckMenu.Location = new System.Drawing.Point(83, 41);
            this.buttonBckMenu.Name = "buttonBckMenu";
            this.buttonBckMenu.Size = new System.Drawing.Size(81, 25);
            this.buttonBckMenu.TabIndex = 10;
            this.buttonBckMenu.Text = "Back to menu";
            this.buttonBckMenu.UseVisualStyleBackColor = true;
            this.buttonBckMenu.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // DataList
            // 
            this.DataList.HideSelection = false;
            this.DataList.Location = new System.Drawing.Point(536, 94);
            this.DataList.Name = "DataList";
            this.DataList.Size = new System.Drawing.Size(252, 191);
            this.DataList.TabIndex = 11;
            this.DataList.UseCompatibleStateImageBehavior = false;
            this.DataList.View = System.Windows.Forms.View.Tile;
            this.DataList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // LabelDataSave
            // 
            this.LabelDataSave.Location = new System.Drawing.Point(296, 94);
            this.LabelDataSave.Name = "LabelDataSave";
            this.LabelDataSave.Size = new System.Drawing.Size(100, 20);
            this.LabelDataSave.TabIndex = 12;
            this.LabelDataSave.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DataDataSave
            // 
            this.DataDataSave.Location = new System.Drawing.Point(296, 137);
            this.DataDataSave.Name = "DataDataSave";
            this.DataDataSave.Size = new System.Drawing.Size(100, 20);
            this.DataDataSave.TabIndex = 13;
            this.DataDataSave.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(218, 94);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(33, 13);
            this.Label.TabIndex = 14;
            this.Label.Text = "Label";
            this.Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(321, 163);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.DataDataSave);
            this.Controls.Add(this.LabelDataSave);
            this.Controls.Add(this.DataList);
            this.Controls.Add(this.buttonBckMenu);
            this.Controls.Add(this.Imagen);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonBckMenu;
        private System.Windows.Forms.ListView DataList;
        private System.Windows.Forms.TextBox LabelDataSave;
        private System.Windows.Forms.TextBox DataDataSave;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
    }
}