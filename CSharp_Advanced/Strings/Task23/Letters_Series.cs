namespace Task23
{
    using System;

    class LettersSeries
    {
        static void Main()
        {
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] != word[i + 1])
                {
                    Console.Write(word[i]);
                }
            }
            Console.WriteLine(word[word.Length - 1]);
        }
    }
}
