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

            try
            {
                strOperator = textBox_Operator.Text.Trim();

                //if (strOperator != "+" && strOperator != "-" && strOperator != "*" && strOperator != "/")
                //   throw new Exception("操作符输入错误");

                Operation Opr = OperationFactory.CreateOperation(strOperator);

                Opr.NumberA = Convert.ToDouble(textBox_NumberA.Text.Trim());
                Opr.NumberB = Convert.ToDouble(textBox_NumberB.Text.Trim());

                textBox_Result.Text = Opr.GetResult().ToString();
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox_Result.Text = "";
                throw;
            }
            //finally
            //{
            //    MessageBox.Show("欢迎！");
            //}
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
