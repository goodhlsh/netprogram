using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0403
{
    class Boss:Employee 
    {
        public Boss(string name) : base(name) { }
        public override void Earnings()  //重写基类同名虚方法
        {
            this.salary = 5000.00F;
        }
        new public void PrintSalary()  
        {
            //base.PrintSalary();
            Console.WriteLine("   | {0,3} | 管理人员 |  {1,8:F2}  |",name,salary );
            Console.WriteLine("   |--------------------------------|");
        }
     }  
}
