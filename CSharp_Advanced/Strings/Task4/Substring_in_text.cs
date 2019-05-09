namespace Task4
{
    using System;

    class SubstringInText
    {
        public static int CountSubstringInText(string pattern, string textToBeSearched)
        {
            int countPattern = 0;

            while (textToBeSearched.IndexOf(pattern) != -1)
            {
                countPattern++;
                textToBeSearched = textToBeSearched.Remove(0,textToBeSearched.IndexOf(pattern) + 1);
            }
            return countPattern;
        }

        static void Main()
        {
            string pattern = Console.ReadLine().ToLower();
            string textToBeSearched = Console.ReadLine().ToLower();

            int countPattern = CountSubstringInText(pattern, textToBeSearched);
            Console.WriteLine(countPattern);
        }
    }
}
