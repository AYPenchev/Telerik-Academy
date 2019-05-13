namespace Task1
{
    using System;

    class GSM
    {
        private double? price;
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
       /* public double? Price
        {
            get { return this.price; }
            set
            {
                if (value != null)
                {
                    //GetPasswordFromUser();
                    if (this.ManufacturerPassword == this.InputPassword)
                    {
                        this.price = value;
                    }
                }
                else
                {
                    this.price = value;
                }
            }
        }*/
        public string Owner { get; private set; }
       /* private string ManufacturerPassword { get; set; } = "qwerty";
        private string InputPassword { get; set; }

        private string GetPasswordFromUser()
        {
            Console.Write("Enter manufacturer's password to change the price of the phone: ");
            this.InputPassword = Console.ReadLine();
            return this.InputPassword;
        }*/

        public override string ToString()
        {
            return string.Format("Phone battery:  {0} \nPhone display:  {1}  \nModel:  {2} \nManufacturer:  {3} \nPrice: {4} \nOwner:  {5}"
                                , this.PhoneBattery, this.PhoneDisplay, this.Model, this.Manufacturer, this.Price, this.Owner);
        }
    }
}
