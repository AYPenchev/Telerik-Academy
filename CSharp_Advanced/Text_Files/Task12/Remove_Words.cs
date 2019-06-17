namespace Task12
{
    using System;
    using System.IO;

    public class RemoveWords
    {
        public static void Main()
        {
            string[] inputWordsToRemove = Console.ReadLine()
                                     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            using (var writeWordsToRemove = new StreamWriter("../../wordsToBeRemoved.txt"))
            {
                for (int i = 0; i < inputWordsToRemove.Length; i++)
                {
                    writeWordsToRemove.WriteLine(inputWordsToRemove[i]);
                }
            }

            try
            {
                File.ReadAllText("../../wordsToBeRemoved.txt");
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

            string[] wordsToBeRemoved = File.ReadAllText("../../wordsToBeRemoved.txt")
                                            .Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            using (var writeToFile = new StreamWriter("../../file.txt"))
            {
                writeToFile.WriteLine("Lorem ipsum nice today amet, consectetur today elit, sed do eiusmod tempor today ut labore et dolore." + Environment.NewLine +
                                      "Ut wednesday ad minim veniam, quis nostrud exercitation ullamco wednesday wednesday ut aliquip commodo wednesday. " + Environment.NewLine +
                                      "Pa nice aute irure dolor in today in nice velit esse cillum dolore eu fugiat nulla pariatur." + Environment.NewLine +
                                      "Excepteur sint nice today non proident, sunt in nice qui officia deserunt mollit nice id est laborum.");
            }

            try
            {
                File.ReadAllText("../../file.txt");
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

            string fileText = File.ReadAllText("../../file.txt");

            for (int i = 0; i < wordsToBeRemoved.Length; i++)
            {
                if (fileText.Contains(wordsToBeRemoved[i]))
                {
                    fileText = fileText.Replace(wordsToBeRemoved[i] + " ", string.Empty);
                }
            }

            File.WriteAllText("../../file.txt", fileText);
        }
    }
}
