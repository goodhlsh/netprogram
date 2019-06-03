using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter503
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //设置2个文本框的属性
            this.txtInput.ForeColor = Color.Blue;
            this.txtHint.BackColor = Color.White;
            this.txtHint.ForeColor = Color.Green;
            this.txtHint.ReadOnly = true;
        }

        private void txtInput_Enter(object sender, EventArgs e)
        {
            //光标进入清除原有文本
            this.txtInput.Clear();
        }

        private void txtInput_Leave(object sender, EventArgs e)
        {
            //焦点退出，将文本添加到tbHint新的一行
            this.txtHint.AppendText(this.txtInput.Text +"\n");
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            //将当前tbInput中文本内容同步显示到lblCopy中
            this.lblCopy.Text = this.txtInput.Text;
        }
    }
}
