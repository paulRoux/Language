namespace GZGL
{
    partial class AddDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDepartment));
            this.label1 = new System.Windows.Forms.Label();
            this.AddId = new System.Windows.Forms.TextBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddMana = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddTel = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号：";
            // 
            // AddId
            // 
            this.AddId.Location = new System.Drawing.Point(177, 98);
            this.AddId.Name = "AddId";
            this.AddId.Size = new System.Drawing.Size(121, 21);
            this.AddId.TabIndex = 0;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(95, 288);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "确定(&Y)";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "经理：";
            // 
            // AddMana
            // 
            this.AddMana.Location = new System.Drawing.Point(177, 140);
            this.AddMana.Name = "AddMana";
            this.AddMana.Size = new System.Drawing.Size(121, 21);
            this.AddMana.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "名称：";
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(177, 186);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(121, 21);
            this.AddName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "电话：";
            // 
            // AddTel
            // 
            this.AddTel.Location = new System.Drawing.Point(177, 235);
            this.AddTel.Name = "AddTel";
            this.AddTel.Size = new System.Drawing.Size(121, 21);
            this.AddTel.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(253, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(115, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "工资管理系统";
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 361);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.AddTel);
            this.Controls.Add(this.AddName);
            this.Controls.Add(this.AddMana);
            this.Controls.Add(this.AddId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "AddDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加部门";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddId;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddMana;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddTel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
    }
}