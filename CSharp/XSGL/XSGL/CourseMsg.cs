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
    public partial class CourseMsg : Form
    {
        string courseName;
        string courseClass;
        string required;
        int credit;
        int prelectionCredit;
        int experimentCredit;

        public CourseMsg()
        {
            InitializeComponent();
            cboClass.SelectedIndex = 0;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("您输入的信息不完整！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tabControl1.SelectedIndex = 1;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (txtName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("您输入的信息不完整！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    courseName = txtName.Text;
                    courseClass = cboClass.SelectedItem.ToString();
                    required = rdoRequired.Checked ? "必修" : "选修";
                    credit = (int)nudCredit.Value;
                    prelectionCredit = (int)nudPrelection.Value;
                    experimentCredit = (int)nudExp.Value;
                    string message = String.Format("课程名：{0}\n课程类别：{1}\n课程性质：{2}\n学分：{3}\n理论学时：{4}\n实验学时：{5}\n", courseName, courseClass, required, credit, prelectionCredit, experimentCredit);
                    txtInfo.Text = message;
                }
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string sql = String.Format("INSERT INTO CourseMsg (CourseName, CourseClass, Requireds, Credit, PrelectionCredit, ExperimentCredit) VALUES('{0}','{1}'),'{2}','{3}','{4}','{5}')", courseName, courseClass, required, credit, prelectionCredit, experimentCredit);

            string connString = @"Data Source = 127.0.0.1; Initial Catalog = XSGL; Integrated Security = True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int n = Convert.ToInt32(comm.ExecuteNonQuery());
                    if (n > 0)
                    {
                        MessageBox.Show("添加课程信息成功！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("添加课程信息失败！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库操作出错！" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        
    }
}
