namespace GZGL
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UserType = new System.Windows.Forms.ComboBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserType
            // 
            this.UserType.FormattingEnabled = true;
            this.UserType.Items.AddRange(new object[] {
            "员工",
            "经理",
            "总裁"});
            this.UserType.Location = new System.Drawing.Point(209, 268);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(143, 20);
            this.UserType.TabIndex = 2;
            this.UserType.Text = "员工";
            // 
            // btnSign
            // 
            this.btnSign.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSign.Location = new System.Drawing.Point(259, 323);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(75, 23);
            this.btnSign.TabIndex = 4;
            this.btnSign.Text = "注册(&S)";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(141, 323);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 3;
            this.btnYes.Text = "登陆(&Y)";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(209, 220);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(143, 21);
            this.txtPwd.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(209, 173);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 21);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "用户类型：";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(129, 223);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(41, 12);
            this.lblPwd.TabIndex = 8;
            this.lblPwd.Text = "密 码:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(129, 176);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "用户名：";
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMain.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMain.Location = new System.Drawing.Point(152, 96);
            this.lblMain.Name = "lblMain";
            this.lblMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMain.Size = new System.Drawing.Size(180, 27);
            this.lblMain.TabIndex = 6;
            this.lblMain.Text = "工资管理系统";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Login
            // 
            this.AcceptButton = this.btnYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnSign;
            this.ClientSize = new System.Drawing.Size(480, 443);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMain);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UserType;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMain;
    }
}