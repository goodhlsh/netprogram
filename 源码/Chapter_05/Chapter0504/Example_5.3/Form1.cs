using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = Properties.Resources.bg;      //设置Button1的背景
            this.button1.BackgroundImageLayout = ImageLayout.Stretch;    //设置Button1背景布局
            this.button2.Image = Properties.Resources.qie;   //设置Button1显示的图像
            this.button2.ImageAlign = ContentAlignment.MiddleCenter;   //设置图像居中对齐
            this.button2.Text = "图像按钮";                                              //设置Button2的文本
            this.button3.FlatStyle = FlatStyle.Flat;             //设置Button3的样式
            this.button3.Text = "接受按钮";                    //设置Button3的文本
            this.button4.Text = "取消按钮";                   //设置Button4的文本

            this.AcceptButton = button3;                 //设置窗体的默认按钮为button3
            this.CancelButton = button4;               //设置窗体的默认按钮为button3
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("接受按钮事件", "提示");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("取消按钮事件", "提示");
        }
    }
}
