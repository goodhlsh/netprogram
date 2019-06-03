using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter0206
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("请输入你的年龄：");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 18)  
            {
                if (number>=18 && number<=30)    //判断是否在18和30岁之间
                  Console.WriteLine("你的年龄为{0}，你现在正处于努力奋斗的黄金阶段，继续努力！", number);
                else if (number >= 18 && number <= 50)   //判断是否在18和50岁之间
                    Console.WriteLine("你的年龄为{0}，你现在正处于人生的黄金阶段，珍惜当下！", number);
                else
                    Console.WriteLine("你的年龄为{0}，最美不过夕阳红！", number);
            }
            else if (number < 6 && number > 0)   //判断是否在0和6岁之间
            {
                Console.WriteLine("你的年龄为{0}，呵呵，你还是个小朋友呢！", number);
            }
            else
            {
                Console.WriteLine("你的年龄为{0}，不好意思，你还没成年！", number);
            } 
        }
    }
}
