﻿using System;
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
    public partial class UserProfileAllForm : Form
    {
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";

        public UserProfileAllForm()
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

                SqlCommand cmd = new SqlCommand("SELECT * FROM USER_PROFILE", sqlConnect);
                // SqlDataReader reader = cmd.ExecuteReader();

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvUserProfile.DataSource = dt;

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
            dgvUserProfile.Columns["ID"].Visible = false;
            dgvUserProfile.Columns["NAME"].HeaderText = "Nome";
            dgvUserProfile.Columns["ACTIVE"].HeaderText = "Ativo";

            foreach (DataGridViewColumn col in dgvUserProfile.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            UserProfileDetails userProfileDetails = new UserProfileDetails();
            userProfileDetails.Show();
            this.Hide();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            UserProfileDetails userProfileDetails = new UserProfileDetails();
            userProfileDetails.Show();
            this.Hide();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            int idUserProfile = Int32.Parse(dgvUserProfile.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                //Conectar
                sqlConnect.Open();
                string sql = "DELETE FROM USER_PROFILE WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idUserProfile));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Removido com sucesso!");
                ShowData();
            }
            catch (Exception ex)
            {
                //Tratar exceções
                MessageBox.Show("Erro ao remover Usuário!" + "\n\n" + ex.Message);
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
