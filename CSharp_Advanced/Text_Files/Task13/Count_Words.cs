namespace Task13
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class CountWords
    {
        static void Main()
        {
            string wordsPath = Console.ReadLine();

            try
            {
                File.ReadAllText(wordsPath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found!");
                return;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No file path is given!");
                return;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entered file path is not correct!");
                return;
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The chosen file is not supported!");
                return;
            }

            string[] words = File.ReadAllText(wordsPath)
                                           .Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            string testPath = Console.ReadLine();

            try
            {
                File.ReadAllText(testPath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No file path is given!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entered file path is not correct!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The chosen file is not supported!");
            }

            string[] text = File.ReadAllText(testPath)
                                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if(!words.Select(x => x).Contains(text[i]))
                {
                    continue;
                }
                if (wordsDictionary.ContainsKey(text[i]))
                {
                    wordsDictionary[text[i]]++;
                }
                else
                {
                    wordsDictionary.Add(text[i], 1);
                }
            }

            string result = Console.ReadLine();

            using (var writerResult = new StreamWriter(result))
            {
                var sortedContainer = from entry in wordsDictionary orderby entry.Value descending select entry;
                foreach (KeyValuePair<string, int> keyValuePair in sortedContainer)
                {
                    writerResult.WriteLine("word = {0}, Count = {1}", keyValuePair.Key, keyValuePair.Value);
                }
            }
        }
    }
}
