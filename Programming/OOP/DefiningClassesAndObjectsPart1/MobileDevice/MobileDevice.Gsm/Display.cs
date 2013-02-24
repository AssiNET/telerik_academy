using System;

namespace MobileDevice.Gsm
{
    public class Display
    {
        // Declaring Fields
        private double size;
        private string numberOfColors;
        
        // Declaring Properties
        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The screen size field cannot be negative or equals to zero!");
                }

                this.size = value;
            }
        }

        public string NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && (value != "64K" || value != "256K" || value != "16M"))
                {
                    throw new ArgumentException("Wrong number of colors! Choose between (64K, 256K or 16M)!");
                }
                this.numberOfColors = value;
            }
        }
        
        // Constructors
        public Display(double size, string numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
    }
}