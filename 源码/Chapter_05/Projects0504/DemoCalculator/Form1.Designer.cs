namespace DemoCalculator
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEquels = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(192, 228);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 29);
            this.panel1.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(5, 5);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(172, 21);
            this.txtResult.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnEquels, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnPoint, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnSign, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnZero, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnDiv, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnThree, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnTwo, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnOne, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnMul, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSix, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnFive, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnFour, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSub, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnNine, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnEight, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnSeven, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClear, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCE, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBackspace, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(186, 187);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnEquels
            // 
            this.btnEquels.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEquels.Location = new System.Drawing.Point(141, 156);
            this.btnEquels.Name = "btnEquels";
            this.btnEquels.Size = new System.Drawing.Size(42, 23);
            this.btnEquels.TabIndex = 20;
            this.btnEquels.Text = "=";
            this.btnEquels.UseVisualStyleBackColor = true;
            this.btnEquels.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnPoint
            // 
            this.btnPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPoint.Location = new System.Drawing.Point(95, 156);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(40, 23);
            this.btnPoint.TabIndex = 19;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnSign
            // 
            this.btnSign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSign.Location = new System.Drawing.Point(49, 156);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(40, 23);
            this.btnSign.TabIndex = 18;
            this.btnSign.Text = "+/-";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnZero
            // 
            this.btnZero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZero.Location = new System.Drawing.Point(3, 156);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(40, 23);
            this.btnZero.TabIndex = 17;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnDiv
            // 
            this.btnDiv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDiv.Location = new System.Drawing.Point(141, 118);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(42, 23);
            this.btnDiv.TabIndex = 16;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnThree
            // 
            this.btnThree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThree.Location = new System.Drawing.Point(95, 118);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(40, 23);
            this.btnThree.TabIndex = 15;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnTwo
            // 
            this.btnTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTwo.Location = new System.Drawing.Point(49, 118);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(40, 23);
            this.btnTwo.TabIndex = 14;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnOne
            // 
            this.btnOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOne.Location = new System.Drawing.Point(3, 118);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(40, 23);
            this.btnOne.TabIndex = 13;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnMul
            // 
            this.btnMul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMul.Location = new System.Drawing.Point(141, 81);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(42, 23);
            this.btnMul.TabIndex = 12;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnSix
            // 
            this.btnSix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSix.Location = new System.Drawing.Point(95, 81);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(40, 23);
            this.btnSix.TabIndex = 11;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnFive
            // 
            this.btnFive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFive.Location = new System.Drawing.Point(49, 81);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(40, 23);
            this.btnFive.TabIndex = 10;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnFour
            // 
            this.btnFour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFour.Location = new System.Drawing.Point(3, 81);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(40, 23);
            this.btnFour.TabIndex = 9;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnSub
            // 
            this.btnSub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSub.Location = new System.Drawing.Point(141, 44);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(42, 23);
            this.btnSub.TabIndex = 8;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnNine
            // 
            this.btnNine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNine.Location = new System.Drawing.Point(95, 44);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(40, 23);
            this.btnNine.TabIndex = 7;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnEight
            // 
            this.btnEight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEight.Location = new System.Drawing.Point(49, 44);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(40, 23);
            this.btnEight.TabIndex = 6;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnSeven
            // 
            this.btnSeven.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSeven.Location = new System.Drawing.Point(3, 44);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(40, 23);
            this.btnSeven.TabIndex = 5;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(141, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Location = new System.Drawing.Point(95, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnCE
            // 
            this.btnCE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCE.Location = new System.Drawing.Point(49, 7);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(40, 23);
            this.btnCE.TabIndex = 2;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackspace.Location = new System.Drawing.Point(3, 7);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(40, 23);
            this.btnBackspace.TabIndex = 1;
            this.btnBackspace.Text = "Back";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 228);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "简易计算器";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnEquels;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnBackspace;
    }
}

