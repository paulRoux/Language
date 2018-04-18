using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] a = new double[5];
        int i = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double element = double.Parse(txtElement.Text);
            a[i] = element;
            txtPrior.Text += a[i] + " ";
            i++;
            lblNo.Text = "请输入第" + (i + 1) + "个元素";
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Array.Sort(a);
            txtSort.Text = a[0] + " " + a[1] + " " + a[2] + " " + a[3] + " " + a[4];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNo.Text = "请输入第" + (i + 1) + "个元素";
        }
    }
}
