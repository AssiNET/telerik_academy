using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDevice.Gsm
{
    public class Gsm
    {
        // Declaring Fields
        private string modelName;
        private string manufactureName;
        private decimal productPrice;
        private string ownerName;
        private Battery battery;
        private Display display;
        private static Gsm iPhone4S;
        private List<Call> callHistory;

        // Declaring Properties
        public static Gsm IPhone4S
        {
            get
            {
                return iPhone4S;
            }
            set
            {
                iPhone4S = value;
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The model field is required!");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentException("The model must be atleast 2 characters long!");
                }

                this.modelName = value;
            }
        }

        public string ManufactureName
        {
            get
            {
                return this.manufactureName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The manufacture field is required");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentException("The model must be atleast 2 characters");
                }

                this.manufactureName = value;
            }
        }

        public decimal ProductPrice
        {
            get
            {
                return this.productPrice;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price field cannot be negative!");
                }

                this.productPrice = value;
            }
        }

        public string OwnerName
        {
            get
            {
                return this.ownerName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length < 6)
                {
                    throw new ArgumentException("The owner field must be at least 6 characters long!");
                }
                this.ownerName = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return callHistory;
            }

            set
            {
                this.callHistory = value;
            }
        }

        // Constructors
        static Gsm()
        {
            IPhone4S = new Gsm("iPhone 4S", "Apple");
        }

        public Gsm(string modelName, string manufactureName)
            : this(modelName, manufactureName, 0)
        {
            
        }

        public Gsm(string modelName, string manufactureName, decimal productPrice)
            : this(modelName, manufactureName, productPrice, "")
        {

        }

        public Gsm(string modelName, string manufactureName, decimal productPrice, string ownerName)
            : this(modelName, manufactureName, productPrice, ownerName, "", null, 0, 0)
        {

        }

        public Gsm(string modelName, string manufactureName, decimal productPrice, string ownerName, string batteryModel, BatteryType? batteryType, int idleModeTime, int maximumTalkTime) 
            : this (modelName, manufactureName, productPrice, ownerName, batteryModel, batteryType, idleModeTime, maximumTalkTime, 0, "")
        {
    
        }

        public Gsm(string modelName, string manufactureName, decimal productPrice, string ownerName, string batteryModel, BatteryType? batteryType, int idleModeTime, int maximumTalkTime, double displaySize, string numberOfColors)
        {
            this.ModelName = modelName;
            this.ManufactureName = manufactureName;
            this.ProductPrice = productPrice;
            this.OwnerName = ownerName;
            this.Battery = new Battery(batteryModel, idleModeTime, maximumTalkTime, batteryType);
            this.Display = new Display(displaySize, numberOfColors);
            this.CallHistory = new List<Call>();
        }

        // Methods
        public void AddCall(DateTime dateAndTime, string dialedNumber, uint duration)
        {
            this.callHistory.Add(new Call(dateAndTime, dialedNumber, duration));
        }

        public void DeleteCall(int callID)
        {
            this.CallHistory.RemoveAt(callID);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public string GetTotalPrice(decimal tariff)
        {
            decimal totalPrice = 0m;
            decimal totalTime = 0m;

            foreach (var call in this.CallHistory)
            {
                totalTime += call.Duration;
            }
            totalPrice = (totalTime / 60) * tariff;

            return string.Format("{0:C3}", totalPrice);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Model: " + this.ModelName + "\n" + "Manufacture: " + this.ManufactureName);
            
            if (this.ProductPrice > 0)
            {
                result.AppendLine("Price: " + string.Format("{0:C}", this.ProductPrice, new System.Globalization.CultureInfo("fr-FR")));
            }

            if (!string.IsNullOrWhiteSpace(this.OwnerName))
            {
                result.AppendLine("Owner: " + this.OwnerName);
            }

            if (!string.IsNullOrWhiteSpace(this.Battery.ModelName))
            {
                result.AppendLine("Battery: " + this.Battery.ModelName);
            }
            else
            {
                result.AppendLine("Battery: N/A");
            }

            if (this.Battery.BatteryType != null)
            {
                result.AppendLine("Battery Type: " + this.Battery.BatteryType);
            }
            else
            {
                result.AppendLine("Battery Type: N/A");
            }

            if (this.Battery.IdleModeTime > 0)
            {
                result.AppendLine("Standby Time: " + this.Battery.IdleModeTime);
            }
            else
            {
                result.AppendLine("Standby Time: N/A");
            }

            if (this.Battery.MaximumTalkTime > 0)
            {
                result.AppendLine("Maximal Talk Time: " + this.Battery.MaximumTalkTime);
            }
            else
            {
                result.AppendLine("Maximal Talk Time: N/A");
            }

            if (this.Display.Size > 0)
            {
                result.AppendLine("Display Size: " + this.Display.Size);
            }
            else
            {
                result.AppendLine("Display Size: N/A");
            }

            if (!string.IsNullOrWhiteSpace(this.Display.NumberOfColors))
            {
                result.AppendLine("Colors: " + this.Display.NumberOfColors);
            }
            else
            {
                result.AppendLine("Colors: N/A");
            }

            return result.ToString();
        }
    }
}