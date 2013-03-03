using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    // Delegate
    public delegate void TimerDelegate();

    // class Timer
    class Timer
    {
        // Method which will be attached to the delegate 
        private void SayHello()
        {
            Console.WriteLine("Hello! I am timer.");
        }

        public void Sleep(int timeInterval)
        {
            Thread.Sleep(timeInterval);
        }

        // Method where the delegateTimer will be execute at each timeInterval
        public void ExecuteMethod(int timeInterval)
        {
            TimerDelegate delegateTimer = this.SayHello;

            while (true)
            {
                delegateTimer();
                Thread.Sleep(timeInterval);    // Sleeping the execution of the thread
            }
        }
    }
}
