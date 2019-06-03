using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0404
{
    //定义委托类型
    delegate bool Comparison(object x, object y);    
    class Program
    {      
        static void Main(string[] args)
        {
            Employee[] employees = { new Employee("张薇薇", 20000),new Employee("张玮玮", 10000), new Employee("张巍巍", 25000), new Employee("张伟伟", 50000) };

            BubbleSorter.Sort(employees, Employee.CompareSalary); 

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.ReadKey();
        }
    }
    class BubbleSorter
    {
        static public void Sort(object[] sortArray, Comparison comparison)
        {
            for (int i = 0; i < sortArray.Length; i++)
            {
                for (int j = i + 1; j < sortArray.Length; j++)
                {
                    if (comparison(sortArray[j], sortArray[i]))
                    {
                        object temp = sortArray[i];
                        sortArray[i] = sortArray[j];
                        sortArray[j] = temp;
                    }
                }
            }
        }
    }
    class Employee
    {
        private string name;
        private decimal salary;

        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1:C}", name, salary);
        }

        public static bool CompareSalary(object x, object y)
        {
            Employee e1 = (Employee)x;
            Employee e2 = (Employee)y;

            return (e1.salary < e2.salary);
        }
    }
}
