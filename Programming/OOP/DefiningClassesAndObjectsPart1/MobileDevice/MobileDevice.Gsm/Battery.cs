using System;

namespace MobileDevice.Gsm
{
    public class Battery
    {
        // Declaring Fields
        private string modelName;
        private int idleModeTime;
        private int maximumTalkTime;
        private BatteryType? batteryType;

        // Declaring Properties
        public BatteryType? BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }

        public string ModelName
        {
            get
            {
                return this.modelName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length < 4)
                {
                    throw new ArgumentException("The model must be at least 4 characters long!");
                }

                this.modelName = value;
            }
        }

        public int IdleModeTime
        {
            get
            {
                return this.idleModeTime;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The field hours cannot be negative or equals to zero!");
                }
                this.idleModeTime = value;
            }
        }

        public int MaximumTalkTime
        {
            get
            {
                return this.maximumTalkTime;
            }
            set
            {
                this.maximumTalkTime = value;
            }
        }

        // Constructors
        public Battery(string model, int idleModeTime, int maximumTalkTime, BatteryType? batteryType)
        {
            this.ModelName = model;
            this.IdleModeTime = idleModeTime;
            this.MaximumTalkTime = maximumTalkTime;
            this.BatteryType = batteryType;
        }
    }
}