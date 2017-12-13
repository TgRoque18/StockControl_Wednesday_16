namespace StockControl
{
    partial class FormStockEdition
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ckbActive = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(49, 66);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(49, 128);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(106, 22);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Quantidade:";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.Location = new System.Drawing.Point(56, 190);
            this.lblActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(61, 22);
            this.lblActive.TabIndex = 2;
            this.lblActive.Text = "Ativo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 127);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 22);
            this.textBox2.TabIndex = 4;
            // 
            // ckbActive
            // 
            this.ckbActive.AutoSize = true;
            this.ckbActive.Location = new System.Drawing.Point(191, 194);
            this.ckbActive.Margin = new System.Windows.Forms.Padding(4);
            this.ckbActive.Name = "ckbActive";
            this.ckbActive.Size = new System.Drawing.Size(18, 17);
            this.ckbActive.TabIndex = 5;
            this.ckbActive.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = global::StockControl.Properties.Resources.DeleteIcon;
            this.btnDelete.Location = new System.Drawing.Point(532, 293);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 63);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = global::StockControl.Properties.Resources.SaveIcon1;
            this.btnSave.Location = new System.Drawing.Point(301, 293);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 63);
            this.btnSave.TabIndex = 7;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::StockControl.Properties.Resources.BackIcon3;
            this.btnBack.Location = new System.Drawing.Point(87, 293);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 63);
            this.btnBack.TabIndex = 6;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // FormStockEdition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 370);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ckbActive);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStockEdition";
            this.Text = "FormStockEdition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox ckbActive;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}