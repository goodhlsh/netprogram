namespace Example_5._5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstLeft = new System.Windows.Forms.ListBox();
            this.lstRight = new System.Windows.Forms.ListBox();
            this.btnAllSelction = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnAddSelcted = new System.Windows.Forms.Button();
            this.btnClearSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程列表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择的课程列表";
            // 
            // lstLeft
            // 
            this.lstLeft.FormattingEnabled = true;
            this.lstLeft.ItemHeight = 14;
            this.lstLeft.Location = new System.Drawing.Point(12, 37);
            this.lstLeft.Name = "lstLeft";
            this.lstLeft.Size = new System.Drawing.Size(150, 312);
            this.lstLeft.TabIndex = 2;
            // 
            // lstRight
            // 
            this.lstRight.FormattingEnabled = true;
            this.lstRight.ItemHeight = 14;
            this.lstRight.Location = new System.Drawing.Point(271, 37);
            this.lstRight.Name = "lstRight";
            this.lstRight.Size = new System.Drawing.Size(150, 312);
            this.lstRight.TabIndex = 3;
            // 
            // btnAllSelction
            // 
            this.btnAllSelction.Location = new System.Drawing.Point(185, 60);
            this.btnAllSelction.Name = "btnAllSelction";
            this.btnAllSelction.Size = new System.Drawing.Size(59, 35);
            this.btnAllSelction.TabIndex = 4;
            this.btnAllSelction.Text = "<<";
            this.btnAllSelction.UseVisualStyleBackColor = true;
            this.btnAllSelction.Click += new System.EventHandler(this.btnAllSelction_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(185, 138);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(59, 35);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = ">>";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnAddSelcted
            // 
            this.btnAddSelcted.Location = new System.Drawing.Point(185, 216);
            this.btnAddSelcted.Name = "btnAddSelcted";
            this.btnAddSelcted.Size = new System.Drawing.Size(59, 35);
            this.btnAddSelcted.TabIndex = 6;
            this.btnAddSelcted.Text = "<";
            this.btnAddSelcted.UseVisualStyleBackColor = true;
            this.btnAddSelcted.Click += new System.EventHandler(this.btnAddSelcted_Click);
            // 
            // btnClearSelected
            // 
            this.btnClearSelected.Location = new System.Drawing.Point(185, 294);
            this.btnClearSelected.Name = "btnClearSelected";
            this.btnClearSelected.Size = new System.Drawing.Size(59, 35);
            this.btnClearSelected.TabIndex = 7;
            this.btnClearSelected.Text = ">";
            this.btnClearSelected.UseVisualStyleBackColor = true;
            this.btnClearSelected.Click += new System.EventHandler(this.btnClearSelected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 368);
            this.Controls.Add(this.btnClearSelected);
            this.Controls.Add(this.btnAddSelcted);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnAllSelction);
            this.Controls.Add(this.lstRight);
            this.Controls.Add(this.lstLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox控件用法";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstLeft;
        private System.Windows.Forms.ListBox lstRight;
        private System.Windows.Forms.Button btnAllSelction;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnAddSelcted;
        private System.Windows.Forms.Button btnClearSelected;
    }
}

