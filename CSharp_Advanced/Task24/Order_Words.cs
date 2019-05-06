namespace Task24
{
    using System;

    class OrderWords
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(text);

            foreach (string word in text)
            {
                Console.WriteLine(word);
            }
        }
    }
}
