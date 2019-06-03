using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter0211
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;   //统计奇数的个数
            float sum = 0;   //奇数的和
            int number;
            bool flag=true;    //循环结束标志
            
            while(flag==true)
            {
                Console.Write("请输入整数：");
                number = Convert.ToInt32(Console.ReadLine());
                if (number ==-1)
                {
                    break;   //输入-1，结束循环
                }
                else if (number %2==0)
                {
                    continue;    //如果是偶数，开始下一次循环
                }
                count++;
                sum += number;
            }
            Console.WriteLine("您一共输入了{0}个奇数，它们的平均值为{1:F2}.", count,sum / count);
            Console.ReadKey();
        }
    }
}
