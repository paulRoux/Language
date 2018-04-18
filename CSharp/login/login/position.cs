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
    public partial class position : Form
    {
        int Money;
        string kinds;
        string kind;
        string kind1;
        string person;
        public position()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                kinds = radioButton1.Text;
            }
            else
            {
                kinds = radioButton2.Text;
            }

            kind = comboBox1.SelectedItem.ToString();
            kind1 = listBox1.SelectedItem.ToString();
            person = "";
            if (checkBox1.Checked)
            {
                person = checkBox1.Text;
            }
            else if (checkBox2.Checked)
            {
                person = checkBox2.Text;
            }
            else if (checkBox3.Checked)
            {
                person = checkBox3.Text;
            }
            else if (checkBox4.Checked)
            {
                person = checkBox4.Text;
            }
            else if (checkBox5.Checked)
            {
                person = checkBox5.Text;
            }
            else if (checkBox6.Checked)
            {
                person = checkBox6.Text;
            }
            Money = (int)money.Value;
            string things = richTextBox2.Text;
            string explain = textBox3.Text;

            string info = "您的收支类型为：" + kinds;
            info += "\n收支类别为：" + kind;
            info += "\n收支项目为：" + kind1;
            info += "\n" + kinds +"人的为"+ person;
            info += "\n金额：" + Money;
            info += "\n\n说明：" + explain;
            info += "\n备注：" + things;
            info += "\n日期：" + time.Text;

            MessageBox.Show(info, "收支信息", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void position_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label9.Left > this.Width)
            {
                label9.Left = 0;
            }
            label9.Left += 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("保存", "保存成功!", MessageBoxButtons.OK);
        }
    }
}
