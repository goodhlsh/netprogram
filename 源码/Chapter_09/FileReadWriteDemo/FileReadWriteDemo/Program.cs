using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReadWriteDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取随机文件
            byte[] byData = new byte[200];
            char[] charData = new Char[200];
            Console.WriteLine("\n 从文件中读取数据示例。读取数据如下：");
            Console.WriteLine("-----------------------------------------------------");
            try
            {
                FileStream aFile = new FileStream("Program.cs", FileMode.Open);
                aFile.Seek(135, SeekOrigin.Begin);   //文件指针移动到文件的第135个字节
                aFile.Read(byData, 0, 200);         //200个字节读入到byData字节数组中
            }
            catch (IOException e)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(e.ToString());
                Console.ReadKey();
                return;
            }
            //将字节流转成字符
            Decoder d = Encoding.UTF8.GetDecoder(); 
            d.GetChars(byData, 0, byData.Length, charData, 0);
            //输出字符
            Console.WriteLine(charData);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\n 向文件中写入数据示例程序开始");
             try
            {
                FileStream aFile = new FileStream("Temp.txt", FileMode.Create);
                charData = "My pink half of the drainpipe.".ToCharArray();
                byData = new byte[charData.Length];
                Encoder e = Encoding.UTF8.GetEncoder();
                e.GetBytes(charData, 0, charData.Length, byData, 0, true);
                //移动文件指针到文件开始位置
                aFile.Seek(0, SeekOrigin.Begin);
                aFile.Write(byData, 0, byData.Length);
            }
            catch (IOException ex)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }
    }
}
