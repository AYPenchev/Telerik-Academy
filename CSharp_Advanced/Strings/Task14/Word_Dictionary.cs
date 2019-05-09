namespace Task14
{
    using System;
    using System.Collections.Generic;

    class WordDictionary
    {
        static void Main()
        {
            Dictionary<string, string> wordDictionary = new Dictionary<string, string>();

            wordDictionary.Add(".NET", "platform for applications from Microsoft");
            wordDictionary.Add("CLR", "managed execution environment for .NET");
            wordDictionary.Add("namespace", "hierarchical organization of classes");

            string searchedWord = Console.ReadLine();
            if(wordDictionary.ContainsKey(searchedWord))
            {
                Console.WriteLine(wordDictionary[searchedWord]);
            }
        }
    }
}
