namespace Task16
{
    using System;

    class DateDifference
    {
        static void Main()
        {
            Console.Write("Enter the first date: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the second date: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            TimeSpan rangeTimeSpan = secondDate.Subtract(firstDate);

            Console.WriteLine("Distance: " + rangeTimeSpan.Days + " days");

        }
    }
}
