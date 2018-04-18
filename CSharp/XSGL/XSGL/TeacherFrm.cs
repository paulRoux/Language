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
    public partial class TeacherFrm : Form
    {
        private int current = 1;
        string connString = @"Data Source = 127.0.0.1; Initial Catalog = XSGL; Integrated Security = True";
        int count = 0;
        Login iden = new Login();

        public TeacherFrm()
        {
            InitializeComponent();
            current = 1;
            ShowCurrentTeacher();
        }

        private void ShowCurrentTeacher()
        {
            string sql = String.Format("SELECT * FROM TeacherMsg WHERE TeacherNo = '{0}'", current);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                try
                {
                    if (reader.Read())
                    {
                        teaId.Text = reader.GetString(1);
                        teaName.Text = reader.GetString(2);
                        string sex = reader.GetString(3);
                        if (sex == "男")
                        {
                            rdoMale.Checked = true;
                        }
                        else
                        {
                            rdoFemale.Checked = true;
                        }
                        teaTitle.Text = reader.GetString(4);
                        teaPwd.Text = reader.GetString(5);
                        txtCourse.Text = reader.GetString(6);
                        count++;
                    }
                    else
                    {
                        if (current == 0)
                        {
                            MessageBox.Show("前面已经无数据了！", "没有数据", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            current = 1;
                        }
                        else
                        {
                            MessageBox.Show("后面已经无数据了！", "没有数据", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            current = count;
                        }
                    }
                    reader.Close();
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

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            current--;
            ShowCurrentTeacher();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            current++;
            ShowCurrentTeacher();
        }

        private void teaUpdate_Click(object sender, EventArgs e)
        {
            if (Login.identity == 1)
            {
                string sex = "";
                if (rdoMale.Checked)
                {
                    sex = "男";
                }
                else
                {
                    sex = "女";
                }

                string sql = String.Format("UPDATE TeacherMsg SET TeacherId = '{0}', TeacherName = '{1}', TeacherSex = '{2}', TeacherTitle = '{3}', TeacherPwd = '{4}', TeacherCou = '{5}' WHERE TeacherNo = '{6}'", teaId.Text, teaName.Text, sex, teaTitle.Text, teaPwd.Text, txtCourse.Text, current);

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = XSGL; Integrated Security = True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = comm.ExecuteNonQuery();
                        if (n <= 0)
                        {
                            MessageBox.Show("更新数据库失败，请检查数据格式！", "更新失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("更新数据库成功！", "更新成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("数据库操作出错。" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("必须是管理员才能更新教师信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void teaDelete_Click(object sender, EventArgs e)
        {
            if (Login.identity == 1)
            {
                string sql = String.Format("DELETE FROM TeacherMsg WHERE TeacherNo = '{0}'", current);

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = XSGL; Integrated Security = True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int n = comm.ExecuteNonQuery();
                    if (n <= 0)
                    {
                        MessageBox.Show("删除数据失败，请与管理员联系！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        current--;
                        ShowCurrentTeacher();
                        MessageBox.Show("删除数据成功！", "删除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("必须是管理员才能更新教师信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
