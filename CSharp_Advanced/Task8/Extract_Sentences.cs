namespace Task8
{
    using System;
    using System.Text;

    class ExtractSentences
    {
        public static string SentenceExtract(string text, string searchedWordInSenteces)
        {
            string[] textAsArray = text.Split('.');
            StringBuilder searchedSentences = new StringBuilder();
            foreach (string sentence in textAsArray)
            {
                if (sentence.Contains(" " + searchedWordInSenteces + " "))
                {
                    searchedSentences.Append(sentence);
                    searchedSentences.Append(".");
                }
            }
            return searchedSentences.ToString();
        }
        static void Main()
        {
            string searchedWordInSenteces = Console.ReadLine();
            string text = Console.ReadLine();
            Console.WriteLine(SentenceExtract(text, searchedWordInSenteces));
        }
    }
}
