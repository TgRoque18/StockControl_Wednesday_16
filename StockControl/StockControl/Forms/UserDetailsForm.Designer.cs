namespace StockControl
{
    partial class UserDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetailsForm));
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.txbUserEmail = new System.Windows.Forms.TextBox();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.txbUserRepassword = new System.Windows.Forms.TextBox();
            this.lblUserRepassword = new System.Windows.Forms.Label();
            this.txbUserPassword = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUserActive = new System.Windows.Forms.Label();
            this.lblUserProfile = new System.Windows.Forms.Label();
            this.cmbUserProfile = new System.Windows.Forms.ComboBox();
            this.ckbUserActive = new System.Windows.Forms.CheckBox();
            this.btnUserDeleteProfile = new System.Windows.Forms.Button();
            this.btnUserSaveProfile = new System.Windows.Forms.Button();
            this.btnUserBackPages = new System.Windows.Forms.Button();
            this.btnUserPhotoProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblUserName.Location = new System.Drawing.Point(224, 26);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 22);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Nome";
            // 
            // tbxUserName
            // 
            this.tbxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbxUserName.Location = new System.Drawing.Point(227, 66);
            this.tbxUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(270, 27);
            this.tbxUserName.TabIndex = 1;
            // 
            // txbUserEmail
            // 
            this.txbUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txbUserEmail.Location = new System.Drawing.Point(227, 148);
            this.txbUserEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbUserEmail.Name = "txbUserEmail";
            this.txbUserEmail.Size = new System.Drawing.Size(270, 27);
            this.txbUserEmail.TabIndex = 3;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblUserEmail.Location = new System.Drawing.Point(224, 107);
            this.lblUserEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(54, 22);
            this.lblUserEmail.TabIndex = 2;
            this.lblUserEmail.Text = "Email";
            // 
            // txbUserRepassword
            // 
            this.txbUserRepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txbUserRepassword.Location = new System.Drawing.Point(227, 320);
            this.txbUserRepassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbUserRepassword.Name = "txbUserRepassword";
            this.txbUserRepassword.Size = new System.Drawing.Size(229, 27);
            this.txbUserRepassword.TabIndex = 7;
            // 
            // lblUserRepassword
            // 
            this.lblUserRepassword.AutoSize = true;
            this.lblUserRepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblUserRepassword.Location = new System.Drawing.Point(224, 277);
            this.lblUserRepassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserRepassword.Name = "lblUserRepassword";
            this.lblUserRepassword.Size = new System.Drawing.Size(170, 22);
            this.lblUserRepassword.TabIndex = 6;
            this.lblUserRepassword.Text = "Confirme sua senha";
            // 
            // txbUserPassword
            // 
            this.txbUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txbUserPassword.Location = new System.Drawing.Point(227, 232);
            this.txbUserPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbUserPassword.Name = "txbUserPassword";
            this.txbUserPassword.Size = new System.Drawing.Size(229, 27);
            this.txbUserPassword.TabIndex = 5;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblUserPassword.Location = new System.Drawing.Point(224, 193);
            this.lblUserPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(142, 22);
            this.lblUserPassword.TabIndex = 4;
            this.lblUserPassword.Text = "Criar uma senha";
            // 
            // lblUserActive
            // 
            this.lblUserActive.AutoSize = true;
            this.lblUserActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblUserActive.Location = new System.Drawing.Point(224, 381);
            this.lblUserActive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserActive.Name = "lblUserActive";
            this.lblUserActive.Size = new System.Drawing.Size(75, 22);
            this.lblUserActive.TabIndex = 9;
            this.lblUserActive.Text = "É ativo?";
            // 
            // lblUserProfile
            // 
            this.lblUserProfile.AutoSize = true;
            this.lblUserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblUserProfile.Location = new System.Drawing.Point(467, 288);
            this.lblUserProfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserProfile.Name = "lblUserProfile";
            this.lblUserProfile.Size = new System.Drawing.Size(152, 22);
            this.lblUserProfile.TabIndex = 8;
            this.lblUserProfile.Text = "Escolha seu perfil";
            // 
            // cmbUserProfile
            // 
            this.cmbUserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbUserProfile.FormattingEnabled = true;
            this.cmbUserProfile.Location = new System.Drawing.Point(471, 318);
            this.cmbUserProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUserProfile.Name = "cmbUserProfile";
            this.cmbUserProfile.Size = new System.Drawing.Size(185, 28);
            this.cmbUserProfile.TabIndex = 10;
            // 
            // ckbUserActive
            // 
            this.ckbUserActive.AutoSize = true;
            this.ckbUserActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ckbUserActive.Location = new System.Drawing.Point(316, 388);
            this.ckbUserActive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbUserActive.Name = "ckbUserActive";
            this.ckbUserActive.Size = new System.Drawing.Size(15, 14);
            this.ckbUserActive.TabIndex = 11;
            this.ckbUserActive.UseVisualStyleBackColor = true;
            // 
            // btnUserDeleteProfile
            // 
            this.btnUserDeleteProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnUserDeleteProfile.Image")));
            this.btnUserDeleteProfile.Location = new System.Drawing.Point(555, 436);
            this.btnUserDeleteProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUserDeleteProfile.Name = "btnUserDeleteProfile";
            this.btnUserDeleteProfile.Size = new System.Drawing.Size(42, 44);
            this.btnUserDeleteProfile.TabIndex = 13;
            this.btnUserDeleteProfile.UseVisualStyleBackColor = true;
            // 
            // btnUserSaveProfile
            // 
            this.btnUserSaveProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnUserSaveProfile.Image")));
            this.btnUserSaveProfile.Location = new System.Drawing.Point(618, 436);
            this.btnUserSaveProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUserSaveProfile.Name = "btnUserSaveProfile";
            this.btnUserSaveProfile.Size = new System.Drawing.Size(42, 44);
            this.btnUserSaveProfile.TabIndex = 14;
            this.btnUserSaveProfile.UseVisualStyleBackColor = true;
            // 
            // btnUserBackPages
            // 
            this.btnUserBackPages.Image = ((System.Drawing.Image)(resources.GetObject("btnUserBackPages.Image")));
            this.btnUserBackPages.Location = new System.Drawing.Point(9, 419);
            this.btnUserBackPages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUserBackPages.Name = "btnUserBackPages";
            this.btnUserBackPages.Size = new System.Drawing.Size(62, 60);
            this.btnUserBackPages.TabIndex = 15;
            this.btnUserBackPages.UseVisualStyleBackColor = true;
            // 
            // btnUserPhotoProfile
            // 
            this.btnUserPhotoProfile.Image = global::StockControl.Properties.Resources.UserIcon2;
            this.btnUserPhotoProfile.Location = new System.Drawing.Point(16, 26);
            this.btnUserPhotoProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUserPhotoProfile.Name = "btnUserPhotoProfile";
            this.btnUserPhotoProfile.Size = new System.Drawing.Size(176, 197);
            this.btnUserPhotoProfile.TabIndex = 16;
            this.btnUserPhotoProfile.UseVisualStyleBackColor = true;
            // 
            // UserDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 372);
            this.Controls.Add(this.btnUserPhotoProfile);
            this.Controls.Add(this.btnUserBackPages);
            this.Controls.Add(this.btnUserSaveProfile);
            this.Controls.Add(this.btnUserDeleteProfile);
            this.Controls.Add(this.ckbUserActive);
            this.Controls.Add(this.cmbUserProfile);
            this.Controls.Add(this.lblUserActive);
            this.Controls.Add(this.lblUserProfile);
            this.Controls.Add(this.txbUserRepassword);
            this.Controls.Add(this.lblUserRepassword);
            this.Controls.Add(this.txbUserPassword);
            this.Controls.Add(this.lblUserPassword);
            this.Controls.Add(this.txbUserEmail);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.lblUserName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserDetailsForm";
            this.Text = "Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.TextBox txbUserEmail;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.TextBox txbUserRepassword;
        private System.Windows.Forms.Label lblUserRepassword;
        private System.Windows.Forms.TextBox txbUserPassword;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblUserActive;
        private System.Windows.Forms.Label lblUserProfile;
        private System.Windows.Forms.ComboBox cmbUserProfile;
        private System.Windows.Forms.CheckBox ckbUserActive;
        private System.Windows.Forms.Button btnUserDeleteProfile;
        private System.Windows.Forms.Button btnUserSaveProfile;
        private System.Windows.Forms.Button btnUserBackPages;
        private System.Windows.Forms.Button btnUserPhotoProfile;
    }
}