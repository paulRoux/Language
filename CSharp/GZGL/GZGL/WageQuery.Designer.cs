namespace GZGL
{
    partial class WageQuery
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
            this.label3 = new System.Windows.Forms.Label();
            this.ManadateQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dvWageInfoMa = new System.Windows.Forms.DataGridView();
            this.MaQueryId = new System.Windows.Forms.TextBox();
            this.ManagerQuery = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dvWageInfo = new System.Windows.Forms.DataGridView();
            this.dateQuery = new System.Windows.Forms.Button();
            this.EmQueryId = new System.Windows.Forms.TextBox();
            this.Query = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvWageInfoMa)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvWageInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 489);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.date);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ManadateQuery);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dvWageInfoMa);
            this.tabPage1.Controls.Add(this.MaQueryId);
            this.tabPage1.Controls.Add(this.ManagerQuery);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "经理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(461, 20);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(159, 21);
            this.date.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "日期：";
            // 
            // ManadateQuery
            // 
            this.ManadateQuery.Location = new System.Drawing.Point(642, 18);
            this.ManadateQuery.Name = "ManadateQuery";
            this.ManadateQuery.Size = new System.Drawing.Size(75, 23);
            this.ManadateQuery.TabIndex = 3;
            this.ManadateQuery.Text = "查询(&Q)";
            this.ManadateQuery.UseVisualStyleBackColor = true;
            this.ManadateQuery.Click += new System.EventHandler(this.ManadateQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "经理编号：";
            // 
            // dvWageInfoMa
            // 
            this.dvWageInfoMa.AllowUserToAddRows = false;
            this.dvWageInfoMa.AllowUserToDeleteRows = false;
            this.dvWageInfoMa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvWageInfoMa.Location = new System.Drawing.Point(24, 59);
            this.dvWageInfoMa.Name = "dvWageInfoMa";
            this.dvWageInfoMa.ReadOnly = true;
            this.dvWageInfoMa.RowTemplate.Height = 23;
            this.dvWageInfoMa.Size = new System.Drawing.Size(737, 388);
            this.dvWageInfoMa.TabIndex = 13;
            // 
            // MaQueryId
            // 
            this.MaQueryId.Location = new System.Drawing.Point(119, 20);
            this.MaQueryId.Name = "MaQueryId";
            this.MaQueryId.Size = new System.Drawing.Size(132, 21);
            this.MaQueryId.TabIndex = 0;
            // 
            // ManagerQuery
            // 
            this.ManagerQuery.Location = new System.Drawing.Point(271, 18);
            this.ManagerQuery.Name = "ManagerQuery";
            this.ManagerQuery.Size = new System.Drawing.Size(75, 23);
            this.ManagerQuery.TabIndex = 1;
            this.ManagerQuery.Text = "查询(&Q)";
            this.ManagerQuery.UseVisualStyleBackColor = true;
            this.ManagerQuery.Click += new System.EventHandler(this.ManagerQuery_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dvWageInfo);
            this.tabPage2.Controls.Add(this.dateQuery);
            this.tabPage2.Controls.Add(this.EmQueryId);
            this.tabPage2.Controls.Add(this.Query);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "员工";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(461, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "日期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "员工编号：";
            // 
            // dvWageInfo
            // 
            this.dvWageInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvWageInfo.Location = new System.Drawing.Point(24, 59);
            this.dvWageInfo.Name = "dvWageInfo";
            this.dvWageInfo.RowTemplate.Height = 23;
            this.dvWageInfo.Size = new System.Drawing.Size(737, 387);
            this.dvWageInfo.TabIndex = 14;
            // 
            // dateQuery
            // 
            this.dateQuery.Location = new System.Drawing.Point(642, 17);
            this.dateQuery.Name = "dateQuery";
            this.dateQuery.Size = new System.Drawing.Size(75, 23);
            this.dateQuery.TabIndex = 3;
            this.dateQuery.Text = "查询(&Q)";
            this.dateQuery.UseVisualStyleBackColor = true;
            this.dateQuery.Click += new System.EventHandler(this.dateQuery_Click);
            // 
            // EmQueryId
            // 
            this.EmQueryId.Location = new System.Drawing.Point(120, 19);
            this.EmQueryId.Name = "EmQueryId";
            this.EmQueryId.Size = new System.Drawing.Size(131, 21);
            this.EmQueryId.TabIndex = 0;
            this.EmQueryId.Text = " ";
            // 
            // Query
            // 
            this.Query.Location = new System.Drawing.Point(271, 17);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(75, 23);
            this.Query.TabIndex = 1;
            this.Query.Text = "查询(&Q)";
            this.Query.UseVisualStyleBackColor = true;
            this.Query.Click += new System.EventHandler(this.Query_Click);
            // 
            // WageQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 513);
            this.Controls.Add(this.tabControl1);
            this.Name = "WageQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工资查询";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvWageInfoMa)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvWageInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ManadateQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvWageInfoMa;
        private System.Windows.Forms.TextBox MaQueryId;
        private System.Windows.Forms.Button ManagerQuery;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dvWageInfo;
        private System.Windows.Forms.Button dateQuery;
        private System.Windows.Forms.TextBox EmQueryId;
        private System.Windows.Forms.Button Query;

    }
}