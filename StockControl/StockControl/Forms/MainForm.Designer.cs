namespace StockControl.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblHomeWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxLog = new System.Windows.Forms.PictureBox();
            this.pbxUserProfile = new System.Windows.Forms.PictureBox();
            this.pbxCategory = new System.Windows.Forms.PictureBox();
            this.pbxStock = new System.Windows.Forms.PictureBox();
            this.pbxProduct = new System.Windows.Forms.PictureBox();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.pbxHomeLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHomeLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHomeWelcome
            // 
            this.lblHomeWelcome.AutoSize = true;
            this.lblHomeWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHomeWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblHomeWelcome.Name = "lblHomeWelcome";
            this.lblHomeWelcome.Size = new System.Drawing.Size(144, 20);
            this.lblHomeWelcome.TabIndex = 1;
            this.lblHomeWelcome.Text = "Seja bem vindo(a)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sujeito";
            // 
            // pbxLog
            // 
            this.pbxLog.BackgroundImage = global::StockControl.Properties.Resources.Report2_icon_old_;
            this.pbxLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLog.Location = new System.Drawing.Point(359, 192);
            this.pbxLog.Margin = new System.Windows.Forms.Padding(4);
            this.pbxLog.Name = "pbxLog";
            this.pbxLog.Size = new System.Drawing.Size(95, 95);
            this.pbxLog.TabIndex = 38;
            this.pbxLog.TabStop = false;
            this.pbxLog.Click += new System.EventHandler(this.pbxLog_Click);
            // 
            // pbxUserProfile
            // 
            this.pbxUserProfile.BackgroundImage = global::StockControl.Properties.Resources.UserProfileIcon;
            this.pbxUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxUserProfile.Location = new System.Drawing.Point(211, 192);
            this.pbxUserProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pbxUserProfile.Name = "pbxUserProfile";
            this.pbxUserProfile.Size = new System.Drawing.Size(95, 95);
            this.pbxUserProfile.TabIndex = 37;
            this.pbxUserProfile.TabStop = false;
            this.pbxUserProfile.Click += new System.EventHandler(this.pbxUserProfile_Click);
            // 
            // pbxCategory
            // 
            this.pbxCategory.BackgroundImage = global::StockControl.Properties.Resources.CategoryStyle_old_1;
            this.pbxCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxCategory.Location = new System.Drawing.Point(359, 64);
            this.pbxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.pbxCategory.Name = "pbxCategory";
            this.pbxCategory.Size = new System.Drawing.Size(95, 95);
            this.pbxCategory.TabIndex = 36;
            this.pbxCategory.TabStop = false;
            this.pbxCategory.Click += new System.EventHandler(this.pbxCategory_Click);
            // 
            // pbxStock
            // 
            this.pbxStock.Location = new System.Drawing.Point(61, 64);
            this.pbxStock.Margin = new System.Windows.Forms.Padding(4);
            this.pbxStock.Name = "pbxStock";
            this.pbxStock.Size = new System.Drawing.Size(95, 95);
            this.pbxStock.TabIndex = 35;
            this.pbxStock.TabStop = false;
            this.pbxStock.Click += new System.EventHandler(this.pbxStock_Click);
            // 
            // pbxProduct
            // 
            this.pbxProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxProduct.BackgroundImage")));
            this.pbxProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxProduct.Location = new System.Drawing.Point(211, 64);
            this.pbxProduct.Margin = new System.Windows.Forms.Padding(4);
            this.pbxProduct.Name = "pbxProduct";
            this.pbxProduct.Size = new System.Drawing.Size(95, 95);
            this.pbxProduct.TabIndex = 34;
            this.pbxProduct.TabStop = false;
            // 
            // pbxUser
            // 
            this.pbxUser.BackgroundImage = global::StockControl.Properties.Resources.UserProfileIcon;
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxUser.Location = new System.Drawing.Point(61, 192);
            this.pbxUser.Margin = new System.Windows.Forms.Padding(4);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(95, 95);
            this.pbxUser.TabIndex = 33;
            this.pbxUser.TabStop = false;
            this.pbxUser.Click += new System.EventHandler(this.pbxUser_Click);
            // 
            // pbxHomeLogin
            // 
            this.pbxHomeLogin.Location = new System.Drawing.Point(16, 305);
            this.pbxHomeLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pbxHomeLogin.Name = "pbxHomeLogin";
            this.pbxHomeLogin.Size = new System.Drawing.Size(47, 43);
            this.pbxHomeLogin.TabIndex = 32;
            this.pbxHomeLogin.TabStop = false;
            this.pbxHomeLogin.Click += new System.EventHandler(this.pbxHomeLogin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 363);
            this.Controls.Add(this.pbxLog);
            this.Controls.Add(this.pbxUserProfile);
            this.Controls.Add(this.pbxCategory);
            this.Controls.Add(this.pbxStock);
            this.Controls.Add(this.pbxProduct);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.pbxHomeLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHomeWelcome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Controle de estoque";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHomeLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomeWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxHomeLogin;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.PictureBox pbxProduct;
        private System.Windows.Forms.PictureBox pbxStock;
        private System.Windows.Forms.PictureBox pbxCategory;
        private System.Windows.Forms.PictureBox pbxUserProfile;
        private System.Windows.Forms.PictureBox pbxLog;
    }
}