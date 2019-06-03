﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project301
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUM = 3;  //学生人数
            //声明二维数组，存放学生信息
            string[,] student = new string[NUM, 7]; 
            //方法调用
            InputStudent(student,NUM);
            OutputStudent(student,NUM);

            Console.ReadKey();
        }
        //学生信息输入
        static void InputStudent(string[,] student, int num)
        {
            Console.Clear();
            for (int i = 0; i < num; i++)           
            {
                Console.Write("请输入第{0}个学生的学号：", i + 1);
                student[i, 0] = Console.ReadLine();
                Console.Write("请输入第{0}个学生的姓名：", i + 1);
                student[i, 1] = Console.ReadLine();
                Console.Write("请输入第{0}个学生的语文成绩：", i + 1);
                student[i, 2] = Console.ReadLine();
                Console.Write("请输入第{0}个学生的数学成绩：", i + 1);
                student[i, 3] = Console.ReadLine();
                Console.Write("请输入第{0}个学生的英语成绩：", i + 1);
                student[i, 4] = Console.ReadLine();
                //计算总分
                int temp = Convert.ToInt32(student[i, 2]) + Convert.ToInt32(student[i, 3]) + Convert.ToInt32(student[i, 4]);
                student[i, 5] = Convert.ToString(temp);
                student[i, 6] = string.Format("{0:F2}", temp / 3.0);
            }
        }
        //学生信息输出
        static void OutputStudent(string[,] student, int num)
        {
            //输出学生成绩
            Console.WriteLine("                学生成绩单");
            Console.WriteLine("|-------------------------------------------|");
            Console.WriteLine("| 学  号 | 姓名 |语文|数学|英语|总 分|平均分|");
            Console.WriteLine("|-------------------------------------------|");
            for (int i = 0; i < num; i++)
            {

                Console.WriteLine("|{0,8}|{1,3}|{2,4}|{3,4}|{4,4}|{5,5}|{6,6:f2}|", student[i, 0], student[i, 1], student[i, 2], student[i, 3], student[i, 4], student[i, 5], student[i, 6]);
                Console.WriteLine("|-------------------------------------------|");
            }
        }
    }
}
