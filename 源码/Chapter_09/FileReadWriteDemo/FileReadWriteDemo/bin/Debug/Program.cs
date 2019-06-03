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
            byte[] byData = new byte[200];
            char[] charData = new Char[200];

            try
            {
                FileStream aFile = new FileStream("Program.cs", FileMode.Open);
                aFile.Seek(135, SeekOrigin.Begin);
                aFile.Read(byData, 0, 200);
            }
            catch (IOException e)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(e.ToString());
                Console.ReadKey();
                return;
            }

            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(byData, 0, byData.Length, charData, 0);

            Console.WriteLine(charData);
            Console.ReadKey();

        }
    }
}
