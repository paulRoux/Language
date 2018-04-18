using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Road
{
    public partial class Form1 : Form
    {

        Image img1 = Image.FromFile(@"D:\VSStudy\Road\green.jpg");   //绿灯
        Image img2 = Image.FromFile(@"D:\VSStudy\Road\red.jpg");   //红灯
        Image img3 = Image.FromFile(@"D:\VSStudy\Road\yellow.jpg");   //黄灯
        Image img4 = Image.FromFile(@"D:\VSStudy\Road\default.jpg");  //默认灯
        int i = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 0)
                i = 20;
            if (i > 13 && i <= 20)
            {
                pictureBox1.Image = img2;
                pictureBox3.Image = img2;
                pictureBox2.Image = img1;
                pictureBox4.Image = img1;

                int j = i - 10;
                int k = i - 13;

                label1.Text = j.ToString();          //绿灯
                label2.Text = k.ToString();          //红灯
                label3.Text = j.ToString();          //绿灯
                label4.Text = k.ToString();          //红灯

            }
            else if (i > 10 && i <= 13)
            {
                pictureBox1.Image = img2;
                pictureBox3.Image = img2;
                pictureBox2.Image = img3;
                pictureBox4.Image = img3;

                int j = i - 10;
                int k = j;

                label1.Text = j.ToString();          //绿灯
                label2.Text = k.ToString();          //黄灯
                label3.Text = j.ToString();          //绿灯
                label4.Text = k.ToString();          //黄灯
            }
            else if (i > 3 && i <= 10)
            {
                pictureBox1.Image = img1;
                pictureBox3.Image = img1;
                pictureBox2.Image = img2;
                pictureBox4.Image = img2;

                int j = i - 3;
                int k = i;

                label1.Text = j.ToString();          //绿灯
                label2.Text = k.ToString();          //红灯
                label3.Text = j.ToString();          //绿灯
                label4.Text = k.ToString();          //红灯
            }
            else
            {
                pictureBox1.Image = img3;
                pictureBox3.Image = img3;
                pictureBox2.Image = img2;
                pictureBox4.Image = img2;

                int j = i;
                int k = j;

                label1.Text = j.ToString();          //黄灯
                label2.Text = k.ToString();          //红灯
                label3.Text = j.ToString();          //黄灯
                label4.Text = k.ToString();          //红灯
            }
            i--;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                timer1.Enabled = true;
                button1.Text = "Stop";
            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "Start";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = img4;
            pictureBox3.Image = img4;
            pictureBox2.Image = img4;
            pictureBox4.Image = img4;
        }
    }
}
