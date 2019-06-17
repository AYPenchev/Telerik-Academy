namespace Intro_Programming_Homework
{
    using System;

    public class IntroductionToProgramming
    {
        public static void Main()
        {
            //Task 1-8
            Console.WriteLine("Hello, C#!");
            Console.WriteLine("Asen Penchev");
            Console.WriteLine("1 \n101 \n1001");
            Console.WriteLine("Asen \nPenchev");
            Console.WriteLine(Math.Sqrt(12345));

            //Task 9, 16
            int sequenceChanger = 5;
            int startSequence = 2;
            for (int i = 0; i < 10; i++, sequenceChanger += 2)
            {
                Console.WriteLine(startSequence);
                if (i % 2 == 0)
                {
                    startSequence -= sequenceChanger;
                }
                else
                {
                    startSequence += sequenceChanger;
                }
            }

            //Task 14
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Year);

            //Task 15
            string date = Console.ReadLine();
            String[] components = date.Split('.');
            int month = int.Parse(components[0]);
            int day = int.Parse(components[1]);
            int year = int.Parse(components[2]);
            if (month <= DateTime.Now.Month)
            {
                if (day > DateTime.Now.Day)
                {
                    year++;
                }
            }

            int userAge = DateTime.Now.Year - year;
            Console.WriteLine("You are " + userAge + " years old");

            int userAgeInTenYears = userAge + 10;
            Console.WriteLine("In 10 years you will be " + userAgeInTenYears + " years old");
        }
    }
}