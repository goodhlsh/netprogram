using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter1002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //不使用样式，在当前窗体上绘制文字  
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.LawnGreen);
            Font font = new Font("楷体GB-2312", 25, FontStyle.Bold);
            g.DrawString("Hello World!", font, brush, 20, 20);
            brush.Dispose();
            font.Dispose();

            brush = new SolidBrush(Color.RosyBrown);
            font = new Font("Timers New Roman", 40, FontStyle.Regular);
            g.DrawString("Hello World!", font, brush, 20, 60);
            brush.Dispose();
            font.Dispose();

            brush = new SolidBrush(Color.Red);
            font = new Font("黑体", 30, FontStyle.Regular);
            g.DrawString("Hello World!", font, brush, new Rectangle(20, 140, 400, 60));
            brush.Dispose();
            font.Dispose();  

        }
    }
}
