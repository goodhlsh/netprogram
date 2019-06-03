using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prpject0405
{
    //水壶类
       public class Heater
    {
        private int temperature;
        //声明委托
        public delegate void BoiledEventHandler(Object sender, BoiledEventArgs e);
        public event BoiledEventHandler Boiled;//声明事件
        //参数类
        public class BoiledEventArgs : EventArgs
        {
            public readonly int temperature;
            public BoiledEventArgs(int temperature)
            {
                this.temperature = temperature;
            }
        }

        public void BoiledWater()
        {
            for (int i = 0; i <= 100; i++)
            {
                temperature = i;
                if (temperature >= 95)
                {
                    BoiledEventArgs e = new BoiledEventArgs(temperature);
                    OnBoiled(e); //执行注册到事件对象的所有方法
                }
            }
        }

            protected virtual void OnBoiled(BoiledEventArgs e)
        {
            if (Boiled != null)  //如果有对象注册
            {
                Boiled(this,e);
            }

        }
    }

   

}



