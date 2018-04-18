using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class Totol : Form
    {
        private bool isLogined = false;
        public Totol()
        {
            InitializeComponent();
        }

        private void 退出XCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于ACtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reference about = new Reference();
            about.ShowDialog();
            tssMsg.Text = about.Text;
        }

        private void 用户管理UCtrlUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 登陆LCtrlLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Login about = new Login();
            //about.ShowDialog();
            //tssMsg.Text = about.Text;

            Login lForm = new Login();
            tssMsg.Text = lForm.Text;

            if (lForm.ShowDialog() == DialogResult.OK)
            {
                if ((bool)lForm.Tag)
                {
                    isLogined = true;
                    tssMsg.Text = "恭喜您，已成功登录系统！";
                }
                else
                {
                    isLogined = false;
                    tssMsg.Text = "注意，必须先登录才能使用本系统！";
                }
            }
        }

        private void 添加收支项目ICtrlIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Things about = new Things();
            //about.ShowDialog();
            //tssMsg.Text = about.Text;

            if (isLogined)
            {
                Things tForm = new Things();
                tForm.MdiParent = this;
                tForm.Show();
                tssMsg.Text = tForm.Text;
            }
            else
            {
                tssMsg.Text = "注意，必须先登录才能使用本系统！";
            }
        }

        private void 添加收支PCtrlPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //position about = new position();
            //about.ShowDialog();
            //tssMsg.Text = about.Text;

            if (isLogined)
            {
                position pForm = new position();
                pForm.MdiParent = this;
                pForm.Show();
                tssMsg.Text = pForm.Text;
            }
            else
            {
                tssMsg.Text = "注意，必须先登录才能使用本系统！";
            }
        }

    }
}
