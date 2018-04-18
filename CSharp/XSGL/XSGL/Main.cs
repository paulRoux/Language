using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XSGL
{
    public partial class Main : Form
    {
        public static bool isLogined = false;  //记录登陆的凭据
        public static int count = 1;
        public static bool logined = false;  //检测是否登录同步
        Login iden = new Login();

        public Main()
        {
            InitializeComponent();
            //this.IsMdiContainer = true;
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            tssMsg.Text = "即将退出系统！";
            if (MessageBox.Show("您确定要退出系统吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //count = 1;
                //Login.identity = 0;
                Application.Exit();
            }
        }

        private void tsmLogin_Click(object sender, EventArgs e)
        {
            if (Login.Ju == 2)
            {
                MessageBox.Show("您已登陆过，如需切换账号，请先注销！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Login lForm = new Login();  //实例化用户登陆窗体
                tssMsg.Text = "正在登陆！";

                if (lForm.ShowDialog() == DialogResult.OK)
                {
                    if ((bool)lForm.Tag)
                    {
                        isLogined = true;
                        count = 0;
                        logined = true;
                        tssMsg.Text = "恭喜您，已成功登录到学生管理系统！";
                    }
                    else
                    {
                        isLogined = false;
                        tssMsg.Text = "注意，必须先登录才能使用本系统！";
                    }
                }
            }
        }

        private void tsmNewStudent_Click(object sender, EventArgs e)
        {           
            if (isLogined && Login.identity == 1)
            {
                StudentMsg sForm = new StudentMsg();
                //sForm.MdiParent = this;
                sForm.Show();
                tssMsg.Text = sForm.Text;
            }
            else
            {
                if (!isLogined)
                {
                    tssMsg.Text = "注意，必须先登录才能使用本系统！";
                }
                else
                {
                    tssMsg.Text = "注意，必须是管理员才能添加学生！";
                    if (MessageBox.Show("注意，必须是管理员才能添加学生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        tssMsg.Text = "请选择一个操作！";
                    }
                }
            }
        }

        private void tsmNewCourse_Click(object sender, EventArgs e)
        {
            if (isLogined && Login.identity == 1)
            {
                CourseMsg cForm = new CourseMsg();
                //cForm.MdiParent = this;
                cForm.Show();
                tssMsg.Text = cForm.Text;
            }
            else
            {
                if (!isLogined)
                {                   
                    tssMsg.Text = "注意，必须先登录才能使用本系统！";
                }
                else
                {
                    tssMsg.Text = "注意，必须是管理员才能添加课程！";
                    if (MessageBox.Show("注意，必须是管理员才能添加课程！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        tssMsg.Text = "请选择一个操作！";
                    }
                }
            }
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            tssMsg.Text = "关于";
            AboutForm about = new AboutForm();
            about.ShowDialog();
            tssMsg.Text = "请选择一个操作！";
        }

        private void tsmStuMsgMag_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                StudentFrm sfForm = new StudentFrm();
                //sfForm.MdiParent = this;
                sfForm.Show();
                tssMsg.Text = sfForm.Text;
                if (Login.identity == 1)
                {
                    tssMsg.Text = "您现在是管理员身份，可进行所有操作！";
                }
                else if (Login.identity == 2)
                {
                    tssMsg.Text = "您现在是教师身份，不可进行删除操作！";
                }
                else if(Login.identity == 3)
                {
                    tssMsg.Text = "您现在是学生身份，不可进行更新和删除操作！";
                }
            }
            else
            {
                tssMsg.Text = "注意，必须先登录才能使用本系统！";
            }
        }

        private void tsmCurMsgMag_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                CourseFrm cfForm = new CourseFrm();
                //cfForm.MdiParent = this;
                cfForm.Show();
                tssMsg.Text = cfForm.Text;
                if (Login.identity == 1)
                {
                    tssMsg.Text = "您现在是管理员身份，可进行所有操作！";
                }
                else if (Login.identity == 2)
                {
                    tssMsg.Text = "您现在是教师身份，不可进行更新和删除操作！";
                }
                else if (Login.identity == 3)
                {
                    tssMsg.Text = "您现在是学生身份，不可进行更新和删除操作！";
                }
            }
            else
            {
                tssMsg.Text = "注意，必须先登录才能使用本系统！";
            }
        }

        private void UserLogOff_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                if (MessageBox.Show("您确定要注销登陆吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Login.Ju = 1;
                    count = 1;
                    Login.identity = 0;
                    MessageBox.Show("注销成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tssMsg.Text = "用户已注销！";
                    isLogined = false;
                    Login login = new Login();
                    login.ShowDialog();
                    if (Login.Ju == 2)
                    {
                        tssMsg.Text = "恭喜您，已成功登录到学生管理系统！";
                    }
                    else
                    {
                        tssMsg.Text = "您还没登录，请先登录！";
                    }
                }
            }
            else
            {
                tssMsg.Text = "您还没登录，请先登录！";
            }
        }

        private void tsmNewTea_Click(object sender, EventArgs e)
        {
            if (isLogined && Login.identity == 1)
            {
                TeacherMsg tmForm = new TeacherMsg();
                tmForm.Show();
                tssMsg.Text = tmForm.Text;
            }
            else
            {
                if (!isLogined)
                {
                    tssMsg.Text = "注意，必须先登录才能使用本系统！";
                }
                else
                {
                    tssMsg.Text = "注意，必须是管理员才能添加教师！";
                    if (MessageBox.Show("注意，必须是管理员才能添加教师！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        tssMsg.Text = "请选择一个操作！";
                    }            
                }
            }
        }

        private void tsmTeaMsg_Click(object sender, EventArgs e)
        {
            if (isLogined && Login.identity != 3)
            {
                TeacherFrm tfForm = new TeacherFrm();
                tfForm.Show();
                tssMsg.Text = tfForm.Text;
                if (Login.identity == 1)
                {
                    tssMsg.Text = "您现在是管理员身份！";
                }
                else if (Login.identity == 2)
                {
                    tssMsg.Text = "您现在是教师身份！";
                }
            }
            else
            {
                if (Login.identity == 3)
                {
                    tssMsg.Text = "您现在是学生，无法查看教师信息！";
                    if (MessageBox.Show("您现在是学生，无法查看教师信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        tssMsg.Text = "请选择一个操作！";
                    }      
                }
                else
                {
                    tssMsg.Text = "注意，必须先登录才能使用本系统！";
                }
            }
        }

        private void GradeCheck_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                GradeCheck cgForm = new GradeCheck();
                cgForm.Show();
                tssMsg.Text = cgForm.Text;
            }
            else
            {
                tssMsg.Text = "注意，必须先登录才能使用本系统！";
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {            
            Login.Ju = 1;
            Login login = new Login();
            login.ShowDialog();
            if (logined)
            {
                isLogined = true;
                tssMsg.Text = "恭喜您，已成功登录到学生管理系统！";
            }
            else
            {
                isLogined = false;
                tssMsg.Text = "注意，必须先登录才能使用本系统！";
            }
        }
    }
}
