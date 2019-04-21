namespace UsingClassesAndObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Methods;

    class UsingClassesAndObjects
    {
        public static IEnumerable<DateTime> Model { get; private set; }

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

        public static double GetTriangleArea05(double sideA, double sideB, double sideC)
        {
            double semipermeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semipermeter * (semipermeter - sideA) * (semipermeter - sideB) * (semipermeter - sideC));
        }

        public static double GetTriangleArea06(double sideA, double sideB, double angleBetween)
        {
            double angleInRadians = angleBetween * Math.PI / 180;
            return (sideA * sideB * Math.Sin(angleInRadians)) / 2;
        }

        public static int GetWorkdays07(DateTime date)
        {
            int year = DateTime.Today.Year;
            DateTime[] holidays = { new DateTime(year, 1, 1), new DateTime(year, 3, 3), new DateTime(year, 4, 28), new DateTime(year, 5, 1),
                                    new DateTime(year, 5, 6), new DateTime(year, 5, 24), new DateTime(year, 9, 6), new DateTime(year, 9, 22),
                                    new DateTime(year, 12, 24), new DateTime(year, 12, 25), new DateTime(year, 12, 26)
                                  };

            DateTime startDate = DateTime.Today;

            TimeSpan rangeTimeSpan = date.Subtract(startDate);
            DateTime[] rangeTimeArray = new DateTime[rangeTimeSpan.Days];

            DateTime currentDate = startDate;
            for (int i = 0; i < rangeTimeSpan.Days; i++)
            {
                currentDate = currentDate.AddDays(1);
                rangeTimeArray[i] = currentDate;
            }

            int NumOfWorkDays = rangeTimeArray.Where(x => x >= startDate &&
                                                    x.DayOfWeek != DayOfWeek.Saturday &&
                                                    x.DayOfWeek != DayOfWeek.Sunday &&
                                                    !holidays.Contains(x)).Count();

            for (int i = 0; i < rangeTimeArray.Length; i++)
            {
                if ((rangeTimeArray[i].DayOfWeek == DayOfWeek.Saturday || rangeTimeArray[i].DayOfWeek == DayOfWeek.Sunday) &&
                    holidays.Contains(rangeTimeArray[i]))
                {
                    NumOfWorkDays--;
                }
            }
            return NumOfWorkDays;
        }

        public static void FillArray(ref int[] numbers)
        {
            numbers = Console.ReadLine()
                           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(item => int.Parse(item))
                           .ToArray();
        }

        public static int SumIntegers08()
        {
            int[] sumArray = Array.Empty<int>();
            FillArray(ref sumArray);

            int sum = 0;
            foreach (var num in sumArray)
            {
                sum += num;
            }
            return sum;
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
            /* Task 5
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.00}", GetTriangleArea05(sideA, sideB, sideC));
            */
            /* Task 6
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double angleBetween = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.00}", GetTriangleArea06(sideA, sideB, angleBetween));
            */
            /* Task 7
            Console.WriteLine("Enter due date in this format: dd/mm/yyyy");

            DateTime dueDate;
            if (DateTime.TryParse(Console.ReadLine(), out dueDate))
            {
                Console.WriteLine(GetWorkdays07(dueDate));
            }
            else
            {
                Console.WriteLine("You have entered an incorrect value.");
            }
            */

            /* Task 8 
            Console.WriteLine(SumIntegers08());
            */
        }
    }
}
