using System;
using System.Windows;
using System.Windows.Controls;

namespace Projects1102
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 清空操作
        /// </summary>
        /// <param name="sender">btnClearAll</param>
        /// <param name="e">RoutedEventArgs</param>
        private void btnClearAll_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtShow.Text.Length != 0)
            {
                txtShow.Text = "";
            }
        }

        /// <summary>
        /// 向右删除
        /// </summary>
        /// <param name="sender">btnClearLeft</param>
        /// <param name="e">RouteEventArgs</param>
        private void btnClearLeft_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtShow.Text.Length > 0)
            {
                txtShow.Text = txtShow.Text.Substring(0, txtShow.Text.Length - 1);
            }
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender">btnExit</param>
        /// <param name="e">RouteEventArgs</param>
        private void btnExit_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            txtShow.Text += btn.Content;
        }

        private void Button_Click_Result(object sender, RoutedEventArgs e)
        {
            try
            {
                //1.是否符合规范
                if (IsCorrect(txtShow.Text))
                {
                    Result(txtShow.Text);
                }
                else
                {
                    txtShow.Text = "不符合规范";
                }
            }
            catch (Exception ex)
            {
                txtShow.Text = ex.Message;
            }
        }

        /// <summary>
        ///判断是否符合规范
        /// </summary>
        /// <param name="str">操作符内容</param>
        /// <returns></returns>
        public bool IsCorrect(string str)
        {
            bool isCorrect = false;
            char[] txtArr = str.ToCharArray();
            int length = txtArr.Length;
            //首尾必须为数字
            if (Char.IsNumber(txtArr[0]) && Char.IsNumber(txtArr[length - 1]))
            {
                int num = 0;
                foreach (char item in txtArr)
                {
                    if (item.Equals('+') || item.Equals('-') || item.Equals('*') || item.Equals('/'))
                    {
                        num += 1;
                    }
                }
                //排除不含操作符和含有多个操作符的可能
                if (num != 1)
                {
                    isCorrect = false;
                }
                else
                {
                    isCorrect = true;
                }
            }
            else
            {
                isCorrect = false;
            }
            return isCorrect;
        }

        public void Result(string str)
        {
            int index = 0;
            string operate;

            if (str.Contains("+"))
            {
                index = str.IndexOf("+");
            }
            else if (str.Contains("-"))
            {
                index = str.IndexOf("-");
            }
            else if (str.Contains("*"))
            {
                index = str.IndexOf("*");
            }
            else if (str.Contains("/"))
            {
                index = str.IndexOf("/");
            }

            operate = str.Substring(index, 1);
            double p1 = Convert.ToDouble(str.Substring(0, index));
            double p2 = Convert.ToDouble(str.Substring(index + 1, str.ToCharArray().Length - index - 1));
            switch (operate)
            {
                case "+":
                    txtShow.Text += " = " + (p1 + p2);
                    break;
                case "-":
                    txtShow.Text += " = " + (p1 - p2);
                    break;
                case "*":
                    txtShow.Text += " = " + (p1 * p2);
                    break;
                case "/":
                    if (p2 == 0)
                    {
                        txtShow.Text += "除数不能为0";
                    }
                    else
                    {
                        txtShow.Text += " = " + (p1 / p2);
                    }
                    break;
            }
        }
    }
}
