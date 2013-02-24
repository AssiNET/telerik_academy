using System;

namespace MobileDevice.Gsm
{
    public class Call
    {
        // Declaring Fields
        private DateTime dateAndTime;
        private uint duration;
        private string dialedNumber;

        // Declaring Properties
        public uint Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        public string CallDate
        {
            get
            {
                return this.dateAndTime.Date.ToShortDateString();
            }
            set
            {
                this.dateAndTime = DateTime.Parse(value);
            }
        }

        public string CallTime
        {
            get
            {
                return this.dateAndTime.ToLongTimeString();
            }
            set
            {
                this.dateAndTime = DateTime.Parse(value);
            }
        }

        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }
            set
            {
                this.dialedNumber = value;
            }
        }

        // Constructors
        public Call(DateTime dateAndTime, string dialedNumber, uint duration)
        {
            this.CallDate = dateAndTime.Date.ToShortDateString();
            this.CallTime = dateAndTime.TimeOfDay.ToString();
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }
    }
}
