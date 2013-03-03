using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    class TimerTest
    {
        static void Main()
        {
            Timer timer = new Timer();
            timer.ExecuteMethod(2000); // time interval: 2 seconds
        }
    }
}
