using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_6._3
{
    public partial class Form1 : Form
    {
        private int location;

        public Form1()
        {
            InitializeComponent();
        }
        //开始移动按钮单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            location = this.pictureBox1.Left;
            this.timer1.Start();    //开始计时器
        }
        //停止移动按钮单击事件
        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();   //停止计时器
        }
        //计时器间隔事件响应函数
        private void timer1_Tick(object sender, EventArgs e)
        {
             if (this.pictureBox1.Left >=this.Width )
            {
                this.pictureBox1.Left = location ;             
            }
             this.pictureBox1.Left = this.pictureBox1.Left + 1;
        }
    }
}
