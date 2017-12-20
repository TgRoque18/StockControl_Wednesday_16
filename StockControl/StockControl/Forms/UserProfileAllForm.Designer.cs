namespace StockControl.Forms
{
    partial class UserProfileAllForm
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.pbxEdit = new System.Windows.Forms.PictureBox();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.pbxSave = new System.Windows.Forms.PictureBox();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.dtgUserProfileA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUserProfileA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(13, 39);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(79, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Pesquisar :";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(99, 37);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(108, 20);
            this.tbxSearch.TabIndex = 1;
            // 
            // pbxBack
            // 
            this.pbxBack.Location = new System.Drawing.Point(27, 325);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(35, 35);
            this.pbxBack.TabIndex = 4;
            this.pbxBack.TabStop = false;
            // 
            // pbxEdit
            // 
            this.pbxEdit.Location = new System.Drawing.Point(413, 325);
            this.pbxEdit.Name = "pbxEdit";
            this.pbxEdit.Size = new System.Drawing.Size(35, 35);
            this.pbxEdit.TabIndex = 5;
            this.pbxEdit.TabStop = false;
            // 
            // pbxDelete
            // 
            this.pbxDelete.Location = new System.Drawing.Point(454, 325);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(35, 35);
            this.pbxDelete.TabIndex = 6;
            this.pbxDelete.TabStop = false;
            // 
            // pbxSave
            // 
            this.pbxSave.Location = new System.Drawing.Point(372, 325);
            this.pbxSave.Name = "pbxSave";
            this.pbxSave.Size = new System.Drawing.Size(35, 35);
            this.pbxSave.TabIndex = 7;
            this.pbxSave.TabStop = false;
            // 
            // pbxSearch
            // 
            this.pbxSearch.Location = new System.Drawing.Point(224, 37);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(20, 20);
            this.pbxSearch.TabIndex = 8;
            this.pbxSearch.TabStop = false;
            // 
            // dtgUserProfileA
            // 
            this.dtgUserProfileA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUserProfileA.Location = new System.Drawing.Point(77, 77);
            this.dtgUserProfileA.Name = "dtgUserProfileA";
            this.dtgUserProfileA.Size = new System.Drawing.Size(371, 224);
            this.dtgUserProfileA.TabIndex = 11;
            // 
            // UserProfileAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 372);
            this.Controls.Add(this.dtgUserProfileA);
            this.Controls.Add(this.pbxSearch);
            this.Controls.Add(this.pbxSave);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.pbxEdit);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserProfileAllForm";
            this.Text = "Perfil de Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUserProfileA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxEdit;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.PictureBox pbxSave;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.DataGridView dtgUserProfileA;
    }
}