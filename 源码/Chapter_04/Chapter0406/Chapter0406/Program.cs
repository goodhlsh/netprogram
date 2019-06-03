using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter0406
{
    public delegate void MyDelegate(string name);
    public class PersonManager
    {
        public event MyDelegate MyEvent;

        //执行事件  
        public void Execute(string name)
        {
            if (MyEvent != null)
                MyEvent(name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            //绑定事件处理方法  
            personManager.MyEvent += new MyDelegate(GetName);
            personManager.Execute("Leslie");
            Console.ReadKey();
        }

        public static void GetName(string name)
        {
            Console.WriteLine("My name is " + name);
        }
    }
}
