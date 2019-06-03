using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter1003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           Image image = new Bitmap(@"E:\Books\Program\Chapter_10\mm.jpg");  
          // 从窗体的左上角(0,0)的位置开始绘制图像  
         e.Graphics.DrawImage(image, 0, 0);  
         // 从窗体的(150, 20)位置开始绘制一个比图像大30%的矩形，说明在该矩形中缩放图像  
         int width = image.Width;  
         int height = image.Height;  
         RectangleF destinationRect = new RectangleF(150, 20, 1.3f * width, 1.3f * height);  
         // 绘制一个矩形，说明在矩形的位置图像将要被缩放  
         RectangleF sourceRect = new RectangleF(0, 0, 0.75f * width, 0.75f * height);  
        e.Graphics.DrawImage( image, destinationRect, sourceRect, GraphicsUnit.Pixel); 
        }
    }
}
