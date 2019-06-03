using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0402
{
    class Student
    {   //字段
        string id;
        string name;
        int grade1;
        int grade2;
        int grade3;
        //属性
        public string ID
        { 
          get { return id; }
          set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Grade1
        {
            get { return grade1; }
            set
            {
                if (value >= 0 && value <= 100) grade1 = value;
                else
                {
                    Console.WriteLine("数据不符合要求！"); return;
                }
            }
        }
        public int Grade2
        {
            get { return grade2; }
            set
            {
                if (value >= 0 && value <= 100) grade2 = value;
                else
                {
                    Console.WriteLine("数据不符合要求！"); return;
                }
            }
        }
        public int Grade3
        {
            get { return grade3; }
            set
            {
                if (value >= 0 && value <= 100) grade3 = value;
                else
                {
                    Console.WriteLine("数据不符合要求！"); return;
                }
            }
        }
    }
}
