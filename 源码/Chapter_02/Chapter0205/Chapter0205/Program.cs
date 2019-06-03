using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter0205
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, min;
            Console.Write("请输入第一个数字：");
            int a = int.Parse(Console.ReadLine());
            Console.Write("请输入第二个数字：");
            int b = int.Parse(Console.ReadLine());
            Console.Write("请输入第三个数字：");
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                max = a;
                min = b;
            }
            else
            {
                max = b;
                min = a;
            }
            if (max < c)
            {
                max = c;
            }
            else if (min > c)
            {
                min = c;
            }
            Console.WriteLine("最大的数字是：{0},最小的数字是：{1}", max, min);
            Console.ReadKey();
        }
    }
}
