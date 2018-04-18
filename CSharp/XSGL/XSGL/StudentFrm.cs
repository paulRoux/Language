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
    public partial class StudentFrm : Form
    {
        private int current = 1;
        private int flag = 0;  //解决一直向后读数据的问题
        string connString = @"Data Source = 127.0.0.1; Initial Catalog = XSGL; Integrated Security = True";
        int count = 0;  //计算读到了第几个数
        Login iden = new Login();

        public StudentFrm()
        {
            InitializeComponent();
            current = 1;
            ShowCurrentStudent();
        }

        private void ShowCurrentStudent()
        {
            string sql = String.Format("SELECT * FROM StudentMsg WHERE StudentNo = '{0}'", current);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    txtName.Text = reader.GetString(1);
                    string sex = reader.GetString(2);
                    if (sex == "男")
                    {
                        rdoMale.Checked = true;
                    }
                    else
                    {
                        rdoFemale.Checked = true;
                    }
                    dtBirthday.Value = reader.GetDateTime(3);
                    txtDept.Text = reader.GetString(4);
                    txtSpec.Text = reader.GetString(5);              
                    string[] hobbies = new string[6];
                    hobbies = reader.GetString(6).Split(' ');
                    password.Text = reader.GetString(7);

                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    checkBox5.Checked = false;
                    checkBox6.Checked = false;

                    foreach (string s in hobbies)
                    {
                        switch (s)
                        {
                            case "阅读": checkBox1.Checked = true;
                                break;
                            case "体育": checkBox2.Checked = true;
                                break;
                            case "音乐": checkBox3.Checked = true;
                                break;
                            case "上网": checkBox4.Checked = true;
                                break;
                            case "旅游": checkBox5.Checked = true;
                                break;
                            default: checkBox6.Checked = true;
                                break;
                        }
                    }
                    count++;
                }
                else
                {
                    if (current < 1)
                    {
                        MessageBox.Show("前面已经无数据了！", "没有数据", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        current = 1;
                    }
                    else if(current > count - 8)
                    {
                        MessageBox.Show("后面已经无数据了！", "没有数据", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        flag = 1;
                    }
                }
                reader.Close();
            }          
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                current--;
                flag = 0;
            }
            current--;
            ShowCurrentStudent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(flag == 0)
                current++;
            ShowCurrentStudent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Login.identity == 1 || Login.identity == 2)
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

                string hobby = "";

                if (checkBox1.Checked) hobby += checkBox1.Text += ' ';
                if (checkBox2.Checked) hobby += checkBox2.Text += ' ';
                if (checkBox3.Checked) hobby += checkBox3.Text += ' ';
                if (checkBox4.Checked) hobby += checkBox4.Text += ' ';
                if (checkBox5.Checked) hobby += checkBox5.Text += ' ';
                if (checkBox6.Checked) hobby += checkBox6.Text += ' ';

                string sql = String.Format("UPDATE StudentMsg SET StudentName = '{0}', Sex = '{1}', Birthday = '{2}', Department = '{3}', Speciality = '{4}', Hobby = '{5}', StudentPwd = '{6}' WHERE StudentNo = '{7}'", txtName.Text, sex, dtBirthday.Value, txtDept.Text, txtSpec.Text, hobby, password.Text, current);

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
                MessageBox.Show("只有管理员才能修改学生信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Login.identity == 1)
            {
                string sql = String.Format("DELETE FROM StudentMsg WHERE StudentNo = '{0}'", current);

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
                        ShowCurrentStudent();
                        MessageBox.Show("删除数据成功！", "删除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("只有管理员才能修改学生信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
