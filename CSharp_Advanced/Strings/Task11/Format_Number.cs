namespace Task11
{
    using System;

    class FormatNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15:D}", number);
            Console.WriteLine("{0,15:X}", number);
            Console.WriteLine("{0,15:P}", number);
            Console.WriteLine("{0,15:E}", number);
        }
    }
}
