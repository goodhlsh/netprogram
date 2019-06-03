using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter0208
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance, interestRate, targeBalance;
            Console.Write("请输入账户本金：");
            balance = Convert.ToDouble (Console.ReadLine());
            Console.Write("请输入当前固定利率(%)：");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.Write("请输入您的预期余额：");
            targeBalance = Convert.ToDouble(Console.ReadLine());
            int totalYears = 0;
            do
            {
                balance *= interestRate;
                ++totalYears;
            } while (balance < targeBalance);
            Console.WriteLine("In {0} year{1} you'll have a balance of {2}.",totalYears,totalYears ==1?"":"s",balance);
            Console.ReadKey();
        }
    }
}
