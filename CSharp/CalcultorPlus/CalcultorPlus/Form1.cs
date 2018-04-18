using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalcultorPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNum1.Text);
            double b = Convert.ToDouble(txtNum2.Text);
            double result = 0;

            switch (txtopera.Text)
            { 
                case "+": result = a + b;
                    break;
                case "-": result = a - b;
                    break;
                case "*": result = a * b;
                    break;
                case "/": result = a / b;
                    break;
                case "%": result = a % b;
                    break;
                case "^": result = Math.Pow(a, b);
                    break;
                default :
                    MessageBox.Show("请输入一个有效的运算符\n注意：%表示取余,^表示求幂!");
                    break;
            }
            lblShow.Text = result.ToString();
        }
    }
}
