using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0403
{
    class CommissionWorker : Employee 
    {
        private int quantity;
        public CommissionWorker(string name, int quantity)
            : base(name)
        {
            this.quantity = quantity;
        }
        public override void Earnings()   //重写基类同名虚方法
        {
            this.salary =(float) (2000 + quantity * 12.00 * 0.05);
        }
        new public void PrintSalary()
        {
             Console.WriteLine("   | {0,3} | 销售人员 |  {1,8:F2}  |", name, salary);
            Console.WriteLine("   |--------------------------------|");
        }
    }
}
