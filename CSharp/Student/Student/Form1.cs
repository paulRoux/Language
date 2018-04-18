using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region baseclass
        public abstract class Student
        {
            protected string name;
            protected int age;
            public static int number;
            public Student(string name, int age)
            {
                this.name = name;
                this.age = age;
                number++;
            }
            public string Name { get { return name; } }
            public abstract double Average();
        }
        #endregion

        #region little
        public class Little : Student
        {
            protected double chinese;
            protected double math;
            public Little(string name, int age, double chinese, double math)
                : base(name, age)
            {
                this.chinese = chinese;
                this.math = math;
            }
            public override double Average()
            {
                return (chinese + math) / 2;
            }
        }
        #endregion

        #region mid
        public class Mid : Student
        {
            protected double chinese;
            protected double math;
            protected double english;
            public Mid(string name, int age, double chinese, double math, double english)
                : base(name, age)
            {
                this.chinese = chinese;
                this.math = math;
                this.english = english;
            }
            public override double Average()
            {
                return (chinese + math + english) / 3;
            }
        }
        #endregion

        #region big
        public class Big : Student
        {
            protected double chinese;
            protected double math;
            protected double english;
            public Big(string name, int age, double chinese, double math, double english)
                : base(name, age)
            {
                this.chinese = chinese;
                this.math = math;
                this.english = english;
            }
            public override double Average()
            {
                return (chinese + math + english) / 3;
            }
        }
        #endregion

        #region little_click
        private void little_Click(object sender, EventArgs e)
        {
            string Name = Convert.ToString(name.Text);
            int Age = Convert.ToInt32(age.Text);
            double Chinese = Convert.ToDouble(chinese.Text);
            double Math = Convert.ToDouble(math.Text);

            Little stu = new Little(Name, Age, Chinese, Math);

            result.Text += "总人数：" + Student.number + "姓名：" + stu.Name + "，小学生，平均成绩为：" + stu.Average()+"\r\n";

        }
        #endregion

        #region mid_click
        private void mid_Click(object sender, EventArgs e)
        {
            string Name = Convert.ToString(name.Text);
            int Age = Convert.ToInt32(age.Text);
            double Chinese = Convert.ToDouble(chinese.Text);
            double Math = Convert.ToDouble(math.Text);
            double English = Convert.ToDouble(english.Text);

            Mid stu = new Mid(Name, Age, Chinese, Math, English);

            result.Text += "\n" + "总人数：" + Student.number + "姓名：" + stu.Name + "，中学生，平均成绩为：" + stu.Average() + "\r\n";
        }
        #endregion

        #region big_click
        private void big_Click(object sender, EventArgs e)
        {
            string Name = Convert.ToString(name.Text);
            int Age = Convert.ToInt32(age.Text);
            double Chinese = Convert.ToDouble(chinese.Text);
            double Math = Convert.ToDouble(math.Text);
            double English = Convert.ToDouble(english.Text);

            Big stu = new Big(Name, Age, Chinese, Math, English);

            result.Text += "\n" + "总人数：" + Student.number + "姓名：" + stu.Name + "，中学生，平均成绩为：" + stu.Average() + "\r\n";
        }
        #endregion
    }
}
