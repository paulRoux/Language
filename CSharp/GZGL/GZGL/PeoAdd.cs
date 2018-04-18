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
    public partial class PeoAdd : Form
    {
        public PeoAdd()
        {
            InitializeComponent();
            if (Login.identity == 1 || Login.identity == 2)
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
                else
                {
                    if (MessageBox.Show("添加经理前请确认已有所在的部门！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        AddId.Focus();
                    }
                }
            }
            else
            {
                if (MessageBox.Show("添加员工前请确认已有所在的部门的经理！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    textBox7.Focus();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要取消添加吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                AddId.Focus();
            }
        }

        private void PeoAdd_Load(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (MessageBox.Show("添加经理前请确认已有所在的部门！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    AddId.Focus();
                }
            }
            else
            {
                if (MessageBox.Show("添加员工前请确认已有所在的部门的经理！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    textBox7.Focus();
                }
            }


            string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";
            SqlConnection conn = new SqlConnection(connString);

            string sql = String.Format("SELECT * FROM EmployeeMsg");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);

                da.SelectCommand = comm;
                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                da.Fill(ds, "EmployeeMsg");

                this.AddManager.DisplayMember = "ManagerId";
                this.AddManager.ValueMember = "EmployeeId";
                this.AddManager.DataSource = ds.Tables["EmployeeMsg"];
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

        private void btnMaAdd_Click_1(object sender, EventArgs e)
        {
            
            if (AddId.Text == "" || AddDepartment.Text == "" || AddName.Text == "" || AddPwd.Text == "")
            {
                MessageBox.Show("填写信息不完整，请填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                string sql = String.Format("INSERT INTO ManagerMsg (ManagerId, DepartmentId, ManagerName, ManagerSex, ManagerTime, ManagerWorkAge, ManagerAccount, ManagerTel, ManagerEmail, ManagerPwd, ManagerRemark) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", AddId.Text, AddDepartment.Text, AddName.Text, sex, AddDate.Value, AddWorkAge.Text, AddAccount.Text, AddTel.Text, AddEmail.Text, AddPwd.Text, AddRemark.Text);


                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = comm.ExecuteNonQuery();

                        if (n > 0)
                        {
                            MessageBox.Show("添加人员信息成功！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AddId.Text = "";
                            AddManager.Text = "";
                            AddDepartment.Text = "";
                            AddName.Text = "";
                            AddWorkAge.Text = "";
                            AddAccount.Text = "";
                            AddTel.Text = "";
                            AddEmail.Text = "";
                            AddPwd.Text = "";
                            AddRemark.Text = "";
                            AddId.Focus();
                        }
                        else
                        {
                            MessageBox.Show("添加人员信息失败！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            string comb = AddManager.SelectedValue.ToString();

            if (textBox7.Text == "" || textBox1.Text == "" || textBox8.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("填写信息不完整，请填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sex = "";

                if (radioButton2.Checked)
                {
                    sex = radioButton2.Text;
                }
                else
                {
                    sex = radioButton1.Text;
                }

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                string sql = String.Format("INSERT INTO EmployeeMsg (EmployeeId, ManagerId, DepartmentId, EmployeeName, EmployeeSex, EmployeeTime, EmployeeWorkAge, EmployeeAccount, EmployeeTel, EmployeeEmail, EmployeePwd, EmployeeRemark) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')", textBox7.Text, comb, textBox1.Text, textBox8.Text, sex, dateTimePicker1.Value, textBox2.Text, textBox4.Text, textBox3.Text, textBox5.Text, textBox6.Text, richTextBox1.Text);


                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = comm.ExecuteNonQuery();

                        if (n > 0)
                        {
                            MessageBox.Show("添加人员信息成功！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox7.Text = "";
                            textBox1.Text = ""; 
                            textBox8.Text = "";
                            textBox2.Text = "";
                            textBox4.Text = "";
                            textBox3.Text = "";
                            textBox5.Text = "";
                            textBox6.Text = "";
                            richTextBox1.Text = "";
                            textBox7.Focus();
                        }
                        else
                        {
                            MessageBox.Show("添加人员信息失败！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnMaCancel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要取消添加吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                AddId.Focus();
            }
        }

    }
}
