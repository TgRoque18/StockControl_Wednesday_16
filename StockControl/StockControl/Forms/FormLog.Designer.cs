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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLog));
            this.dgvLogSearch = new System.Windows.Forms.DataGridView();
            this.tbxLogSearch = new System.Windows.Forms.TextBox();
            this.lblLogSearch = new System.Windows.Forms.Label();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
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
            // tbxLogSearch
            // 
            this.tbxLogSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbxLogSearch.Location = new System.Drawing.Point(112, 14);
            this.tbxLogSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxLogSearch.Name = "tbxLogSearch";
            this.tbxLogSearch.Size = new System.Drawing.Size(191, 23);
            this.tbxLogSearch.TabIndex = 21;
            // 
            // lblLogSearch
            // 
            this.lblLogSearch.AutoSize = true;
            this.lblLogSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLogSearch.Location = new System.Drawing.Point(12, 20);
            this.lblLogSearch.Name = "lblLogSearch";
            this.lblLogSearch.Size = new System.Drawing.Size(71, 17);
            this.lblLogSearch.TabIndex = 20;
            this.lblLogSearch.Text = "Pesquisar";
            // 
            // pbxSearch
            // 
            this.pbxSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxSearch.BackgroundImage")));
            this.pbxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxSearch.Location = new System.Drawing.Point(320, 17);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(20, 20);
            this.pbxSearch.TabIndex = 31;
            this.pbxSearch.TabStop = false;
            // 
            // pbxBack
            // 
            this.pbxBack.BackgroundImage = global::StockControl.Properties.Resources.back;
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxBack.Location = new System.Drawing.Point(35, 317);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(35, 35);
            this.pbxBack.TabIndex = 24;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // FormLog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(523, 364);
            this.Controls.Add(this.pbxSearch);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.tbxLogSearch);
            this.Controls.Add(this.lblLogSearch);
            this.Controls.Add(this.dgvLogSearch);
            this.Name = "FormLog";
            this.Text = "Log";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogSearch;
        private System.Windows.Forms.TextBox tbxLogSearch;
        private System.Windows.Forms.Label lblLogSearch;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxSearch;
    }
}