namespace Reverse_String
{
    using System;

    class ReverseString
    {
        public static string StringReverse(string inputToBeReversed)
        {
            char[] inputAsCharArray = inputToBeReversed.ToCharArray();
            Array.Reverse(inputAsCharArray);
            return new string(inputAsCharArray);
        }

        static void Main(string[] args)
        {
            string inputToBeReversed = Console.ReadLine();
            string reversedInput = StringReverse(inputToBeReversed);
            Console.WriteLine(reversedInput);
        }
    }
}
