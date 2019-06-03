using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0203
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUM=5;   //学生人数

            string stuID;      //学生学号
            string name;       //学生姓名
            string chinese;    //语文
            string math;       //学生
            string english;    //英语
            int i=0;          //循环变量

            for (i =0; i <NUM; i++)        //开始迭代重复
            {
                Console.Write("请输入第{0}个学生学号：",i+1);
                stuID = Console.ReadLine();
                Console.Write("请输入第{0}个学生姓名：",i+1);
                name = Console.ReadLine();
                Console.Write("请输入第{0}个学生语文成绩：",i+1);
                chinese = Console.ReadLine();
                Console.Write("请输入第{0}个学生数学成绩：",i+1);
                math = Console.ReadLine();
                Console.Write("请输入第{0}个学生英语成绩：",i+1);
                english = Console.ReadLine();               
                
             }
                Console.ReadKey();
        }
    }
}
