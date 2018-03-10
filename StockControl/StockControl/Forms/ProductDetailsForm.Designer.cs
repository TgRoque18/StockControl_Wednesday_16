namespace StockControl.Forms
{
    partial class ProductDetailsForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblactive = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.ckbActive = new System.Windows.Forms.CheckBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.pbxSave = new System.Windows.Forms.PictureBox();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.pbxSaveImage = new System.Windows.Forms.PictureBox();
            this.pbxProductPicture = new System.Windows.Forms.PictureBox();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSaveImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProductPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName.Location = new System.Drawing.Point(107, 37);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrice.Location = new System.Drawing.Point(107, 71);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 17);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Preço:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCategory.Location = new System.Drawing.Point(107, 103);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 17);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Categoria:";
            // 
            // lblactive
            // 
            this.lblactive.AutoSize = true;
            this.lblactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblactive.Location = new System.Drawing.Point(107, 136);
            this.lblactive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblactive.Name = "lblactive";
            this.lblactive.Size = new System.Drawing.Size(43, 17);
            this.lblactive.TabIndex = 3;
            this.lblactive.Text = "Ativo:";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbxName.Location = new System.Drawing.Point(175, 37);
            this.tbxName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(122, 23);
            this.tbxName.TabIndex = 4;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbxPrice.Location = new System.Drawing.Point(175, 71);
            this.tbxPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(122, 23);
            this.tbxPrice.TabIndex = 5;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(175, 103);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(122, 24);
            this.cmbCategory.TabIndex = 8;
            // 
            // ckbActive
            // 
            this.ckbActive.AutoSize = true;
            this.ckbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ckbActive.Location = new System.Drawing.Point(175, 136);
            this.ckbActive.Margin = new System.Windows.Forms.Padding(2);
            this.ckbActive.Name = "ckbActive";
            this.ckbActive.Size = new System.Drawing.Size(15, 14);
            this.ckbActive.TabIndex = 9;
            this.ckbActive.UseVisualStyleBackColor = true;
            // 
            // pbxBack
            // 
            this.pbxBack.BackgroundImage = global::StockControl.Properties.Resources.back;
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxBack.Location = new System.Drawing.Point(15, 307);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(35, 35);
            this.pbxBack.TabIndex = 14;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // pbxSave
            // 
            this.pbxSave.BackgroundImage = global::StockControl.Properties.Resources.save;
            this.pbxSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxSave.Location = new System.Drawing.Point(384, 313);
            this.pbxSave.Name = "pbxSave";
            this.pbxSave.Size = new System.Drawing.Size(35, 35);
            this.pbxSave.TabIndex = 13;
            this.pbxSave.TabStop = false;
            this.pbxSave.Click += new System.EventHandler(this.pbxSave_Click);
            // 
            // pbxDelete
            // 
            this.pbxDelete.BackgroundImage = global::StockControl.Properties.Resources.delete;
            this.pbxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxDelete.Location = new System.Drawing.Point(460, 313);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(35, 35);
            this.pbxDelete.TabIndex = 12;
            this.pbxDelete.TabStop = false;
            this.pbxDelete.Click += new System.EventHandler(this.pbxDelete_Click);
            // 
            // pbxSaveImage
            // 
            this.pbxSaveImage.Location = new System.Drawing.Point(384, 130);
            this.pbxSaveImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbxSaveImage.Name = "pbxSaveImage";
            this.pbxSaveImage.Size = new System.Drawing.Size(83, 14);
            this.pbxSaveImage.TabIndex = 11;
            this.pbxSaveImage.TabStop = false;
            // 
            // pbxProductPicture
            // 
            this.pbxProductPicture.Location = new System.Drawing.Point(384, 29);
            this.pbxProductPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pbxProductPicture.Name = "pbxProductPicture";
            this.pbxProductPicture.Size = new System.Drawing.Size(83, 82);
            this.pbxProductPicture.TabIndex = 10;
            this.pbxProductPicture.TabStop = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(107, 216);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 15;
            this.lblid.Visible = false;
            // 
            // ProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 371);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.pbxSave);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.pbxSaveImage);
            this.Controls.Add(this.pbxProductPicture);
            this.Controls.Add(this.ckbActive);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblactive);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductDetailsForm";
            this.Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSaveImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProductPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblactive;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.CheckBox ckbActive;
        private System.Windows.Forms.PictureBox pbxProductPicture;
        private System.Windows.Forms.PictureBox pbxSaveImage;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxSave;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.Label lblid;
    }
}