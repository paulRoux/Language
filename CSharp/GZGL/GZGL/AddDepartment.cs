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
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (AddId.Text == "" || AddMana.Text == "" || AddName.Text == "")
            {
                MessageBox.Show("填写信息不完整，请填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string connString = @"Data Source = 127.0.0.1; Initial Catalog = GZGL; User ID = Paul_roux; Pwd = xia3150931050";

                string sql = String.Format("INSERT INTO DepartmentMsg (DepartmentId, MangerDepId, DepartmentName, DepartmentTel) VALUES('{0}', '{1}', '{2}', '{3}')", AddId.Text, AddMana.Text, AddName.Text, AddTel.Text);
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
                            MessageBox.Show("添加部门信息成功！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AddId.Text = "";
                            AddMana.Text = "";
                            AddName.Text = "";
                            AddTel.Text = "";
                            AddId.Focus();
                        }
                        else
                        {
                            MessageBox.Show("添加部门信息失败！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
