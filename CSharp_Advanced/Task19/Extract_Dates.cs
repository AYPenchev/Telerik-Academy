namespace Task19
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    class ExtractDates
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<DateTime> dates = new List<DateTime>();
            string format = "dd.MM.yyyy";

            foreach (string searchedDate in text)
            {
                DateTime dateToBeAdded;
                if (DateTime.TryParseExact(searchedDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateToBeAdded))
                {
                    dates.Add(dateToBeAdded);
                }
            }

            foreach (DateTime date in dates)
            {
                Console.WriteLine(date.Year + "-" + date.Month + "-" + date.Day);
            }
        }










    }
}
