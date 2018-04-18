using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            name.Text = "";
            passwd.Text = "";
            name.Focus();
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            //string username = name.Text;
            //string password = passwd.Text;
            //int flag = 0;
            //if (username == "admin" && password == "1234")
            //{
            //    MessageBox.Show("欢迎进入个人理财系统！", "登陆成功!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    flag = 1;
            //}
            //else
            //{
            //    MessageBox.Show("您输入的用户名或密码错误！", "登录失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //if (flag == 1)
            //{
            //    this.Close();
            //}


            string username = name.Text;
            string password = passwd.Text;
            string connString = @"Data Source = HASEE-PC; Initial Catalog = login; Integrated Security = true";
            SqlConnection conn = new SqlConnection(connString);

            string sql = String.Format("select count(*) from [Luser] where UserName = '{0}' and Passwd = '{1}'", username, password);
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = (int)comm.ExecuteScalar();
                if (n == 1)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Tag = true;
                }
                else
                {
                    MessageBox.Show("您输入的用户名或者密码错误！请重试！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Tag = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Tag = false;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
