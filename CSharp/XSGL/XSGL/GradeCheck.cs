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
    public partial class GradeCheck : Form
    {
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet("XSGL");

        //private void ShowGrades()
        //{
        //    string sql = "SELECT DISTINCT StudentNo AS 学生编号, CourseId AS 课程编号, Score AS 成绩 FROM ScoreMsg";

        //    string connString = @"Data Source = 127.0.0.1; Initial Catalog = XSGL; Integrated Security = True";

        //    using (SqlConnection connection = new SqlConnection(connString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            SqlCommand comm = new SqlCommand(sql, connection);
        //            da.SelectCommand = comm;
        //            SqlCommandBuilder builder = new SqlCommandBuilder(da);
        //            //builder.GetUpdateCommand();
        //            da.Fill(ds, "ScoreMsg");
        //            this.dvGrade.DataSource = ds.Tables["ScoreMsg"];

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("数据库操作出错。" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //    }
        //}

        public GradeCheck()
        {
            InitializeComponent();
        }

        private void GradeCheck_Load(object sender, EventArgs e)
        {
            //ShowGrades();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int flag = 0;  //定义标识符，清空表格中上次的查询数据
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                DataTable dt = (DataTable)dvGrade.DataSource;
                dt.Rows.Clear();
                dvGrade.DataSource = dt;
            }

            string sql = String.Format("SELECT StudentName AS 学生姓名, CourseName AS 课程, Score AS 成绩 FROM ScoreMsg, StudentMsg, CourseMsg WHERE StudentMsg.StudentNo = ScoreMsg.StudentNo AND CourseMsg.CourseId = ScoreMsg.CourseId AND ScoreMsg.StudentNo = '{0}'", StudentNo.Text);

            string connString = @"Data Source = 127.0.0.1; Initial Catalog = XSGL; Integrated Security = True";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand comm = new SqlCommand(sql, connection);
                    da.SelectCommand = comm;
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    da.Fill(ds, "ScoreMsg");
                    this.dvGrade.DataSource = ds.Tables["ScoreMsg"];
                    flag = 1;

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

    }
}
