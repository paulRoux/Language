namespace XSGL
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSysteMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.UserLogOff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStudentMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStuMsgMag = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTeacherMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewTea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTeaMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCourseMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCurMsgMag = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScoreMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.GradeCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.UserLogin = new System.Windows.Forms.ToolStripButton();
            this.UserLog = new System.Windows.Forms.ToolStripButton();
            this.UserCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNewStudent = new System.Windows.Forms.ToolStripButton();
            this.tsbNewMsgMag = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TeacherNew = new System.Windows.Forms.ToolStripButton();
            this.TeacherMsg = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNewCourse = new System.Windows.Forms.ToolStripButton();
            this.tsbCurMsgMag = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.GradeMag = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbScoreMsg = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSysteMsg,
            this.tsmStudentMsg,
            this.tsmTeacherMsg,
            this.tsmCourseMsg,
            this.tsmScoreMsg,
            this.tsmHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSysteMsg
            // 
            this.tsmSysteMsg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLogin,
            this.UserLogOff,
            this.tsmExit});
            this.tsmSysteMsg.Name = "tsmSysteMsg";
            this.tsmSysteMsg.Size = new System.Drawing.Size(83, 21);
            this.tsmSysteMsg.Text = "系统管理(&S)";
            // 
            // tsmLogin
            // 
            this.tsmLogin.Name = "tsmLogin";
            this.tsmLogin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmLogin.Size = new System.Drawing.Size(185, 22);
            this.tsmLogin.Text = "用户登录(&L)";
            this.tsmLogin.Click += new System.EventHandler(this.tsmLogin_Click);
            // 
            // UserLogOff
            // 
            this.UserLogOff.Name = "UserLogOff";
            this.UserLogOff.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.UserLogOff.Size = new System.Drawing.Size(185, 22);
            this.UserLogOff.Text = "用户注销(&C)";
            this.UserLogOff.Click += new System.EventHandler(this.UserLogOff_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmExit.Size = new System.Drawing.Size(185, 22);
            this.tsmExit.Text = "用户退出(&X)";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmStudentMsg
            // 
            this.tsmStudentMsg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewStudent,
            this.tsmStuMsgMag});
            this.tsmStudentMsg.Name = "tsmStudentMsg";
            this.tsmStudentMsg.Size = new System.Drawing.Size(88, 21);
            this.tsmStudentMsg.Text = "学生管理(&M)";
            // 
            // tsmNewStudent
            // 
            this.tsmNewStudent.Name = "tsmNewStudent";
            this.tsmNewStudent.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmNewStudent.Size = new System.Drawing.Size(242, 22);
            this.tsmNewStudent.Text = "添加学生信息(&A)";
            this.tsmNewStudent.Click += new System.EventHandler(this.tsmNewStudent_Click);
            // 
            // tsmStuMsgMag
            // 
            this.tsmStuMsgMag.Name = "tsmStuMsgMag";
            this.tsmStuMsgMag.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmStuMsgMag.Size = new System.Drawing.Size(242, 22);
            this.tsmStuMsgMag.Text = "学生信息管理(&I)";
            this.tsmStuMsgMag.Click += new System.EventHandler(this.tsmStuMsgMag_Click);
            // 
            // tsmTeacherMsg
            // 
            this.tsmTeacherMsg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewTea,
            this.tsmTeaMsg});
            this.tsmTeacherMsg.Name = "tsmTeacherMsg";
            this.tsmTeacherMsg.Size = new System.Drawing.Size(83, 21);
            this.tsmTeacherMsg.Text = "教师管理(&T)";
            // 
            // tsmNewTea
            // 
            this.tsmNewTea.Name = "tsmNewTea";
            this.tsmNewTea.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmNewTea.Size = new System.Drawing.Size(226, 22);
            this.tsmNewTea.Text = "添加教师信息";
            this.tsmNewTea.Click += new System.EventHandler(this.tsmNewTea_Click);
            // 
            // tsmTeaMsg
            // 
            this.tsmTeaMsg.Name = "tsmTeaMsg";
            this.tsmTeaMsg.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tsmTeaMsg.Size = new System.Drawing.Size(226, 22);
            this.tsmTeaMsg.Text = "查询教师信息";
            this.tsmTeaMsg.Click += new System.EventHandler(this.tsmTeaMsg_Click);
            // 
            // tsmCourseMsg
            // 
            this.tsmCourseMsg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewCourse,
            this.tsmCurMsgMag});
            this.tsmCourseMsg.Name = "tsmCourseMsg";
            this.tsmCourseMsg.Size = new System.Drawing.Size(84, 21);
            this.tsmCourseMsg.Text = "课程管理(&C)";
            // 
            // tsmNewCourse
            // 
            this.tsmNewCourse.Name = "tsmNewCourse";
            this.tsmNewCourse.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.tsmNewCourse.Size = new System.Drawing.Size(219, 22);
            this.tsmNewCourse.Text = "添加课程(&A)";
            this.tsmNewCourse.Click += new System.EventHandler(this.tsmNewCourse_Click);
            // 
            // tsmCurMsgMag
            // 
            this.tsmCurMsgMag.Name = "tsmCurMsgMag";
            this.tsmCurMsgMag.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmCurMsgMag.Size = new System.Drawing.Size(219, 22);
            this.tsmCurMsgMag.Text = "课程信息管理(&I)";
            this.tsmCurMsgMag.Click += new System.EventHandler(this.tsmCurMsgMag_Click);
            // 
            // tsmScoreMsg
            // 
            this.tsmScoreMsg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GradeCheck});
            this.tsmScoreMsg.Name = "tsmScoreMsg";
            this.tsmScoreMsg.Size = new System.Drawing.Size(84, 21);
            this.tsmScoreMsg.Text = "成绩管理(&A)";
            // 
            // GradeCheck
            // 
            this.GradeCheck.Name = "GradeCheck";
            this.GradeCheck.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.GradeCheck.Size = new System.Drawing.Size(185, 22);
            this.GradeCheck.Text = "查询成绩(&V)";
            this.GradeCheck.Click += new System.EventHandler(this.GradeCheck_Click);
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbout});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(61, 21);
            this.tsmHelp.Text = "帮助(&H)";
            // 
            // tsmAbout
            // 
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(116, 22);
            this.tsmAbout.Text = "关于(A)";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserLogin,
            this.UserLog,
            this.UserCancel,
            this.toolStripSeparator3,
            this.tsbNewStudent,
            this.tsbNewMsgMag,
            this.toolStripSeparator1,
            this.TeacherNew,
            this.TeacherMsg,
            this.toolStripSeparator4,
            this.tsbNewCourse,
            this.tsbCurMsgMag,
            this.toolStripSeparator2,
            this.GradeMag,
            this.toolStripSeparator5,
            this.tsbScoreMsg});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(575, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "常用命令";
            // 
            // UserLogin
            // 
            this.UserLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UserLogin.Image = ((System.Drawing.Image)(resources.GetObject("UserLogin.Image")));
            this.UserLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(29, 29);
            this.UserLogin.Text = "用户登录";
            this.UserLogin.Click += new System.EventHandler(this.tsmLogin_Click);
            // 
            // UserLog
            // 
            this.UserLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UserLog.Image = ((System.Drawing.Image)(resources.GetObject("UserLog.Image")));
            this.UserLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UserLog.Name = "UserLog";
            this.UserLog.Size = new System.Drawing.Size(29, 29);
            this.UserLog.Text = "用户注销";
            this.UserLog.Click += new System.EventHandler(this.UserLogOff_Click);
            // 
            // UserCancel
            // 
            this.UserCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UserCancel.Image = ((System.Drawing.Image)(resources.GetObject("UserCancel.Image")));
            this.UserCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UserCancel.Name = "UserCancel";
            this.UserCancel.Size = new System.Drawing.Size(29, 29);
            this.UserCancel.Text = "用户退出";
            this.UserCancel.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbNewStudent
            // 
            this.tsbNewStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewStudent.Image")));
            this.tsbNewStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewStudent.Name = "tsbNewStudent";
            this.tsbNewStudent.Size = new System.Drawing.Size(29, 29);
            this.tsbNewStudent.Text = "添加学生信息";
            this.tsbNewStudent.Click += new System.EventHandler(this.tsmNewStudent_Click);
            // 
            // tsbNewMsgMag
            // 
            this.tsbNewMsgMag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewMsgMag.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewMsgMag.Image")));
            this.tsbNewMsgMag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewMsgMag.Name = "tsbNewMsgMag";
            this.tsbNewMsgMag.Size = new System.Drawing.Size(29, 29);
            this.tsbNewMsgMag.Text = "学生信息管理";
            this.tsbNewMsgMag.Click += new System.EventHandler(this.tsmStuMsgMag_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // TeacherNew
            // 
            this.TeacherNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TeacherNew.Image = ((System.Drawing.Image)(resources.GetObject("TeacherNew.Image")));
            this.TeacherNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TeacherNew.Name = "TeacherNew";
            this.TeacherNew.Size = new System.Drawing.Size(29, 29);
            this.TeacherNew.Text = "添加教师信息";
            this.TeacherNew.Click += new System.EventHandler(this.tsmNewTea_Click);
            // 
            // TeacherMsg
            // 
            this.TeacherMsg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TeacherMsg.Image = ((System.Drawing.Image)(resources.GetObject("TeacherMsg.Image")));
            this.TeacherMsg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TeacherMsg.Name = "TeacherMsg";
            this.TeacherMsg.Size = new System.Drawing.Size(29, 29);
            this.TeacherMsg.Text = "查看教师信息";
            this.TeacherMsg.Click += new System.EventHandler(this.tsmTeaMsg_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbNewCourse
            // 
            this.tsbNewCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewCourse.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewCourse.Image")));
            this.tsbNewCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewCourse.Name = "tsbNewCourse";
            this.tsbNewCourse.Size = new System.Drawing.Size(29, 29);
            this.tsbNewCourse.Text = "添加课程信息";
            this.tsbNewCourse.Click += new System.EventHandler(this.tsmNewCourse_Click);
            // 
            // tsbCurMsgMag
            // 
            this.tsbCurMsgMag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCurMsgMag.Image = ((System.Drawing.Image)(resources.GetObject("tsbCurMsgMag.Image")));
            this.tsbCurMsgMag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCurMsgMag.Name = "tsbCurMsgMag";
            this.tsbCurMsgMag.Size = new System.Drawing.Size(29, 29);
            this.tsbCurMsgMag.Text = "课程信息管理";
            this.tsbCurMsgMag.Click += new System.EventHandler(this.tsmCurMsgMag_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // GradeMag
            // 
            this.GradeMag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GradeMag.Image = ((System.Drawing.Image)(resources.GetObject("GradeMag.Image")));
            this.GradeMag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GradeMag.Name = "GradeMag";
            this.GradeMag.Size = new System.Drawing.Size(29, 29);
            this.GradeMag.Text = "成绩管理";
            this.GradeMag.Click += new System.EventHandler(this.GradeCheck_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbScoreMsg
            // 
            this.tsbScoreMsg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbScoreMsg.Image = ((System.Drawing.Image)(resources.GetObject("tsbScoreMsg.Image")));
            this.tsbScoreMsg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScoreMsg.Name = "tsbScoreMsg";
            this.tsbScoreMsg.Size = new System.Drawing.Size(29, 29);
            this.tsbScoreMsg.Text = "关于";
            this.tsbScoreMsg.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tssMsg});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 467);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(575, 22);
            this.StatusStrip1.TabIndex = 2;
            this.StatusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Image = ((System.Drawing.Image)(resources.GetObject("tssStatus.Image")));
            this.tssStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(48, 17);
            this.tssStatus.Text = "就绪";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssMsg
            // 
            this.tssMsg.Name = "tssMsg";
            this.tssMsg.Size = new System.Drawing.Size(512, 17);
            this.tssMsg.Spring = true;
            this.tssMsg.Text = "请选择一个操作";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 489);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生成绩管理系统";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSysteMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmStudentMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmNewStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmStuMsgMag;
        private System.Windows.Forms.ToolStripMenuItem tsmCourseMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmNewCourse;
        private System.Windows.Forms.ToolStripMenuItem tsmCurMsgMag;
        private System.Windows.Forms.ToolStripMenuItem tsmScoreMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewStudent;
        private System.Windows.Forms.ToolStripButton tsbNewMsgMag;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbNewCourse;
        private System.Windows.Forms.ToolStripButton tsbCurMsgMag;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbScoreMsg;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmTeacherMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmNewTea;
        private System.Windows.Forms.ToolStripMenuItem tsmTeaMsg;
        private System.Windows.Forms.ToolStripButton UserLogin;
        private System.Windows.Forms.ToolStripButton UserCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TeacherNew;
        private System.Windows.Forms.ToolStripButton TeacherMsg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem UserLogOff;
        private System.Windows.Forms.ToolStripButton UserLog;
        private System.Windows.Forms.ToolStripMenuItem GradeCheck;
        private System.Windows.Forms.ToolStripButton GradeMag;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}