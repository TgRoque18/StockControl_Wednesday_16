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
    public partial class FormStockEdition : Form
    {
        public FormStockEdition()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            FormStockExibition stockAllForm = new FormStockExibition();
            stockAllForm.Show();
            this.Hide();
        }
    }
}

