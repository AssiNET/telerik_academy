using MobileDevice.Gsm;
using System;
using System.Linq;
using System.Text;
using System.Threading;

namespace GsmCallHistoryTest
{
    class GsmCallHistoryTest
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
            Console.OutputEncoding = Encoding.UTF8;

            Gsm gsm = new Gsm("N95", "Nokia");

            gsm.AddCall(DateTime.Now, "0883442233", 30);
            gsm.AddCall(DateTime.Now, "0883442233", 30);
            gsm.AddCall(DateTime.Now, "0883442233", 30);
            gsm.AddCall(DateTime.Now, "0883442233", 60);
            gsm.AddCall(DateTime.Now, "0883442233", 30);
            gsm.AddCall(DateTime.Now, "0883442233", 30);

            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine("Date:{0}\nTime:{1}\nPhone Number:{2}\nDuration:{3}s\n", call.CallDate, call.CallTime, call.DialedNumber, call.Duration);
            }

            Console.WriteLine(gsm.GetTotalPrice(0.37M));

            RemoveLongestCall(gsm);

            Console.WriteLine(gsm.GetTotalPrice(0.37M));

            Console.WriteLine();

            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine("Date:{0}\nTime:{1}\nPhone Number:{2}\nDuration:{3}s\n", call.CallDate, call.CallTime, call.DialedNumber, call.Duration);
            }

            gsm.ClearCallHistory();
        }
  
        static void RemoveLongestCall(Gsm gsm)
        {
            Call[] calls = gsm.CallHistory.ToArray();
            Array.Sort(calls, (x, y) => x.Duration.CompareTo(y.Duration));                 // Using lamda expresion in order to sort the array
            gsm.CallHistory = calls.ToList();
            gsm.CallHistory.RemoveAt(gsm.CallHistory.Count - 1);
        }
    }
}