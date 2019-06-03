namespace Chapter1103
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxLocalInfo = new System.Windows.Forms.ListBox();
            this.listBoxRemoteInfo = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxLocalInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "远程主机IP信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxRemoteInfo);
            this.groupBox2.Location = new System.Drawing.Point(231, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "远程主机IP信息";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "显示本机IP信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "显示服务器信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxLocalInfo
            // 
            this.listBoxLocalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLocalInfo.FormattingEnabled = true;
            this.listBoxLocalInfo.ItemHeight = 12;
            this.listBoxLocalInfo.Location = new System.Drawing.Point(3, 17);
            this.listBoxLocalInfo.Name = "listBoxLocalInfo";
            this.listBoxLocalInfo.Size = new System.Drawing.Size(194, 194);
            this.listBoxLocalInfo.TabIndex = 0;
            // 
            // listBoxRemoteInfo
            // 
            this.listBoxRemoteInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRemoteInfo.FormattingEnabled = true;
            this.listBoxRemoteInfo.ItemHeight = 12;
            this.listBoxRemoteInfo.Location = new System.Drawing.Point(3, 17);
            this.listBoxRemoteInfo.Name = "listBoxRemoteInfo";
            this.listBoxRemoteInfo.Size = new System.Drawing.Size(194, 194);
            this.listBoxRemoteInfo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP地址转换与域名解析示例";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxLocalInfo;
        private System.Windows.Forms.ListBox listBoxRemoteInfo;
    }
}

