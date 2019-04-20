using System;

namespace UsingClassesAndObjects
{
    class UsingClassesAndObjects
    {
        public static void IsLeapYear01(int year)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }

        public static void PrintTenRandomNumbers02()
        {
            Random randNum = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", randNum.Next(100, 200));
            }
        }

        public static void GetDayOfWeek03()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today.DayOfWeek);
        }

        public static double GetTriangleArea04(double sideOfTriangle, double altitudeOfTriangle)
        {
            return (sideOfTriangle * altitudeOfTriangle) / 2;
        }

        static void Main()
        {
            /* Task 1
            int year = int.Parse(Console.ReadLine());
            IsLeapYear01(year);
            */
            /* Task 2 
            PrintTenRandomNumbers02();
            */
            /* Task 3
            GetDayOfWeek03();
            */
            /* Task 4
            double sideOfTriangle = double.Parse(Console.ReadLine());
            double altitudeOfTriangle = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.00}", GetTriangleArea04(sideOfTriangle, altitudeOfTriangle));
            */
        }
    }
}