using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter201
{
    class Program
    {
        static void Main(string[] args)
        {
            string stuid;      //学生学号
            string name;       //学生姓名
            string chinese;    //语文
            string math;       //学生
            string english;    //英语
            int total;         //总分
            double  average;   //平均成绩
  
           Console.Write("学号：");
           stuid = Console.ReadLine();
           Console.Write("姓名：");
           name = Console.ReadLine();
           Console.Write("语文：");
           chinese = Console.ReadLine();
           Console.Write("数学：");
           math= Console.ReadLine();
           Console.Write("英语：");
           english = Console.ReadLine();
           //计算学生总成绩
           total = Int32.Parse(chinese) + Int32.Parse(math) + Int32.Parse(english);
          average = total / 3.0;
          //输出学生成绩
          Console.WriteLine("                学生成绩单");
          Console.WriteLine("|-------------------------------------------|");
          Console.WriteLine("| 学  号 | 姓名 |语文|数学|英语|总 分|平均分|");
          Console.WriteLine("|-------------------------------------------|");
          Console.WriteLine("|{0,8}|{1,3}|{2,4}|{3,4}|{4,4}|{5,5}|{6,6:f2}|",stuid,name,chinese,math,english,total,average);
          Console.WriteLine("|-------------------------------------------|");
          Console.ReadKey();
      }
    }
}
