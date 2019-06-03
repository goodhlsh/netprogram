using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prpject0405
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Prpject0405.Heater();
            Alart alart = new Prpject0405.Alart();

            heater.Boiled += alart.MakeAlart;   //注册事件
            heater.Boiled += Display.ShowMsg;  //注册静态方法

            heater.BoiledWater();   //烧水

            Console.ReadKey();
        }
    }
}
