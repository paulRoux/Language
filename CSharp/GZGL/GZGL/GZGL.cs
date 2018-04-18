using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GZGL
{
    public partial class GZGL : Form
    {
        
        public static bool isLogined = false;
        public static bool logined = false;
        public static bool refer = false;
        public static bool update = false;

        public GZGL()
        {
            InitializeComponent();
        }

        private void GZGL_Load(object sender, EventArgs e)
        {
            Login.Loginoff = 1;
            Login login = new Login();
            login.ShowDialog();
            if (logined)
            {
                isLogined = true;
                TssMsg.Text = "恭喜您，已成功登录到工资管理系统！";
            }
            else
            {
                isLogined = false;
                TssMsg.Text = "注意，必须先登录才能使用本系统！";
            }
        }

        private void UserLogin_Click(object sender, EventArgs e)
        {
            if (Login.Loginoff == 2)
            {
                MessageBox.Show("您已登陆过，如需切换账号，请先注销！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Login lForm = new Login();  //实例化用户登陆窗体
                TssMsg.Text = "正在登陆！";

                if (lForm.ShowDialog() == DialogResult.OK)
                {
                    if ((bool)lForm.Tag)
                    {
                        isLogined = true;
                        logined = true;
                        TssMsg.Text = "恭喜您，已成功登录到工资管理系统！";
                    }
                    else
                    {
                        isLogined = false;
                        TssMsg.Text = "注意，必须先登录才能使用本系统！";
                    }
                }
            }
        }

        private void GZGL_FormClosing(object sender, FormClosingEventArgs e)
        {
            TssMsg.Text = "即将退出系统！";
            Application.Exit();
        }

        private void UserSignin_Click(object sender, EventArgs e)
        {

            SignIn sign = new SignIn();
            sign.ShowDialog();
            if (SignIn.signIn == true)
            {
                
                if (Login.Loginoff == 2)
                {
                    //MessageBox.Show("登陆成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    TssMsg.Text = "恭喜您，已成功登录到工资管理系统！";
                }
                else
                {
                    Login login = new Login();
                    login.ShowDialog();
                    //MessageBox.Show("您还没登录，请先登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TssMsg.Text = "您还没登录，请先登录！";
                }
            }
           
            
        }

        private void UserCancel_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                if (MessageBox.Show("您确定要注销登陆吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Login.Loginoff = 1;
                    Login.identity = 0;
                    isLogined = false;
                    MessageBox.Show("注销成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TssMsg.Text = "用户已注销！";
                    Login login = new Login();
                    login.ShowDialog();
                    if (Login.Loginoff == 2)
                    {
                        TssMsg.Text = "恭喜您，已成功登录到工资管理系统！";
                    }
                    else
                    {
                        TssMsg.Text = "您还没登录，请先登录！";
                    }
                }
                else
                {
                    TssMsg.Text = "请选择一个操作！";
                }
            }
            else
            {
                TssMsg.Text = "您还没登录，请先登录！";           
                MessageBox.Show("您还未登陆，请先登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void userUpdate_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                UserUpdate userUpdate = new UserUpdate();
                userUpdate.ShowDialog();
                if (update == false)
                    TssMsg.Text = "信息修改";
                else
                    TssMsg.Text = "请选择一个操作！";
            }
            else
            {
                TssMsg.Text = "您还未登陆，请先登录！";
                MessageBox.Show("您还未登陆，请先登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TsbAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
            if (refer == false)
                TssMsg.Text = "关于";
            else
                TssMsg.Text = "请选择一个操作！";
        }

        private void PeoIfoAdd_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                if (Login.identity != 1)
                {
                    PeoAdd meAdd = new PeoAdd();
                    meAdd.ShowDialog();
                }
                else
                {
                    TssMsg.Text = "权限不够，请联系相关人员！";
                    if (MessageBox.Show("权限不够，请联系相关人员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        TssMsg.Text = "请选择一个操作！";
                    }
                }
            }
            else
            {
                TssMsg.Text = "您还未登陆，请先登录！";
                MessageBox.Show("您还未登陆，请先登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PeoIfoSearch_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                PeoQuery query = new PeoQuery();
                query.ShowDialog();
                TssMsg.Text = "正在查询！";
            }
            else
            {
                TssMsg.Text = "您还未登陆，请先登录！";
                MessageBox.Show("您还未登陆，请先登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PeoIfoUpdate_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                if (Login.identity != 1)
                {
                    PeoUpdate update = new PeoUpdate();
                    update.ShowDialog();
                    TssMsg.Text = "正在修改！";
                }
                else
                {
                    TssMsg.Text = "权限不够，请联系相关人员！";
                    if (MessageBox.Show("权限不够，请联系相关人员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        TssMsg.Text = "请选择一个操作！";
                    }
                }
            }
            else
            {
                TssMsg.Text = "您还未登陆，请先登录！";
                MessageBox.Show("您还未登陆，请先登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SlaIfoSearch_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                WageQuery waQuery = new WageQuery();
                waQuery.ShowDialog();
                TssMsg.Text = "正在查询！";
            }
            else
            {
                TssMsg.Text = "您还未登陆，请先登录！";
                MessageBox.Show("您还未登陆，请先登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void HelpText_Click(object sender, EventArgs e)
        {
            HelpText help = new HelpText();
            help.Show();
            TssMsg.Text = "帮助文档";
        }

        private void SlaIfoUpdate_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                if (Login.identity != 1)
                {
                    WageUpdate wageupdate = new WageUpdate();
                    wageupdate.ShowDialog();
                    TssMsg.Text = "正在修改工资信息！";
                }
                else
                {
                    TssMsg.Text = "权限不够，请联系相关人员！";
                    if (MessageBox.Show("权限不够，请联系相关人员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        TssMsg.Text = "请选择一个操作！";
                    }
                }
            }
            else
            {
                TssMsg.Text = "您还未登陆，请先登录！";
                MessageBox.Show("您还未登陆，请先登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbAddSsalary_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                if (Login.identity != 1)
                {
                    WageAdd wageAdd = new WageAdd();
                    wageAdd.ShowDialog();
                }
                else
                {
                    TssMsg.Text = "权限不够，请联系相关人员！";
                    if (MessageBox.Show("权限不够，请联系相关人员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        TssMsg.Text = "请选择一个操作！";
                    }
                }
            }
            else
            {
                TssMsg.Text = "您还未登陆，请先登录！";
                MessageBox.Show("您还未登陆，请先登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void tsbAddDepart_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                if (Login.identity == 3)
                {
                    AddDepartment AddDe = new AddDepartment();
                    AddDe.ShowDialog();
                }
                else
                {
                    TssMsg.Text = "权限不够，请联系相关人员！";
                    if (MessageBox.Show("权限不够，请联系相关人员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        TssMsg.Text = "请选择一个操作！";
                    }
                }
            }
            else
            {
                TssMsg.Text = "您还未登陆，请先登录！";
                MessageBox.Show("您还未登陆，请先登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
