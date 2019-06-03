using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projects0504
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }
        //单击数字命令按钮的事件处理程序
        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;

            if (textBox1.Text != "")
                textBox1.Text += b1.Text;
            else
                textBox1.Text = b1.Text;
        }
        //单击运算符命令按钮的事件处理程序
        private void btnOp_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            textBox1.Text = textBox1.Text + " " + btn.Text + " ";//空格用于分隔数字各运算符               
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
             textBox1.Text = textBox1.Text + ".";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double  r;                      //用于保存计算结果
            string t = textBox1.Text;　　  //t用于保存文本框中的算术表达式
            int space = t.IndexOf(' ');   //用于搜索空格位置
            string s1 = t.Substring(0, space);//s1用于保存第一个运算数
            char op = Convert.ToChar(t.Substring(space + 1, 1));  //op用于保存运算符
            string s2 = t.Substring(space + 3);    //s2用于保存第二个运算数
            double arg1 = Convert.ToDouble(s1);  //将运算数从string转换为double
            double arg2 = Convert.ToDouble(s2);

            switch (op)
           {
            case '+':
              r = arg1 + arg2;
              break;
           case '-':
               r = arg1 - arg2;
               break;
            case '*':
                r = arg1 * arg2;
                break;
            case '/':
                if (arg2 == 0)
                {
                    throw new ApplicationException();
                }
                else
                {
                    r = arg1 / arg2;
                    break;                }
                
            default:
                throw new ApplicationException();
           }
            textBox1.Text = textBox1.Text+" = "+ r.ToString();
        }
    }
}
