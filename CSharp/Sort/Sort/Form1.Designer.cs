namespace Sort
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
            this.txtElement = new System.Windows.Forms.TextBox();
            this.txtPrior = new System.Windows.Forms.TextBox();
            this.txtSort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtElement
            // 
            this.txtElement.Location = new System.Drawing.Point(37, 101);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(129, 21);
            this.txtElement.TabIndex = 0;
            // 
            // txtPrior
            // 
            this.txtPrior.Location = new System.Drawing.Point(37, 189);
            this.txtPrior.Name = "txtPrior";
            this.txtPrior.ReadOnly = true;
            this.txtPrior.Size = new System.Drawing.Size(226, 21);
            this.txtPrior.TabIndex = 1;
            // 
            // txtSort
            // 
            this.txtSort.Location = new System.Drawing.Point(37, 274);
            this.txtSort.Name = "txtSort";
            this.txtSort.ReadOnly = true;
            this.txtSort.Size = new System.Drawing.Size(226, 21);
            this.txtSort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "数组空间为5，请依次输入5个数字：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "排序前数组序列：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "排序后数组序列：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(173, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(173, 230);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 8;
            this.btnSort.Text = "排序";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(35, 68);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(0, 12);
            this.lblNo.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 367);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSort);
            this.Controls.Add(this.txtPrior);
            this.Controls.Add(this.txtElement);
            this.Name = "Form1";
            this.Text = "NumSort";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.TextBox txtPrior;
        public System.Windows.Forms.TextBox txtSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblNo;
    }
}

