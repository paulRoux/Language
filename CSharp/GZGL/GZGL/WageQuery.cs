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
    public partial class WageQuery : Form
    {
        public static string Username = "";

        public WageQuery()
        {
            InitializeComponent();          
            ShowInformation();
            if (Login.identity == 1)
            {
                tabControl1.SelectedIndex = 1;
                EmQueryId.Focus();
            }
            else
            {
                tabControl1.SelectedIndex = 0;
                ShowInformationManager();
                MaQueryId.Focus();
            }
        }

        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet("GZGL");

        private int flag = 0;


        private void ShowInformationManager()
        {
            string sql = String.Format("SELECT ManagerId AS 编号, MaSlaMonth AS 日期, MaSlaBaseWage AS 基础工资, MaSlaBonus AS 奖金, MaSlaAllowance AS 津贴, MaSlaInsurance AS 保险, MaSlaOvertimePay AS 加班费, MaSlaFine AS 罚款, MaSlaAbsenteeism AS 迟到次数, MaSlaOthers AS 备注 FROM ManagerSalary");

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
                    this.dvWageInfoMa.DataSource = ds.Tables["ManagerSalary"];

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
       
        private void ShowInformation()
        {
            string sql = String.Format("SELECT EmployeeId AS 编号, EmSlaMonth AS 日期, EmSlaBaseWage AS 基础工资, EmSlaBonus AS 奖金, EmSlaAllowance AS 津贴, EmSlaInsurance AS 保险, EmSlaOvertimePay AS 加班费, EmSlaFine AS 罚款, EmSlaAbsenteeism AS 迟到次数, EmSlaOthers AS 备注 FROM EmployeeSalary");

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
                    this.dvWageInfo.DataSource = ds.Tables["EmployeeSalary"];

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


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (Login.identity == 1)
                {
                    tabControl1.SelectedIndex = 1;
                    MessageBox.Show("权限不足，请与相关人员联系！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void Query_Click(object sender, EventArgs e)
        {
            string ID = EmQueryId.Text.Trim();

            if (flag == 1)
            {
                DataTable dt = (DataTable)dvWageInfo.DataSource;
                dt.Rows.Clear();
                dvWageInfo.DataSource = dt;
            }

            if (EmQueryId.Text.Trim() == "")
            {
                MessageBox.Show("请输入所要查询员工的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                //string sql1 = String.Format("SELECT EmployeeId AS 编号, EmSlaMonth AS 日期, EmSlaBaseWage AS 基础工资, EmSlaBonus AS 奖金, EmSlaAllowance AS 津贴, EmSlaInsurance AS 保险, EmSlaOvertimePay AS 加班费, EmSlaFine AS 罚款, EmSlaAbsenteeism AS 迟到次数, EmSlaOthers AS 备注 FROM EmployeeSalary WHERE EmployeeId = '{0}'", Username);

                string sql = String.Format("SELECT EmployeeId AS 编号, DepartmentId AS 部门, EmSlaMonth AS 日期, EmSlaBaseWage AS 基础工资, EmSlaBonus AS 奖金, EmSlaAllowance AS 津贴, EmSlaInsurance AS 保险, EmSlaOvertimePay AS 加班费, EmSlaFine AS 罚款, EmSlaAbsenteeism AS 迟到次数, EmSlaOthers AS 备注 FROM EmployeeSalary WHERE EmployeeId = '{0}'", ID);


                string Sql = String.Format("SELECT COUNT(*) FROM EmployeeSalary WHERE EmployeeId = '{0}'", ID);

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();

                        SqlCommand comm = new SqlCommand(sql, conn);                          SqlCommand Comm = new SqlCommand(Sql, conn);
                        da.SelectCommand = comm;
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);

                        int n = (int)Comm.ExecuteScalar();
                        if (n == 1)
                        {
                            da.Fill(ds, "EmployeeSalary");
                            this.dvWageInfo.DataSource = ds.Tables["EmployeeSalary"];

                            flag = 1;
                        }
                        else
                        {
                            MessageBox.Show("没有查询到此人信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ManadateQuery_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                DataTable dt = (DataTable)dvWageInfoMa.DataSource;
                dt.Rows.Clear();
                dvWageInfoMa.DataSource = dt;
            }

            string Date = date.Value.ToShortDateString();


            //string sql = String.Format("SELECT ManagerId AS 编号, MaSlaMonth AS 日期, MaSlaBaseWage AS 基础工资, MaSlaBonus AS 奖金, MaSlaAllowance AS 津贴, MaSlaInsurance AS 保险, MaSlaOvertimePay AS 加班费, MaSlaFine AS 罚款, MaSlaAbsenteeism AS 迟到次数, MaSlaOthers AS 备注 FROM ManagerSalary WHERE MaSlaMonth = '{0}' AND ManagerId = '{1}'", Date, Username);

            string sql = String.Format("SELECT ManagerId AS 编号, MaSlaMonth AS 日期, MaSlaBaseWage AS 基础工资, MaSlaBonus AS 奖金, MaSlaAllowance AS 津贴, MaSlaInsurance AS 保险, MaSlaOvertimePay AS 加班费, MaSlaFine AS 罚款, MaSlaAbsenteeism AS 迟到次数, MaSlaOthers AS 备注 FROM ManagerSalary WHERE MaSlaMonth = '{0}'", Date);

            string Sql = String.Format("SELECT COUNT(*) FROM EmployeeSalary WHERE EmSlaMonth = '{0}'", Date);

            string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    SqlCommand Comm = new SqlCommand(Sql, conn);
                    da.SelectCommand = comm;
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);

                    int n = (int)Comm.ExecuteScalar();
                    if (n != 1)
                    {
                        MessageBox.Show("没有查询到此人信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        da.Fill(ds, "ManagerSalary");
                        this.dvWageInfoMa.DataSource = ds.Tables["ManagerSalary"];

                        flag = 1;
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

        private void ManagerQuery_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                DataTable dt = (DataTable)dvWageInfoMa.DataSource;
                if (dt.Rows.Count != 0)
                {
                    dt.Rows.Clear();
                    dvWageInfoMa.DataSource = dt;
                }
            }

            string ID = MaQueryId.Text;

            if (MaQueryId.Text.Trim() == "")
            {
                MessageBox.Show("请输入所要查询经理的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //string sql = String.Format("SELECT ManagerId AS 编号, MaSlaMonth AS 日期, MaSlaBaseWage AS 基础工资, MaSlaBonus AS 奖金, MaSlaAllowance AS 津贴, MaSlaInsurance AS 保险, MaSlaOvertimePay AS 加班费, MaSlaFine AS 罚款, MaSlaAbsenteeism AS 迟到次数, MaSlaOthers AS 备注 FROM ManagerSalary WHERE ManagerId = '{0}'", ID);

                string sql = String.Format("SELECT ManagerId AS 编号, DepartmentId AS 部门, MaSlaMonth AS 日期, MaSlaBaseWage AS 基础工资, MaSlaBonus AS 奖金, MaSlaAllowance AS 津贴, MaSlaInsurance AS 保险, MaSlaOvertimePay AS 加班费, MaSlaFine AS 罚款, MaSlaAbsenteeism AS 迟到次数, MaSlaOthers AS 备注 FROM ManagerSalary WHERE ManagerId = '{0}'", ID);

                string Sql = String.Format("SELECT COUNT(*) FROM ManagerSalary WHERE ManagerId = '{0}'", ID);

                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(sql, conn);
                        SqlCommand Comm = new SqlCommand(Sql, conn);
                        da.SelectCommand = comm;
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        int n = (int)Comm.ExecuteScalar();
                        if (n == 1)
                        {
                            da.Fill(ds, "ManagerSalary");
                            this.dvWageInfoMa.DataSource = ds.Tables["ManagerSalary"];

                            flag = 1;
                        }
                        else
                        {
                            MessageBox.Show("没有查询到此人信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dateQuery_Click(object sender, EventArgs e)
        {
            string Date = dateTimePicker1.Value.ToString();

            if (flag == 1)
            {
                DataTable dt = (DataTable)dvWageInfo.DataSource;
                dt.Rows.Clear();
                dvWageInfo.DataSource = dt;
            }

            //string sql = String.Format("SELECT EmployeeId AS 编号, EmSlaMonth AS 日期, EmSlaBaseWage AS 基础工资, EmSlaBonus AS 奖金, EmSlaAllowance AS 津贴, EmSlaInsurance AS 保险, EmSlaOvertimePay AS 加班费, EmSlaFine AS 罚款, EmSlaAbsenteeism AS 迟到次数, EmSlaOthers AS 备注 FROM EmployeeSalary WHERE ManagerID = '{0}' AND EmSlaMonth = '{1}'", Username, Date);

            string sql = String.Format("SELECT EmployeeId AS 编号, EmSlaMonth AS 日期, EmSlaBaseWage AS 基础工资, EmSlaBonus AS 奖金, EmSlaAllowance AS 津贴, EmSlaInsurance AS 保险, EmSlaOvertimePay AS 加班费, EmSlaFine AS 罚款, EmSlaAbsenteeism AS 迟到次数, EmSlaOthers AS 备注 FROM EmployeeSalary WHERE EmSlaMonth = '{0}'", Date);

            string Sql = String.Format("SELECT COUNT(*) FROM EmployeeSalary WHERE EmSlaMonth = '{0}'", Date);

            string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    SqlCommand Comm = new SqlCommand(Sql, conn);
                    da.SelectCommand = comm;
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);

                    int n = (int)Comm.ExecuteScalar();
                    if (n != 1)
                    {
                        MessageBox.Show("没有查询到此人信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        da.Fill(ds, "EmployeeMsg");
                        this.dvWageInfo.DataSource = ds.Tables["EmployeeMsg"];

                        flag = 1;
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
