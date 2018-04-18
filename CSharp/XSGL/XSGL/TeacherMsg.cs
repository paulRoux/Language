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
    public partial class TeacherMsg : Form
    {
        Login iden = new Login();

        public TeacherMsg()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (Login.identity == 1)
            {
                string sex = "";
                if (rdoMale.Checked)
                {
                    sex = rdoMale.Text;
                }
                else
                {
                    sex = rdoFemale.Text;
                }

                string id = teacherId.Text;
                string name = teacherName.Text;
                string title = teacherTitle.Text;
                string password = teacherPwd.Text;

                string sql = String.Format("INSERT INTO TeacherMsg (TeacherId, TeacherName, TeacherSex, TeacherTitle, TeacherPwd) VALUES('{0}','{1}'),'{2}','{3}','{4}','{5}')", id, name, sex, title, password);

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = XSGL; Integrated Security = True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = comm.ExecuteNonQuery();
                        if (n > 0)
                        {
                            MessageBox.Show("添加教师信息成功！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("添加教师信息失败！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("必须是管理员才能添加教师信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
