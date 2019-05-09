namespace Task22
{
    using System;
    using System.Collections.Generic;

    class WordsCount
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> words = new Dictionary<string, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (words.ContainsKey(text[i]))
                {
                    words[text[i]]++;
                }
                else
                {
                    words.Add(text[i], 1);
                }
            }

            foreach (KeyValuePair<string, int> keyValuePair in words)
            {
                Console.WriteLine("word = {0}, Count = {1}", keyValuePair.Key, keyValuePair.Value);
            }
        }
    }
}
