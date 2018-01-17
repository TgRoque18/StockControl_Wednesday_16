﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl.Forms
{
    public partial class ProducDetailslForm : Form
    {
        string name = "";
        float price = 0;
        string category = "";
        bool active = false;

        public ProducDetailslForm()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            ProductAllForm productAllForm = new ProductAllForm();
            productAllForm.Show();
            this.Hide();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            GetData();
        }

        void GetData()
        {
            name = tbxName.Text;
            price = float.Parse(tbxPrice.Text);
            category = cmbCategory.Text;
            active = ckbActive.Checked;
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
