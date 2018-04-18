using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GZGL
{
    public partial class HelpText : Form
    {
        public HelpText()
        {
            InitializeComponent();
        }

        private void HelpText_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\VSStudy\CSharp\GZGL\帮助文档.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadToEnd();
            this.richTextBox1.Text = str;
            sr.Close();
            fs.Close();
        }
    }
}
