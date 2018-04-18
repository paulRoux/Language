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
    public partial class CourseFrm : Form
    {
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet("XSGL");
        Login iden = new Login();

        public CourseFrm()
        {
            InitializeComponent();
        }

        private void ShowCourses()
        {                    
            string sql = "SELECT CourseId AS 课程ID, CourseName AS 课程名称, CourseClass AS 课程类别, Requireds AS 是否必修, Credit AS 学分, PrelectionCredit AS 理论学时, ExperimentCredit AS 实验学时 FROM CourseMsg";

            string connString = @"Data Source = 127.0.0.1; Initial Catalog = XSGL; Integrated Security = True";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand comm = new SqlCommand(sql, connection);
                    da.SelectCommand = comm;
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    //builder.GetUpdateCommand();
                    da.Fill(ds, "CourseMsg");
                    this.dvgCourse.DataSource = ds.Tables["CourseMsg"];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库操作出错。" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void CourseFrm_Load(object sender, EventArgs e)
        {
            ShowCourses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.identity == 1)
            {
                string ConnString = @"Data Source = 127.0.0.1; Initial Catalog = XSGL; Integrated Security = True";

                using (SqlConnection Conn = new SqlConnection(ConnString))
                {
                    try
                    {
                        Conn.Open();
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);

                        //da.Update(ds, "CourseMsg");
                        MessageBox.Show("服务器目前无法更新！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("数据库操作出错。" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        Conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("必须是管理员才能进行更改！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Login.identity == 1)
            {
                if (MessageBox.Show("您是否真的要取消目前添加、修改或删除的操作？", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ds.Clear();
                    ShowCourses();
                    dvgCourse.Refresh();
                }
            }
            else
            {
                MessageBox.Show("必须是管理员才能进行更改！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
