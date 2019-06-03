using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Chapter1001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            SolidBrush sdBrush1 = new SolidBrush(Color.Red);
            SolidBrush sdBrush2 = new SolidBrush(Color.Green);
            SolidBrush sdBrush3 = new SolidBrush(Color.Blue);
            g.FillEllipse(sdBrush2, 20, 40, 60, 70);
            Rectangle rect = new Rectangle(0, 0, 200, 100);
            g.FillPie(sdBrush3, 0, 0, 200, 40, 0.0f, 30.0f);
            PointF point1 = new PointF(50.0f, 250.0f);
            PointF point2 = new PointF(100.0f, 25.0f);
            PointF point3 = new PointF(150.0f, 40.0f);
            PointF point4 = new PointF(250.0f, 50.0f);
            PointF point5 = new PointF(300.0f, 100.0f);
            PointF[] curvePoints = { point1, point2, point3, point4, point5 };
            g.FillPolygon(sdBrush1, curvePoints);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            HatchBrush hBrush1 = new HatchBrush(HatchStyle.DiagonalCross, Color.Chocolate, Color.Red);
            HatchBrush hBrush2 = new HatchBrush(HatchStyle.DashedHorizontal,
            Color.Green, Color.Black);
            HatchBrush hBrush3 = new HatchBrush(HatchStyle.Weave,
            Color.BlueViolet, Color.Blue);
            g.FillEllipse(hBrush1, 20, 80, 60, 20);
            Rectangle rect = new Rectangle(0, 0, 200, 100);
            g.FillPie(hBrush3, 0, 0, 200, 40, 0.0f, 30.0f);
            PointF point1 = new PointF(50.0f, 250.0f);
            PointF point2 = new PointF(100.0f, 25.0f);
            PointF point3 = new PointF(150.0f, 40.0f);
            PointF point4 = new PointF(250.0f, 50.0f);
            PointF point5 = new PointF(300.0f, 100.0f);
            PointF[] curvePoints = { point1, point2, point3, point4, point5 };
            g.FillPolygon(hBrush2, curvePoints); 

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            //根据文件名创建原始大小的bitmap对象
            Bitmap bitmap = new Bitmap(@"E:\Books\Program\Chapter_10\mm.jpg");
            //将其缩放到当前窗体大小
            bitmap = new Bitmap(bitmap, this.ClientRectangle.Size);
            TextureBrush myBrush = new TextureBrush(bitmap);
            g.FillEllipse(myBrush, this.ClientRectangle);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            Point centerPoint = new Point(150, 100);
            int R = 60;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(centerPoint.X - R, centerPoint.Y - R, 2 * R, 2 * R);
            PathGradientBrush brush = new PathGradientBrush(path);
            //指定路径中心点
            brush.CenterPoint = centerPoint;
            //指定路径中心的颜色
            brush.CenterColor = Color.Red;
            //Color类型的数组指定与路径上每个顶点的颜色
            brush.SurroundColors = new Color[] { Color.Plum };
            g.FillEllipse(brush, centerPoint.X - R, centerPoint.Y - R, 2 * R, 2 * R);
            centerPoint = new Point(350, 100);
            R = 20;
            path = new GraphicsPath();
            path.AddEllipse(centerPoint.X - R, centerPoint.Y - R, 2 * R, 2 * R);
            path.AddEllipse(centerPoint.X - 2 * R, centerPoint.Y - 2 * R, 4 * R, 4 * R);
            path.AddEllipse(centerPoint.X - 3 * R, centerPoint.Y - 3 * R, 6 * R, 6 * R);
            brush = new PathGradientBrush(path);
            brush.CenterPoint = centerPoint;
            brush.CenterColor = Color.Red;
            brush.SurroundColors = new Color[] { Color.Black, Color.Blue, Color.Green };
            g.FillPath(brush, path);

        }
    }
}
