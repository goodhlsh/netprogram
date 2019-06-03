using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter0407
{
    class NewMailEventArgs : EventArgs
    {
        private readonly string m_from;
        private readonly string m_to;
        private readonly string m_subject;
        public NewMailEventArgs(string from, string to, string subject)
        {
            m_from = from;
            m_to = to;
            m_subject = subject;
        }
        public string From { get { return m_from; } }
        public string To { get { return m_to; } }
        public string Subject { get { return m_subject; } }
    }

    delegate void NewMailEventHandler(object sender, NewMailEventArgs e); //事件所用的委托
    class MailManager    //提供事件的类
    {
        public event NewMailEventHandler NewMail;
        //通知已订阅事件的对象
        protected virtual void OnNewMail(NewMailEventArgs e)
        {
            NewMailEventHandler temp = NewMail; //MulticastDelegate一个委托链表
            //通知所有已订阅事件的对象
            if (temp != null)
                temp(this, e); //通过事件NewMail(一种特殊的委托)逐一回调客户端的方法
        }
        //提供一个方法，引发事件
        public void SimulateNewMail(string from, string to, string subject)
        {
            NewMailEventArgs e = new NewMailEventArgs(from, to, subject);
            OnNewMail(e);
        }
    }

    class Fax
    {
        public Fax(MailManager mm)
        {   //Subscribe 
            mm.NewMail += new NewMailEventHandler(Fax_NewMail);
        }
        private void Fax_NewMail(object sender, NewMailEventArgs e)
        {
            Console.WriteLine("Message arrived at Fax...");
            Console.WriteLine("From={0}, To={1}, Subject='{2}'", e.From, e.To, e.Subject);
        }
        public void Unregister(MailManager mm)
        {
            mm.NewMail -= new NewMailEventHandler(Fax_NewMail);
        }
    }
    class Print
    {
        public Print(MailManager mm)
        {  //Subscribe ,在mm.NewMail的委托链表中加入Print_NewMail方法
            mm.NewMail += new NewMailEventHandler(Print_NewMail);
        }
        private void Print_NewMail(object sender, NewMailEventArgs e)
        {
            Console.WriteLine("Message arrived at Print...");
            Console.WriteLine("From={0}, To={1}, Subject='{2}'", e.From, e.To, e.Subject);
        }
        public void Unregister(MailManager mm)
        {
            mm.NewMail -= new NewMailEventHandler(Print_NewMail);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MailManager mm = new MailManager();
            if (true)
            {
                Fax fax = new Fax(mm);
                Print prt = new Print(mm);
            }

            mm.SimulateNewMail("Zeng Xianquan", "Cao Yusong", "事件测试");
            Console.ReadLine();

        }
    }
}
