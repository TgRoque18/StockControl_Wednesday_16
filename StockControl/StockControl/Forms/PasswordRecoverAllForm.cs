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
    public partial class PasswordRecoverAllForm : Form
    {
        public PasswordRecoverAllForm()
        {
            InitializeComponent();
        }

        private void btnRecoverPassword_Click(object sender, EventArgs e)
        {
            LoginAllForm login = new LoginAllForm();
            login.Show();
            this.Hide();
        }
    }
}
