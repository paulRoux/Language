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
    public partial class WageUpdate : Form
    {
        //public static string UsernameUpdate = "";

        private int flag1 = 0;
        private int flag5 = 0;
        private int flag7 = 0;

        public WageUpdate()
        {
            InitializeComponent();
            if (tabControl1.SelectedIndex == 0 && tabControl2.SelectedIndex == 0)
                ShowInformationManager();
            if (tabControl1.SelectedIndex == 0 && tabControl2.SelectedIndex == 1)
                ShowInformationManagerSalary();
            if (tabControl1.SelectedIndex == 1 && tabControl3.SelectedIndex == 0)
                ShowInformation();
            if (tabControl1.SelectedIndex == 1 && tabControl3.SelectedIndex == 1)
                ShowInformationSalary();
        }

        //private SqlDataAdapter da = new SqlDataAdapter();
        //private DataSet ds = new DataSet("GZGL");

        private int flag = 0;

        private void ShowInformation()
        {
            string sql = String.Format("SELECT EmployeeId AS 编号, DepartmentId AS 部门, EmSlaMonth AS 日期, EmSlaBaseWage AS 基础工资, EmSlaBonus AS 奖金, EmSlaAllowance AS 津贴, EmSlaInsurance AS 保险, EmSlaOvertimePay AS 加班费, EmSlaFine AS 罚款, EmSlaAbsenteeism AS 迟到次数, EmSlaOthers AS 备注 FROM EmployeeSalary");

            string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataSet ds = new DataSet("GZGL"); 
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    da.SelectCommand = comm;
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    da.Fill(ds, "EmployeeSalary");
                    this.dataGridView1.DataSource = ds.Tables["EmployeeSalary"];

                    flag = 1;
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

        private void ShowInformationSalary()
        {
            string sql = String.Format("SELECT EmployeeId AS 编号, DepartmentId AS 部门, EmSlaMonth AS 日期, EmSlaBonus AS 奖金, EmSlaAllowance AS 津贴, EmSlaFine AS 罚款, EmSlaAbsenteeism AS 迟到次数, EmSlaOthers AS 备注 FROM EmployeeSalary");

            string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataSet ds = new DataSet("GZGL"); 
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    da.SelectCommand = comm;
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    da.Fill(ds, "EmployeeSalary");
                    this.dataGridView2.DataSource = ds.Tables["EmployeeSalary"];

                    flag = 1;
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

        private void ShowInformationManager()
        {
            string sql = String.Format("SELECT ManagerId AS 编号, DepartmentId AS 部门, MaSlaMonth AS 日期, MaSlaBaseWage AS 基础工资, MaSlaBonus AS 奖金, MaSlaAllowance AS 津贴, MaSlaInsurance AS 保险, MaSlaOvertimePay AS 加班费, MaSlaFine AS 罚款, MaSlaAbsenteeism AS 迟到次数, MaSlaOthers AS 备注 FROM ManagerSalary");

            string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataSet ds = new DataSet("GZGL"); 
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    da.SelectCommand = comm;
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    da.Fill(ds, "ManagerSalary");
                    this.dataGridView3.DataSource = ds.Tables["ManagerSalary"];

                    flag = 1;
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

        private void ShowInformationManagerSalary()
        {
            string sql = String.Format("SELECT ManagerId AS 编号, DepartmentId AS 部门, MaSlaMonth AS 日期, MaSlaBonus AS 奖金, MaSlaAllowance AS 津贴, MaSlaFine AS 罚款, MaSlaAbsenteeism AS 迟到次数, MaSlaOthers AS 备注 FROM ManagerSalary");

            string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataSet ds = new DataSet("GZGL"); 
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    da.SelectCommand = comm;
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    da.Fill(ds, "ManagerSalary");
                    this.dataGridView4.DataSource = ds.Tables["ManagerSalary"];

                    flag = 1;
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet("GZGL"); 
  
            if (flag == 1)
            {
                DataTable dt = (DataTable)dataGridView3.DataSource;
                dt.Rows.Clear();
                dataGridView3.DataSource = dt;
            }

            string ID = textBox2.Text;


            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("请输入所要查询经理的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //string sql = String.Format("SELECT ManagerId AS 编号, DepartmentId AS 部门, MaSlaMonth AS 日期, MaSlaBaseWage AS 基础工资, MaSlaBonus AS 奖金, MaSlaAllowance AS 津贴, MaSlaInsurance AS 保险, MaSlaOvertimePay AS 加班费, MaSlaFine AS 罚款, MaSlaAbsenteeism AS 迟到次数, MaSlaOthers AS 备注 FROM ManagerSalary WHERE ManagerId = '{0}'", UsernameUpdate);

                string sql = String.Format("SELECT ManagerId AS 编号, DepartmentId AS 部门, MaSlaMonth AS 日期, MaSlaBaseWage AS 基础工资, MaSlaBonus AS 奖金, MaSlaAllowance AS 津贴, MaSlaInsurance AS 保险, MaSlaOvertimePay AS 加班费, MaSlaFine AS 罚款, MaSlaAbsenteeism AS 迟到次数, MaSlaOthers AS 备注 FROM ManagerSalary WHERE ManagerId = '{0}'", ID);

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        da.SelectCommand = comm;
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        da.Fill(ds, "ManagerSalary");
                        this.dataGridView3.DataSource = ds.Tables["ManagerSalary"];

                        flag = 1;
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
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet("GZGL"); 

            if (flag == 1)
            {
                DataTable dt8 = (DataTable)dataGridView3.DataSource;
                dt8.Rows.Clear();
                dataGridView3.DataSource = dt8;
            }

            string DeId = textBox1.Text;

            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("请输入所要查询部门的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                //string sql = String.Format("SELECT ManagerId AS 编号, DepartmentId AS 部门, MaSlaMonth AS 日期, MaSlaBaseWage AS 基础工资, MaSlaBonus AS 奖金, MaSlaAllowance AS 津贴, MaSlaInsurance AS 保险, MaSlaOvertimePay AS 加班费, MaSlaFine AS 罚款, MaSlaAbsenteeism AS 迟到次数, MaSlaOthers AS 备注 FROM ManagerSalary WHERE DepartmentId = '{0}' AND ManagerId = '{1}'", DeId, UsernameUpdate);

                string sql = String.Format("SELECT ManagerId AS 编号, DepartmentId AS 部门, MaSlaMonth AS 日期, MaSlaBaseWage AS 基础工资, MaSlaBonus AS 奖金, MaSlaAllowance AS 津贴, MaSlaInsurance AS 保险, MaSlaOvertimePay AS 加班费, MaSlaFine AS 罚款, MaSlaAbsenteeism AS 迟到次数, MaSlaOthers AS 备注 FROM ManagerSalary WHERE DepartmentId = '{0}'", DeId);

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        da.SelectCommand = comm;
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        da.Fill(ds, "ManagerSalary");
                        this.dataGridView3.DataSource = ds.Tables["ManagerSalary"];

                        flag = 1;
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


        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("请输入要修改信息的经理的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                    string sql = String.Format("UPDATE ManagerSalary SET MaSlaAbsenteeism = '{0}' WHERE ManagerId = '{1}'", textBox9.Text,  textBox5.Text);

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";                


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

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("请输入要修改信息的经理的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                string sql = String.Format("UPDATE ManagerSalary SET MaSlaBonus = '{0}' WHERE ManagerId = '{1}'", textBox7.Text, textBox5.Text);


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

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("请输入要修改信息的经理的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                string sql = String.Format("UPDATE ManagerSalary SET MaSlaAllowance = '{0}' WHERE ManagerId = '{1}'", textBox6.Text, textBox5.Text);


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


        private void btnDeSlaUpdate_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet("GZGL"); 

            string ID = DeSaId.Text;

            if (flag5 == 1)
            {
                DataTable dt1 = (DataTable)dataGridView1.DataSource;
                dt1.Rows.Clear();
                dataGridView1.DataSource = dt1;
            }

            if (DeSaId.Text.Trim() == "")
            {
                MessageBox.Show("请输入所要查询部门的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = String.Format("SELECT EmployeeId AS 编号, DepartmentId AS 部门, EmSlaMonth AS 日期, EmSlaBaseWage AS 基础工资, EmSlaBonus AS 奖金, EmSlaAllowance AS 津贴, EmSlaInsurance AS 保险, EmSlaOvertimePay AS 加班费, EmSlaFine AS 罚款, EmSlaAbsenteeism AS 迟到, EmSlaOthers AS 备注 FROM EmployeeSalary WHERE DepartmentId = '{0}'", ID);

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        da.SelectCommand = comm;
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        da.Fill(ds, "EmployeeSalary");
                        this.dataGridView1.DataSource = ds.Tables["EmployeeSalary"];

                        flag5 = 1;
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

        private void btnEmIdSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet("GZGL"); 

            if (flag1 == 1)
            {
                DataTable dt2 = (DataTable)dataGridView2.DataSource;
                dt2.Rows.Clear();
                dataGridView2.DataSource = dt2;
            }

            if (EmTxtIdSearch.Text.Trim() == "")
            {
                MessageBox.Show("请输入所要查询员工的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = String.Format("SELECT EmployeeId AS 编号, DepartmentId AS 部门, EmSlaMonth AS 日期, EmSlaBonus AS 奖金, EmSlaAllowance AS 津贴, EmSlaFine AS 罚款, EmSlaAbsenteeism AS 迟到, EmSlaOthers AS 备注 FROM EmployeeSalary WHERE EmployeeId = '{0}'", EmTxtIdSearch.Text);

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        da.SelectCommand = comm;
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        da.Fill(ds, "EmployeeSalary");
                        this.dataGridView2.DataSource = ds.Tables["EmployeeSalary"];

                        flag1 = 1;
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

        private void btnEmDeSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet("GZGL"); 

            if (flag1 == 1)
            {
                DataTable dt3 = (DataTable)dataGridView2.DataSource;
                dt3.Rows.Clear();
                dataGridView2.DataSource = dt3;
            }

            if (EmTxtDeSearch.Text.Trim() == "")
            {
                MessageBox.Show("请输入所要查询经理的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = String.Format("SELECT EmployeeId AS 编号, DepartmentId AS 部门, EmSlaMonth AS 日期, EmSlaBonus AS 奖金, EmSlaAllowance AS 津贴, EmSlaFine AS 罚款, EmSlaAbsenteeism AS 迟到次数, EmSlaOthers AS 备注 FROM EmployeeSalary WHERE DepartmentId = '{0}'", EmTxtDeSearch.Text);

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        da.SelectCommand = comm;
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        da.Fill(ds, "EmployeeSalary");
                        this.dataGridView2.DataSource = ds.Tables["EmployeeSalary"];

                        flag1 = 1;
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

        private void btnEmTime_Click(object sender, EventArgs e)
        {
            if (EmTxtIdSearch.Text == "")
            {
                MessageBox.Show("请输入要修改信息的员工的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = String.Format("UPDATE EmployeeSalary SET EmSlaAbsenteeism = '{0}' WHERE EmployeeId = '{1}'", EmTxtTime.Text, EmTxtIdSearch.Text);

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";


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

        private void btnEmBonus_Click(object sender, EventArgs e)
        {
            if (EmTxtIdSearch.Text == "")
            {
                MessageBox.Show("请输入要修改信息的员工的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = String.Format("UPDATE EmployeeSalary SET EmSlaBonus = '{0}' WHERE EmployeeId = '{1}'", Bonus.Text, EmTxtIdSearch.Text);

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";


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

        private void btnAllowance_Click(object sender, EventArgs e)
        {
            if (EmTxtIdSearch.Text == "")
            {
                MessageBox.Show("请输入要修改信息的员工的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = String.Format("UPDATE EmployeeSalary SET EmSlaAllowance = '{0}' WHERE EmployeeId = '{1}'", EmTxtAllowance.Text, EmTxtIdSearch.Text);

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";


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



        private void button6_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet("GZGL"); 

            if (flag7 == 1)
            {
                DataTable dt4 = (DataTable)dataGridView4.DataSource;
                dt4.Rows.Clear();
                dataGridView4.DataSource = dt4;
            }

            string DeId = textBox3.Text;

            if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("请输入所要查询部门的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = String.Format("SELECT ManagerId AS 编号, DepartmentId AS 部门, MaSlaMonth AS 日期, MaSlaBonus AS 奖金, MaSlaAllowance AS 津贴, MaSlaFine AS 罚款, MaSlaAbsenteeism AS 迟到次数, MaSlaOthers AS 备注 FROM ManagerSalary WHERE DepartmentId = '{0}'", DeId);

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        da.SelectCommand = comm;
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        da.Fill(ds, "ManagerSalary");
                        this.dataGridView4.DataSource = ds.Tables["ManagerSalary"];

                        flag7 = 1;
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

        private void btnEmUpdate_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet("GZGL"); 

            if (flag5 == 1)
            {
                DataTable dt5 = (DataTable)dataGridView1.DataSource;
                if (dt5.Rows.Count > 0)
                {
                    dt5.Rows.Clear();
                    dataGridView1.DataSource = dt5;
                }
            }

            if (MaSaId.Text.Trim() == "")
            {
                MessageBox.Show("请输入所要查询经理的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = String.Format("SELECT EmployeeId AS 编号, DepartmentId AS 部门, EmSlaMonth AS 日期, EmSlaBaseWage AS 基础工资, EmSlaBonus AS 奖金, EmSlaAllowance AS 津贴, EmSlaInsurance AS 保险, EmSlaOvertimePay AS 加班费, EmSlaFine AS 罚款, EmSlaAbsenteeism AS 迟到, EmSlaOthers AS 备注 FROM EmployeeSalary WHERE EmployeeId = '{0}'", MaSaId.Text);

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        da.SelectCommand = comm;
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        da.Fill(ds, "EmployeeSalary");
                        this.dataGridView1.DataSource = ds.Tables["EmployeeSalary"];

                        flag5 = 1;
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

        private void button10_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet("GZGL"); 

            if (flag7 == 1)
            {
                DataTable dt6 = (DataTable)dataGridView4.DataSource;
                if (dt6.Rows.Count > 0)
                {
                    dt6.Rows.Clear();
                    dataGridView4.DataSource = dt6;
                }
            }

            string ID = textBox5.Text;

            if (textBox5.Text.Trim() == "")
            {
                MessageBox.Show("请输入所要查询经理的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = String.Format("SELECT ManagerId AS 编号, DepartmentId AS 部门, MaSlaMonth AS 日期, MaSlaBonus AS 奖金, MaSlaAllowance AS 津贴, MaSlaFine AS 罚款, MaSlaAbsenteeism AS 迟到次数, MaSlaOthers AS 备注 FROM ManagerSalary WHERE ManagerId = '{0}'", ID);

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        da.SelectCommand = comm;
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        da.Fill(ds, "ManagerSalary");
                        this.dataGridView4.DataSource = ds.Tables["ManagerSalary"];

                        flag7 = 1;
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

        //static bool Switch5 = false;
        //static bool Switch6 = false;
        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 1)
            {
                if (Login.identity == 2)
                {
                    tabControl2.SelectedIndex = 0;
                    MessageBox.Show("权限不足，请与相关人员联系！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //if (Switch5 == false)
            //{
            //    if (tabControl1.SelectedIndex == 0 && tabControl2.SelectedIndex == 0)
            //    {
            //        Switch5 = true;
            //        ShowInformationManager();
            //    }
            //}

            //if (Switch6 == false)
            //{
            //    if (tabControl1.SelectedIndex == 0 && tabControl2.SelectedIndex == 1)
            //    {
            //        Switch6 = true;
            //        ShowInformationManagerSalary();
            //    }
            //}
        }

        //bool Switch1 = false;
        //bool Switch2 = false;
        //bool Switch3 = false;
        //bool Switch4 = false;
        //private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (Switch1 == false)
        //    {
        //        if (tabControl1.SelectedIndex == 0 && tabControl2.SelectedIndex == 0)
        //        {
        //            Switch1 = true;
        //            ShowInformationManager();
        //        }
        //    }

        //    if (Switch2 == false)
        //    {
        //        if (tabControl1.SelectedIndex == 0 && tabControl2.SelectedIndex == 1)
        //        {
        //            Switch1 = true;
        //            ShowInformationManagerSalary();
        //        }
        //    }

        //    if (Switch3 == false)
        //    {
        //        if (tabControl1.SelectedIndex == 1 && tabControl3.SelectedIndex == 0)
        //        {
        //            Switch3 = true;
        //            ShowInformation();
        //        }
        //    }

        //    if (Switch4 == false)
        //    {
        //        if (tabControl1.SelectedIndex == 1 && tabControl3.SelectedIndex == 1)
        //        {
        //            Switch4 = true;
        //            ShowInformationSalary();
        //        }
        //    }
        //}


        //static bool Switch7 = false;
        //static bool Switch8 = false;
        //private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (Switch7 == false)
        //    {
        //        if (tabControl1.SelectedIndex == 1 && tabControl3.SelectedIndex == 0)
        //        {
        //            Switch7 = true;
        //            ShowInformation();
        //        }
        //    }
        //    if (Switch8 == false)
        //    {
        //        if (tabControl1.SelectedIndex == 1 && tabControl3.SelectedIndex == 1)
        //        {
        //            Switch8 = true;
        //            ShowInformationSalary();
        //        }
        //    }
        //}
   
    }
}
