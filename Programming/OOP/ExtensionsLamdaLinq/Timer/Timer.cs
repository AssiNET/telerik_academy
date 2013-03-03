using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    public delegate void TimerDelegate(int timeInterval);

    class Timer
    {
        public static void SayHello(int timeInterval)
        {
            while (true)
            {
                Console.WriteLine("Hello! I am timer.");
                Thread.Sleep(timeInterval);   
            }
        }

        public void Sleep(int timeInterval)
        {
            Thread.Sleep(timeInterval);
        }
    }
}
