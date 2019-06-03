using System;
using System.Windows.Forms;

namespace Chapter0502
{
    public partial class Form1 : Form
    {
        //构造函数
        public Form1()
        {
            InitializeComponent();
        }
        //窗体装入事件
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("正在进行窗体初始化！","窗体初始化");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("开始响应窗体事件！","单击窗体"); 
        }
        //关闭窗体时事件
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("正在关闭窗体","关闭窗体");
        }
        //窗体关闭后事件
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("主窗体已关闭，即将关闭应用程序", "应用程序关闭");
        }
    }
}
