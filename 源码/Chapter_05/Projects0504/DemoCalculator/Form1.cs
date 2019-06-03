using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DemoCalculator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 从Win32 SDK中引入播放报警声音的系统函数  
        /// </summary>
       [DllImport("user32.dll")]
        public static extern int MessageBeep(uint n);

        //计算器运算操作标志枚举
        private enum Operators
        {
             None, Add, Sub, Div, Mult        
        }
        private decimal firstNumber = 0;  //保存第一个数字
        private Operators operators = Operators.None;  //保存运算操作
        private bool needClear = true;   //是否需要清屏
        /// <summary>
        /// 构造函数
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 处理按钮点击事件的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;   // 得到本次点击的按钮实例引用(通过sender参数)
            // 根据按钮上的文本, 进行分支处理 
            switch (btn.Text.Trim())
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    if (this.needClear)
                    {
                        this.txtResult.Text = btn.Text;
                        this.needClear = false;
                    }
                    else
                    {
                        this.txtResult.Text += btn.Text;
                    }
                   break;
                case ".":
                    if (this.txtResult.Text.IndexOf('.') >= 0)
                    {
                        MessageBeep(0xFFFFFFFF); //如果文本框内已经有一个小数点, 则发出警报声
                    }
                    else
                    {
                        this.txtResult.Text += btn.Text; //在文本框字符串末尾增加小数点字符
                    }
                    break;
                case "Back":
                    if (this.txtResult.Text.Length > 1)
                    { // 如果文本框字符串长度大于1个字符, 则删除最后一个字符
                        this.txtResult.Text = this.txtResult.Text.Remove(this.txtResult.Text.Length - 1);
                    }
                    else
                    {
                        this.txtResult.Text = "0";  // 如果文本框字符串只剩1个字符, 则将文本框设置为字符"0"  
                        this.needClear = true;
                    }
                    break;
                case "+":
                    // 将文本框字符串转为数字类型保存在firstNumber字段中
                    this.firstNumber = decimal.Parse(this.txtResult.Text);
                    this.operators = Operators.Add; // 设置操作标志为Add  
                    this.needClear = true;
                    break;
                case "-":
                    this.firstNumber = decimal.Parse(this.txtResult.Text);
                    this.operators = Operators.Sub;
                    this.needClear = true;
                    break;
                case "*":
                    this.firstNumber = decimal.Parse(this.txtResult.Text);
                    this.operators = Operators.Mult;
                    this.needClear = true;
                    break;
                case "/":
                    this.firstNumber = decimal.Parse(this.txtResult.Text);
                    this.operators = Operators.Div;
                    this.needClear = true;
                    break;
                    case "=":
                    {
                        decimal secondNumber = decimal.Parse(this.txtResult.Text);
                        switch (this.operators)
                        {
                            case Operators.Add:
                                this.firstNumber += secondNumber;
                                break;
                            case Operators.Sub:
                                this.firstNumber += secondNumber;
                                break;
                            case Operators.Div:
                                this.firstNumber /= secondNumber;
                                break;
                            case Operators.Mult:
                                this.firstNumber *= secondNumber;
                                break;
                        }
                        // 在文本框中显示firstNumber字段的内容 
                        this.txtResult.Text = this.firstNumber.ToString();
                        this.needClear = true;
                    }
                    break;
                case "CE":
                    // CE按钮清除以前所有的操作和屏幕显示 
                    this.firstNumber = 0;
                    this.needClear = true;
                    this.txtResult.Text = "0";
                    this.operators = Operators.None;
                    break;
                case "C":
                    // C按钮只清除屏幕显示, 运算类型和上一次输入数字不清除 
                    this.txtResult.Text = "0";
                    this.needClear = true;
                    break;
                case "+/-":
                    // 根据文本框字符串第一个字符是否为-号字符, 对文本框字符串进行处理
                    if (this.txtResult.Text[0] == '-')
                    {
                        this.txtResult.Text = this.txtResult.Text.Remove(0,1);
                    }
                    else
                    {
                        this.txtResult.Text = this.txtResult.Text.Insert(0, "-");
                    }
                    break;
                    }
        }
    }
}
