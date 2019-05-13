namespace Task1
{
    using System;
    using System.Collections.Generic;

    class GSM
    {
        private const decimal CallPricePerSecond = 0.26m;
        public static string iPhone4S = "info";

        public GSM()
        {
            this.PhoneBattery = null;
            this.PhoneDisplay = null;
            this.Model = string.Empty;
            this.Manufacturer = string.Empty;
            this.Price = 0;
            this.Owner = string.Empty;
        }
        public GSM(string model, string manufacturer, Battery phoneBattery = null, Display phoneDisplay = null,
                                                                     double? price = null, string owner = null)
        {
            this.PhoneBattery = phoneBattery;
            this.PhoneDisplay = phoneDisplay;
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }

        public Battery PhoneBattery { get; private set; }
        public Display PhoneDisplay { get; private set; }
        public string Model { get; private set; }
        public string Manufacturer { get; private set; }
        public double? Price { get; private set; }
        public string Owner { get; private set; }
        private List<Call> CallHistory { get; set; } = new List<Call>();

        public void AddCall(string currPhoneNumber, ulong currDuaration)
        {
            this.CallHistory.Add(new Call(currPhoneNumber, currDuaration));
        }

        public void DeleteCall(int position)
        {
            if ((this.CallHistory.Count <= position - 1) || (position - 1 < 0))
            {
                throw new ApplicationException("Such call history log does not exist!");
            }
            this.CallHistory.RemoveAt(position - 1);
        }

        public void ShowCallHistory()
        {
            Console.WriteLine("Current call history:");
            int indexer = 1;
            foreach (var call in this.CallHistory)
            {
                Console.Write(indexer++);
                Console.Write(" ---> ");
                Console.WriteLine(call);
            }
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal TotalCallPrice()
        {
            ulong allDuaration = 0;

            foreach (var call in this.CallHistory)
            {
                allDuaration += call.Duaration;
            }

            return allDuaration * CallPricePerSecond;
        }

        public override string ToString()
        {
            return string.Format("Phone battery:  {0} \nPhone display:  {1}  \nModel:  {2} \nManufacturer:  {3} \nPrice: {4} \nOwner:  {5}"
                                , this.PhoneBattery, this.PhoneDisplay, this.Model, this.Manufacturer, this.Price, this.Owner);
        }
    }
}
