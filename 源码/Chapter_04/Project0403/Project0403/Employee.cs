using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0403
{
    class Employee
    {
        protected  string name;  //姓名
        protected  float  salary; //工资
        public Employee(string name)
        {
           this.name = name; 
           salary =0F;
        }
         public virtual void  Earnings() //计算工资虚方法
        {
        }
         public void PrintSalary()  //输出工资
        {
          Console.WriteLine("              工资单");
          Console.WriteLine("   |--------------------------------|");
          Console.WriteLine("   | 姓  名 | 职   务 |    工  资   |");
          Console.WriteLine("   |--------------------------------|");
        }
      }
} 

  
