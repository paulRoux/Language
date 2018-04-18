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
    public partial class Login : Form
    {

        public static int identity = 0;  //确定用户的权限
        public static int Loginoff = 0;  //确定登陆的状态（成功，失败，未登录）

        public Login()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string password = txtPwd.Text;
            string usertype = UserType.Text;


            if (Loginoff == 1)
            {               
                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";
                SqlConnection conn = new SqlConnection(connString);

                string sql = String.Format("SELECT COUNT(*) FROM [UserLogin] WHERE UserId = '{0}' AND UserPwd = '{1}' AND UserType = '{2}'", userName, password, usertype);

                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = (int)comm.ExecuteScalar();
                UserUpdate.UserName = userName;
                //WageQuery.Username = userName;
                //WageUpdate.UsernameUpdate = userName;

                if (this.UserType.Text == "员工")
                {
                    try
                    {
                        if (n == 1)
                        {
                            GZGL.isLogined = true;
                            GZGL.logined = true;
                            Loginoff = 2;
                            identity = 1;
                            this.DialogResult = DialogResult.OK;
                            this.Tag = true;
                            this.Hide();
                        }
                        else
                        {
                            GZGL.isLogined = false;
                            GZGL.logined = false;
                            Loginoff = 1;
                            MessageBox.Show("您输入的用户名或密码错误,请重试！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtPwd.Text = "";
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
                else if (this.UserType.Text == "经理")
                {
                    try
                    {
                        if (n == 1)
                        {
                            GZGL.isLogined = true;
                            GZGL.logined = true;
                            Loginoff = 2;
                            identity = 2;
                            this.DialogResult = DialogResult.OK;
                            this.Tag = true;
                            this.Hide();
                        }
                        else
                        {
                            this.Tag = false;
                            GZGL.isLogined = false;
                            GZGL.logined = false;
                            Loginoff = 1;
                            MessageBox.Show("您输入的用户名或密码错误！请重试！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtPwd.Text = "";                
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
                else
                {
                    try
                    {
                        if (n == 1)
                        {
                            GZGL.isLogined = true;
                            GZGL.logined = true;
                            Loginoff = 2;
                            identity = 3;
                            this.DialogResult = DialogResult.OK;
                            this.Tag = true;
                            this.Hide();
                        }
                        else
                        {
                            GZGL.isLogined = false;
                            GZGL.logined = false;
                            Loginoff = 1;
                            MessageBox.Show("您输入的用户名或密码错误！请重试！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtPwd.Text = "";
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
            else
            {
                MessageBox.Show("您已登陆过，如需切换账号，请先注销！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.UserType.SelectedIndex = 0;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("您确定要退出登陆吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                identity = 0;
                Loginoff = 1;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn sign = new SignIn();
            sign.ShowDialog();
            this.Close();
        }
    }
}
