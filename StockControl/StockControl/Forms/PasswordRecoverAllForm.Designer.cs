﻿namespace StockControl.Forms
{
    partial class PasswordRecoverAllForm
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.btnRecoverPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(23, 47);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login :";
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(83, 47);
            this.tbxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(68, 20);
            this.tbxLogin.TabIndex = 2;
            // 
            // btnRecoverPassword
            // 
            this.btnRecoverPassword.Location = new System.Drawing.Point(71, 99);
            this.btnRecoverPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecoverPassword.Name = "btnRecoverPassword";
            this.btnRecoverPassword.Size = new System.Drawing.Size(67, 31);
            this.btnRecoverPassword.TabIndex = 1;
            this.btnRecoverPassword.Text = "Recuperar Senha";
            this.btnRecoverPassword.UseVisualStyleBackColor = true;
            this.btnRecoverPassword.Click += new System.EventHandler(this.btnRecoverPassword_Click);
            // 
            // PasswordRecoverAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 159);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.btnRecoverPassword);
            this.Controls.Add(this.lblLogin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PasswordRecoverAllForm";
            this.Text = "Recuperação de senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.Button btnRecoverPassword;
    }
}