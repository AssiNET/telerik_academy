using MobileDevice.Gsm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGsm
{
    class GsmTest
    {
        // Declaring Fields

        private Gsm[] devices;
        
        // Declaring Properties

        public Gsm[] Devices
        {
            get
            {
                return this.devices;
            }
            set
            {
                this.devices = value;
            }
        }

        // Constructors

        public GsmTest(Gsm[] devices)
        {
            this.Devices = devices;
        }
    }
}
