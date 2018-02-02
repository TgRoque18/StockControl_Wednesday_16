using StockControl.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl
{
    public partial class FormStockEdition : Form
    {
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";
        string name = "";
        float amount = 0;
        bool active = false;

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

        void GetData()
        {
            name = tbxName.Text;
            amount = float.Parse(tbxAmount.Text);
            active = ckbActive.Checked;
        }

        void CleanData()
        {
            tbxName.Text = "";
            tbxAmount.Text = "";
            ckbActive.Checked = false;
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                GetData();

                //Conectar
                sqlConnect.Open();
                string sql = "INSERT INTO STOCK(NAME,QUANTITY, ACTIVE) VALUES (@name, @quantity, @active)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@quantity", amount));
                cmd.Parameters.Add(new SqlParameter("@active", active));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Adicionado com sucesso!");


            }
            catch (Exception ex)
            {
                //Tratar exce��es
                MessageBox.Show("Erro ao adicionar no estoque!" + ex.Message);
                CleanData();
            }
            finally
            {
                //Fechar
                sqlConnect.Close();
            }
        }
    }
}

