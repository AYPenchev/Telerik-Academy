﻿namespace Task2
{
    using System.Collections.Generic;
    using System.IO;

    public class Bunnies
    {
        public static void Main()
        {
            var bunnies = new List<Bunny>
            {
                new Bunny { Name = "Leonid", Age= 1, FurType = FurType.NotFluffy },
                new Bunny { Name = "Rasputin", Age= 2, FurType = FurType.ALittleFluffy },
                new Bunny { Name = "Tiberii", Age= 3, FurType = FurType.ALittleFluffy },
                new Bunny { Name = "Neron", Age= 1, FurType = FurType.ALittleFluffy },
                new Bunny { Name = "Klavdii", Age= 3, FurType = FurType.Fluffy },
                new Bunny { Name = "Vespasian", Age= 3, FurType = FurType.Fluffy },
                new Bunny { Name = "Domician", Age = 4, FurType = FurType.FluffyToTheLimit },
                new Bunny { Name = "Tit", Age= 2, FurType = FurType.FluffyToTheLimit }
            };

            var consoleWriter = new ConsoleWriter();

            foreach (Bunny bunny in bunnies)
            {
                bunny.Introduce(consoleWriter);
            }

            string bunniesFilePath = @"..\..\bunnies.txt";

            using (var streamWriter = new StreamWriter(bunniesFilePath))
            {
                foreach (var bunny in bunnies)
                {
                    streamWriter.WriteLine(bunny.ToString());
                }
            }
        }
    }
}
