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
            this.dgvLogSearch = new System.Windows.Forms.DataGridView();
            this.btnLogBackPages = new System.Windows.Forms.Button();
            this.btnLogSearch = new System.Windows.Forms.Button();
            this.tbxLogSearch = new System.Windows.Forms.TextBox();
            this.lblLogSearch = new System.Windows.Forms.Label();
            this.btnLgAdd = new System.Windows.Forms.Button();
            this.btnLogEdit = new System.Windows.Forms.Button();
            this.btnLogDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLogSearch
            // 
            this.dgvLogSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogSearch.Location = new System.Drawing.Point(12, 58);
            this.dgvLogSearch.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLogSearch.Name = "dgvLogSearch";
            this.dgvLogSearch.Size = new System.Drawing.Size(495, 215);
            this.dgvLogSearch.TabIndex = 17;
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
            // btnLogSearch
            // 
            this.btnLogSearch.Location = new System.Drawing.Point(332, 23);
            this.btnLogSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogSearch.Name = "btnLogSearch";
            this.btnLogSearch.Size = new System.Drawing.Size(20, 20);
            this.btnLogSearch.TabIndex = 22;
            this.btnLogSearch.UseVisualStyleBackColor = true;
            // 
            // tbxLogSearch
            // 
            this.tbxLogSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbxLogSearch.Location = new System.Drawing.Point(112, 14);
            this.tbxLogSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxLogSearch.Name = "tbxLogSearch";
            this.tbxLogSearch.Size = new System.Drawing.Size(191, 26);
            this.tbxLogSearch.TabIndex = 21;
            // 
            // lblLogSearch
            // 
            this.lblLogSearch.AutoSize = true;
            this.lblLogSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLogSearch.Location = new System.Drawing.Point(12, 20);
            this.lblLogSearch.Name = "lblLogSearch";
            this.lblLogSearch.Size = new System.Drawing.Size(84, 20);
            this.lblLogSearch.TabIndex = 20;
            this.lblLogSearch.Text = "Pesquisar";
            // 
            // btnLgAdd
            // 
            this.btnLgAdd.Location = new System.Drawing.Point(373, 318);
            this.btnLgAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLgAdd.Name = "btnLgAdd";
            this.btnLgAdd.Size = new System.Drawing.Size(35, 35);
            this.btnLgAdd.TabIndex = 25;
            this.btnLgAdd.UseVisualStyleBackColor = true;
            // 
            // btnLogEdit
            // 
            this.btnLogEdit.Location = new System.Drawing.Point(425, 318);
            this.btnLogEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogEdit.Name = "btnLogEdit";
            this.btnLogEdit.Size = new System.Drawing.Size(35, 35);
            this.btnLogEdit.TabIndex = 24;
            this.btnLogEdit.UseVisualStyleBackColor = true;
            // 
            // btnLogDelete
            // 
            this.btnLogDelete.Location = new System.Drawing.Point(476, 318);
            this.btnLogDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogDelete.Name = "btnLogDelete";
            this.btnLogDelete.Size = new System.Drawing.Size(35, 35);
            this.btnLogDelete.TabIndex = 23;
            this.btnLogDelete.UseVisualStyleBackColor = true;
            // 
            // FormLog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(523, 364);
            this.Controls.Add(this.btnLgAdd);
            this.Controls.Add(this.btnLogEdit);
            this.Controls.Add(this.btnLogDelete);
            this.Controls.Add(this.btnLogSearch);
            this.Controls.Add(this.tbxLogSearch);
            this.Controls.Add(this.lblLogSearch);
            this.Controls.Add(this.btnLogBackPages);
            this.Controls.Add(this.dgvLogSearch);
            this.Name = "FormLog";
            this.Text = "Log";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogSearch;
        private System.Windows.Forms.Button btnLogBackPages;
        private System.Windows.Forms.Button btnLogSearch;
        private System.Windows.Forms.TextBox tbxLogSearch;
        private System.Windows.Forms.Label lblLogSearch;
        private System.Windows.Forms.Button btnLgAdd;
        private System.Windows.Forms.Button btnLogEdit;
        private System.Windows.Forms.Button btnLogDelete;
    }
}