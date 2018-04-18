namespace Student
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.little = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.mid = new System.Windows.Forms.Button();
            this.big = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chinese = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.math = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.english = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // little
            // 
            this.little.Location = new System.Drawing.Point(612, 92);
            this.little.Name = "little";
            this.little.Size = new System.Drawing.Size(75, 23);
            this.little.TabIndex = 1;
            this.little.Text = "小学生";
            this.little.UseVisualStyleBackColor = true;
            this.little.Click += new System.EventHandler(this.little_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(178, 94);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 21);
            this.name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "年龄：";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(178, 142);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 21);
            this.age.TabIndex = 2;
            // 
            // mid
            // 
            this.mid.Location = new System.Drawing.Point(612, 139);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(75, 23);
            this.mid.TabIndex = 1;
            this.mid.Text = "中学生";
            this.mid.UseVisualStyleBackColor = true;
            this.mid.Click += new System.EventHandler(this.mid_Click);
            // 
            // big
            // 
            this.big.Location = new System.Drawing.Point(612, 187);
            this.big.Name = "big";
            this.big.Size = new System.Drawing.Size(75, 23);
            this.big.TabIndex = 1;
            this.big.Text = "大学生";
            this.big.UseVisualStyleBackColor = true;
            this.big.Click += new System.EventHandler(this.big_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "语文/必修课：";
            // 
            // chinese
            // 
            this.chinese.Location = new System.Drawing.Point(435, 94);
            this.chinese.Name = "chinese";
            this.chinese.Size = new System.Drawing.Size(100, 21);
            this.chinese.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "数学/选修课：";
            // 
            // math
            // 
            this.math.Location = new System.Drawing.Point(435, 141);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(100, 21);
            this.math.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "英语：";
            // 
            // english
            // 
            this.english.Location = new System.Drawing.Point(435, 189);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(100, 21);
            this.english.TabIndex = 2;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(103, 263);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(584, 180);
            this.result.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 636);
            this.Controls.Add(this.result);
            this.Controls.Add(this.english);
            this.Controls.Add(this.math);
            this.Controls.Add(this.chinese);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.big);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.little);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button little;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Button mid;
        private System.Windows.Forms.Button big;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox chinese;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox math;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox english;
        private System.Windows.Forms.TextBox result;
    }
}

