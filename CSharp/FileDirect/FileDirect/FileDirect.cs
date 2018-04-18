using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileDirect
{
    public partial class FileDirect : Form
    {
        public FileDirect()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Analyzer a = new Analyzer();
            string path = txtPath.Text;
            string dir, file;
            a.SplitPath(path, out dir, out file);
            txtDir.Text = dir;
            txtFilename.Text = file;
        }
    }

    class Analyzer
    {
        public void SplitPath(string path, out string dir, out string filename)
        {
            int i;
            i = path.LastIndexOf('\\');
            dir = path.Substring(0, i);
            filename = path.Substring(i + 1);
        }
    }
}
