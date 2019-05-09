namespace Task21
{
    using System;
    using System.Collections.Generic;

    class LettersCount
    {
        static void Main()
        {
            string word = Console.ReadLine();
            Dictionary<char, int> letters = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                if(letters.ContainsKey(word[i]))
                {
                    letters[word[i]]++;
                }
                else
                {
                    letters.Add(word[i], 1);
                }
            }

            foreach(KeyValuePair<char, int> keyValuePair in letters)
            {
                Console.WriteLine("Letter = {0}, Count = {1}", keyValuePair.Key, keyValuePair.Value);
            }
        }
    }
}
