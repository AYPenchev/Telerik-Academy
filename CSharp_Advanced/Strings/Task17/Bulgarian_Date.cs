namespace Task17
{
    using System;

    class BulgarianDate
    {
        static void Main()
        {
            Console.Write("Enter the date and time: ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());

            dateTime = dateTime.AddHours(6);
            dateTime = dateTime.AddMinutes(30);

            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.DayOfWeek);
        }
    }
}
