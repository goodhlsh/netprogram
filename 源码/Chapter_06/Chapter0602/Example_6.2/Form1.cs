using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }     
        //窗体装入事件
        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "当前日期为：" + DateTime.Now.ToShortDateString();
        }
        //加载进度条按钮事件
        private void button1_Click(object sender, EventArgs e)
        {
            this.toolStripProgressBar1.Minimum = 0;           //进度条最小值
            this.toolStripProgressBar1.Maximum = 5000;    //进度条最大值
            this.toolStripProgressBar1.Step = 2;                //进度条的增值
            for (int i = 0; i < 5000; i++)
            {
                this.toolStripProgressBar1.PerformStep();     //增加进度条当前位置
            }
        }
    }
}
