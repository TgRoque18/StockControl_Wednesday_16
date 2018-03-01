namespace StockControl
{
    partial class FormStockExibition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStockExibition));
            this.lblName = new System.Windows.Forms.Label();
            this.tbxsearch = new System.Windows.Forms.TextBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.pbxSave = new System.Windows.Forms.PictureBox();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.pbxEdit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 49);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Pesquisar:";
            // 
            // tbxsearch
            // 
            this.tbxsearch.Location = new System.Drawing.Point(150, 51);
            this.tbxsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxsearch.Name = "tbxsearch";
            this.tbxsearch.Size = new System.Drawing.Size(229, 26);
            this.tbxsearch.TabIndex = 2;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStock.Location = new System.Drawing.Point(129, 125);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(556, 345);
            this.dgvStock.TabIndex = 10;
            // 
            // pbxSearch
            // 
            this.pbxSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxSearch.BackgroundImage")));
            this.pbxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxSearch.Location = new System.Drawing.Point(404, 51);
            this.pbxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(30, 31);
            this.pbxSearch.TabIndex = 26;
            this.pbxSearch.TabStop = false;
            // 
            // pbxBack
            // 
            this.pbxBack.BackgroundImage = global::StockControl.Properties.Resources.BackIcon;
            this.pbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxBack.Location = new System.Drawing.Point(68, 500);
            this.pbxBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(52, 54);
            this.pbxBack.TabIndex = 27;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // pbxSave
            // 
            this.pbxSave.BackgroundImage = global::StockControl.Properties.Resources.Add_icon_old_;
            this.pbxSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxSave.Location = new System.Drawing.Point(537, 500);
            this.pbxSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxSave.Name = "pbxSave";
            this.pbxSave.Size = new System.Drawing.Size(52, 54);
            this.pbxSave.TabIndex = 28;
            this.pbxSave.TabStop = false;
            this.pbxSave.Click += new System.EventHandler(this.pbxSave_Click);
            // 
            // pbxDelete
            // 
            this.pbxDelete.BackgroundImage = global::StockControl.Properties.Resources.DeleteIcon;
            this.pbxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxDelete.Location = new System.Drawing.Point(687, 500);
            this.pbxDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(52, 54);
            this.pbxDelete.TabIndex = 29;
            this.pbxDelete.TabStop = false;
            this.pbxDelete.Click += new System.EventHandler(this.pbxDelete_Click);
            // 
            // pbxEdit
            // 
            this.pbxEdit.BackgroundImage = global::StockControl.Properties.Resources.Edit_icon_old_;
            this.pbxEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxEdit.Location = new System.Drawing.Point(610, 500);
            this.pbxEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxEdit.Name = "pbxEdit";
            this.pbxEdit.Size = new System.Drawing.Size(52, 54);
            this.pbxEdit.TabIndex = 30;
            this.pbxEdit.TabStop = false;
            this.pbxEdit.Click += new System.EventHandler(this.pbxEdit_Click);
            // 
            // FormStockExibition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 572);
            this.Controls.Add(this.pbxEdit);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.pbxSave);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.pbxSearch);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.tbxsearch);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormStockExibition";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.FormStockExibition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxsearch;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxSave;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.PictureBox pbxEdit;
    }
}