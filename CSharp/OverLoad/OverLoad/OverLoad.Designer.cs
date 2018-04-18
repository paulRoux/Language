namespace OverLoad
{
    partial class OverLoad
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.txtOp1 = new System.Windows.Forms.TextBox();
            this.txtOp2 = new System.Windows.Forms.TextBox();
            this.txtOp3 = new System.Windows.Forms.TextBox();
            this.btnTwoInt = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnThreeInt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "数据3:";
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(33, 280);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(23, 12);
            this.lblShow.TabIndex = 3;
            this.lblShow.Text = "\" \"";
            // 
            // txtOp1
            // 
            this.txtOp1.Location = new System.Drawing.Point(81, 102);
            this.txtOp1.Name = "txtOp1";
            this.txtOp1.Size = new System.Drawing.Size(100, 21);
            this.txtOp1.TabIndex = 4;
            // 
            // txtOp2
            // 
            this.txtOp2.Location = new System.Drawing.Point(268, 102);
            this.txtOp2.Name = "txtOp2";
            this.txtOp2.Size = new System.Drawing.Size(100, 21);
            this.txtOp2.TabIndex = 5;
            // 
            // txtOp3
            // 
            this.txtOp3.Location = new System.Drawing.Point(462, 102);
            this.txtOp3.Name = "txtOp3";
            this.txtOp3.Size = new System.Drawing.Size(100, 21);
            this.txtOp3.TabIndex = 6;
            // btnTwoInt
            // 
            this.btnTwoInt.Location = new System.Drawing.Point(44, 182);
            this.btnTwoInt.Name = "btnTwoInt";
            this.btnTwoInt.Size = new System.Drawing.Size(75, 23);
            this.btnTwoInt.TabIndex = 7;
            this.btnTwoInt.Text = "两个整数";
            this.btnTwoInt.UseVisualStyleBackColor = true;
            this.btnTwoInt.Click += new System.EventHandler(this.btnTwoInt_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(223, 182);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(75, 23);
            this.btnDouble.TabIndex = 8;
            this.btnDouble.Text = "两个浮点数";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnThreeInt
            // 
            this.btnThreeInt.Location = new System.Drawing.Point(432, 182);
            this.btnThreeInt.Name = "btnThreeInt";
            this.btnThreeInt.Size = new System.Drawing.Size(75, 23);
            this.btnThreeInt.TabIndex = 9;
            this.btnThreeInt.Text = "三个整数";
            this.btnThreeInt.UseVisualStyleBackColor = true;
            this.btnThreeInt.Click += new System.EventHandler(this.btnThreeInt_Click);
            // 
            // OverLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 493);
            this.Controls.Add(this.btnThreeInt);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnTwoInt);
            this.Controls.Add(this.txtOp3);
            this.Controls.Add(this.txtOp2);
            this.Controls.Add(this.txtOp1);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OverLoad";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.TextBox txtOp1;
        private System.Windows.Forms.TextBox txtOp2;
        private System.Windows.Forms.TextBox txtOp3;
        private System.Windows.Forms.Button btnTwoInt;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnThreeInt;
    }
}

