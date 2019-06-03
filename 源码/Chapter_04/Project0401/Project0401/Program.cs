using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0401
{
    class Program
    {
        static void Main(string[] args)
        {
            string id,name,c1,c2,c3;

            Console.Write("输入学生学号：");
            id = Console.ReadLine();
            Console.Write("输入学生姓名：");
            name = Console.ReadLine();
            Console.Write("输入学生语文成绩：");
            c1 = Console.ReadLine();
            Console.Write("输入学生数学成绩：");
            c2 = Console.ReadLine();
            Console.Write("输入学生英语成绩：");
            c3 = Console.ReadLine();
            //建立学生对象
            Student student = new Student(id, name, c1, c2, c3);
            student.OutputStudent();  //调用方法

            Console.ReadKey();
        }
    }
}
