namespace DefineClass
{
    partial class DefineClass
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
            this.lblShow = new System.Windows.Forms.Label();
            this.btnClaculate = new System.Windows.Forms.Button();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "半径：";
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(83, 151);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(17, 12);
            this.lblShow.TabIndex = 1;
            this.lblShow.Text = "\"\"";
            // 
            // btnClaculate
            // 
            this.btnClaculate.Location = new System.Drawing.Point(265, 99);
            this.btnClaculate.Name = "btnClaculate";
            this.btnClaculate.Size = new System.Drawing.Size(75, 23);
            this.btnClaculate.TabIndex = 2;
            this.btnClaculate.Text = "计算";
            this.btnClaculate.UseVisualStyleBackColor = true;
            this.btnClaculate.Click += new System.EventHandler(this.btnClaculate_Click);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(143, 101);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 21);
            this.txtRadius.TabIndex = 3;
            // 
            // DefineClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 349);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.btnClaculate);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.label1);
            this.Name = "DefineClass";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DefineClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnClaculate;
        private System.Windows.Forms.TextBox txtRadius;
    }
}

