using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter0501
{
    public partial class Form1 : Form
    {
        static int x = 200;
        static int y = 200;
        static int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 新建窗体
            Form1 form2 = new Form1();
            form2.Visible = true;

            // 设置当前窗体位置
            form2.SetDesktopLocation(x, y);
            x += 30;
            y += 30;

            // 激活当前窗体
            this.Activate();
            this.button1.Enabled = false;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            count -= 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            count += 1;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            label1.Text = "x: " + x + " y: " + y;
            label2.Text = "当前打开窗体数为: " + count;
        }
    }
}
