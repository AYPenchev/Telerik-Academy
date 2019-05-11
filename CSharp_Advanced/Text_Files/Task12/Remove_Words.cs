namespace Task12
{
    using System;
    using System.IO;

    class RemoveWords
    {
        static void Main()
        {
            using (var writeWordsToRemove = new StreamWriter("../../wordsToBeRemoved.txt"))
            {
                writeWordsToRemove.WriteLine("nice");
                writeWordsToRemove.WriteLine("wednesday");
                writeWordsToRemove.WriteLine("today");
            }

            string[] wordsToBeRemoved = File.ReadAllText("../../wordsToBeRemoved.txt")
                            .Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            using (var writeToFile = new StreamWriter("../../file.txt"))
            {
                writeToFile.WriteLine("Lorem ipsum nice today amet, consectetur today elit, sed do eiusmod tempor today ut labore et dolore." + Environment.NewLine +
                                      "Ut wednesday ad minim veniam, quis nostrud exercitation ullamco wednesday wednesday ut aliquip commodo wednesday. " + Environment.NewLine +
                                      "Pa nice aute irure dolor in today in nice velit esse cillum dolore eu fugiat nulla pariatur." + Environment.NewLine +
                                      "Excepteur sint nice today non proident, sunt in nice qui officia deserunt mollit nice id est laborum.");
            }
            string fileText = File.ReadAllText("../../file.txt");

            for (int i = 0; i < wordsToBeRemoved.Length; i++)
            {
                if(fileText.Contains(wordsToBeRemoved[i]))
                {
                    fileText = fileText.Replace(wordsToBeRemoved[i] + " ", string.Empty);
                }
            }

            File.WriteAllText("../../file.txt", fileText);
        }
    }
}
