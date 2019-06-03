using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0303
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUM = 3;  //学生人数
            string[,] student = new string[NUM, 7];  //二维数组声明
            InputStudent(student, NUM);     //调用学生信息输入方法
            OutputStudent(student, NUM);    //调用学生信息输出方法
        }
        //学生信息输入方法
        static void InputStudent(string[,] student, int num)
        {
            int temp;
            string strStudent = string.Empty;
            string[] strInfo;

            for (int i = 0; i < num; i++)   //重复输入学生信息        
            {
                Console.Write("输入第{0}个学生信息（以顿号分割）：", i + 1);
                strStudent = Console.ReadLine();
                strInfo = strStudent.Split('、');   //分隔字符串
                for (int j = 0; j < strInfo.Length; j++)
                {
                    student[i, j] = strInfo[j];
                }               
                //计算总分
                temp = Convert.ToInt32(student[i, 2]) + Convert.ToInt32(student[i, 3]) + Convert.ToInt32(student[i, 4]);
                student[i, 5] = Convert.ToString(temp);
                student[i, 6] = string.Format("{0:F2}", temp/3.0);
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
                Console.WriteLine("|{0,8}|{1,3}|{2,4}|{3,4}|{4,4}|{5,5}|{6,6:f2}|", student[i, 0], student[i, 1],
              student[i, 2], student[i, 3], student[i, 4], student[i, 5], student[i, 6]);
                Console.WriteLine("|-------------------------------------------|");
            }
        }
    }
}
