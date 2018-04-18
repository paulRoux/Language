using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverLoad
{
    public partial class OverLoad : Form
    {
        public OverLoad()
        {
            InitializeComponent();
        }

        private void btnTwoInt_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtOp1.Text);
            int b = Convert.ToInt32(txtOp2.Text);
            Maxer M = new Maxer();
            lblShow.Text = "最大值:" + M.Max(a, b);
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtOp1.Text);
            double b = Convert.ToDouble(txtOp2.Text);
            Maxer M = new Maxer();
            lblShow.Text = "最大值:" + M.Max(a, b);
        }

        private void btnThreeInt_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtOp1.Text);
            int b = Convert.ToInt32(txtOp2.Text);
            int c = Convert.ToInt32(txtOp3.Text);
            Maxer M = new Maxer();
            lblShow.Text = "最大值:" + M.Max(a, b, c);
        }
    }

    class Maxer
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        public double Max(double a, double b)
        {
            return a > b ? a : b;
        }
        public int Max(int a, int b, int c)
        {
            int max = a;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            return max;
        }
    }
}
