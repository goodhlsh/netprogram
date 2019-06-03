using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter0210
{
    class Program
    {
        static void Main(string[] args)
        {
          int Letters = 0;    // 存放字母的个数 
	      int Digits = 0;  	// 存放数字的个数
	      int Punctuations = 0;	// 存放标点符号的个数
	
            Console.Write("请输入一个字符串： ");
	        string  inString = Console.ReadLine();		
	       // 声明 foreach 循环以遍历输入的字符串中的每个字符。 
	       foreach(char ch in inString)
	      {
	     	if(char.IsLetter(ch))         // 检查字母
		       Letters++;
		   if(char.IsDigit(ch))           // 检查数字
	           Digits++;
		    if(char.IsPunctuation(ch))    // 检查标点符号
		         Punctuations++;
	     }
	     Console.WriteLine("字母个数为： {0}", Letters);
	     Console.WriteLine("数字个数为： {0}", Digits);
	     Console.WriteLine("标点符号个数为： {0}",Punctuations);
         Console.ReadKey();
        }
    }
}
