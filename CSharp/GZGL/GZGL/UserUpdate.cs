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
    public partial class UserUpdate : Form
    {
        public static string UserName = ""; 

        public UserUpdate()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string userId = UserName;
            string userOldPwd = txtOldPwd.Text;
            string userNewPwd = txtNewPwd.Text;

            if (Login.Loginoff == 2)
            {
                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";
                SqlConnection conn = new SqlConnection(connString);

                string pwdJudge = String.Format("SELECT COUNT(*) FROM UserLogin WHERE UserId = '{0}'", userId);

                conn.Open();
                SqlCommand comm = new SqlCommand(pwdJudge, conn);
                int n = (int)comm.ExecuteScalar();

                if (n == 1)
                {
                    if (userNewPwd == EnsureNewPwd.Text)
                    {
                        string sql = String.Format("UPDATE UserLogin SET UserPwd = '{0}' WHERE UserId = '{1}'", userNewPwd, userId);

                        SqlCommand Comm = new SqlCommand(sql, conn);
                        int m = (int)Comm.ExecuteNonQuery();

                        try
                        {
                            if (m > 0)
                            {
                                MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("您两次输入的密码不匹配，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtOldPwd.Text = "";
                        txtNewPwd.Text = "";
                        EnsureNewPwd.Text = "";
                        txtOldPwd.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("此用户不存在，请确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("您未登录，请先登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GZGL.update = true;
            this.Close();
        }

    }
}
