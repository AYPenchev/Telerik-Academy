namespace Task9
{
    using System;
    using System.Linq;

    class ForbiddenWords
    {
        public static string CensorText(string text, string words)
        {
            string[] forbbidenWords = words.Split(' ').ToArray();
            for (int i = 0; i < forbbidenWords.Length; i++)
            {
                text = text.Replace(forbbidenWords[i], new string('*', forbbidenWords[i].Length));
            }
            return text;
        }

        static void Main()
        {
            string text = Console.ReadLine();
            string forbiddenWords = Console.ReadLine();
            Console.WriteLine(CensorText(text, forbiddenWords));
        }
    }
}
