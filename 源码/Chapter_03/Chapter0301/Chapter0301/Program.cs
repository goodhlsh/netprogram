using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter0301
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = new int[11];  //声明数组
            Random  ram=new Random ();      //随机数对象
          
            for (int i = 0; i < 10; i++)     //利用循环完成数组初始化
            {
                myIntArray[i] = ram.Next(100, 999); //随机生成（100，99）之间的整数
            }

            Console.WriteLine("插入前的数组：");
            foreach (int m in myIntArray )  //遍历数组
            {
                Console.Write("{0,4}",m);    //输出数组元素的值
            }

            Console.Write("\n 输入插入位置（0-9）：");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.Write(" 输入插入数据：");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int k=myIntArray.Length-1;k>pos;k--)  //数组元素移位
            {
                myIntArray[k] = myIntArray[k - 1];
            }
            myIntArray[pos] = number;
            Console.WriteLine("插入后的数组：");
            foreach (int m in myIntArray)  //遍历数组
            {
                Console.Write("{0,4}", m);    //输出数组元素的值
            }
            Console.ReadKey();
        }
    }
}
