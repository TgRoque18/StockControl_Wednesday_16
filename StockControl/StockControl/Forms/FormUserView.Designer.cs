namespace StockControl.Forms
{
    partial class FormUserView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserView));
            this.ckbUserActive = new System.Windows.Forms.CheckBox();
            this.cmbUserProfile = new System.Windows.Forms.ComboBox();
            this.lblUserActive = new System.Windows.Forms.Label();
            this.lblUserProfile = new System.Windows.Forms.Label();
            this.txbUserEmail = new System.Windows.Forms.TextBox();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnUserPhotoProfile = new System.Windows.Forms.Button();
            this.btnUserBackPagesView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckbUserActive
            // 
            this.ckbUserActive.AutoSize = true;
            this.ckbUserActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ckbUserActive.Location = new System.Drawing.Point(147, 447);
            this.ckbUserActive.Name = "ckbUserActive";
            this.ckbUserActive.Size = new System.Drawing.Size(18, 17);
            this.ckbUserActive.TabIndex = 28;
            this.ckbUserActive.UseVisualStyleBackColor = true;
            // 
            // cmbUserProfile
            // 
            this.cmbUserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbUserProfile.FormattingEnabled = true;
            this.cmbUserProfile.Location = new System.Drawing.Point(412, 463);
            this.cmbUserProfile.Name = "cmbUserProfile";
            this.cmbUserProfile.Size = new System.Drawing.Size(245, 33);
            this.cmbUserProfile.TabIndex = 27;
            // 
            // lblUserActive
            // 
            this.lblUserActive.AutoSize = true;
            this.lblUserActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblUserActive.Location = new System.Drawing.Point(14, 439);
            this.lblUserActive.Name = "lblUserActive";
            this.lblUserActive.Size = new System.Drawing.Size(61, 26);
            this.lblUserActive.TabIndex = 26;
            this.lblUserActive.Text = "Ativo";
            // 
            // lblUserProfile
            // 
            this.lblUserProfile.AutoSize = true;
            this.lblUserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblUserProfile.Location = new System.Drawing.Point(407, 425);
            this.lblUserProfile.Name = "lblUserProfile";
            this.lblUserProfile.Size = new System.Drawing.Size(62, 26);
            this.lblUserProfile.TabIndex = 25;
            this.lblUserProfile.Text = "Perfil";
            // 
            // txbUserEmail
            // 
            this.txbUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txbUserEmail.Location = new System.Drawing.Point(412, 374);
            this.txbUserEmail.Name = "txbUserEmail";
            this.txbUserEmail.Size = new System.Drawing.Size(359, 32);
            this.txbUserEmail.TabIndex = 20;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblUserEmail.Location = new System.Drawing.Point(407, 324);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(68, 26);
            this.lblUserEmail.TabIndex = 19;
            this.lblUserEmail.Text = "Email";
            // 
            // tbxUserName
            // 
            this.tbxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbxUserName.Location = new System.Drawing.Point(19, 374);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(359, 32);
            this.tbxUserName.TabIndex = 18;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblUserName.Location = new System.Drawing.Point(14, 330);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(71, 26);
            this.lblUserName.TabIndex = 17;
            this.lblUserName.Text = "Nome";
            // 
            // btnUserPhotoProfile
            // 
            this.btnUserPhotoProfile.Image = global::StockControl.Properties.Resources.UserIcon2;
            this.btnUserPhotoProfile.Location = new System.Drawing.Point(214, 12);
            this.btnUserPhotoProfile.Name = "btnUserPhotoProfile";
            this.btnUserPhotoProfile.Size = new System.Drawing.Size(314, 298);
            this.btnUserPhotoProfile.TabIndex = 32;
            this.btnUserPhotoProfile.UseVisualStyleBackColor = true;
            // 
            // btnUserBackPagesView
            // 
            this.btnUserBackPagesView.Image = ((System.Drawing.Image)(resources.GetObject("btnUserBackPagesView.Image")));
            this.btnUserBackPagesView.Location = new System.Drawing.Point(19, 515);
            this.btnUserBackPagesView.Name = "btnUserBackPagesView";
            this.btnUserBackPagesView.Size = new System.Drawing.Size(83, 74);
            this.btnUserBackPagesView.TabIndex = 31;
            this.btnUserBackPagesView.UseVisualStyleBackColor = true;
            // 
            // FormUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 602);
            this.Controls.Add(this.btnUserPhotoProfile);
            this.Controls.Add(this.btnUserBackPagesView);
            this.Controls.Add(this.ckbUserActive);
            this.Controls.Add(this.cmbUserProfile);
            this.Controls.Add(this.lblUserActive);
            this.Controls.Add(this.lblUserProfile);
            this.Controls.Add(this.txbUserEmail);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.lblUserName);
            this.Name = "FormUserView";
            this.Text = "FormUserView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserPhotoProfile;
        private System.Windows.Forms.Button btnUserBackPagesView;
        private System.Windows.Forms.CheckBox ckbUserActive;
        private System.Windows.Forms.ComboBox cmbUserProfile;
        private System.Windows.Forms.Label lblUserActive;
        private System.Windows.Forms.Label lblUserProfile;
        private System.Windows.Forms.TextBox txbUserEmail;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label lblUserName;
    }
}