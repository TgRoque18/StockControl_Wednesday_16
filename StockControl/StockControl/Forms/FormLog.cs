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
    public partial class FormLog : Form
    {
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";

        public FormLog()
        {            
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        public void Save()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {               
                //Conectar
                sqlConnect.Open();
                string sql = "INSERT INTO LOG(NAME, ACTIVE) VALUES (@name, @active)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                //cmd.Parameters.Add(new SqlParameter("@name", name));
                //cmd.Parameters.Add(new SqlParameter("@active", active));

                cmd.ExecuteNonQuery();               

            }
            catch (Exception ex)
            {
                //Tratar exceções
                MessageBox.Show("Erro ao criar log!" + ex.Message);        
            }
            finally
            {
                //Fechar
                sqlConnect.Close();
            }
        }

    }
}
