using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter0207
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入学员成绩：");
            int grade = Convert.ToInt32(Console.ReadLine());
            switch (grade / 10)
            {
                case 10:
                case 9:
                    Console.WriteLine("成绩：{0}  等级：A",grade);
                    break;
                case 8:
                     Console.WriteLine("成绩：{0}  等级：B",grade);
                    break;
                case 7:
                    Console.WriteLine("成绩：{0}  等级：C",grade);
                    break;
                case 6:
                    Console.WriteLine("成绩：{0}  等级：D",grade);
                    break;
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("成绩：{0}  等级：E",grade);
                    break;
                default:
                    Console.WriteLine("输入成绩错误！");
                    break;
            }
        }
    }
}
