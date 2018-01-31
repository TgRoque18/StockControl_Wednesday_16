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

namespace StockControl.Forms
{
    public partial class UserAllForm : Form
    {
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";


        public UserAllForm()
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

                SqlCommand cmd = new SqlCommand("SELECT * FROM USER", sqlConnect);
                // SqlDataReader reader = cmd.ExecuteReader();

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvUserASearch.DataSource = dt;

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
            dgvUserASearch.Columns["ID"].Visible = false;
            dgvUserASearch.Columns["NAME"].HeaderText = "Nome";
            dgvUserASearch.Columns["PASSWORD"].Visible = false;
            dgvUserASearch.Columns["EMAIL"].HeaderText = "Email";
            dgvUserASearch.Columns["ACTIVE"].HeaderText = "Ativo";           
            dgvUserASearch.Columns["FK_USER_PROFILE"].Visible = false;

            foreach (DataGridViewColumn col in dgvUserASearch.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void pbxUserBackPages_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }


        private void pbxUserAdd_Click(object sender, EventArgs e)
        {
            UserDetailsForm userdetailsform = new UserDetailsForm();
            userdetailsform.Show();
            this.Hide();
        }

        private void pbxUserEdit_Click(object sender, EventArgs e)
        {
            UserDetailsForm userdetailsform = new UserDetailsForm();
            userdetailsform.Show();
            this.Hide();
        }

        private void pbxUserDelete_Click(object sender, EventArgs e)
        {
            int idUser = Int32.Parse(dgvUserASearch.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                //Conectar
                sqlConnect.Open();
                string sql = "DELETE FROM CATEGORY WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idUser));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuário removido com sucesso!");
                ShowData();
            }
            catch (Exception ex)
            {
                //Tratar exceções
                MessageBox.Show("Erro ao remover usuário!" + "\n\n" + ex.Message);
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

