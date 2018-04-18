using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*int money = Convert.ToInt32(txtMoney.Text);
            int year = Convert.ToInt32(txtYear.Text);
            double rate = Convert.ToDouble(txtRate.Text) / 100;
            double interest = money * rate * year;
            txtInterest.Text = interest.ToString();
            double total = money + interest;
            txtTotal.Text = total.ToString();*/
        }

        private void button_Click(object sender, EventArgs e)
        {
            int money = Convert.ToInt32(txtMoney.Text);
            int year = Convert.ToInt32(txtYear.Text);
            double rate = Convert.ToDouble(txtRate.Text) / 100;
            double interest = money * rate * year;
            txtInterest.Text = interest.ToString();
            double total = money + interest;
            txtTotal.Text = total.ToString();
        }
    }
}
