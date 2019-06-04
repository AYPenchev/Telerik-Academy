namespace Task3
{
    using System;

    public class RangeException
    {
        static void Main()
        {
            InvalidRangeException<int> intException = new InvalidRangeException<int>(1,100,"Invalid range ");

            try
            {
                int input = int.Parse(Console.ReadLine());
                if (intException.Start > input || intException.End < input)
                {
                    throw new InvalidRangeException<int>(intException.Start, intException.End, intException.Message);
                }

            }
            catch (InvalidRangeException<int>)
            {
                Console.Error.WriteLine(intException.Message + "input should be between " + intException.Start + " and " + intException.End);
            }

            DateTime start = new DateTime(1980,1,1);
            DateTime end = new DateTime(1980, 1, 1);

            InvalidRangeException<DateTime> dateException = new InvalidRangeException<DateTime>(start, end, "Invalid range ");

            try
            {
                DateTime input = DateTime.Parse(Console.ReadLine());

                if (dateException.Start > input || dateException.End < input)
                {
                    throw new InvalidRangeException<DateTime>(dateException.Start, dateException.End, dateException.Message);
                }

            }
            catch (InvalidRangeException<DateTime>)
            {
                Console.Error.WriteLine(dateException.Message + "input should be between " + dateException.Start + " and " 
                                        + dateException.End);
            }
        }
    }
}
