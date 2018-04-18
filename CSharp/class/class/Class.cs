using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace @class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Book book1;
            book1 = new Book();
            Book book2 = new Book();
            book1.title = "九阳神功！";
            book1.price = 999999;
            string strMsg = book1.GetMessage();
            lblShow.Text = strMsg;
            book2.title = "葵花宝典！";
            book2.price = 999999;
            lblShow.Text += "\n\n" + book2.GetMessage();
        }
    }
    public class Book
    {
        public string title;
        public double price;
        public string GetMessage()
        {
            return string.Format("书名：{0}, 价格：{1}元。", this.title, this.price);
        }
    }
}
