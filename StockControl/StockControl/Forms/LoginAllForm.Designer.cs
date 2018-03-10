namespace StockControl.Forms
{
    partial class LoginAllForm
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(142, 134);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 25);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Senha :";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(142, 92);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(71, 25);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login :";
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(250, 92);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(235, 26);
            this.tbxLogin.TabIndex = 4;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(250, 129);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(235, 26);
            this.tbxPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(286, 260);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 80);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 405);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPassword);
            this.Name = "LoginAllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}