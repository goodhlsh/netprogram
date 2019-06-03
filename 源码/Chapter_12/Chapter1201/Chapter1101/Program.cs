using System;
using System.Windows;


namespace Chapter1101
{
    static class Program
    {
        [STAThread]
       static void Main()
         {
             // 定义Application对象作为整个应用程序入口  
             Application App = new Application();
             //指定Application对象的MainWindow属性为启动窗体，然后调用无参数的Run方法
             MainWindow mw = new MainWindow();
             App.MainWindow = mw;
             mw.Show();
             App.Run();
         }
    }
}
