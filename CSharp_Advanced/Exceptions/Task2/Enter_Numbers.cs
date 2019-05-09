namespace Task2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class EnterNumbers
    {
        private static bool IsIncreasing(List<int> numbers)
        {
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1].CompareTo(numbers[i]) >= 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main()
        {
            int start = 0;
            int end = 100;
            const int count = 10;

            List<int> numbers = new List<int>();

            try
            {
                for (int i = 0; i < count; i++)
                {
                    numbers.Add(int.Parse(Console.ReadLine()));
                }

                if (numbers.Any(x => x < start) || numbers.Any(x => x > end) || !IsIncreasing(numbers))
                {
                    throw new ArgumentException();
                }

                Console.WriteLine("1 < " + string.Join(" < ", numbers) + " < 100");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }

        }
    }
}
