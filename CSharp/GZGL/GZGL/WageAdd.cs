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
    public partial class WageAdd : Form
    {
        public WageAdd()
        {
            InitializeComponent();
        }

        private void btnMaAdd_Click(object sender, EventArgs e)
        {
            if (AddId.Text == "" || AddDepartment.Text == "")
            {
                MessageBox.Show("填写信息不完整，请填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                string sql = String.Format("INSERT INTO ManagerSalary (ManagerId, DepartmentId, MaSlaMonth, MaSlaBaseWage, MaSlaBonus, MaSlaAllowance, MaSlaInsurance, MaSlaOvertimePay, MaSlaFine, MaSlaAbsenteeism, MaSlaOthers) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", AddId.Text, AddDepartment.Text, AddDate.Value, AddBaseWage.Text, AddBonus.Text, AddAllowance.Text, AddInsurance.Text, AddOverTimePay.Text, AddFine.Text, AddAbsent.Text, AddRemark.Text);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();

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
                            int BaseWage = 9000;
                            int Allowance = 300;
                            int Insurance = 200;
                            AddId.Text = "";
                            AddDepartment.Text = "";
                            AddBaseWage.Text = BaseWage.ToString(); 
                            AddBonus.Text = "";
                            AddAllowance.Text = Allowance.ToString();
                            AddInsurance.Text = Insurance.ToString();
                            AddOverTimePay.Text = ""; 
                            AddFine.Text = ""; 
                            AddAbsent.Text = "";
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

        private void btnMaCancel_Click(object sender, EventArgs e)
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

        private void btnEmpAdd_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox13.Text == "")
            {
                MessageBox.Show("填写信息不完整，请填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                string sql = String.Format("INSERT INTO EmployeeSalary (EmanagerId, DepartmentId, EmSlaMonth, EmSlaBaseWage, EmSlaBonus, EmSlaAllowance, EmMaSlaInsurance, EmSlaOvertimePay, EmSlaFine, EmSlaAbsenteeism, EmSlaOthers) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", textBox2.Text, textBox13.Text, EmAddDate.Value, textBox9.Text, textBox10.Text, textBox3.Text, textBox5.Text, textBox4.Text, textBox6.Text, textBox7.Text, richTextBox1.Text);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();

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
                            int BaseWage = 5000;
                            int Allowance = 200;
                            int Insurance = 200;
                            textBox2.Text = "";
                            textBox13.Text = "";
                            textBox9.Text = BaseWage.ToString();
                            textBox10.Text = "";
                            textBox3.Text = Allowance.ToString();
                            textBox5.Text = Insurance.ToString();
                            textBox4.Text = "";
                            textBox6.Text = "";
                            textBox7.Text = "";
                            richTextBox1.Text = "";
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

        private void btnEmpCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要取消添加吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                textBox2.Focus();
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
                    if (MessageBox.Show("添加工资前请确认已有所在经理！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        AddId.Focus();
                    }
                }
            }
            else
            {
                if (MessageBox.Show("添加工资前请确认已有所在员工！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    textBox2.Focus();
                }
            }
        }

        private void WageAdd_Load(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (MessageBox.Show("添加工资前请确认已有所在经理！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    AddId.Focus();
                }
            }
            else
            {
                if (MessageBox.Show("添加工资前请确认已有所在员工！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    textBox2.Focus();
                }
            }
        }


    }
}
