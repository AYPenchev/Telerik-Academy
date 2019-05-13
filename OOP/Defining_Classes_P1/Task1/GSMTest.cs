namespace Task1
{
    using System;
    using System.Collections.Generic;

    class GSMTest
    {
        static void Main()
        {
            Battery phoneOneBattery = new Battery("Samsung Batery", 48, 12, BatteryType.Li_lon);
            Display phoneOneDisplay = new Display(5.7, 12000);
            GSM phoneOne = new GSM("Galaxy A6", "Samsung", phoneOneBattery, phoneOneDisplay, owner: "Peter", price: 600);

            Battery phoneTwoBattery = new Battery("iPhone Batery", 60, 24, BatteryType.NiMH);
            Display phoneTwoDisplay = new Display(4.5, 154000000);
            GSM phoneTwo = new GSM("4S", "iPhone", phoneTwoBattery, phoneTwoDisplay, owner: "Gosho", price: 1100);

            //Console.WriteLine(phoneOne.Price);
            //phoneOne.Price = 20;
            
            List<GSM> phones = new List<GSM>();
            phones.Add(phoneOne);
            phones.Add(phoneTwo);

            for (int i = 0; i < phones.Count; i++)
            {
                Console.WriteLine($"{i + 1}." + Environment.NewLine + phones[i] + Environment.NewLine);
            }
            Console.WriteLine(GSM.iPhone4S);
        }
    }
}
