namespace Calculator
{
    partial class Interface
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NumberA = new System.Windows.Forms.TextBox();
            this.textBox_NumberB = new System.Windows.Forms.TextBox();
            this.textBox_Operator = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Operation = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_Input = new System.Windows.Forms.GroupBox();
            this.groupBox_Output = new System.Windows.Forms.GroupBox();
            this.groupBox_Input.SuspendLayout();
            this.groupBox_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数字A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数字B:";
            // 
            // textBox_NumberA
            // 
            this.textBox_NumberA.Location = new System.Drawing.Point(70, 20);
            this.textBox_NumberA.Name = "textBox_NumberA";
            this.textBox_NumberA.Size = new System.Drawing.Size(100, 21);
            this.textBox_NumberA.TabIndex = 0;
            // 
            // textBox_NumberB
            // 
            this.textBox_NumberB.Location = new System.Drawing.Point(70, 74);
            this.textBox_NumberB.Name = "textBox_NumberB";
            this.textBox_NumberB.Size = new System.Drawing.Size(100, 21);
            this.textBox_NumberB.TabIndex = 2;
            // 
            // textBox_Operator
            // 
            this.textBox_Operator.Location = new System.Drawing.Point(70, 47);
            this.textBox_Operator.Name = "textBox_Operator";
            this.textBox_Operator.Size = new System.Drawing.Size(100, 21);
            this.textBox_Operator.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "运算符:";
            // 
            // button_Operation
            // 
            this.button_Operation.Location = new System.Drawing.Point(12, 126);
            this.button_Operation.Name = "button_Operation";
            this.button_Operation.Size = new System.Drawing.Size(75, 23);
            this.button_Operation.TabIndex = 1;
            this.button_Operation.Text = "运算";
            this.button_Operation.UseVisualStyleBackColor = true;
            this.button_Operation.Click += new System.EventHandler(this.button_Operation_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(113, 126);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 2;
            this.button_Clear.Text = "清除";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(70, 20);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.Size = new System.Drawing.Size(100, 21);
            this.textBox_Result.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "运算结果:";
            // 
            // groupBox_Input
            // 
            this.groupBox_Input.Controls.Add(this.textBox_NumberA);
            this.groupBox_Input.Controls.Add(this.label1);
            this.groupBox_Input.Controls.Add(this.label2);
            this.groupBox_Input.Controls.Add(this.textBox_NumberB);
            this.groupBox_Input.Controls.Add(this.textBox_Operator);
            this.groupBox_Input.Controls.Add(this.label3);
            this.groupBox_Input.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Input.Name = "groupBox_Input";
            this.groupBox_Input.Size = new System.Drawing.Size(176, 106);
            this.groupBox_Input.TabIndex = 0;
            this.groupBox_Input.TabStop = false;
            this.groupBox_Input.Text = "输入区域";
            // 
            // groupBox_Output
            // 
            this.groupBox_Output.Controls.Add(this.textBox_Result);
            this.groupBox_Output.Controls.Add(this.label4);
            this.groupBox_Output.Location = new System.Drawing.Point(12, 165);
            this.groupBox_Output.Name = "groupBox_Output";
            this.groupBox_Output.Size = new System.Drawing.Size(176, 54);
            this.groupBox_Output.TabIndex = 3;
            this.groupBox_Output.TabStop = false;
            this.groupBox_Output.Text = "输出区域";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 231);
            this.Controls.Add(this.groupBox_Output);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Operation);
            this.Controls.Add(this.groupBox_Input);
            this.Name = "Interface";
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.groupBox_Input.ResumeLayout(false);
            this.groupBox_Input.PerformLayout();
            this.groupBox_Output.ResumeLayout(false);
            this.groupBox_Output.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NumberA;
        private System.Windows.Forms.TextBox textBox_NumberB;
        private System.Windows.Forms.TextBox textBox_Operator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Operation;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox_Input;
        private System.Windows.Forms.GroupBox groupBox_Output;
    }
}

