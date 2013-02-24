using MobileDevice.Gsm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestingGsm
{
    class Testing
    {
        static void Main(string[] args)
        {
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                Gsm[] devices = new Gsm[3]
                {
                    new Gsm("Galaxy Note 3", "Samsung"),
                    new Gsm("iPhone", "Apple", 1000),
                    new Gsm("N95", "Nokia", 300, "Bai Pesho", "BP-4L", BatteryType.LiIon, 6, 400)
                };

                foreach (Gsm device in devices)
                {
                    Console.WriteLine(device);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot create Gsm object!" + e.Message);
            }
        }
    }
}
