using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reverse
{
    public partial class Reverse : Form
    {
        public Reverse()
        {
            InitializeComponent();
        }

        private void bntReverse_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtOriginal.Text);
            int turnNum = 0;
            while (num > 0)
            {
                turnNum = turnNum * 10 + num % 10;
                num = num / 10;
            }
            turnTurn.Text = turnNum.ToString();
        }
    }
}
