using StockControl.Class;
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
        int act = 0;

        public FormStockEdition()
        {
            InitializeComponent();
        }
        public FormStockEdition(int idStock)
        {
            InitializeComponent();

            lblId.Text = idStock.ToString(); //-------

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                    //Conectar
                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM STOCK WHERE ID = @id", sqlConnect);
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY WHERE ID = " + idCategory.ToString(), sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", idStock));

                    Stock stock = new Stock(); //------

                    using (SqlDataReader reader = cmd.ExecuteReader()) //-----
                    {
                        while (reader.Read())
                        {
                            stock.Id = Int32.Parse(reader["ID"].ToString());
                            stock.Quantity = Int32.Parse(reader["QUANTITY"].ToString());
                            if(Int32.Parse(reader["ACTIVE"].ToString()) == 0)
                            {
                                stock.Active = false;
                            }
                            else
                            {
                                stock.Active = true;
                            }
                            stock.Name = reader["NAME"].ToString();

                        }
                    }

                    tbxName.Text = stock.Name;
                    ckbActive.Checked = stock.Active;
                    tbxAmount.Text = stock.Quantity.ToString();

                }
                catch (Exception EX)
                {
                    //Tratar exce��es
                    MessageBox.Show(EX.Message);
                }
                finally
                {
                    //Fechar
                    sqlConnect.Close();
                }
            }
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
            if (string.IsNullOrEmpty(lblId.Text)) //-----
            {
                //Salvar
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
            else
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    sqlConnect.Open();
                    string sql = "UPDATE STOCK SET QUANTITY=@quantity, ACTIVE = @active, NAME = @name";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    if(this.ckbActive.Checked)
                    {
                        act = 1;
                    }
                    else
                    {
                        act = 0;
                    }

                    cmd.Parameters.Add(new SqlParameter("@quantity", this.tbxAmount.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", act));
                    cmd.Parameters.Add(new SqlParameter("@name", this.tbxName.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Alterações salvas com sucesso!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao editar esta estoque!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();

                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
            }
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblId.Text)) //-----
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
                {
                    //Conectar
                    sqlConnect.Open();
                    string sql = "DELETE FROM STOCK WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", this.lblId.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Removido com sucesso!");

                    //LogHelper log = new LogHelper();
                    //log.Insert("User Remove");
                }
                catch (Exception ex)
                {
                    //Tratar exce��es
                    MessageBox.Show("Erro ao remover estoque!" + ex.Message);
                    //throw;

                    //LogHelper logBD = new LogHelper();
                    //logBD.PrintLog(Convert.ToString(ex));
                }
                finally
                {
                    //Fechar
                    sqlConnect.Close();
                }
            }
        }
    }
}

