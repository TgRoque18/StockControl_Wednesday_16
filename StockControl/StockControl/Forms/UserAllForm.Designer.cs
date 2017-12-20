namespace StockControl.Forms
{
    partial class UserAllForm
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
            this.tbxUserASearch = new System.Windows.Forms.TextBox();
            this.lblUserASearch = new System.Windows.Forms.Label();
            this.btnUserASearch = new System.Windows.Forms.Button();
            this.dgvUserASearch = new System.Windows.Forms.DataGridView();
            this.btnUserADelete = new System.Windows.Forms.Button();
            this.btnUserABackPages = new System.Windows.Forms.Button();
            this.btnUserAEdit = new System.Windows.Forms.Button();
            this.btnUserAAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserASearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUserASearch
            // 
            this.tbxUserASearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbxUserASearch.Location = new System.Drawing.Point(135, 33);
            this.tbxUserASearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxUserASearch.Name = "tbxUserASearch";
            this.tbxUserASearch.Size = new System.Drawing.Size(191, 26);
            this.tbxUserASearch.TabIndex = 3;
            // 
            // lblUserASearch
            // 
            this.lblUserASearch.AutoSize = true;
            this.lblUserASearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUserASearch.Location = new System.Drawing.Point(35, 39);
            this.lblUserASearch.Name = "lblUserASearch";
            this.lblUserASearch.Size = new System.Drawing.Size(84, 20);
            this.lblUserASearch.TabIndex = 2;
            this.lblUserASearch.Text = "Pesquisar";
            // 
            // btnUserASearch
            // 
            this.btnUserASearch.Location = new System.Drawing.Point(355, 42);
            this.btnUserASearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserASearch.Name = "btnUserASearch";
            this.btnUserASearch.Size = new System.Drawing.Size(20, 20);
            this.btnUserASearch.TabIndex = 15;
            this.btnUserASearch.UseVisualStyleBackColor = true;
            // 
            // dgvUserASearch
            // 
            this.dgvUserASearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserASearch.Location = new System.Drawing.Point(13, 92);
            this.dgvUserASearch.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUserASearch.Name = "dgvUserASearch";
            this.dgvUserASearch.Size = new System.Drawing.Size(480, 190);
            this.dgvUserASearch.TabIndex = 16;
            // 
            // btnUserADelete
            // 
            this.btnUserADelete.Location = new System.Drawing.Point(475, 317);
            this.btnUserADelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserADelete.Name = "btnUserADelete";
            this.btnUserADelete.Size = new System.Drawing.Size(35, 35);
            this.btnUserADelete.TabIndex = 17;
            this.btnUserADelete.UseVisualStyleBackColor = true;
            // 
            // btnUserABackPages
            // 
            this.btnUserABackPages.Image = global::StockControl.Properties.Resources.BackIcon;
            this.btnUserABackPages.Location = new System.Drawing.Point(12, 317);
            this.btnUserABackPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserABackPages.Name = "btnUserABackPages";
            this.btnUserABackPages.Size = new System.Drawing.Size(35, 35);
            this.btnUserABackPages.TabIndex = 18;
            this.btnUserABackPages.UseVisualStyleBackColor = true;
            // 
            // btnUserAEdit
            // 
            this.btnUserAEdit.Location = new System.Drawing.Point(424, 317);
            this.btnUserAEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserAEdit.Name = "btnUserAEdit";
            this.btnUserAEdit.Size = new System.Drawing.Size(35, 35);
            this.btnUserAEdit.TabIndex = 18;
            this.btnUserAEdit.UseVisualStyleBackColor = true;
            // 
            // btnUserAAdd
            // 
            this.btnUserAAdd.Location = new System.Drawing.Point(372, 317);
            this.btnUserAAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserAAdd.Name = "btnUserAAdd";
            this.btnUserAAdd.Size = new System.Drawing.Size(35, 35);
            this.btnUserAAdd.TabIndex = 19;
            this.btnUserAAdd.UseVisualStyleBackColor = true;
            // 
            // UserAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 364);
            this.Controls.Add(this.btnUserAAdd);
            this.Controls.Add(this.btnUserAEdit);
            this.Controls.Add(this.btnUserABackPages);
            this.Controls.Add(this.btnUserADelete);
            this.Controls.Add(this.dgvUserASearch);
            this.Controls.Add(this.btnUserASearch);
            this.Controls.Add(this.tbxUserASearch);
            this.Controls.Add(this.lblUserASearch);
            this.Name = "UserAllForm";
            this.Text = "Pesquisar usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserASearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUserASearch;
        private System.Windows.Forms.Label lblUserASearch;
        private System.Windows.Forms.Button btnUserASearch;
        private System.Windows.Forms.DataGridView dgvUserASearch;
        private System.Windows.Forms.Button btnUserADelete;
        private System.Windows.Forms.Button btnUserABackPages;
        private System.Windows.Forms.Button btnUserAEdit;
        private System.Windows.Forms.Button btnUserAAdd;
    }
}