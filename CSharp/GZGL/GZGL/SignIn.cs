using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GZGL
{
    public partial class SignIn : Form
    {

        public static bool signIn = false;

        public SignIn()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {

            string userid = txtId.Text;
            string userName = txtName.Text;
            string password = txtPwd.Text;
            string ensurepwd = EnsurePwd.Text;
            string usertype = UserType.Text;

            
            if (userid == "")
            {
                MessageBox.Show("用户编号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (userName == "")
            {
                MessageBox.Show("用户名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (password == "")
            {
                MessageBox.Show("用户密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnsurePwd.Text = "";
            }
            else
            {
                if (password == ensurepwd)
                {
                    string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                    string sql = String.Format("INSERT INTO UserLogin (UserId, Username, UserPwd, UserType) VALUES('{0}', '{1}', '{2}', '{3}')", userid, userName, password, usertype);

                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand comm = new SqlCommand(sql, conn);
                            int n = comm.ExecuteNonQuery();

                            if (n > 0)
                            {
                                signIn = true;
                                MessageBox.Show("注册成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();

                            }
                            else
                            {
                                signIn = false;
                                MessageBox.Show("注册失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("操作数据库出错！" + ex.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        finally
                        {
                            conn.Close();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("您两次输入的密码不匹配，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPwd.Text = "";
                    EnsurePwd.Text = "";
                    txtPwd.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            signIn = false;
            this.Close();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            if (Login.identity == 1 || Login.identity == 2 || Login.identity == 0)
            {
                UserType.Enabled = false;
            }
            else if (Login.identity == 3)
            {
                UserType.Enabled = true;
            }
        }
    }
}
