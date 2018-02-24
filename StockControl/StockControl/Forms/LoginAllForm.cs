using StockControl.Class;
using StockControl.Helper;
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
    public partial class LoginAllForm : Form
    {
        string login = "";
        string password = "";

        public LoginAllForm()
        {
            InitializeComponent();
        }
        private void btnRecoverPassword_Click(object sender, EventArgs e)
        {
            PasswordRecoverAllForm passwordRecoverAllForm = new PasswordRecoverAllForm();
            passwordRecoverAllForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;

            GetData();
            if (CheckLogin(password,login))
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                CleanData();
                MessageBox.Show("Usuário ou senha incorretos!");
            }

           

        }

        void GetData()
        {
            login = tbxLogin.Text;
            password = tbxPassword.Text;
        }

        void CleanData()
        {
            tbxPassword.Text = "";
            tbxLogin.Text = "";
        }

        private bool CheckLogin(string password, string name)
        {
            User user = UserHelper.SelectByName(name);

            if (user != null)
            {
                if (UserHelper.Hash(password) == user.Password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
