namespace GUI.Forms
{
    partial class Data
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
            this.LbProduct = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.TbName = new MaterialSkin.Controls.MaterialTextBox();
            this.TbPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.CbColor = new MaterialSkin.Controls.MaterialComboBox();
            this.CbGender = new MaterialSkin.Controls.MaterialComboBox();
            this.CbBrand = new MaterialSkin.Controls.MaterialComboBox();
            this.TbAmount = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.FlpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.materialCard9 = new MaterialSkin.Controls.MaterialCard();
            this.BtnSave = new MaterialSkin.Controls.MaterialButton();
            this.BtnDiscard = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.FlpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbProduct
            // 
            this.LbProduct.AutoSize = true;
            this.LbProduct.Depth = 0;
            this.LbProduct.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LbProduct.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.LbProduct.Location = new System.Drawing.Point(434, 7);
            this.LbProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbProduct.Name = "LbProduct";
            this.LbProduct.Size = new System.Drawing.Size(120, 41);
            this.LbProduct.TabIndex = 11;
            this.LbProduct.Text = "Product";
            this.LbProduct.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(390, -9);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(5, 656);
            this.materialDivider1.TabIndex = 12;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // TbName
            // 
            this.TbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbName.Depth = 0;
            this.TbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TbName.Location = new System.Drawing.Point(154, 14);
            this.TbName.MaxLength = 50;
            this.TbName.MouseState = MaterialSkin.MouseState.OUT;
            this.TbName.Multiline = false;
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(134, 50);
            this.TbName.TabIndex = 13;
            this.TbName.Text = "";
            // 
            // TbPrice
            // 
            this.TbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbPrice.Depth = 0;
            this.TbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TbPrice.Location = new System.Drawing.Point(154, 17);
            this.TbPrice.MaxLength = 50;
            this.TbPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.TbPrice.Multiline = false;
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(134, 50);
            this.TbPrice.TabIndex = 14;
            this.TbPrice.Text = "";
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.AutoScroll = true;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.CbBrand);
            this.materialCard1.Controls.Add(this.CbGender);
            this.materialCard1.Controls.Add(this.CbColor);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(429, 268);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(788, 67);
            this.materialCard1.TabIndex = 15;
            // 
            // CbColor
            // 
            this.CbColor.AutoResize = false;
            this.CbColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbColor.Depth = 0;
            this.CbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbColor.DropDownHeight = 174;
            this.CbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbColor.DropDownWidth = 121;
            this.CbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbColor.FormattingEnabled = true;
            this.CbColor.Hint = "Color";
            this.CbColor.IntegralHeight = false;
            this.CbColor.ItemHeight = 43;
            this.CbColor.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Green",
            "Red",
            "White",
            "Yellow"});
            this.CbColor.Location = new System.Drawing.Point(17, 9);
            this.CbColor.MaxDropDownItems = 4;
            this.CbColor.MouseState = MaterialSkin.MouseState.OUT;
            this.CbColor.Name = "CbColor";
            this.CbColor.Size = new System.Drawing.Size(140, 49);
            this.CbColor.Sorted = true;
            this.CbColor.TabIndex = 2;
            // 
            // CbGender
            // 
            this.CbGender.AutoResize = false;
            this.CbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbGender.Depth = 0;
            this.CbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbGender.DropDownHeight = 174;
            this.CbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbGender.DropDownWidth = 121;
            this.CbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbGender.FormattingEnabled = true;
            this.CbGender.Hint = "Gender";
            this.CbGender.IntegralHeight = false;
            this.CbGender.ItemHeight = 43;
            this.CbGender.Items.AddRange(new object[] {
            "Man",
            "Unisex",
            "Woman"});
            this.CbGender.Location = new System.Drawing.Point(163, 9);
            this.CbGender.MaxDropDownItems = 4;
            this.CbGender.MouseState = MaterialSkin.MouseState.OUT;
            this.CbGender.Name = "CbGender";
            this.CbGender.Size = new System.Drawing.Size(140, 49);
            this.CbGender.Sorted = true;
            this.CbGender.TabIndex = 3;
            // 
            // CbBrand
            // 
            this.CbBrand.AutoResize = false;
            this.CbBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbBrand.Depth = 0;
            this.CbBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbBrand.DropDownHeight = 174;
            this.CbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBrand.DropDownWidth = 121;
            this.CbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbBrand.FormattingEnabled = true;
            this.CbBrand.Hint = "Brand";
            this.CbBrand.IntegralHeight = false;
            this.CbBrand.ItemHeight = 43;
            this.CbBrand.Items.AddRange(new object[] {
            "Addidas",
            "IRun",
            "Nike"});
            this.CbBrand.Location = new System.Drawing.Point(309, 9);
            this.CbBrand.MaxDropDownItems = 4;
            this.CbBrand.MouseState = MaterialSkin.MouseState.OUT;
            this.CbBrand.Name = "CbBrand";
            this.CbBrand.Size = new System.Drawing.Size(140, 49);
            this.CbBrand.Sorted = true;
            this.CbBrand.TabIndex = 4;
            // 
            // TbAmount
            // 
            this.TbAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbAmount.Depth = 0;
            this.TbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TbAmount.Location = new System.Drawing.Point(166, 13);
            this.TbAmount.MaxLength = 50;
            this.TbAmount.MouseState = MaterialSkin.MouseState.OUT;
            this.TbAmount.Multiline = false;
            this.TbAmount.Name = "TbAmount";
            this.TbAmount.Size = new System.Drawing.Size(134, 50);
            this.TbAmount.TabIndex = 16;
            this.TbAmount.Text = "";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(17, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(54, 24);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Name";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(17, 17);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(47, 24);
            this.materialLabel3.TabIndex = 18;
            this.materialLabel3.Text = "Price";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(16, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(71, 24);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "Amount";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Controls.Add(this.TbName);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(429, 62);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(317, 75);
            this.materialCard2.TabIndex = 20;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel3);
            this.materialCard3.Controls.Add(this.TbPrice);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(429, 165);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(317, 75);
            this.materialCard3.TabIndex = 21;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.TbAmount);
            this.materialCard4.Controls.Add(this.materialLabel4);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(774, 62);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(317, 75);
            this.materialCard4.TabIndex = 22;
            // 
            // FlpContainer
            // 
            this.FlpContainer.AutoScroll = true;
            this.FlpContainer.Controls.Add(this.materialCard9);
            this.FlpContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlpContainer.Location = new System.Drawing.Point(0, 0);
            this.FlpContainer.Name = "FlpContainer";
            this.FlpContainer.Size = new System.Drawing.Size(384, 615);
            this.FlpContainer.TabIndex = 23;
            // 
            // materialCard9
            // 
            this.materialCard9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard9.Depth = 0;
            this.materialCard9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard9.Location = new System.Drawing.Point(14, 14);
            this.materialCard9.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard9.Name = "materialCard9";
            this.materialCard9.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard9.Size = new System.Drawing.Size(348, 100);
            this.materialCard9.TabIndex = 2;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSave.Depth = 0;
            this.BtnSave.DrawShadows = true;
            this.BtnSave.HighEmphasis = true;
            this.BtnSave.Icon = null;
            this.BtnSave.Location = new System.Drawing.Point(1159, 341);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(58, 36);
            this.BtnSave.TabIndex = 24;
            this.BtnSave.Text = "Save";
            this.BtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSave.UseAccentColor = false;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDiscard
            // 
            this.BtnDiscard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDiscard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDiscard.Depth = 0;
            this.BtnDiscard.DrawShadows = true;
            this.BtnDiscard.HighEmphasis = true;
            this.BtnDiscard.Icon = global::GUI.Properties.Resources.icons8_trash_can_32;
            this.BtnDiscard.Image = global::GUI.Properties.Resources.icons8_trash_can_32;
            this.BtnDiscard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDiscard.Location = new System.Drawing.Point(1041, 341);
            this.BtnDiscard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnDiscard.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDiscard.Name = "BtnDiscard";
            this.BtnDiscard.Size = new System.Drawing.Size(110, 36);
            this.BtnDiscard.TabIndex = 25;
            this.BtnDiscard.Text = "Discard";
            this.BtnDiscard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDiscard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnDiscard.UseAccentColor = true;
            this.BtnDiscard.UseVisualStyleBackColor = true;
            this.BtnDiscard.Click += new System.EventHandler(this.BtnDiscard_Click);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1223, 615);
            this.Controls.Add(this.BtnDiscard);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.FlpContainer);
            this.Controls.Add(this.materialCard4);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.LbProduct);
            this.Name = "Data";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Data_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.FlpContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel LbProduct;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTextBox TbName;
        private MaterialSkin.Controls.MaterialTextBox TbPrice;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox CbColor;
        private MaterialSkin.Controls.MaterialComboBox CbBrand;
        private MaterialSkin.Controls.MaterialComboBox CbGender;
        private MaterialSkin.Controls.MaterialTextBox TbAmount;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private System.Windows.Forms.FlowLayoutPanel FlpContainer;
        private MaterialSkin.Controls.MaterialCard materialCard9;
        private MaterialSkin.Controls.MaterialButton BtnSave;
        private MaterialSkin.Controls.MaterialButton BtnDiscard;
    }
}