using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prpject0405
{
    public class Display
    {
        public static void ShowMsg(Object sender, Heater.BoiledEventArgs e)
        {
            Heater h = (Heater)sender;

            Console.WriteLine("水快开啦，当前水温为{0} 摄氏度.\n",e.temperature);
           
        }
    }
}
