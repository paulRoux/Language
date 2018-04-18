using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RoadPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 60;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 0)
                i = 60;
            if (i > 30)  // 30秒红灯
            {
                pictureBox4.Image = this.imageList1.Images[3];
                pictureBox5.Image = pictureBox6.Image = this.imageList1.Images[4];
                this.label2.ForeColor = Color.Red;
                this.label2.Text = (100 + (i - 30)).ToString().Substring(1, 2);
                
                pictureBox10.Image = this.imageList1.Images[7];
                pictureBox11.Image = pictureBox12.Image = this.imageList1.Images[0];
                this.label4.ForeColor = Color.Red;
                this.label4.Text = (100 + (i - 30)).ToString().Substring(1, 2);

                

                if (i > 43)  // 17秒绿灯
                {
                    
                    pictureBox1.Image = this.imageList1.Images[0];
                    pictureBox2.Image = pictureBox3.Image = this.imageList1.Images[2];
                    this.label1.ForeColor = Color.Green;
                    this.label1.Text = (100 + (i - 30 - 13)).ToString().Substring(1, 2);

                    pictureBox7.Image = this.imageList1.Images[4];
                    pictureBox8.Image = pictureBox9.Image = this.imageList1.Images[9];
                    this.label3.ForeColor = Color.Green;
                    this.label3.Text = (100 + (i - 30 - 13)).ToString().Substring(1, 2);
                }  
                else
                {
                    if (i > 40)  //3秒黄灯
                    {
                        pictureBox1.Image = this.imageList1.Images[0];
                        pictureBox2.Image = pictureBox3.Image = this.imageList1.Images[1];
                        this.label1.ForeColor = Color.Yellow;
                        this.label1.Text = (100 + (i - 30 - 10)).ToString().Substring(1, 2);

                        pictureBox7.Image = this.imageList1.Images[4];
                        pictureBox8.Image = pictureBox9.Image = this.imageList1.Images[8];
                        this.label3.ForeColor = Color.Yellow;
                        this.label3.Text = (100 + (i - 30 - 10)).ToString().Substring(1, 2);
                    }
                    else if (i > 33)  //10秒红灯
                    {
                        pictureBox1.Image = this.imageList1.Images[11];
                        pictureBox2.Image = pictureBox3.Image = this.imageList1.Images[3];
                        this.label1.ForeColor = Color.Red;
                        this.label1.Text = (100 + (i - 30)).ToString().Substring(1, 2);

                        pictureBox7.Image = this.imageList1.Images[6];
                        pictureBox8.Image = pictureBox9.Image = this.imageList1.Images[7];
                        this.label3.ForeColor = Color.Red;
                        this.label3.Text = (100 + (i - 30)).ToString().Substring(1, 2);
                    }
                    else
                    {
                        pictureBox1.Image = this.imageList1.Images[10];
                        pictureBox2.Image = pictureBox3.Image = this.imageList1.Images[3];
                        this.label1.ForeColor = Color.Yellow;
                        this.label1.Text = (100 + (i - 30)).ToString().Substring(1, 2);

                        pictureBox7.Image = this.imageList1.Images[5];
                        pictureBox8.Image = pictureBox9.Image = this.imageList1.Images[7];
                        this.label3.ForeColor = Color.Yellow;
                        this.label3.Text = (100 + (i - 30)).ToString().Substring(1, 2);
                    }
                }
            }
            else
            {
                if (i > 0)  //30秒红灯
                {
                    pictureBox1.Image = this.imageList1.Images[0];
                    pictureBox2.Image = pictureBox3.Image = this.imageList1.Images[3];
                    this.label1.ForeColor = Color.Red;
                    this.label1.Text = (100 + i).ToString().Substring(1, 2);

                    pictureBox7.Image = this.imageList1.Images[4];
                    pictureBox8.Image = pictureBox9.Image = this.imageList1.Images[7];
                    this.label3.ForeColor = Color.Red;
                    this.label3.Text = (100 + i).ToString().Substring(1, 2);

                    if (i > 13)  //17秒绿灯
                    {
                        pictureBox4.Image = this.imageList1.Images[3];
                        pictureBox5.Image = pictureBox6.Image = this.imageList1.Images[6];
                        this.label2.ForeColor = Color.Green;
                        this.label2.Text = (100 + (i - 13)).ToString().Substring(1, 2);

                        pictureBox10.Image = this.imageList1.Images[7];
                        pictureBox11.Image = pictureBox12.Image = this.imageList1.Images[11];
                        this.label4.ForeColor = Color.Green;
                        this.label4.Text = (100 + (i - 13)).ToString().Substring(1, 2);
                    }
                    else
                    {
                        if (i > 10)  //3秒黄灯  转弯10秒绿灯
                        {
                            pictureBox4.Image = this.imageList1.Images[3];
                            pictureBox5.Image = pictureBox6.Image = this.imageList1.Images[5];
                            this.label2.ForeColor = Color.Yellow;
                            this.label2.Text = (100 + (i - 10)).ToString().Substring(1, 2);

                            pictureBox10.Image = this.imageList1.Images[7];
                            pictureBox11.Image = pictureBox12.Image = this.imageList1.Images[10];
                            this.label4.ForeColor = Color.Yellow;
                            this.label4.Text = (100 + (i - 10)).ToString().Substring(1, 2);
                        }
                        else if (i > 3)  //10秒红灯
                        {
                            pictureBox4.Image = this.imageList1.Images[2];
                            pictureBox5.Image = pictureBox6.Image = this.imageList1.Images[4];
                            this.label2.ForeColor = Color.Red;
                            this.label2.Text = (100 + i).ToString().Substring(1, 2);

                            pictureBox10.Image = this.imageList1.Images[9];
                            pictureBox11.Image = pictureBox12.Image = this.imageList1.Images[0];
                            this.label4.ForeColor = Color.Red;
                            this.label4.Text = (100 + i).ToString().Substring(1, 2);
                        }
                        else  //转弯3秒黄灯
                        {
                            pictureBox4.Image = this.imageList1.Images[1];
                            pictureBox5.Image = pictureBox6.Image = this.imageList1.Images[4];
                            this.label2.ForeColor = Color.Yellow;
                            this.label2.Text = (100 + i).ToString().Substring(1, 2);

                            pictureBox10.Image = this.imageList1.Images[8];
                            pictureBox11.Image = pictureBox12.Image = this.imageList1.Images[0];
                            this.label4.ForeColor = Color.Yellow;
                            this.label4.Text = (100 + i).ToString().Substring(1, 2);
                        }
                    }
                }
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
                button1.Text = "Strat";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
