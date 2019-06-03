using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter0401
{
    class Program
    {
        static void SquareIt(int x)  //参数x通过值传递
        {
            x *= x;
            System.Console.WriteLine("The value of n is {0} inside the method.", x);
        }

        static void Main(string[] args)
        {
            int n = 5;  //局部变量的定义
            System.Console.WriteLine("The value of n is {0} before calling the method. ", n);

            SquareIt(n);  // 通过值传递调用方法
            System.Console.WriteLine("The value of n is {0} after calling the method.", n);

            System.Console.ReadKey();

        }
    }
}
