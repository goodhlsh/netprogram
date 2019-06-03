using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0202
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;      //用户名
            string passwd;        //密码
            //提示输入用户名和密码
            Console.WriteLine("\n" + "                 欢迎登录学生成绩管理系统V0.8" + "\n");
            Console.Write("请输入用户名：");
            username = Console.ReadLine();
            Console.Write("请输入密码：");
            passwd = Console.ReadLine();
            if (username == "admin" && passwd == "123456")  //判断用户名和密码是否正确
            {
                Console.WriteLine("用户名和密码正确，按任意键登录！");
            }
            else
            {
                Console.WriteLine("用户名或和密码错误，请核对信息！");
            }
            Console.ReadKey();
        }
    }
}
