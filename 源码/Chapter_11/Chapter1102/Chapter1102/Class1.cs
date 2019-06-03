using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1102
{
    class Class1
    {
        public volatile bool isStop;
        private Form1 form1;

        public Class1 (Form1 form1)
        {
            this.form1 = form1;
        }

        public  void Method1(Object obj)
        {
            string str = obj as string;
            form1.AddMessage(str);

            while (isStop == false)
            {
                Thread.Sleep(100);
                form1.AddMessage("A");                
            }
            form1.AddMessage("\n 线程A已被终止！\n");  
        }
        public void Method2()
        {       
             while (isStop == false)
            {
                Thread.Sleep(100);
                form1.AddMessage("B");                
            }
             form1.AddMessage("\n 线程B已被终止！\n");  
        }
    }
}
