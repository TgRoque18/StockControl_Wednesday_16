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
using System.Data.SqlClient;

namespace StockControl
{
    public partial class FormStockExibition : Form
    {
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";

        public FormStockExibition()
        {
            InitializeComponent();
            ShowData();
            ResizeDataGridView();
        }

        private void ShowData()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM STOCK", sqlConnect);
                // SqlDataReader reader = cmd.ExecuteReader();

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvStock.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar. " + ex.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void ResizeDataGridView()
        {
            dgvStock.Columns["ID"].Visible = false;
            dgvStock.Columns["NAME"].HeaderText = "Nome";
            dgvStock.Columns["ACTIVE"].HeaderText = "Ativo";
            dgvStock.Columns["QUANTITY"].HeaderText = "Qtd";
            dgvStock.Columns["FK_PRODUCT"].Visible = false;

            foreach (DataGridViewColumn col in dgvStock.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
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

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            int idStock = Int32.Parse(dgvStock.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                //Conectar
                sqlConnect.Open();
                string sql = "DELETE FROM STOCK WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idStock));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Removido com sucesso!");
                ShowData();
            }
            catch (Exception ex)
            {
                //Tratar exceções
                MessageBox.Show("Erro ao remover Stock!" + "\n\n" + ex.Message);
                throw;
            }
            finally
            {
                //Fechar
                sqlConnect.Close();
            }
        }
    }
}

