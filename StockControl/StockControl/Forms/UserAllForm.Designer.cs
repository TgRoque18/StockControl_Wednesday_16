﻿namespace StockControl.Forms
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
            this.dgvUserASearch = new System.Windows.Forms.DataGridView();
            this.pbxUserSearch = new System.Windows.Forms.PictureBox();
            this.pbxUserBackPages = new System.Windows.Forms.PictureBox();
            this.pbxUserAdd = new System.Windows.Forms.PictureBox();
            this.pbxUserEdit = new System.Windows.Forms.PictureBox();
            this.pbxUserDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserASearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserBackPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUserASearch
            // 
            this.tbxUserASearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbxUserASearch.Location = new System.Drawing.Point(135, 33);
            this.tbxUserASearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxUserASearch.Name = "tbxUserASearch";
            this.tbxUserASearch.Size = new System.Drawing.Size(191, 23);
            this.tbxUserASearch.TabIndex = 3;
            // 
            // lblUserASearch
            // 
            this.lblUserASearch.AutoSize = true;
            this.lblUserASearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUserASearch.Location = new System.Drawing.Point(35, 39);
            this.lblUserASearch.Name = "lblUserASearch";
            this.lblUserASearch.Size = new System.Drawing.Size(71, 17);
            this.lblUserASearch.TabIndex = 2;
            this.lblUserASearch.Text = "Pesquisar";
            // 
            // dgvUserASearch
            // 
            this.dgvUserASearch.AllowUserToAddRows = false;
            this.dgvUserASearch.AllowUserToOrderColumns = true;
            this.dgvUserASearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserASearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUserASearch.Location = new System.Drawing.Point(31, 92);
            this.dgvUserASearch.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUserASearch.MultiSelect = false;
            this.dgvUserASearch.Name = "dgvUserASearch";
            this.dgvUserASearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserASearch.Size = new System.Drawing.Size(462, 190);
            this.dgvUserASearch.TabIndex = 16;
            // 
            // pbxUserSearch
            // 
            this.pbxUserSearch.BackgroundImage = global::StockControl.Properties.Resources.Search_icon_old_;
            this.pbxUserSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUserSearch.Location = new System.Drawing.Point(345, 39);
            this.pbxUserSearch.Name = "pbxUserSearch";
            this.pbxUserSearch.Size = new System.Drawing.Size(20, 20);
            this.pbxUserSearch.TabIndex = 24;
            this.pbxUserSearch.TabStop = false;
            // 
            // pbxUserBackPages
            // 
            this.pbxUserBackPages.BackgroundImage = global::StockControl.Properties.Resources.back;
            this.pbxUserBackPages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUserBackPages.Location = new System.Drawing.Point(12, 317);
            this.pbxUserBackPages.Name = "pbxUserBackPages";
            this.pbxUserBackPages.Size = new System.Drawing.Size(35, 35);
            this.pbxUserBackPages.TabIndex = 23;
            this.pbxUserBackPages.TabStop = false;
            this.pbxUserBackPages.Click += new System.EventHandler(this.pbxUserBackPages_Click);
            // 
            // pbxUserAdd
            // 
            this.pbxUserAdd.BackgroundImage = global::StockControl.Properties.Resources.add;
            this.pbxUserAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxUserAdd.Location = new System.Drawing.Point(372, 317);
            this.pbxUserAdd.Name = "pbxUserAdd";
            this.pbxUserAdd.Size = new System.Drawing.Size(35, 35);
            this.pbxUserAdd.TabIndex = 22;
            this.pbxUserAdd.TabStop = false;
            this.pbxUserAdd.Click += new System.EventHandler(this.pbxUserAdd_Click);
            // 
            // pbxUserEdit
            // 
            this.pbxUserEdit.BackgroundImage = global::StockControl.Properties.Resources.edit;
            this.pbxUserEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxUserEdit.Location = new System.Drawing.Point(424, 317);
            this.pbxUserEdit.Name = "pbxUserEdit";
            this.pbxUserEdit.Size = new System.Drawing.Size(35, 35);
            this.pbxUserEdit.TabIndex = 21;
            this.pbxUserEdit.TabStop = false;
            this.pbxUserEdit.Click += new System.EventHandler(this.pbxUserEdit_Click);
            // 
            // pbxUserDelete
            // 
            this.pbxUserDelete.BackgroundImage = global::StockControl.Properties.Resources.delete;
            this.pbxUserDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxUserDelete.Location = new System.Drawing.Point(476, 317);
            this.pbxUserDelete.Name = "pbxUserDelete";
            this.pbxUserDelete.Size = new System.Drawing.Size(35, 35);
            this.pbxUserDelete.TabIndex = 20;
            this.pbxUserDelete.TabStop = false;
            this.pbxUserDelete.Click += new System.EventHandler(this.pbxUserDelete_Click);
            // 
            // UserAllForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(523, 364);
            this.Controls.Add(this.pbxUserSearch);
            this.Controls.Add(this.pbxUserBackPages);
            this.Controls.Add(this.pbxUserAdd);
            this.Controls.Add(this.pbxUserEdit);
            this.Controls.Add(this.pbxUserDelete);
            this.Controls.Add(this.dgvUserASearch);
            this.Controls.Add(this.tbxUserASearch);
            this.Controls.Add(this.lblUserASearch);
            this.Name = "UserAllForm";
            this.Text = "Pesquisar usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserASearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserBackPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUserASearch;
        private System.Windows.Forms.Label lblUserASearch;
        private System.Windows.Forms.DataGridView dgvUserASearch;
        private System.Windows.Forms.PictureBox pbxUserDelete;
        private System.Windows.Forms.PictureBox pbxUserEdit;
        private System.Windows.Forms.PictureBox pbxUserAdd;
        private System.Windows.Forms.PictureBox pbxUserBackPages;
        private System.Windows.Forms.PictureBox pbxUserSearch;
    }
}