using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter0209
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, p, sum = 0;  //变量定义
            //使用for循环计算1到10以内的数字的阶乘
            for (i = 1; i <= 10; i++)
            {
                p = 1;
                for(j=1;j<=i;j++)
                {
                    p = p * j;
                }
                sum = sum + p;
            }
            Console.WriteLine("1!+2!+...+10!={0}", sum);   //输出结果
            Console.ReadKey();
        }
    }
}
