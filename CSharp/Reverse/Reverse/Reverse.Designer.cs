namespace Reverse
{
    partial class Reverse
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
            this.label2 = new System.Windows.Forms.Label();
            this.turnTurn = new System.Windows.Forms.TextBox();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.bntReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原数：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "逆序";
            // 
            // turnTurn
            // 
            this.turnTurn.Location = new System.Drawing.Point(273, 73);
            this.turnTurn.Name = "turnTurn";
            this.turnTurn.Size = new System.Drawing.Size(100, 21);
            this.turnTurn.TabIndex = 2;
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(93, 73);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(100, 21);
            this.txtOriginal.TabIndex = 3;
            // 
            // bntReverse
            // 
            this.bntReverse.Location = new System.Drawing.Point(390, 71);
            this.bntReverse.Name = "bntReverse";
            this.bntReverse.Size = new System.Drawing.Size(75, 23);
            this.bntReverse.TabIndex = 4;
            this.bntReverse.Text = "逆序";
            this.bntReverse.UseVisualStyleBackColor = true;
            this.bntReverse.Click += new System.EventHandler(this.bntReverse_Click);
            // 
            // Reverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 262);
            this.Controls.Add(this.bntReverse);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.turnTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Reverse";
            this.Text = "Reverse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox turnTurn;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Button bntReverse;
    }
}

