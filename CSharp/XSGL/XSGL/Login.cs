using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace XSGL
{
    public partial class Login : Form
    {
        public static int identity = 0;
        private int judge = 0;
        public static int Ju = 0;

        public Login()
        {
            InitializeComponent();
        }

        //private void btnYes_Click(object sender, EventArgs e)
        //{
        //    string userName = txtName.Text;
        //    string password = txtPwd.Text;

        //    if ((userName == "admin" && password == "123456") || (userName == "paul" && password == "7758") || (userName == "roux" && password == "3150931050"))
        //    {
        //        MessageBox.Show("欢迎进入学生成绩管理系统！", "登陆成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        MessageBox.Show("您输入的用户名或密码错误！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //}

        //Main var = new Main();

        private void btnYes_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string password = txtPwd.Text;


            if (Ju == 1)
            {

                Main.isLogined = true;
                Main.logined = true;
                Ju = 2;

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = XSGL; Integrated Security = true";
                SqlConnection conn = new SqlConnection(connString);  //链接对象
                if (this.UserType.Text == "管理员")
                {
                    //获取用户名和密码匹配的数量的SQL语句
                    string sql = String.Format("SELECT COUNT(*) FROM [UserLogin] WHERE UserName = '{0}' AND Passwords = '{1}'", userName, password);

                    try
                    {
                        conn.Open();  //打开数据库
                        SqlCommand comm = new SqlCommand(sql, conn);  //创建command对象
                        int n = (int)comm.ExecuteScalar();  //执行查询语句，返回匹配的行数

                        if (n == 1)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Tag = true;
                            identity = 1;
                            judge = 1;
                            //Ju.logined = true;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("您输入的用户名或密码错误！请重试！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtPwd.Text = "";
                            Ju = 1;
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
                else if (this.UserType.Text == "学生")
                {
                    //获取用户名和密码匹配的数量的SQL语句
                    string sql = String.Format("SELECT COUNT(*) FROM [StudentMsg] WHERE StudentNo = '{0}' AND StudentPwd = '{1}'", userName, password);

                    try
                    {
                        conn.Open();  //打开数据库
                        SqlCommand comm = new SqlCommand(sql, conn);  //创建command对象
                        int n = (int)comm.ExecuteScalar();  //执行查询语句，返回匹配的行数

                        if (n == 1)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Tag = true;
                            identity = 3;
                            judge = 1;
                            //Ju.logined = true;                      
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("您输入的用户名或密码错误！请重试！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtPwd.Text = "";
                            Ju = 1;
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
                else
                {
                    //获取用户名和密码匹配的数量的SQL语句
                    string sql = String.Format("SELECT COUNT(*) FROM [TeacherMsg] WHERE TeacherId = '{0}' AND TeacherPwd = '{1}'", userName, password);

                    try
                    {
                        conn.Open();  //打开数据库
                        SqlCommand comm = new SqlCommand(sql, conn);  //创建command对象
                        int n = (int)comm.ExecuteScalar();  //执行查询语句，返回匹配的行数

                        if (n == 1)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Tag = true;
                            identity = 2;
                            judge = 1;
                            //Ju.logined = true;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("您输入的用户名或密码错误！请重试！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtPwd.Text = "";
                            Ju = 1;
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
                //this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            judge = 1;
            //txtName.Text = "";
            //txtPwd.Text = "";
            //txtName.Focus();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.UserType.SelectedIndex = 0;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (judge == 0)
            {
                if (MessageBox.Show("您确定要退出登陆吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    identity = 0;
                    Ju = 1;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

    }
}
