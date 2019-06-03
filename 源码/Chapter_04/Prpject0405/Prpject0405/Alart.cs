using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prpject0405
{
    public class Alart
    {
        public void MakeAlart(Object sender,Heater.BoiledEventArgs  e)
        {
            Heater h = (Heater)sender;

            Console.WriteLine("嘀嘀嘀！水温为" + e.temperature + ",快开啦!");          

        }
    }
}
