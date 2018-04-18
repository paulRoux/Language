using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TranArgument
{
    public partial class TranArgument : Form
    {
        public TranArgument()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Swaper s = new Swaper();
            int a = Convert.ToInt32(txtOp1.Text);
            int b = Convert.ToInt32(txtOp2.Text);
            lblShow.Text = string.Format("主调方法:交换之前:a = {0}, b = {1}", a, b);
            lblShow.Text += s.Swap(a, b);
            lblShow.Text += string.Format("\n\n主调方法:调用之后:a = {0}, b = {1}", a, b);
            txtOp1.Text = a.ToString();
            txtOp2.Text = b.ToString();
        }
    }
    class Swaper
    {
        public string Swap(int x, int y)
        {
            string str = string.Format("\n\n被调方法:交换之前:x = {0}, y = {1}", x, y);
            int temp;
            temp = x;
            x = y;
            y = temp;
            str += string.Format("\n\n被调方法:交换之后:x = {0}, y = {1}", x, y);
            return str;
        }
    }
}
