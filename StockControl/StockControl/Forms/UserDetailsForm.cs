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
    public partial class UserDetailsForm : Form
    {

        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size = 4096; user id = luacademy_SQLLogin_1; pwd=msctq6gvt3;data source = StockControl.mssql.somee.com; persist security info=False;initial catalog = StockControl";

        public UserDetailsForm()
        {
            InitializeComponent();
        }

        private void pbxUserBackPages_Click(object sender, EventArgs e)
        {
            UserAllForm userAllForm = new UserAllForm();
            userAllForm.Show();
            this.Hide();
        }

        private void pbxUserSaveProfile_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                GetData();

                //Conectar
                sqlConnect.Open();
                string sql = "INSERT INTO USER(NAME,PASSWORD,EMAIL,ACTIVE) VALUES (@id, @name, @password, @email, @active)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);
                
                //cmd.Parameters.Add(new SqlParameter("@name", name));
                //cmd.Parameters.Add(new SqlParameter("@password", password));
                //cmd.Parameters.Add(new SqlParameter("@email", email));
                //cmd.Parameters.Add(new SqlParameter("@active", active));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuário adicionado com sucesso!");


            }
            catch (Exception ex)
            {
                //Tratar exceções
                MessageBox.Show("Erro ao adicionar o usuário!" + ex.Message);
                CleanData();
            }
            finally
            {
                //Fechar
                sqlConnect.Close();
            }
        }




        private void CleanData()
        {
            throw new NotImplementedException();
        }

        private void GetData()
        {
            throw new NotImplementedException();
        }
    }
}
