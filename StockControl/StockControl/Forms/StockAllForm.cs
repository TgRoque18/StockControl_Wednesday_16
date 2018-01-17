using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockControl.Forms;

namespace StockControl
{
    public partial class FormStockExibition : Form
    {
        public FormStockExibition()
        {
            InitializeComponent();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            FormStockEdition formStockEdition = new FormStockEdition();
            formStockEdition.Show();
            this.Hide();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            FormStockEdition formStockEdition = new FormStockEdition();
            formStockEdition.Show();
            this.Hide();
        }

        private void FormStockExibition_Load(object sender, EventArgs e)
        {

        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        } 
    }
}
