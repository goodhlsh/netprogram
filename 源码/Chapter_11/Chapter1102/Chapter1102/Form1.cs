using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Chapter1102
{
    public partial class Form1 : Form
    {
        
        Thread thread1, thread2;
        Class1 cl;

        private delegate void AddMessageDelegate(string msg);

        public void AddMessage(string msg)
        {
            if (this.richTextBox1.InvokeRequired)
            {
                Action<string> actionDelegate = (x) => { this.richTextBox1.AppendText(x.ToString()); };
                this.richTextBox1.Invoke(actionDelegate, msg);
            }
            else
            {
                this.richTextBox1.AppendText (msg);
            }
        }
        public Form1()
        {
            InitializeComponent();
            cl = new Class1(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            cl.isStop = false;
            thread1 = new Thread(cl.Method1);
            thread1.IsBackground = true;

            thread2 = new Thread(cl.Method2);
            thread1.IsBackground = true;
            thread1.Start("线程A开始执行！\n");
            thread2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cl.isStop = true;
            thread1.Join(0);
            thread2.Join(0);
        }      
    }
}
