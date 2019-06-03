using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0402
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();   //实例化学生对象
           
            Console.Write("输入学生学号：");
            student.ID = Console.ReadLine();
            Console.Write("输入学生姓名：");
            student.Name = Console.ReadLine();
            Console.Write("输入学生语文成绩：");
            student.Grade1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("输入学生数学成绩：");
            student.Grade2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("输入学生英语成绩：");
            student.Grade3 = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
