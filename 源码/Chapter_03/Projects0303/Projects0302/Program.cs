using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects0302
{
    class Program
    {
        public struct Student   //学生结构体定义
        {
           public  string id;
           public  string name;
           public  string grade1;
           public  string grade2;
           public  string grade3;
           public  int total;
           public  float average;
        }
        static void Main(string[] args)
        {
            const int NUM = 3;    //学生人数
            Student stu;         //声明学生结构
            List<Student> listStudent = new List<Student>();  //建立学生列表

            for (int i = 0; i < NUM; i++)   //输入学生信息        
            {
                Console.Write("输入第{0}个学生学号：", i + 1);
                stu.id = Console.ReadLine();
                Console.Write("输入第{0}个学生姓名：", i + 1);
                stu.name = Console.ReadLine();
                Console.Write("输入第{0}个学生语文成绩：", i + 1);
                stu.grade1 = Console.ReadLine();
                Console.Write("输入第{0}个学生数学成绩：", i + 1);
                stu.grade2 = Console.ReadLine();
                Console.Write("输入第{0}个学生英语成绩：", i + 1);
                stu.grade3 = Console.ReadLine();
                //计算总分和平均分
                stu.total = Convert.ToInt32(stu.grade1) + Convert.ToInt32(stu.grade2) + Convert.ToInt32(stu.grade3);
                stu.average = (float)(stu.total / 3.0);

                listStudent.Add(stu);  //添加学生到学生列表
            }
            //输出学生成绩
            Console.WriteLine("                学生成绩单");
            Console.WriteLine("|-------------------------------------------|");
            Console.WriteLine("| 学  号 | 姓名 |语文|数学|英语|总 分|平均分|");
            Console.WriteLine("|-------------------------------------------|");
            foreach (var s in listStudent)
            {
                Console.WriteLine("|{0,8}|{1,3}|{2,4}|{3,4}|{4,4}|{5,5}|{6,6:f2}|", s.id, s.name, s.grade1, s.grade2, s.grade3, s.total, s.average);
                Console.WriteLine("|-------------------------------------------|");
            }
        }
      }
    }
