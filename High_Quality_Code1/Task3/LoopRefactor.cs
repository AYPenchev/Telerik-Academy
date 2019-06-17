namespace Task3
{
    using System;

    public class LoopRefactor
    {
        public static void Main()
        {
            int[] array = new[] { 3, 5, 6, 30, 31 };
            int valueToBeSet = 0;
            int expectedValue = 30;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        valueToBeSet = 666;
                    }
                }
            }

            // More code here
            if (valueToBeSet == 666)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
