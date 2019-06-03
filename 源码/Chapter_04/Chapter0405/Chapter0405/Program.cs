using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter0405
{
    class Program
    {
        public delegate void MyDelegeate(int a, int b); //定义一个委托用来引用max,min
        static void Main(string[] args)
        {
            TestClass tc = new TestClass();
            int i = 10;
            int j = 55;
            MyDelegeate my = tc.Max;
            my(i, j);
            my = tc.Min;
            my(i, j);
            Console.ReadLine();
        }
    }

    class TestClass
    {
        public void Max(int a, int b)
        {
            Console.WriteLine("now call max({0},{1})", a, b);
            int t = a > b ? a : b;
            Console.WriteLine(t);
        }
        public void Min(int a, int b)
        {
            Console.WriteLine("now call min({0},{1})", a, b);
            int t = a < b ? a : b;
            Console.WriteLine(t);
        }
    }

}
