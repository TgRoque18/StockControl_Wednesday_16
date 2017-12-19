namespace StockControl.Forms
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
            this.btnRecoverPassword = new System.Windows.Forms.Button();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(35, 72);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(56, 20);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login :";
            // 
            // btnRecoverPassword
            // 
            this.btnRecoverPassword.Location = new System.Drawing.Point(107, 152);
            this.btnRecoverPassword.Name = "btnRecoverPassword";
            this.btnRecoverPassword.Size = new System.Drawing.Size(100, 48);
            this.btnRecoverPassword.TabIndex = 1;
            this.btnRecoverPassword.Text = "Recuperar Senha";
            this.btnRecoverPassword.UseVisualStyleBackColor = true;
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(125, 72);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(100, 26);
            this.tbxLogin.TabIndex = 2;
            // 
            // PasswordRecoverAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.btnRecoverPassword);
            this.Controls.Add(this.lblLogin);
            this.Name = "PasswordRecoverAllForm";
            this.Text = "PasswordRecoverAllForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnRecoverPassword;
        private System.Windows.Forms.TextBox tbxLogin;
    }
}