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
            this.lblStock = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLeave = new System.Windows.Forms.Label();
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
            this.lblHomeWelcome.Location = new System.Drawing.Point(9, 7);
            this.lblHomeWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomeWelcome.Name = "lblHomeWelcome";
            this.lblHomeWelcome.Size = new System.Drawing.Size(123, 17);
            this.lblHomeWelcome.TabIndex = 1;
            this.lblHomeWelcome.Text = "Seja bem vindo(a)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(136, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sujeito";
            // 
            // pbxLog
            // 
            this.pbxLog.BackgroundImage = global::StockControl.Properties.Resources.Report2_icon_old_;
            this.pbxLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLog.Location = new System.Drawing.Point(269, 156);
            this.pbxLog.Name = "pbxLog";
            this.pbxLog.Size = new System.Drawing.Size(71, 77);
            this.pbxLog.TabIndex = 38;
            this.pbxLog.TabStop = false;
            this.pbxLog.Click += new System.EventHandler(this.pbxLog_Click);
            this.pbxLog.MouseEnter += new System.EventHandler(this.pbxLog_MouseEnter);
            this.pbxLog.MouseLeave += new System.EventHandler(this.pbxLog_MouseLeave);
            // 
            // pbxUserProfile
            // 
            this.pbxUserProfile.BackgroundImage = global::StockControl.Properties.Resources.UserProfileIcon;
            this.pbxUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUserProfile.Location = new System.Drawing.Point(158, 156);
            this.pbxUserProfile.Name = "pbxUserProfile";
            this.pbxUserProfile.Size = new System.Drawing.Size(71, 77);
            this.pbxUserProfile.TabIndex = 37;
            this.pbxUserProfile.TabStop = false;
            this.pbxUserProfile.Click += new System.EventHandler(this.pbxUserProfile_Click);
            this.pbxUserProfile.MouseEnter += new System.EventHandler(this.pbxUserProfile_MouseEnter);
            this.pbxUserProfile.MouseLeave += new System.EventHandler(this.pbxUserProfile_MouseLeave);
            // 
            // pbxCategory
            // 
            this.pbxCategory.BackgroundImage = global::StockControl.Properties.Resources.CategoryStyle_old_1;
            this.pbxCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCategory.Location = new System.Drawing.Point(269, 52);
            this.pbxCategory.Name = "pbxCategory";
            this.pbxCategory.Size = new System.Drawing.Size(71, 77);
            this.pbxCategory.TabIndex = 36;
            this.pbxCategory.TabStop = false;
            this.pbxCategory.Click += new System.EventHandler(this.pbxCategory_Click);
            this.pbxCategory.MouseEnter += new System.EventHandler(this.pbxCategory_MouseEnter);
            this.pbxCategory.MouseLeave += new System.EventHandler(this.pbxCategory_MouseLeave);
            // 
            // pbxStock
            // 
            this.pbxStock.BackgroundImage = global::StockControl.Properties.Resources.StockStyle_old;
            this.pbxStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxStock.Location = new System.Drawing.Point(46, 52);
            this.pbxStock.Name = "pbxStock";
            this.pbxStock.Size = new System.Drawing.Size(71, 77);
            this.pbxStock.TabIndex = 35;
            this.pbxStock.TabStop = false;
            this.pbxStock.Click += new System.EventHandler(this.pbxStock_Click);
            this.pbxStock.MouseEnter += new System.EventHandler(this.pbxStock_MouseEnter);
            this.pbxStock.MouseLeave += new System.EventHandler(this.pbxStock_MouseLeave);
            // 
            // pbxProduct
            // 
            this.pbxProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxProduct.BackgroundImage")));
            this.pbxProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxProduct.Location = new System.Drawing.Point(158, 52);
            this.pbxProduct.Name = "pbxProduct";
            this.pbxProduct.Size = new System.Drawing.Size(71, 77);
            this.pbxProduct.TabIndex = 34;
            this.pbxProduct.TabStop = false;
            this.pbxProduct.Click += new System.EventHandler(this.pbxProduct_Click);
            this.pbxProduct.MouseEnter += new System.EventHandler(this.pbxProduct_MouseEnter);
            this.pbxProduct.MouseLeave += new System.EventHandler(this.pbxProduct_MouseLeave);
            // 
            // pbxUser
            // 
            this.pbxUser.BackgroundImage = global::StockControl.Properties.Resources.UserProfileIcon;
            this.pbxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUser.Location = new System.Drawing.Point(46, 156);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(71, 77);
            this.pbxUser.TabIndex = 33;
            this.pbxUser.TabStop = false;
            this.pbxUser.Click += new System.EventHandler(this.pbxUser_Click);
            this.pbxUser.MouseEnter += new System.EventHandler(this.pbxUser_MouseEnter);
            this.pbxUser.MouseLeave += new System.EventHandler(this.pbxUser_MouseLeave);
            // 
            // pbxHomeLogin
            // 
            this.pbxHomeLogin.BackgroundImage = global::StockControl.Properties.Resources.BackIcon;
            this.pbxHomeLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxHomeLogin.Location = new System.Drawing.Point(12, 248);
            this.pbxHomeLogin.Name = "pbxHomeLogin";
            this.pbxHomeLogin.Size = new System.Drawing.Size(35, 35);
            this.pbxHomeLogin.TabIndex = 32;
            this.pbxHomeLogin.TabStop = false;
            this.pbxHomeLogin.Click += new System.EventHandler(this.pbxHomeLogin_Click);
            this.pbxHomeLogin.MouseEnter += new System.EventHandler(this.pbxHomeLogin_MouseEnter);
            this.pbxHomeLogin.MouseLeave += new System.EventHandler(this.pbxHomeLogin_MouseLeave);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(50, 132);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(67, 17);
            this.lblStock.TabIndex = 39;
            this.lblStock.Text = "Estoque";
            this.lblStock.Visible = false;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.Location = new System.Drawing.Point(166, 236);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(46, 17);
            this.lblProfile.TabIndex = 40;
            this.lblProfile.Text = "Perfil";
            this.lblProfile.Visible = false;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(155, 132);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(73, 17);
            this.lblProduct.TabIndex = 41;
            this.lblProduct.Text = "Produtos";
            this.lblProduct.Visible = false;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(266, 132);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(78, 17);
            this.lblCategory.TabIndex = 41;
            this.lblCategory.Text = "Categoria";
            this.lblCategory.Visible = false;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(266, 236);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(35, 17);
            this.lblLog.TabIndex = 41;
            this.lblLog.Text = "Log";
            this.lblLog.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(50, 236);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 17);
            this.lblUser.TabIndex = 40;
            this.lblUser.Text = "Usuário";
            this.lblUser.Visible = false;
            // 
            // lblLeave
            // 
            this.lblLeave.AutoSize = true;
            this.lblLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeave.Location = new System.Drawing.Point(50, 266);
            this.lblLeave.Name = "lblLeave";
            this.lblLeave.Size = new System.Drawing.Size(37, 17);
            this.lblLeave.TabIndex = 42;
            this.lblLeave.Text = "Sair";
            this.lblLeave.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 295);
            this.Controls.Add(this.lblLeave);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.pbxLog);
            this.Controls.Add(this.pbxUserProfile);
            this.Controls.Add(this.pbxCategory);
            this.Controls.Add(this.pbxStock);
            this.Controls.Add(this.pbxProduct);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.pbxHomeLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHomeWelcome);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLeave;
    }
}