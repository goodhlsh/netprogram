using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0401
{
    internal class Student
    {  //字段定义
        string id;             //学号
        string name;          //姓名
        string chinese;      //语文成绩
        string math;         //数学成绩
        string english;      //英语成绩
        int total;           //总分
        float average;       //平均分
        //构造函数
        public Student(string id,string name,string g1,string g2,string g3)
        {
            this.id = id;
            this.name = name;
            chinese = g1;
            math = g2;
            english = g3;
            total = Convert.ToInt32(g1) + Convert.ToInt32(g2) + Convert.ToInt32(g3);
            average =(float) (total / 3.0);
        }
        //学生成绩输出
        public void OutputStudent()
        {
            Console.WriteLine("             学生成绩单");
            Console.WriteLine("    日期：" + DateTime.Now.ToShortDateString());
            Console.WriteLine("|-------------------------------------------|");
            Console.WriteLine("| 学  号 | 姓名 |语文|数学|英语|总 分|平均分|");
            Console.WriteLine("|-------------------------------------------|");
            Console.WriteLine("|{0,8}|{1,3}|{2,4}|{3,4}|{4,4}|{5,5}|{6,6:f2}|", id, name, chinese, math, english, total, average);
            Console.WriteLine("|-------------------------------------------|");
        }
    }
}
