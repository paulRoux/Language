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
    public partial class PeoQuery : Form
    {
        public PeoQuery()
        {
            InitializeComponent();       
            ShowInformation();
            if (Login.identity == 1)
            {
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                tabControl1.SelectedIndex = 0;
                ShowManagerInformation();
            }
        }
        
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet("GZGL");

        private int flag = 0;


        private void ShowManagerInformation()
        {
            string sql = String.Format("SELECT ManagerNo AS 序列, ManagerId AS 编号, DepartmentId AS 部门, ManagerName AS 姓名, ManagerSex AS 性别, ManagerTime AS 入职时间, ManagerWorkAge AS 工龄, ManagerAccount AS 账户, ManagerTel AS 联系电话, ManagerEmail AS 邮箱, ManagerPwd AS 密码, ManagerRemark AS 备注 FROM ManagerMsg");

            string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    da.SelectCommand = comm;
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    da.Fill(ds, "ManagerMsg");
                    this.dvInfo.DataSource = ds.Tables["ManagerMsg"];

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
            string sql = String.Format("SELECT EmployeeNo AS 序列, EmployeeId AS 编号, ManagerId AS 经理, DepartmentId AS 部门, EmployeeName AS 姓名, EmployeeSex AS 性别, EmployeeTime AS 入职时间, EmployeeWorkAge AS 工龄, EmployeeAccount AS 账户, EmployeeTel AS 联系电话, EmployeeEmail AS 邮箱, EmployeePwd AS 密码, EmployeeRemark AS 备注 FROM EmployeeMsg");

            string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    da.SelectCommand = comm;
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    da.Fill(ds, "EmployeeMsg");
                    this.dvEmInfo.DataSource = ds.Tables["EmployeeMsg"];

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

        private void EmdateQuery_Click(object sender, EventArgs e)
        {
            string Date = Emdate.Value.ToString();

            if (flag == 1)
            {
                DataTable dt = (DataTable)dvEmInfo.DataSource;
                dt.Rows.Clear();
                dvEmInfo.DataSource = dt;
            }

            string sql = String.Format("SELECT EmployeeNo AS 序列, EmployeeId AS 编号, ManagerId AS 经理, DepartmentId AS 部门, EmployeeName AS 姓名, EmployeeSex AS 性别, EmployeeTime AS 入职时间, EmployeeWorkAge AS 工龄, EmployeeAccount AS 账户, EmployeeTel AS 联系电话, EmployeeEmail AS 邮箱, EmployeePwd AS 密码, EmployeeRemark AS 备注 FROM EmployeeMsg WHERE EmployeeTime = '{0}'", Date);

            string Sql = String.Format("SELECT COUNT(*) FROM EmployeeMsg WHERE EmployeeTime = '{0}'", Date);

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
                        this.dvEmInfo.DataSource = ds.Tables["EmployeeMsg"];

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

        private void EmQuery_Click(object sender, EventArgs e)
        {
            string ID = EmQueryId.Text;

            if (flag == 1)
            {
                DataTable dt = (DataTable)dvEmInfo.DataSource;
                dt.Rows.Clear();
                dvEmInfo.DataSource = dt;
            }

            if (EmQueryId.Text.Trim() == "")
            {
                MessageBox.Show("请输入所要查询员工的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = String.Format("SELECT EmployeeNo AS 序列, EmployeeId AS 编号, ManagerId AS 经理, DepartmentId AS 部门, EmployeeName AS 姓名, EmployeeSex AS 性别, EmployeeTime AS 入职时间, EmployeeWorkAge AS 工龄, EmployeeAccount AS 账户, EmployeeTel AS 联系电话, EmployeeEmail AS 邮箱, EmployeePwd AS 密码, EmployeeRemark AS 备注 FROM EmployeeMsg WHERE EmployeeId = '{0}'", ID);

                string Sql = String.Format("SELECT COUNT(*) FROM EmployeeMsg WHERE EmployeeId = '{0}'", ID);

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
                            this.dvEmInfo.DataSource = ds.Tables["EmployeeMsg"];

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

        private void Query_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                DataTable dt = (DataTable)dvInfo.DataSource;
                dt.Rows.Clear();
                dvInfo.DataSource = dt;
            }

            string ID = QueryId.Text;

            if (QueryId.Text.Trim() == "")
            {
                MessageBox.Show("请输入所要查询经理的编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = String.Format("SELECT ManagerNo AS 序列, ManagerId AS 编号, DepartmentId AS 部门, ManagerName AS 姓名, ManagerSex AS 性别, ManagerTime AS 入职时间, ManagerWorkAge AS 工龄, ManagerAccount AS 账户, ManagerTel AS 联系电话, ManagerEmail AS 邮箱, ManagerPwd AS 密码, ManagerRemark AS 备注 FROM ManagerMsg WHERE ManagerId = '{0}'", ID);

                string Sql = String.Format("SELECT COUNT(*) FROM ManagerMsg WHERE ManagerId = '{0}'", ID);

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
                            da.Fill(ds, "ManagerMsg");
                            this.dvInfo.DataSource = ds.Tables["ManagerMsg"];
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
            if (flag == 1)
            {
                DataTable dt = (DataTable)dvInfo.DataSource;
                dt.Rows.Clear();
                dvInfo.DataSource = dt;
            }

            string Date = date.Value.ToString();

            string sql = String.Format("SELECT ManagerNo AS 序列, ManagerId AS 编号, DepartmentId AS 部门, ManagerName AS 姓名, ManagerSex AS 性别, ManagerTime AS 入职时间, ManagerWorkAge AS 工龄, ManagerAccount AS 账户, ManagerTel AS 联系电话, ManagerEmail AS 邮箱, ManagerPwd AS 密码, ManagerRemark AS 备注 FROM ManagerMsg WHERE ManagerTime = '{0}'", Date);

            string Sql = String.Format("SELECT COUNT(*) FROM ManagerMsg WHERE ManagerTime = '{0}'", Date);

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
                        da.Fill(ds, "ManagerMsg");
                        this.dvInfo.DataSource = ds.Tables["ManagerMsg"];

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
