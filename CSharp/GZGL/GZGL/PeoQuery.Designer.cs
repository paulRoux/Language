namespace GZGL
{
    partial class PeoQuery
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvInfo = new System.Windows.Forms.DataGridView();
            this.dateQuery = new System.Windows.Forms.Button();
            this.QueryId = new System.Windows.Forms.TextBox();
            this.Query = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Emdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dvEmInfo = new System.Windows.Forms.DataGridView();
            this.EmdateQuery = new System.Windows.Forms.Button();
            this.EmQueryId = new System.Windows.Forms.TextBox();
            this.EmQuery = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInfo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvEmInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 522);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.date);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dvInfo);
            this.tabPage1.Controls.Add(this.dateQuery);
            this.tabPage1.Controls.Add(this.QueryId);
            this.tabPage1.Controls.Add(this.Query);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "经理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(443, 37);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(166, 21);
            this.date.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "编号：";
            // 
            // dvInfo
            // 
            this.dvInfo.AllowUserToAddRows = false;
            this.dvInfo.AllowUserToDeleteRows = false;
            this.dvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvInfo.Location = new System.Drawing.Point(6, 79);
            this.dvInfo.Name = "dvInfo";
            this.dvInfo.ReadOnly = true;
            this.dvInfo.RowTemplate.Height = 23;
            this.dvInfo.Size = new System.Drawing.Size(790, 411);
            this.dvInfo.TabIndex = 7;
            // 
            // dateQuery
            // 
            this.dateQuery.Location = new System.Drawing.Point(632, 35);
            this.dateQuery.Name = "dateQuery";
            this.dateQuery.Size = new System.Drawing.Size(75, 23);
            this.dateQuery.TabIndex = 3;
            this.dateQuery.Text = "查询(&Q)";
            this.dateQuery.UseVisualStyleBackColor = true;
            this.dateQuery.Click += new System.EventHandler(this.dateQuery_Click);
            // 
            // QueryId
            // 
            this.QueryId.Location = new System.Drawing.Point(128, 37);
            this.QueryId.Name = "QueryId";
            this.QueryId.Size = new System.Drawing.Size(100, 21);
            this.QueryId.TabIndex = 0;
            // 
            // Query
            // 
            this.Query.Location = new System.Drawing.Point(256, 35);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(75, 23);
            this.Query.TabIndex = 1;
            this.Query.Text = "查询(&Q)";
            this.Query.UseVisualStyleBackColor = true;
            this.Query.Click += new System.EventHandler(this.Query_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Emdate);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dvEmInfo);
            this.tabPage2.Controls.Add(this.EmdateQuery);
            this.tabPage2.Controls.Add(this.EmQueryId);
            this.tabPage2.Controls.Add(this.EmQuery);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "员工";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Emdate
            // 
            this.Emdate.Location = new System.Drawing.Point(438, 37);
            this.Emdate.Name = "Emdate";
            this.Emdate.Size = new System.Drawing.Size(166, 21);
            this.Emdate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "日期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "编号：";
            // 
            // dvEmInfo
            // 
            this.dvEmInfo.AllowUserToAddRows = false;
            this.dvEmInfo.AllowUserToDeleteRows = false;
            this.dvEmInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvEmInfo.Location = new System.Drawing.Point(6, 79);
            this.dvEmInfo.Name = "dvEmInfo";
            this.dvEmInfo.ReadOnly = true;
            this.dvEmInfo.RowTemplate.Height = 23;
            this.dvEmInfo.Size = new System.Drawing.Size(790, 411);
            this.dvEmInfo.TabIndex = 15;
            // 
            // EmdateQuery
            // 
            this.EmdateQuery.Location = new System.Drawing.Point(632, 35);
            this.EmdateQuery.Name = "EmdateQuery";
            this.EmdateQuery.Size = new System.Drawing.Size(75, 23);
            this.EmdateQuery.TabIndex = 3;
            this.EmdateQuery.Text = "查询(&Q)";
            this.EmdateQuery.UseVisualStyleBackColor = true;
            this.EmdateQuery.Click += new System.EventHandler(this.EmdateQuery_Click);
            // 
            // EmQueryId
            // 
            this.EmQueryId.Location = new System.Drawing.Point(123, 37);
            this.EmQueryId.Name = "EmQueryId";
            this.EmQueryId.Size = new System.Drawing.Size(100, 21);
            this.EmQueryId.TabIndex = 0;
            // 
            // EmQuery
            // 
            this.EmQuery.Location = new System.Drawing.Point(251, 35);
            this.EmQuery.Name = "EmQuery";
            this.EmQuery.Size = new System.Drawing.Size(75, 23);
            this.EmQuery.TabIndex = 1;
            this.EmQuery.Text = "查询(&Q)";
            this.EmQuery.UseVisualStyleBackColor = true;
            this.EmQuery.Click += new System.EventHandler(this.EmQuery_Click);
            // 
            // PeoQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 537);
            this.Controls.Add(this.tabControl1);
            this.Name = "PeoQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人事查询";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInfo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvEmInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvInfo;
        private System.Windows.Forms.Button dateQuery;
        private System.Windows.Forms.TextBox QueryId;
        private System.Windows.Forms.Button Query;
        private System.Windows.Forms.DateTimePicker Emdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dvEmInfo;
        private System.Windows.Forms.Button EmdateQuery;
        private System.Windows.Forms.TextBox EmQueryId;
        private System.Windows.Forms.Button EmQuery;

    }
}