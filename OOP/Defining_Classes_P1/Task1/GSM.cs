namespace Task1
{
    using System;

    class GSM
    {
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
    }
}
