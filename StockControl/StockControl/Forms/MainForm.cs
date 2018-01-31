using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pbxStock_Click(object sender, EventArgs e)
        {
            FormStockExibition stockAllForm = new FormStockExibition();
            stockAllForm.Show();
            this.Hide();
        }

        private void pbxCategory_Click(object sender, EventArgs e)
        {
            CategoryAllForm categoryAllForm = new CategoryAllForm();
            categoryAllForm.Show();
            this.Hide();
        }

        private void pbxUser_Click(object sender, EventArgs e)
        {
            UserAllForm userAllForm = new UserAllForm();
            userAllForm.Show();
            this.Hide();
        }

        private void pbxUserProfile_Click(object sender, EventArgs e)
        {
            UserProfileAllForm userProfileAllForm = new UserProfileAllForm();
            userProfileAllForm.Show();
            this.Hide();
                
        }

        private void pbxLog_Click(object sender, EventArgs e)
        {
            FormLog logForm = new FormLog();
            logForm.Show();
            this.Hide();
        }

        private void pbxHomeLogin_Click(object sender, EventArgs e)
        {
            LoginAllForm loginAllForm = new LoginAllForm();
            loginAllForm.Show();
            this.Hide();
        }

        private void pbxProduct_Click(object sender, EventArgs e)
        {
            ProductAllForm productAllForm = new ProductAllForm();
            productAllForm.Show();
            this.Hide();
        }

        private void pbxStock_MouseEnter(object sender, EventArgs e)
        {
            lblStock.Visible = true;
            pbxStock.BackColor = Color.Blue;
        }

        private void pbxStock_MouseLeave(object sender, EventArgs e)
        {
            lblStock.Visible = false;
            pbxStock.BackColor = Color.Transparent;
        }

        private void pbxUserProfile_MouseEnter(object sender, EventArgs e)
        {
            lblProfile.Visible = true;
            pbxUserProfile.BackColor = Color.Blue;
        }

        private void pbxUserProfile_MouseLeave(object sender, EventArgs e)
        {
            lblProfile.Visible = false;
            pbxUserProfile.BackColor = Color.Transparent;
        }
    }
}
