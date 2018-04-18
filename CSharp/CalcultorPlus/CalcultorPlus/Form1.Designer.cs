namespace CalcultorPlus
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
            this.btnCalculator = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Label();
            this.Operator = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtopera = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(147, 209);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(75, 23);
            this.btnCalculator.TabIndex = 0;
            this.btnCalculator.Text = "计算";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(269, 209);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "取消";
            this.back.UseVisualStyleBackColor = true;
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(145, 68);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(41, 12);
            this.num1.TabIndex = 2;
            this.num1.Text = "数字a:";
            // 
            // Operator
            // 
            this.Operator.AutoSize = true;
            this.Operator.Location = new System.Drawing.Point(145, 112);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(47, 12);
            this.Operator.TabIndex = 3;
            this.Operator.Text = "运算符:";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(145, 160);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(41, 12);
            this.num2.TabIndex = 4;
            this.num2.Text = "数字b:";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(145, 281);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(35, 12);
            this.result.TabIndex = 5;
            this.result.Text = "结果:";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(221, 65);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(123, 21);
            this.txtNum1.TabIndex = 6;
            // 
            // txtopera
            // 
            this.txtopera.Location = new System.Drawing.Point(220, 109);
            this.txtopera.Name = "txtopera";
            this.txtopera.Size = new System.Drawing.Size(123, 21);
            this.txtopera.TabIndex = 7;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(221, 157);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(123, 21);
            this.txtNum2.TabIndex = 8;
            // 
            // lblShow
            // 
            this.lblShow.Location = new System.Drawing.Point(221, 278);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(123, 21);
            this.lblShow.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 466);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtopera);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.Operator);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.btnCalculator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label Operator;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtopera;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox lblShow;
    }
}

