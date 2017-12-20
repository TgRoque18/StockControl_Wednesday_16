namespace StockControl.Forms
{
    partial class FormLog
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
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.btnLogBackPages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLog
            // 
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Location = new System.Drawing.Point(14, 47);
            this.dgvLog.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.Size = new System.Drawing.Size(495, 215);
            this.dgvLog.TabIndex = 17;
            // 
            // btnLogBackPages
            // 
            this.btnLogBackPages.Location = new System.Drawing.Point(12, 317);
            this.btnLogBackPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogBackPages.Name = "btnLogBackPages";
            this.btnLogBackPages.Size = new System.Drawing.Size(35, 35);
            this.btnLogBackPages.TabIndex = 19;
            this.btnLogBackPages.UseVisualStyleBackColor = true;
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(523, 364);
            this.Controls.Add(this.btnLogBackPages);
            this.Controls.Add(this.dgvLog);
            this.Name = "FormLog";
            this.Text = "Log";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.Button btnLogBackPages;
    }
}