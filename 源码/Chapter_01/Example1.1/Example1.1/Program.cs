using System;

namespace Example1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadLine()的方法
            Console.Write("请输入你的姓名：");//Console.Write()方法是不换行输出信息
            string s = Console.ReadLine();
            //此方法是读取输入的名字并把它存入到字符串s中;
            Console.WriteLine("Hi,{0}.Welcome", s);//Console.WriteLine()是先输出信息再换行
            //Console.read()方法
            Console.Write("请输入你的生日:");
            int i = Console.Read(); //不论输入的是单个字符还是一个字符串，均只输出第一个字符串 
            Console.Write("您的生日是:{0}!", i);
            Console.ReadKey();
        }
    }
}
