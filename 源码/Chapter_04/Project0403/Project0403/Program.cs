using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0403
{
    class Program
    {
        static void Main(string[] args)
        { 
            //实例化对象
            Boss boss = new Boss("雷君威"); 
            CommissionWorker comm = new CommissionWorker("张治国", 3000);
            Employee e =boss as Employee;
            //调用方法
            boss.Earnings();           
            comm.Earnings();
            
            e.PrintSalary();
            boss.PrintSalary();
            comm.PrintSalary();

            Console.ReadKey();
        }
    }
}
