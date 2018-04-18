namespace XSGL
{
    partial class TeacherFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.teaTitle = new System.Windows.Forms.TextBox();
            this.teaPwd = new System.Windows.Forms.TextBox();
            this.teaName = new System.Windows.Forms.TextBox();
            this.teaId = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teaUpdate = new System.Windows.Forms.Button();
            this.teaDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Location = new System.Drawing.Point(113, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 40);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(65, 16);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(35, 16);
            this.rdoFemale.TabIndex = 4;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(6, 16);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(35, 16);
            this.rdoMale.TabIndex = 3;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // teaTitle
            // 
            this.teaTitle.Location = new System.Drawing.Point(320, 84);
            this.teaTitle.Name = "teaTitle";
            this.teaTitle.Size = new System.Drawing.Size(121, 21);
            this.teaTitle.TabIndex = 5;
            // 
            // teaPwd
            // 
            this.teaPwd.Location = new System.Drawing.Point(320, 132);
            this.teaPwd.Name = "teaPwd";
            this.teaPwd.Size = new System.Drawing.Size(121, 21);
            this.teaPwd.TabIndex = 6;
            // 
            // teaName
            // 
            this.teaName.Location = new System.Drawing.Point(113, 134);
            this.teaName.Name = "teaName";
            this.teaName.Size = new System.Drawing.Size(100, 21);
            this.teaName.TabIndex = 2;
            // 
            // teaId
            // 
            this.teaId.Location = new System.Drawing.Point(113, 84);
            this.teaId.Name = "teaId";
            this.teaId.Size = new System.Drawing.Size(100, 21);
            this.teaId.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNext.Location = new System.Drawing.Point(157, 249);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "下一个(&N)";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(61, 249);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "上一个(&P)";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "密码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "职称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "性别:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "姓名:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "教工号:";
            // 
            // teaUpdate
            // 
            this.teaUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.teaUpdate.Location = new System.Drawing.Point(258, 249);
            this.teaUpdate.Name = "teaUpdate";
            this.teaUpdate.Size = new System.Drawing.Size(75, 23);
            this.teaUpdate.TabIndex = 10;
            this.teaUpdate.Text = "更新(&E)";
            this.teaUpdate.UseVisualStyleBackColor = true;
            this.teaUpdate.Click += new System.EventHandler(this.teaUpdate_Click);
            // 
            // teaDelete
            // 
            this.teaDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.teaDelete.Location = new System.Drawing.Point(354, 249);
            this.teaDelete.Name = "teaDelete";
            this.teaDelete.Size = new System.Drawing.Size(75, 23);
            this.teaDelete.TabIndex = 11;
            this.teaDelete.Text = "删除(&D)";
            this.teaDelete.UseVisualStyleBackColor = true;
            this.teaDelete.Click += new System.EventHandler(this.teaDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "课程：";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(320, 185);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(121, 21);
            this.txtCourse.TabIndex = 7;
            // 
            // TeacherFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.teaTitle);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.teaPwd);
            this.Controls.Add(this.teaName);
            this.Controls.Add(this.teaId);
            this.Controls.Add(this.teaDelete);
            this.Controls.Add(this.teaUpdate);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TeacherFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox teaTitle;
        private System.Windows.Forms.TextBox teaPwd;
        private System.Windows.Forms.TextBox teaName;
        private System.Windows.Forms.TextBox teaId;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button teaUpdate;
        private System.Windows.Forms.Button teaDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCourse;
    }
}