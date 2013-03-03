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
        static void Main(string[] args)
        {
            TimerDelegate timerDelegate = new TimerDelegate(Timer.SayHello);

            timerDelegate(2000);
        }
    }
}
