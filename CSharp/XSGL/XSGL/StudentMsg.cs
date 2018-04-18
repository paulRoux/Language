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
    public partial class StudentMsg : Form
    {
        public StudentMsg()
        {
            InitializeComponent();
        }

        private void StudentMsg_Load(object sender, EventArgs e)
        {
            #region Settings         
            rdoMale.Checked = true;
            dtBirthday.MaxDate = DateTime.Now;
            dtBirthday.Value = dtBirthday.MinDate;
            timeGO.Enabled = true;
            #endregion

            #region Deparment
            string sql = String.Format("SELECT Department FROM DepFrm ");
            string conString = @"Data Source=127.0.0.1; Initial Catalog=XSGL; Integrated Security = True";

            SqlConnection conn = new SqlConnection(conString);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);

                da.SelectCommand = comm;
                SqlCommandBuilder bulder = new SqlCommandBuilder(da);

                da.Fill(ds, "DepFrm");

                this.cboDept.DisplayMember = "Department";
                this.cboDept.ValueMember = "ID";

                this.cboDept.DataSource = ds.Tables["DepFrm"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作出错！" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
            }
            #endregion             Deparment Deparment

            #region Speciality
            string Sql = String.Format("SELECT Speciality FROM SpecFrm ");
            string ConString = @"Data Source=127.0.0.1; Initial Catalog=XSGL; Integrated Security = True";

            SqlConnection Conn = new SqlConnection(ConString);
            DataSet Ds = new DataSet();
            SqlDataAdapter Da = new SqlDataAdapter();

            try
            {
                Conn.Open();
                SqlCommand Comm = new SqlCommand(Sql, Conn);

                Da.SelectCommand = Comm;
                SqlCommandBuilder bulder = new SqlCommandBuilder(Da);

                Da.Fill(Ds, "SpecFrm");

                //this.cboDept.DisplayMember = "Department";
                //this.cboDept.ValueMember = "ID";

                //this.cboDept.DataSource = ds.Tables["DepFrm"];

                this.lstSpec.DisplayMember = "Speciality";
                this.lstSpec.ValueMember = "ID";

                this.lstSpec.DataSource = Ds.Tables["SpecFrm"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作出错！" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Conn.Close();
            }
            #endregion 

        }

        //private void btnYes_Click(object sender, EventArgs e)
        //{
        //    string sex = "";
        //    if (rdoMale.Checked)
        //    {
        //        sex = rdoMale.Text;
        //    }
        //    else
        //    {
        //        sex = rdoFemale.Text;
        //    }

        //    string dept = cboDept.SelectedItem.ToString();
        //    string spec = lstSpec.SelectedItem.ToString();
        //    string hobby = "";

        //    if (checkBox1.Checked) hobby += checkBox1.Text += "、";
        //    if (checkBox2.Checked) hobby += checkBox2.Text += "、";
        //    if (checkBox3.Checked) hobby += checkBox3.Text += "、";
        //    if (checkBox4.Checked) hobby += checkBox4.Text += "、";
        //    if (checkBox5.Checked) hobby += checkBox5.Text += "、";
        //    if (checkBox6.Checked) hobby += checkBox6.Text += "、";

        //    string info = "您的姓名是：" + txtName.Text;
        //    info += "\n出生年月为：" + dtBirthday.Value.ToShortDateString();
        //    info += "\n您是：" + dept + "系" + spec + "专业的学生。";
        //    info += "\n你的兴趣有：" + hobby;
        //    MessageBox.Show(info, "学生信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        private void btnYes_Click(object sender, EventArgs e)
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

            //string dept = cboDept.SelectedItem.ToString();
            //string spec = lstSpec.SelectedItem.ToString();
            string spec = lstSpec.SelectedValue.ToString();
            string dept = cboDept.SelectedValue.ToString();
            string passwd = password.Text;
            string hobby = "";

            if (checkBox1.Checked) hobby += checkBox1.Text += ' ';
            if (checkBox2.Checked) hobby += checkBox2.Text += ' ';
            if (checkBox3.Checked) hobby += checkBox3.Text += ' ';
            if (checkBox4.Checked) hobby += checkBox4.Text += ' ';
            if (checkBox5.Checked) hobby += checkBox5.Text += ' ';
            if (checkBox6.Checked) hobby += checkBox6.Text += ' ';

            string sql = String.Format("INSERT INTO StudentMsg (StudentName, Sex, Birthday, Department, Speciality, Hobby, StudentPwd) VALUES('{0}','{1}','{2}','{3}','{4}','{5}', '{6}')" , txtName.Text, sex, dtBirthday.Value, dept, spec, hobby, passwd);

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
                        MessageBox.Show("添加学生信息成功！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("添加学生信息失败！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timeGO_Tick(object sender, EventArgs e)
        {
            if (lblTip.Left >= this.Width)
            {
                lblTip.Left = 0;
            }
            lblTip.Left += 1;
        }
      
    }
}
