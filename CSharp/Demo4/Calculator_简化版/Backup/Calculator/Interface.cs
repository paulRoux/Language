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
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void button_Operation_Click(object sender, EventArgs e)
        {
            string strOperator;
            double dNumberA, dNumberB;
            double dResult = 0;

            try
            {
                dNumberA = Convert.ToDouble(textBox_NumberA.Text.Trim());
                dNumberB = Convert.ToDouble(textBox_NumberB.Text.Trim());
                strOperator = textBox_Operator.Text.Trim();

                switch (strOperator)
                {
                    case "+":
                        dResult = dNumberA + dNumberB;
                        break;
                    case "-":
                        dResult = dNumberA - dNumberB;
                        break;
                    case "*":
                        dResult = dNumberA * dNumberB;
                        break;
                    case "/":
                        if (dNumberB == 0)
                        {
                            MessageBox.Show("被除数不能为0！");
                            return;
                        }
                        dResult = dNumberA / dNumberB;
                        break;
                    default:
                        MessageBox.Show("运算符输入错误！");
                        return;
                }
                textBox_Result.Text = dResult.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox_Result.Text = "";
                throw;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_NumberA.Text = "";
            textBox_NumberB.Text = "";
            textBox_Operator.Text = "";
            textBox_Result.Text = "";
        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }
    }
}
