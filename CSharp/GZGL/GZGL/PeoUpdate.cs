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
    public partial class PeoUpdate : Form
    {
        public PeoUpdate()
        {
            InitializeComponent();
            if (Login.identity == 1)
            {
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                tabControl1.SelectedIndex = 0;
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (Login.identity == 2)
                {
                    tabControl1.SelectedIndex = 1;
                    MessageBox.Show("权限不足，请与相关人员联系！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

            string sql = String.Format("SELECT * FROM ManagerMsg WHERE ManagerId = '{0}'", SearchId.Text);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    //string no = reader.GetString(1);
                    UpdateId.Text = reader.GetString(1);
                    UpdateDepartment.Text = reader.GetString(2);
                    UpdateName.Text = reader.GetString(3);
                    string sex = reader.GetString(4);
                    if (sex == "男")
                    {
                        rdoMale.Checked = true;
                    }
                    else
                    {
                        rdoFemale.Checked = true;
                    }
                    UpdateDate.Value = reader.GetDateTime(5);
                    UpdateWorkAge.Text = reader.GetString(6);
                    UpdateAccount.Text = reader.GetString(7);
                    UpdateTel.Text = reader.GetString(8);
                    UpdateEmail.Text = reader.GetString(9);
                    UpdatePwd.Text = reader.GetString(10);
                    //if(reader.HasRows == NULL)
                    UpdateRemark.Text = reader.GetString(11);

                }
                else
                {
                    MessageBox.Show("没有找到，请检查输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SearchId.Text == "")
            {
                MessageBox.Show("请输入要修改信息的员工的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string ID = SearchId.Text;
                string sex = "";
                if (rdoMale.Checked)
                {
                    sex = "男";
                }
                else
                {
                    sex = "女";
                }

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                string sql = String.Format("UPDATE EmployeeMsg SET EmployeeId = '{0}', ManagerId = '{1}', DepartmentId= '{2}',EmployeeName = '{3}', EmployeeSex = '{4}', EmployeeTime = '{5}', EmployeeWorkAge = '{6}', EmployeeAccount = '{7}', EmployeeTel = '{8}', EmployeeEmail = '{9}', EmployeePwd = '{10}', EmployeeRemark = '{11}' WHERE EmployeeId = '{12}'", UpdateId.Text, UpdateManager.Text, UpdateDepartment.Text, UpdateName.Text, sex, UpdateDate.Value, UpdateWorkAge.Text, UpdateAccount.Text, UpdateTel.Text, UpdateEmail.Text, UpdatePwd.Text, UpdateRemark.Text, ID);


                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = comm.ExecuteNonQuery();
                        if (n <= 0)
                        {
                            MessageBox.Show("修改信息失败，请检查数据格式！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("修改信息成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入要删除信息的员工的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string ID = textBox1.Text;

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                string sql = String.Format("DELETE FROM EmployeeMsg WHERE EmployeeId = '{0}'", ID);


                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = comm.ExecuteNonQuery();
                        if (n <= 0)
                        {
                            MessageBox.Show("更新信息失败，请检查数据格式！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("更新信息成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

            string ID = textBox1.Text;

            string sql = String.Format("SELECT * FROM EmployeeMsg WHERE EmployeeId = '{0}'", ID);


            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    //string no = reader.GetString(1);
                    textBox8.Text = reader.GetString(1);
                    UpdateManager.Text = reader.GetString(2);
                    textBox2.Text = reader.GetString(3);
                    textBox9.Text = reader.GetString(4);
                    string sex = reader.GetString(5);
                    if (sex == "男")
                    {
                        rdoMale.Checked = true;
                    }
                    else
                    {
                        rdoFemale.Checked = true;
                    }
                    dateTimePicker1.Value = reader.GetDateTime(6);
                    textBox3.Text = reader.GetString(7);
                    textBox5.Text = reader.GetString(8);
                    textBox4.Text = reader.GetString(9);
                    textBox6.Text = reader.GetString(10);
                    textBox7.Text = reader.GetString(11);
                    richTextBox1.Text = reader.GetString(12);

                }
                else
                {
                    MessageBox.Show("没有找到，请检查输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
            }
        }

        private void btnMaUpdate_Click(object sender, EventArgs e)
        {
            if (SearchId.Text == "")
            {
                MessageBox.Show("请输入要修改信息的经理的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string searchId = SearchId.Text;

                string sex = "";
                if (rdoMale.Checked)
                {
                    sex = "男";
                }
                else
                {
                    sex = "女";
                }

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                string sql = String.Format("UPDATE ManagerMsg SET ManagerId = '{0}', DepartmentId= '{1}',ManagerName = '{2}', ManagerSex = '{3}', ManagerTime = '{4}', ManagerWorkAge = '{5}', ManagerAccount = '{6}', ManagerTel = '{7}', ManagerEmail = '{8}', ManagerPwd = '{9}', ManagerRemark = '{10}' WHERE ManagerId = '{11}'", UpdateId.Text, UpdateDepartment.Text, UpdateName.Text, sex, UpdateDate.Value, UpdateWorkAge.Text, UpdateAccount.Text, UpdateTel.Text, UpdateEmail.Text, UpdatePwd.Text, UpdateRemark.Text, searchId);


                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = comm.ExecuteNonQuery();
                        if (n <= 0)
                        {
                            MessageBox.Show("更新信息失败，请检查数据格式！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("更新信息成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void btnMaDelete_Click(object sender, EventArgs e)
        {
            if (SearchId.Text == "")
            {
                MessageBox.Show("请输入要删除信息的经理的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string ID = SearchId.Text;

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                string sql = String.Format("DELETE FROM ManagerMsg WHERE ManagerId = '{0}'", ID);


                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = comm.ExecuteNonQuery();
                        if (n <= 0)
                        {
                            MessageBox.Show("删除失败，请与检查数据库！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }


    }
}
