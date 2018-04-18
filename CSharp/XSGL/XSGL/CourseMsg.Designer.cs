namespace XSGL
{
    partial class CourseMsg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nudCredit = new System.Windows.Forms.NumericUpDown();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudExp = new System.Windows.Forms.NumericUpDown();
            this.nudPrelection = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.rdoElective = new System.Windows.Forms.RadioButton();
            this.rdoRequired = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnYes = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredit)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrelection)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 383);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nudCredit);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label0);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(380, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "课程信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nudCredit
            // 
            this.nudCredit.Location = new System.Drawing.Point(87, 181);
            this.nudCredit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCredit.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCredit.Name = "nudCredit";
            this.nudCredit.Size = new System.Drawing.Size(128, 21);
            this.nudCredit.TabIndex = 4;
            this.nudCredit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(140, 313);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "下一步(&N)";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudExp);
            this.groupBox2.Controls.Add(this.nudPrelection);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(33, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 69);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学时分配";
            // 
            // nudExp
            // 
            this.nudExp.Location = new System.Drawing.Point(203, 30);
            this.nudExp.Name = "nudExp";
            this.nudExp.Size = new System.Drawing.Size(78, 21);
            this.nudExp.TabIndex = 6;
            // 
            // nudPrelection
            // 
            this.nudPrelection.Location = new System.Drawing.Point(63, 30);
            this.nudPrelection.Name = "nudPrelection";
            this.nudPrelection.Size = new System.Drawing.Size(63, 21);
            this.nudPrelection.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "实验学时：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "理论学时：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "学分：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 21);
            this.txtName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboClass);
            this.groupBox1.Controls.Add(this.rdoElective);
            this.groupBox1.Controls.Add(this.rdoRequired);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "类别";
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Items.AddRange(new object[] {
            "专业",
            "非专业"});
            this.cboClass.Location = new System.Drawing.Point(61, 33);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(121, 20);
            this.cboClass.TabIndex = 1;
            // 
            // rdoElective
            // 
            this.rdoElective.AutoSize = true;
            this.rdoElective.Location = new System.Drawing.Point(245, 37);
            this.rdoElective.Name = "rdoElective";
            this.rdoElective.Size = new System.Drawing.Size(47, 16);
            this.rdoElective.TabIndex = 3;
            this.rdoElective.Text = "选修";
            this.rdoElective.UseVisualStyleBackColor = true;
            // 
            // rdoRequired
            // 
            this.rdoRequired.AutoSize = true;
            this.rdoRequired.Checked = true;
            this.rdoRequired.Location = new System.Drawing.Point(192, 37);
            this.rdoRequired.Name = "rdoRequired";
            this.rdoRequired.Size = new System.Drawing.Size(47, 16);
            this.rdoRequired.TabIndex = 2;
            this.rdoRequired.TabStop = true;
            this.rdoRequired.Text = "必修";
            this.rdoRequired.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程类别：";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(31, 34);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(65, 12);
            this.label0.TabIndex = 0;
            this.label0.Text = "课程名称：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnYes);
            this.tabPage2.Controls.Add(this.txtInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(380, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "确认信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(141, 313);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "确认(&Y)";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(18, 21);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(342, 286);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "";
            // 
            // CourseMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 407);
            this.Controls.Add(this.tabControl1);
            this.Name = "CourseMsg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加课程";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrelection)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown nudCredit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudExp;
        private System.Windows.Forms.NumericUpDown nudPrelection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.RadioButton rdoElective;
        private System.Windows.Forms.RadioButton rdoRequired;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.RichTextBox txtInfo;
    }
}