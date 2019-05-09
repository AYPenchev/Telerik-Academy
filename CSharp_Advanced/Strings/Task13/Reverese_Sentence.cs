namespace Task13
{
    using System;

    class ReverseSentence
    {
        static void Main()
        {
            string inputText = Console.ReadLine();

            char sign = inputText[inputText.Length - 1];
            inputText = inputText.Remove(inputText.Length - 1);

            string[] textAsArray = inputText.Split(' ');
            Array.Reverse(textAsArray);
            Console.WriteLine(string.Join(" ", textAsArray) + sign);
        }
    }
}