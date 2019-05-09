namespace Task10
{
    using System;

    class UnicodeCharacters
    {
        public static void ConvertToUnicode(string textToBeConverted)
        {
            foreach (char letter in textToBeConverted)
            {
                Console.Write("\\u" + ((int)letter).ToString("X4"));
            }
        }
        static void Main()
        {
            string inputText = Console.ReadLine();
            ConvertToUnicode(inputText);
        }
    }
}
