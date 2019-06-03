using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter0403
{
    public class Shape
    {
        //虚方法
        public virtual void Draw()
        {
            Console.WriteLine("完成基类的画图任务！");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            // 画圆的代码
            Console.WriteLine("正在绘制圆形！");
            base.Draw();
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            // 画矩形代码
            Console.WriteLine("正在绘制矩形！");
            base.Draw();
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            // 多边形代码
            Console.WriteLine("正在绘制多边形！");
            base.Draw();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<Shape> shapes = new System.Collections.Generic.List<Shape>();
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());
            shapes.Add(new Circle());

            // 多态机制：调用每个派生类重写的虚方法
            foreach (Shape s in shapes)
            {
                s.Draw();
            }
            Console.ReadKey();
        }
    }
}
