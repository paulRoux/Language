using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtBox1.Text);
            double b = Convert.ToDouble(txtBox2.Text);
            lblShow.Text = "a+b的和为:";
            lblShow.Text += a + b;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtBox1.Text);
            double b = Convert.ToDouble(txtBox2.Text);
            lblShow.Text = "a减b的差为:";
            lblShow.Text += a - b;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtBox1.Text);
            double b = Convert.ToDouble(txtBox2.Text);
            lblShow.Text = "a乘b的积为:";
            lblShow.Text += a * b;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtBox1.Text);
            double b = Convert.ToDouble(txtBox2.Text);
            lblShow.Text = "a除b的商为:";
            lblShow.Text += a / b;
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtBox1.Text);
            double b = Convert.ToDouble(txtBox2.Text);
            lblShow.Text = a + "的" + b + "次方:";
            lblShow.Text += Math.Pow(a, b);
        }
    }
}
