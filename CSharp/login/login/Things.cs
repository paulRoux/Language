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
    public partial class Things : Form
    {
        string thingName;
        string required;
        string thingKind;

        public Things()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Trim().Length == 0)
            {
                MessageBox.Show("信息不完整", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tabControl1.SelectedIndex = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("添加成功！", "添加", MessageBoxButtons.OK);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (txtname.Text.Trim().Length == 0)
                {
                    MessageBox.Show("输入的信息不完整！", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    thingName = txtname.Text;
                    required = radioButton1.Checked ? "收入" : "支出";
                    thingKind = comboBox1.SelectedItem.ToString();
                    string message = String.Format("项目名称：{0}\n项目类型：{1}\n项目类别：{2}", thingName, required, thingKind);
                    richTextBox1.Text = message;
                }
            }
        }

        private void 信息_Load(object sender, EventArgs e)
        {

        }

    }
}
