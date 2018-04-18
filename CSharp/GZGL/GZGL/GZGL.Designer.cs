namespace GZGL
{
    partial class GZGL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GZGL));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Tsllabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UserManager = new System.Windows.Forms.ToolStripMenuItem();
            this.UserLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.UserSignin = new System.Windows.Forms.ToolStripMenuItem();
            this.userUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.UserCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.PeoIfoManager = new System.Windows.Forms.ToolStripMenuItem();
            this.PeoIfoSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.PeoIfoAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.PeoIfoUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.SlaIfoManager = new System.Windows.Forms.ToolStripMenuItem();
            this.SlaIfoSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.SlaIfoUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbLogin = new System.Windows.Forms.ToolStripButton();
            this.TsbSignin = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.TsbCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbIfoSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.TsbIfoUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbSlaSearch = new System.Windows.Forms.ToolStripButton();
            this.TsbSlaUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbAbout = new System.Windows.Forms.ToolStripButton();
            this.TsbHelpText = new System.Windows.Forms.ToolStripButton();
            this.tsbAddSsalary = new System.Windows.Forms.ToolStripMenuItem();
            this.部门管理DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAddDepart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsllabel,
            this.TssMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(623, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Tsllabel
            // 
            this.Tsllabel.Image = ((System.Drawing.Image)(resources.GetObject("Tsllabel.Image")));
            this.Tsllabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tsllabel.Name = "Tsllabel";
            this.Tsllabel.Size = new System.Drawing.Size(48, 17);
            this.Tsllabel.Text = "就绪";
            this.Tsllabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TssMsg
            // 
            this.TssMsg.Name = "TssMsg";
            this.TssMsg.Size = new System.Drawing.Size(560, 17);
            this.TssMsg.Spring = true;
            this.TssMsg.Text = "请选择一个操作！";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserManager,
            this.部门管理DToolStripMenuItem,
            this.PeoIfoManager,
            this.SlaIfoManager,
            this.Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UserManager
            // 
            this.UserManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserLogin,
            this.UserSignin,
            this.userUpdate,
            this.UserCancel});
            this.UserManager.Name = "UserManager";
            this.UserManager.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.UserManager.Size = new System.Drawing.Size(85, 21);
            this.UserManager.Text = "用户管理(&U)";
            // 
            // UserLogin
            // 
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.UserLogin.Size = new System.Drawing.Size(203, 22);
            this.UserLogin.Text = "用户登录";
            this.UserLogin.Click += new System.EventHandler(this.UserLogin_Click);
            // 
            // UserSignin
            // 
            this.UserSignin.Name = "UserSignin";
            this.UserSignin.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.UserSignin.Size = new System.Drawing.Size(203, 22);
            this.UserSignin.Text = "用户注册";
            this.UserSignin.Click += new System.EventHandler(this.UserSignin_Click);
            // 
            // userUpdate
            // 
            this.userUpdate.Name = "userUpdate";
            this.userUpdate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.U)));
            this.userUpdate.Size = new System.Drawing.Size(203, 22);
            this.userUpdate.Text = "密码修改";
            this.userUpdate.Click += new System.EventHandler(this.userUpdate_Click);
            // 
            // UserCancel
            // 
            this.UserCancel.Name = "UserCancel";
            this.UserCancel.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.UserCancel.Size = new System.Drawing.Size(203, 22);
            this.UserCancel.Text = "用户退出";
            this.UserCancel.Click += new System.EventHandler(this.UserCancel_Click);
            // 
            // PeoIfoManager
            // 
            this.PeoIfoManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PeoIfoSearch,
            this.PeoIfoAdd,
            this.PeoIfoUpdate});
            this.PeoIfoManager.Name = "PeoIfoManager";
            this.PeoIfoManager.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.PeoIfoManager.Size = new System.Drawing.Size(83, 21);
            this.PeoIfoManager.Text = "人事管理(&E)";
            // 
            // PeoIfoSearch
            // 
            this.PeoIfoSearch.Name = "PeoIfoSearch";
            this.PeoIfoSearch.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.PeoIfoSearch.Size = new System.Drawing.Size(204, 22);
            this.PeoIfoSearch.Text = "信息查询";
            this.PeoIfoSearch.Click += new System.EventHandler(this.PeoIfoSearch_Click);
            // 
            // PeoIfoAdd
            // 
            this.PeoIfoAdd.Name = "PeoIfoAdd";
            this.PeoIfoAdd.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.PeoIfoAdd.Size = new System.Drawing.Size(204, 22);
            this.PeoIfoAdd.Text = "员工添加";
            this.PeoIfoAdd.Click += new System.EventHandler(this.PeoIfoAdd_Click);
            // 
            // PeoIfoUpdate
            // 
            this.PeoIfoUpdate.Name = "PeoIfoUpdate";
            this.PeoIfoUpdate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
            this.PeoIfoUpdate.Size = new System.Drawing.Size(204, 22);
            this.PeoIfoUpdate.Text = "信息修改";
            this.PeoIfoUpdate.Click += new System.EventHandler(this.PeoIfoUpdate_Click);
            // 
            // SlaIfoManager
            // 
            this.SlaIfoManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SlaIfoSearch,
            this.tsbAddSsalary,
            this.SlaIfoUpdate});
            this.SlaIfoManager.Name = "SlaIfoManager";
            this.SlaIfoManager.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SlaIfoManager.Size = new System.Drawing.Size(83, 21);
            this.SlaIfoManager.Text = "工资管理(&S)";
            // 
            // SlaIfoSearch
            // 
            this.SlaIfoSearch.Name = "SlaIfoSearch";
            this.SlaIfoSearch.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.SlaIfoSearch.Size = new System.Drawing.Size(194, 22);
            this.SlaIfoSearch.Text = "工资查询";
            this.SlaIfoSearch.Click += new System.EventHandler(this.SlaIfoSearch_Click);
            // 
            // SlaIfoUpdate
            // 
            this.SlaIfoUpdate.Name = "SlaIfoUpdate";
            this.SlaIfoUpdate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.U)));
            this.SlaIfoUpdate.Size = new System.Drawing.Size(194, 22);
            this.SlaIfoUpdate.Text = "工资修改";
            this.SlaIfoUpdate.Click += new System.EventHandler(this.SlaIfoUpdate_Click);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About,
            this.HelpText});
            this.Help.Name = "Help";
            this.Help.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.Help.Size = new System.Drawing.Size(61, 21);
            this.Help.Text = "帮助(&H)";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.H)));
            this.About.Size = new System.Drawing.Size(204, 22);
            this.About.Text = "关于";
            this.About.Click += new System.EventHandler(this.TsbAbout_Click);
            // 
            // HelpText
            // 
            this.HelpText.Name = "HelpText";
            this.HelpText.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.HelpText.Size = new System.Drawing.Size(204, 22);
            this.HelpText.Text = "帮助文档";
            this.HelpText.Click += new System.EventHandler(this.HelpText_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbLogin,
            this.TsbSignin,
            this.tsbUpdate,
            this.TsbCancel,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.TsbIfoSearch,
            this.tsbAdd,
            this.TsbIfoUpdate,
            this.toolStripSeparator2,
            this.TsbSlaSearch,
            this.toolStripButton2,
            this.TsbSlaUpdate,
            this.toolStripSeparator3,
            this.TsbAbout,
            this.TsbHelpText});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(623, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "常用命令";
            // 
            // TsbLogin
            // 
            this.TsbLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbLogin.Image = ((System.Drawing.Image)(resources.GetObject("TsbLogin.Image")));
            this.TsbLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbLogin.Name = "TsbLogin";
            this.TsbLogin.Size = new System.Drawing.Size(24, 24);
            this.TsbLogin.Text = "用户登陆";
            this.TsbLogin.Click += new System.EventHandler(this.UserLogin_Click);
            // 
            // TsbSignin
            // 
            this.TsbSignin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSignin.Image = ((System.Drawing.Image)(resources.GetObject("TsbSignin.Image")));
            this.TsbSignin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSignin.Name = "TsbSignin";
            this.TsbSignin.Size = new System.Drawing.Size(24, 24);
            this.TsbSignin.Text = "用户注册";
            this.TsbSignin.Click += new System.EventHandler(this.UserSignin_Click);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(24, 24);
            this.tsbUpdate.Text = "密码修改";
            this.tsbUpdate.Click += new System.EventHandler(this.userUpdate_Click);
            // 
            // TsbCancel
            // 
            this.TsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("TsbCancel.Image")));
            this.TsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbCancel.Name = "TsbCancel";
            this.TsbCancel.Size = new System.Drawing.Size(24, 24);
            this.TsbCancel.Text = "用户退出";
            this.TsbCancel.Click += new System.EventHandler(this.UserCancel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // TsbIfoSearch
            // 
            this.TsbIfoSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbIfoSearch.Image = ((System.Drawing.Image)(resources.GetObject("TsbIfoSearch.Image")));
            this.TsbIfoSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbIfoSearch.Name = "TsbIfoSearch";
            this.TsbIfoSearch.Size = new System.Drawing.Size(24, 24);
            this.TsbIfoSearch.Text = "信息查询";
            this.TsbIfoSearch.Click += new System.EventHandler(this.PeoIfoSearch_Click);
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(24, 24);
            this.tsbAdd.Text = "员工添加";
            this.tsbAdd.Click += new System.EventHandler(this.PeoIfoAdd_Click);
            // 
            // TsbIfoUpdate
            // 
            this.TsbIfoUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbIfoUpdate.Image = ((System.Drawing.Image)(resources.GetObject("TsbIfoUpdate.Image")));
            this.TsbIfoUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbIfoUpdate.Name = "TsbIfoUpdate";
            this.TsbIfoUpdate.Size = new System.Drawing.Size(24, 24);
            this.TsbIfoUpdate.Text = "信息修改";
            this.TsbIfoUpdate.Click += new System.EventHandler(this.PeoIfoUpdate_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // TsbSlaSearch
            // 
            this.TsbSlaSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSlaSearch.Image = ((System.Drawing.Image)(resources.GetObject("TsbSlaSearch.Image")));
            this.TsbSlaSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSlaSearch.Name = "TsbSlaSearch";
            this.TsbSlaSearch.Size = new System.Drawing.Size(24, 24);
            this.TsbSlaSearch.Text = "工资查询";
            this.TsbSlaSearch.Click += new System.EventHandler(this.SlaIfoSearch_Click);
            // 
            // TsbSlaUpdate
            // 
            this.TsbSlaUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSlaUpdate.Image = ((System.Drawing.Image)(resources.GetObject("TsbSlaUpdate.Image")));
            this.TsbSlaUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSlaUpdate.Name = "TsbSlaUpdate";
            this.TsbSlaUpdate.Size = new System.Drawing.Size(24, 24);
            this.TsbSlaUpdate.Text = "工资修改";
            this.TsbSlaUpdate.Click += new System.EventHandler(this.SlaIfoUpdate_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // TsbAbout
            // 
            this.TsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbAbout.Image = ((System.Drawing.Image)(resources.GetObject("TsbAbout.Image")));
            this.TsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAbout.Name = "TsbAbout";
            this.TsbAbout.Size = new System.Drawing.Size(24, 24);
            this.TsbAbout.Text = "关于";
            this.TsbAbout.Click += new System.EventHandler(this.TsbAbout_Click);
            // 
            // TsbHelpText
            // 
            this.TsbHelpText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbHelpText.Image = ((System.Drawing.Image)(resources.GetObject("TsbHelpText.Image")));
            this.TsbHelpText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbHelpText.Name = "TsbHelpText";
            this.TsbHelpText.Size = new System.Drawing.Size(24, 24);
            this.TsbHelpText.Text = "帮助文档";
            this.TsbHelpText.Click += new System.EventHandler(this.HelpText_Click);
            // 
            // tsbAddSsalary
            // 
            this.tsbAddSsalary.Name = "tsbAddSsalary";
            this.tsbAddSsalary.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.tsbAddSsalary.Size = new System.Drawing.Size(194, 22);
            this.tsbAddSsalary.Text = "工资添加";
            this.tsbAddSsalary.Click += new System.EventHandler(this.tsbAddSsalary_Click);
            // 
            // 部门管理DToolStripMenuItem
            // 
            this.部门管理DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddDepart});
            this.部门管理DToolStripMenuItem.Name = "部门管理DToolStripMenuItem";
            this.部门管理DToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.部门管理DToolStripMenuItem.Text = "部门管理(&D)";
            // 
            // tsbAddDepart
            // 
            this.tsbAddDepart.Name = "tsbAddDepart";
            this.tsbAddDepart.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.tsbAddDepart.Size = new System.Drawing.Size(194, 22);
            this.tsbAddDepart.Text = "添加部门";
            this.tsbAddDepart.Click += new System.EventHandler(this.tsbAddDepart_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.tsbAddSsalary_Click);
            // 
            // GZGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 506);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "GZGL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工资管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GZGL_FormClosing);
            this.Load += new System.EventHandler(this.GZGL_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UserManager;
        private System.Windows.Forms.ToolStripMenuItem UserLogin;
        private System.Windows.Forms.ToolStripMenuItem UserSignin;
        private System.Windows.Forms.ToolStripMenuItem UserCancel;
        private System.Windows.Forms.ToolStripMenuItem PeoIfoManager;
        private System.Windows.Forms.ToolStripMenuItem PeoIfoSearch;
        private System.Windows.Forms.ToolStripStatusLabel Tsllabel;
        private System.Windows.Forms.ToolStripMenuItem PeoIfoUpdate;
        private System.Windows.Forms.ToolStripMenuItem SlaIfoManager;
        private System.Windows.Forms.ToolStripMenuItem SlaIfoSearch;
        private System.Windows.Forms.ToolStripMenuItem SlaIfoUpdate;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem HelpText;
        private System.Windows.Forms.ToolStripStatusLabel TssMsg;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbLogin;
        private System.Windows.Forms.ToolStripButton TsbSignin;
        private System.Windows.Forms.ToolStripButton TsbCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsbIfoSearch;
        private System.Windows.Forms.ToolStripButton TsbIfoUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TsbSlaSearch;
        private System.Windows.Forms.ToolStripButton TsbSlaUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TsbAbout;
        private System.Windows.Forms.ToolStripButton TsbHelpText;
        private System.Windows.Forms.ToolStripMenuItem userUpdate;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripMenuItem PeoIfoAdd;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripMenuItem tsbAddSsalary;
        private System.Windows.Forms.ToolStripMenuItem 部门管理DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsbAddDepart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

