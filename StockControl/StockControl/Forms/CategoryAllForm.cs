using StockControl.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl
{
    public partial class CategoryAllForm : Form
    {
        public CategoryAllForm()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            CategoryDetailsForm categoryDetailForm = new CategoryDetailsForm();
            categoryDetailForm.Show();
            this.Hide();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            CategoryDetailsForm categoryDetailForm = new CategoryDetailsForm();
            categoryDetailForm.Show();
            this.Hide();
        }
    }
}
